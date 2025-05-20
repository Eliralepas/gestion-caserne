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
            lblCodeEngin.DataBindings.Add("Text", EnginsList, "numero");
            lblDate.DataBindings.Add("Text", EnginsList, "dateReception");
            chkEnPanne.DataBindings.Add("checked", EnginsList,"enPanne");
            chkMission.DataBindings.Add("checked", EnginsList, "enMission");

        }

        private void EnginsDisplay_Load(object sender, EventArgs e)
        {
          
        }

        private int getPos()
        {
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
