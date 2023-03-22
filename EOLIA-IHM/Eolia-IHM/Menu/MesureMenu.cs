﻿using Eolia_IHM.Properties;
using Eolia_IHM.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eolia_IHM.Menu
{
    public partial class MesureMenu : UserControl
    {
        public MesureMenu()
        {
            InitializeComponent();
            if (Environment.OSVersion.Platform != PlatformID.Win32NT)
            {
                if (!EoliaCam.CameraExist())
                {
                    multimediaParam.Enabled = false;
                }
            }
            else
            {
                multimediaParam.Enabled = false;
            }

        }

        private void buttonLancerTransmissionMesure_Click(object sender, EventArgs e)
        {
            if (EoliaMes.EtatTransMes())
            {
                buttonLancerTransmissionMesure.Text = "Demarrer transmission mesure";
                EoliaMes.ArreterTransMes();
            }
            else
            {
                buttonLancerTransmissionMesure.Text = "Arrêter transmission mesure";
                EoliaMes.InitialiserTransMes(textBoxLogMesure, labelMesurePortance, labelMesureTrainee, ConfigurationMenu.FREQUENCEMES, ConfigurationMenu.EQGVOLTPORTANCE, ConfigurationMenu.EQGVOLTTRAINEE);
            }
        }

        private void buttonLancerEnregistrementMesure_Click(object sender, EventArgs e)
        {
            if (EoliaMes.EnregistrementMes(labelValeurMoyenneTrainee,labelValeurMoyennePortance,labelNomSession,labelNombreMesure,labelEtatSession, photoParam.Checked,videoParam.Checked, checkBoxAutoReload.Checked))
            {
                if (EoliaCam.CameraExist())
                {
                    multimediaParam.Enabled = true;
                    multimediaParam.BackColor = Color.FromArgb(204,204,204);
                    buttonSauvegarderSessionEnCours.Enabled = true;
                    buttonSauvegarderSessionEnCours.BackColor = Color.White;

                }
                buttonLancerEnregistrementMesure.Text = "Demarrer enregistrement mesure";
            }
            else
            {
                multimediaParam.Enabled = false;
                multimediaParam.BackColor = Color.FromArgb(150,150,150);
                buttonSauvegarderSessionEnCours.Enabled = false;
                buttonSauvegarderSessionEnCours.BackColor = Color.Gray;
                buttonLancerEnregistrementMesure.Text = "Arrêter enregistrement mesure";
            }
        }

        private async void buttonSauvegarderSessionEnCours_Click(object sender, EventArgs e)
        {
            buttonSauvegarderSessionEnCours.Enabled = false;

            if (EoliaSQL.BDDisConnected())
            {
                if (EoliaMes.SessionMesureDispo())
                {
                    string Requete = "INSERT INTO sessionmesure (idSession, nomMesure, dateMesure, czMesure, cxMesure, rhoMesure, sMesure, fMesure, photoMesure, videoMesure) VALUES(NULL, '" + labelNomSession.Text + "', NULL, '"+ConfigurationMenu.CZ+"', '"+ConfigurationMenu.CX+"', '"+ConfigurationMenu.rho+"', '"+ConfigurationMenu.S+"', '"+ ConfigurationMenu.FREQUENCEMES + "', '" + EoliaMes.ObtenirRepPhoto() + "', '" + EoliaMes.ObtenirRepVideo() + "'); SELECT LAST_INSERT_ID();";
                    //   string Requete = "INSERT INTO `Mesure` (`idMesure`, `MesurePortance`, `MesureTrainee`, `NomMesure`) VALUES (NULL, '" + EoliaMes.PortancePretPourEnvoi() + "', '" + EoliaMes.TraineePretPourEnvoi() + "', '" + labelNomSession.Text + "');";
                    int ResultRequete = await EoliaSQL.ExecuterRequeteAvecReponse(Requete);
                    int idSession = ResultRequete;


                    if (ResultRequete != -1)
                    {
                        Requete = "INSERT INTO `mesure` (`idMesure`, `portanceMesure`, `traineeMesure`, `vitesseMesure`, `idSession`) VALUES " + EoliaMes.RequeteMesurePrete(ResultRequete) + ";";
                        ResultRequete = await EoliaSQL.ExecuterRequeteSansReponse(Requete);
                        if (ResultRequete != -1)
                        {
                            EoliaUtils.MsgBoxNonBloquante("Transmission de la session numéro " + idSession + " bien effectuée.");
                            EoliaMes.ReinitialiserSession();
                        }
                        else
                        {
                            EoliaUtils.MsgBoxNonBloquante("Echec de la transmission");
                        }

                    }
                    else
                    {
                        EoliaUtils.MsgBoxNonBloquante("Echec de la transmission");
                    }
                }
                else
                {
                    EoliaUtils.MsgBoxNonBloquante("La session de mesure est inexistante ou vide");
                }
            }
            else
            {
                EoliaUtils.MsgBoxNonBloquante("Non connecté a la BDD, Transmission impossible");
            }
            buttonSauvegarderSessionEnCours.Enabled = true;
        }

        private void buttonTarerCapteurs_Click(object sender, EventArgs e)
        {
            if (EoliaMes.EtatTransMes())
            {
                EoliaMes.TarerCapteur();
            }
            else
            {
                EoliaUtils.MsgBoxNonBloquante("Vous devez établir une transmission avant de tarer");
            }
        }

        private void MesureMenu_MouseEnter(object sender, EventArgs e)
        {
            if (EoliaReg.LiaisonSerieReg())
            {
                if (groupBoxReg.Enabled)
                {
                    EoliaReg.SaveLogBox(textBoxLogMesure);
                    groupBoxReg.Enabled = true;
                }
            }
            else
            {
                if(!groupBoxReg.Enabled)
                    groupBoxReg.Enabled = false;
            }
        }

        private void checkBoxAutoReload_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoReload.Checked)
            {
                EoliaReg.AutoReloadAll(100, labelVitesseIntantanee, labelVitesseSouhaitée);
            }
        }

        private async void buttonPlus_Click(object sender, EventArgs e)
        {
            float actuelDesir;
            if (checkBoxAutoReload.Checked)
            {
                actuelDesir = EoliaReg.obtenirVitesseVoulue();
            }
            else {
                try { 
                    actuelDesir = await EoliaReg.readVitesseAsync();
                }catch(Exception ex)
                {
                    textBoxLogMesure.AppendText("Erreur "+ex.Message+" (regulateur) \r\n");
                    return;
                }
            }
            bool result = false;
            if (actuelDesir == float.NaN)
            {
                try { 
                    result = await EoliaReg.ParamVitesseAsync(EoliaReg.obtenirVitesseVoulueRaw() + 5);
                }
                catch (Exception ex)
                {
                    textBoxLogMesure.AppendText("Erreur " + ex.Message + " (regulateur) \r\n");
                    return;
                }
                if (result)
                {

                    textBoxLogMesure.AppendText("Requète bien envoyée \r\n");
                }
                else
                {
                    textBoxLogMesure.AppendText("Requète bien envoyée mais réponse régulateur erreur \r\n");
                }
            }
            else
            {
                textBoxLogMesure.AppendText("Erreur (regulateur)\r\n");
            }
        }



        private async void buttonMoins_Click_1(object sender, EventArgs e)
        {
            float actuelDesir;
            if (checkBoxAutoReload.Checked)
            {
                actuelDesir = EoliaReg.obtenirVitesseVoulue();
            }
            else
            {
                try
                {
                    actuelDesir = await EoliaReg.readVitesseAsync();
                }
                catch (Exception ex)
                {
                    textBoxLogMesure.AppendText("Erreur " + ex.Message + " (regulateur) \r\n");
                    return;
                }
            }
            bool result = false;
            if (actuelDesir == float.NaN)
            {
                try
                {
                    result = await EoliaReg.ParamVitesseAsync(EoliaReg.obtenirVitesseVoulueRaw() - 5);
                }
                catch (Exception ex)
                {
                    textBoxLogMesure.AppendText("Erreur " + ex.Message + " (regulateur) \r\n");
                    return;
                }
                if (result)
                {

                    textBoxLogMesure.AppendText("Requète bien envoyée \r\n");
                }
                else
                {
                    textBoxLogMesure.AppendText("Requète bien envoyée mais réponse régulateur erreur \r\n");
                }
            }
            else
            {
                textBoxLogMesure.AppendText("Erreur (regulateur)\r\n");
            }
        }

        private void checkBoxSaveVitesse_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxSaveVitesse.Checked)
            {
                if (!checkBoxAutoReload.Checked)
                {
                    checkBoxAutoReload.Checked = true;
                    checkBoxAutoReload.Enabled = false;
                }
            }
            else
            {
                if (checkBoxAutoReload.Enabled)
                    checkBoxAutoReload.Enabled = true;

            }

        }
    }
}
