using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbxChoixCaserne.Focus();
            

        }

        private void cbxChoixCaserne_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!pnlDisplayEngin.Controls.Contains(display))
            {
                pnlDisplayEngin.Controls.Add(display);
            }
            display.First();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            display.Next();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            display.First();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            display.Previous();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            display.Last();
        }
    }
}
