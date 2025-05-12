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

    public delegate void TerminerMission(object sender, EventArgs e, int idMission); //Déclaration de la signature du délégué pour terminer une mission

    public partial class Mission: UserControl
    {

        public Mission(int _idMission, string _nomCaserne, string _natureMission, string _motifMission, DateTime _dateDebut) //Constructeur pour une mission en cours
        {
            InitializeComponent();
            MissionID = _idMission;
            Caserne = _nomCaserne;
            NatureMission = _natureMission;
            MotifMission = _motifMission;
            DateDebut = _dateDebut;
            EstEnCours = true;
        }

        public Mission(int _idMission, string _nomCaserne, string _natureMission, string _motifMission, DateTime _dateDebut, DateTime _dateFin) //Constructeur pour une mission terminée
        {
            InitializeComponent();
            MissionID = _idMission;
            Caserne = _nomCaserne;
            NatureMission = _natureMission;
            MotifMission = _motifMission;
            DateDebut = _dateDebut;
            DateFin = _dateFin;
            EstEnCours = false;
        }

        public Mission(DataRow dr)
        {
            InitializeComponent();
            MissionID = Convert.ToInt32(dr[0]);
            Caserne = dr[1].ToString();
            NatureMission = dr[2].ToString();
            MotifMission = dr[3].ToString();
            DateDebut = Convert.ToDateTime(dr[4]);
            if (dr[5] != DBNull.Value) //Si la date de fin n'est pas nulle
            {
                DateFin = Convert.ToDateTime(dr[5]);
            }
            EstEnCours = Convert.ToBoolean(dr[6]);
        }

        public TerminerMission terminerMission; //Instance du délégué pour terminer une mission

        private int idMission;
        private string nomCaserne;
        private string natureMission;
        private string motifMission = "--> ";
        private DateTime dateDebut;
        private DateTime dateFin;
        private bool estEnCours;

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
            get { return dateDebut; }
            set 
            {
                dateDebut = value;
                lblDateDebut.Text = "Début le    : " + dateDebut.ToString();
            }
        }

        public DateTime DateFin
        {
            get { return dateFin; }
            set
            {
                dateFin = value;
                lblDateFin.Text = "Fin le        :  " + dateFin.ToString();
            }
        }

        public bool EstEnCours
        {
            get { return estEnCours; }
            set 
            {
                estEnCours = value;
                if (estEnCours)
                {
                    lblDateFin.Text = "Fin le        :  ";
                }
                else
                {
                    btnTerminerMission.Visible = false; //On cache le bouton terminer la mission
                }
            }
        }

        public Color Couleur
        {
            set
            {
                panelMission.BackColor = value; //On change la couleur du panel
            }
        }

        public void Terminer()
        {
            
            DateFin = DateTime.Now; //On met à jour la date de fin
            EstEnCours = false; //On met à jour l'état de la mission
        }

        private void btnTerminerMission_Click(object sender, EventArgs e)
        {
            if (terminerMission != null)
            {
                terminerMission(this, e, MissionID); //On appelle le délégué pour terminer la mission
            }
        }

        private void btnCreerPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
