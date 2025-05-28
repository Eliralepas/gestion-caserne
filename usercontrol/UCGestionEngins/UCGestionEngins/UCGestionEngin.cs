using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UCGestionEngins
{
    public partial class UCGestionEngin: UserControl
    {
        DataSet monDs;
        EnginsDisplay display;
        public UCGestionEngin()
        {
            InitializeComponent();
        }

        public UCGestionEngin(DataSet ds)
        {
            monDs = ds;
            InitializeComponent();

        }

        private void UCGestionEngin_Load(object sender, EventArgs e)
        {
            if(monDs == null)
            {
                return;
            }
            if (!monDs.Relations.Contains("RelationsCaserneEngins"))
            {

                monDs.Relations.Add("RelationsCaserneEngins",
                    monDs.Tables["Caserne"].Columns["id"],
                    monDs.Tables["Engin"].Columns["idCaserne"]);
            }

            BindingSource baseCaserne = new BindingSource(monDs,"Caserne");
            cbxChoixCaserne.DataSource = baseCaserne;
            cbxChoixCaserne.DisplayMember = "nom";
            cbxChoixCaserne.ValueMember = "id";

            BindingSource baseEngin = new BindingSource(baseCaserne, "RelationsCaserneEngins");

            display = new EnginsDisplay(baseEngin);
            display.Dock = DockStyle.Fill;
            cbxChoixCaserne.Focus();
            setNext(false);
            setPrevious(false);
            

        }

        private void cbxChoixCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!pnlDisplayEngin.Controls.Contains(display))
            {
                pnlDisplayEngin.Controls.Add(display);
            }
            display.First();
            setPrevious(false);
            setNext(true);
        }


        private void setNext(bool status)
        {
            btnNext.Enabled = status;
            btnLast.Enabled = status;
        }
        private void setPrevious(bool status)
        {
            btnPrevious.Enabled = status;
            btnFirst.Enabled = status;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if(display.Next() == 0)
            {
                setNext(false);
            };
            setPrevious(true);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            display.First();
            setPrevious(false);
            setNext(true);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(display.Previous() == 0)
            {
                setPrevious(false);
            };
            setNext(true);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            display.Last();
            setNext(false);
            setPrevious(true);
        }
    }
}
