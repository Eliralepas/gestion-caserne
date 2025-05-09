using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_Mission
{
    public partial class UC_Mission: UserControl
    {
        public UC_Mission(int _idMission, string _nomCaserne, string _natureMission, string _motifMission ,DateTime _dateDebut, bool _estEnCours)
        {
            InitializeComponent();
            MissionID = _idMission;
            Caserne = _nomCaserne;
            NatureMission = _natureMission;
            MotifMission = _motifMission;
            DateDebut = _dateDebut;
            EstEnCours = _estEnCours;
        }

        int idMission;
        string nomCaserne;
        string natureMission;
        string motifMission;
        DateTime dateDebut;
        DateTime dateFin;
        bool estEnCours;

        public int MissionID
        {
            get { return idMission; }
            set 
            {
                idMission = value;
                lblMissionId.Text = "ID Mission : " + idMission; 
            }
        }

        public string Caserne
        {
            get { return nomCaserne; }
            set 
            {
                nomCaserne = value;
                lblCaserne.Text = "Caserne    : " + nomCaserne; 
            }
        }

        public string NatureMission
        {
            get { return natureMission; }
            set
            {
                natureMission = value;
                lblNatureMission.Text = natureMission;
            }
        }

        public string MotifMission
        {
            get { return motifMission.Substring(3); }
            set
            {
                motifMission = "--> " + value;
                lblMotifMission.Text = motifMission;
            }
        }

        public DateTime DateDebut
        {
            get 
            { 
                return dateDebut; 
            }
            set 
            {
                dateDebut = value;
                lblDateDebut.Text = "Début le    : " + dateDebut.ToString(); 
            }
        }

        public bool EstEnCours
        {
            get { return estEnCours; }
            set 
            {
                estEnCours = value;
                string etat = "";
                if (estEnCours)
                {
                    etat = "----------";
                }
                else
                {
                    dateFin = DateTime.Now;
                    etat = dateFin.ToString();
                }
                lblDateFin.Text = "Fin le        :  " + etat; 
            }
        }

        private void btnCreerPdf_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVoirPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
