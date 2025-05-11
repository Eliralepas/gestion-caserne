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
    public partial class Mission: UserControl
    {

        public Mission(int _idMission, string _nomCaserne, string _natureMission, string _motifMission ,DateTime _dateDebut, bool _estEnCours)
        {
            InitializeComponent();
            MissionID = _idMission;
            Caserne = _nomCaserne;
            NatureMission = _natureMission;
            MotifMission = _motifMission;
            DateDebut = _dateDebut;
            EstEnCours = _estEnCours;
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

        int idMission;
        string nomCaserne;
        string natureMission;
        string motifMission = "--> ";
        DateTime dateDebut;
        DateTime dateFin;
        bool estEnCours;
        string adresse;
        string codePostal;
        string ville;
        string compteRendu;
        DataTable dtPompiers = new DataTable(); //Tableau des pompiers de la mission
        DataTable dtEngins = new DataTable(); //Tableau des engins de la mission

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

        public bool EstEnCours
        {
            get { return estEnCours; }
            set 
            {
                estEnCours = value;
                string etat = "";
                if (estEnCours) //Si la mission est en cours
                {
                    etat = "----------";
                }
                else //Si la mission est terminée: afficher la date de fin
                {
                    dateFin = DateTime.Now;
                    etat = dateFin.ToString();
                }
                lblDateFin.Text = "Fin le        :  " + etat;
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

        private void btnCreerPdf_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVoirPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
