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

        }


        public void Next()
        {
            EnginsList.MoveNext();
            refresh();
        }

        public void Last()
        {
            EnginsList.MoveLast();
            refresh();
        }

        public void Previous()
        {
            EnginsList.MovePrevious();
            refresh();
        }

        public void First()
        {
            EnginsList.MoveFirst();
            refresh();
        }


    }
}
