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

    public partial class Rectangle : PolygonM
    {
        public Rectangle() : base()
        {
            m_nbSommet = 4;
            m_minpoints = 4;
            InitializeComponent();
        }

        public Rectangle(int[] pos, int size) : base(new System.Drawing.Point(pos[0], pos[1]), new Size(size, size), 4)
        {
            m_nbSommet = 4;
            m_minpoints = 4;
            InitializeComponent();
        }



        protected override void GeneratePolygonPoint()
        {
            m_VertexArray = new PointF[m_nbSommet];
            float halfWidth = m_PolygonRadius / 2;
            float halfHeight = m_PolygonRadius / 2;
            m_VertexArray[0] = new PointF(m_center.X - halfWidth, m_center.Y - halfHeight);
            m_VertexArray[1] = new PointF(m_center.X + halfWidth, m_center.Y - halfHeight);
            m_VertexArray[2] = new PointF(m_center.X + halfWidth, m_center.Y + halfHeight);
            m_VertexArray[3] = new PointF(m_center.X - halfWidth, m_center.Y + halfHeight);
        }
    }
}
