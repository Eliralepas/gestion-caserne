using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCGestionEngins
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
            
        }

        private void EnginsDisplay_Load(object sender, EventArgs e)
        {
        }

        public void refresh()
        {
            DataRowView currentEngin = (DataRowView)EnginsList.Current;
            lblCodeEngin.Text = $"{currentEngin["numero"]}-{currentEngin["codeTypeEngin"]}-{currentEngin["idCaserne"]}";
            lblDate.Text = $"{currentEngin["dateReception"]}";

            strMission.m_BackGroundColor =Convert.ToBoolean(currentEngin["enMission"]) ? Color.Yellow : Color.White;
            strPanne.m_BackGroundColor = Convert.ToBoolean(currentEngin["enPanne"]) ? Color.Yellow : Color.White;
            string codeType = currentEngin["codeTypeEngin"].ToString();


           var varimg = Properties.Resources.ResourceManager.GetObject(codeType);
           if(varimg is Image img){
                pctEnginImage.Image = img;
           }
           else{
                pctEnginImage.Image = Properties.Resources.Default;
           }
            
        }


        private int getPos()
        {
            refresh();
            return EnginsList.Position;
        }


        public int Next()
        {
            EnginsList.MoveNext();
            return EnginsList.Count -1-  getPos();
        }

        public int Last()
        {
            EnginsList.MoveLast();
            return EnginsList.Count - 1-  getPos();
        }

        public int Previous()
        {
            EnginsList.MovePrevious();
            return getPos();
        }

        public int First()
        {
            EnginsList.MoveFirst();
            return getPos();
        }


    }
}
