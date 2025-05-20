using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygon
{
    public partial class Star : Circle
    {
        private float m_rotation;
        private Color checkedColor;
        private Color unCheckedColor;

        public float m_Rotation { get { return m_rotation; } set { m_rotation = value;refreshPolygon(); } }
        private Boolean _isChecked;

        public Boolean m_isChecked
        {
            get { return _isChecked; }
            
            set
            {
                _isChecked = value;
                changeChecked();
            }
        }

        public Color m_checkedColor { get { return checkedColor; } set { checkedColor = value; } }
        public Color m_unCheckedColor { get { return unCheckedColor; } set { unCheckedColor = value; } }



        public Star() : base()
        {
            m_nbSommet = 5;
            m_PolygonRadius = Math.Min(Width, Height) / 2;
            m_center = new PointF(Width / 2, Height / 2);
            m_rotation = 60;
            InitializeComponent();
            refreshPolygon();
        }

        public Star(int[] pos, int size,int nbBranche) : base(pos, new Size(size, size), nbBranche)
        {
            m_nbSommet = 5;
            m_rotation = 60;
            InitializeComponent();
        }


        private void changeChecked()
        {
            if(_isChecked)
            {
                m_BackGroundColor = checkedColor;
            }
            else
            {
                m_BackGroundColor = unCheckedColor;
            }
        }

        protected override void refreshPolygon()
        {
            this.BackColor = Color.FromArgb(0, 255, 255, 255);
            GeneratePolygonPoint();
            GenerateText();
            Invalidate();
        }


        


        protected override void GeneratePolygonPoint()
        {
            int nbBranches = m_nbSommet;
            
            m_VertexArray = new PointF[2 * nbBranches];
            float outerRadius = m_PolygonRadius;
            float innerRadius = m_PolygonRadius / 2;
            double angleIncrement = Math.PI / nbBranches;
            for (int i = 0; i < 2 * nbBranches; i++)
            {
                double angle = i * angleIncrement + m_rotation;
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                m_VertexArray[i] = new PointF(
                    m_center.X + (float)(Math.Cos(angle) * radius),
                    m_center.Y + (float)(Math.Sin(angle) * radius)
                );
            }
        }
    }
}
