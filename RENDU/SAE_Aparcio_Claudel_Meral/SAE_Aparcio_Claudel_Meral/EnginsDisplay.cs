using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace UC_GestionEngins
{

    public partial class EnginsDisplay : UserControl
    {
        private BindingSource EnginsList;
        
        public EnginsDisplay()
        {
            InitializeComponent();
        }

        public EnginsDisplay(BindingSource baseEngin)
        {
            InitializeComponent();
            EnginsList = baseEngin;
            lblCodeEngin.DataBindings.Add("Text", EnginsList, "numero");
            lblDate.DataBindings.Add("Text", EnginsList, "dateReception");
            chkEnPanne.DataBindings.Add("Checked", EnginsList,"enPanne");
            chkEnMission.DataBindings.Add("Checked", EnginsList, "enMission");
        }

        private void EnginsDisplay_Load(object sender, EventArgs e)
        {
          

        }

        private void refreshImage()
        {
            Visible = false;
            timer.Start();
            DataRowView currentEngin = (DataRowView)EnginsList.Current;
            string codeType = currentEngin["codeTypeEngin"].ToString();
            var varimg = SAE_Aparcio_Claudel_Meral.Properties.Resources.ResourceManager.GetObject(codeType);
            if(varimg is Image img)
            {
                pctEnginImage.Image = img;
            }
            else
            {
                pctEnginImage.Image = SAE_Aparcio_Claudel_Meral.Properties.Resources.Default;
            }
        }

        private int getPos()
        {
            
            return EnginsList.Position;
        }


        public int Next()
        {
            EnginsList.MoveNext();
            refreshImage();
            return EnginsList.Count -1-  getPos();
        }

        public int Last()
        {
            EnginsList.MoveLast();
            refreshImage();
            return EnginsList.Count - 1-  getPos();
        }

        public int Previous()
        {
            EnginsList.MovePrevious();
            refreshImage();
            return getPos();
        }

        public int First()
        {
            EnginsList.MoveFirst();
            refreshImage();
            return getPos();    
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Visible = true;
            timer.Stop();
        }
    }
}
