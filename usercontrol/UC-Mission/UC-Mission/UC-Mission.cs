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

        public Mission(int _idMission, string _nomCaserne, string _natureMission, string _motifMission ,DateTime _dateDebut)
        {
            InitializeComponent();
            MissionID = _idMission;
            Caserne = _nomCaserne;
            NatureMission = _natureMission;
            MotifMission = _motifMission;
            DateDebut = _dateDebut;
            EstEnCours = true;
        }

        public Mission(int _idMission, string _nomCaserne, string _natureMission, string _motifMission, DateTime _dateDebut, DateTime _dateFin)
        {
            InitializeComponent();
            MissionID = _idMission;
            Caserne = _nomCaserne;
            NatureMission = _natureMission;
            MotifMission = _motifMission;
            DateDebut = _dateDebut;
            DateFin = _dateFin;
            EstEnCours = false;
            btnTerminerMission.Visible = false; //On cache le bouton terminer la mission si elle est déjà terminée
        }

        public Mission(DataRow dr)
        {
            InitializeComponent();
            MissionID = Convert.ToInt32(dr[0]);
            Caserne = dr[1].ToString();
            NatureMission = dr[2].ToString();
            MotifMission = dr[3].ToString();
            DateDebut = Convert.ToDateTime(dr[4]);
            EstEnCours = Convert.ToBoolean(dr[5]);
        }

        public TerminerMission terminerMission; //Instance du délégué pour terminer une mission

        private int idMission;
        private string nomCaserne;
        private string natureMission;
        private string motifMission = "--> ";
        private DateTime dateDebut;
        private DateTime dateFin;
        private bool estEnCours;
        private string adresse;
        private string codePostal;
        private string ville;
        private string compteRendu;
        private List<string> listePompiers = new List<string>(); //Liste des pompiers affectés à la mission
        private List<string> listeEngins = new List<string>(); //Liste des engins affectés à la mission

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
                    lblDateFin.Text = "Fin le        :  -----------------";
                }
            }
        }

        public string Adresse
        {
            get { return adresse; }
            set
            {
                adresse = value;
            }
        }

        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                codePostal = value;
            }
        }

        public string Ville
        {
            get { return ville; }
            set
            {
                ville = value;
            }
        }

        public string CompteRendu
        {
            get { return compteRendu; }
            set
            {
                compteRendu = value;
            }
        }

        public void Terminer()
        {
            
            DateFin = DateTime.Now; //On met à jour la date de fin
            EstEnCours = false; //On met à jour l'état de la mission
            btnTerminerMission.Visible = false; //On cache le bouton terminer la mission
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
