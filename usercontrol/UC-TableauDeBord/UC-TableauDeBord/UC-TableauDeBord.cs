using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC_TableauDeBord
{
    public partial class UC_TableauDeBord: UserControl
    {
        public UC_TableauDeBord()
        {
            InitializeComponent();
        }

        List<UserControl> listMissions = new List<UserControl>();

        public void AddMission(UserControl mission)
        {
            listMissions.Add(mission);
        }

        public void RemoveMission(UserControl mission)
        {
            listMissions.Remove(mission);
        }

        public void DisplayMissions()
        {
            foreach (var mission in listMissions)
            {
                mission.Visible = true;
            }
        }
    }
}
