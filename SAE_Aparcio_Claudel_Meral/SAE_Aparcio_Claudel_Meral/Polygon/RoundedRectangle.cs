using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polygon
{
    public partial class RoundedRectangle : PolygonM
    {
        private float m_cornerRadius = 20;
        
        
        public float CornerRadius { get { return m_cornerRadius; } set { m_cornerRadius = value; GenerateCorners(); refreshPolygon(); GenerateCorners(); } }
        public RoundedRectangle() : base()
        {

            m_nbSommet = 90;
            m_minpoints = 4;
            InitializeComponent();
            GenerateCorners();
            GeneratePolygonPoint();
        }

       

        public RoundedRectangle(int[] pos, Size size, int quality) : base(new System.Drawing.Point(pos[0], pos[1]), size, quality)
        {
            InitializeComponent();
            GenerateCorners();
            GeneratePolygonPoint();
            m_minpoints = 4;
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GenerateCorners();
            GeneratePolygonPoint();
            Invalidate();
        }

        private void GenerateCorners()
        {
            m_corners = new PointF[4];

            m_corners[0] = new PointF(this.Size.Width - m_cornerRadius, this.Size.Height - m_cornerRadius); // bas droit
            m_corners[1] = new PointF(m_cornerRadius, this.Size.Height - m_cornerRadius); // bas gauche
            m_corners[2] = new PointF(m_cornerRadius, m_cornerRadius); // haut gauche
            m_corners[3] = new PointF(this.Size.Width - m_cornerRadius, m_cornerRadius); // haut droit
        }



        protected override void GeneratePolygonPoint()
        {
            if (m_corners == null)
            {
                GenerateCorners();
            }

            m_VertexArray = new PointF[m_nbSommet];
            int quality = m_nbSommet / 4;

            for (int i = 0; i < m_nbSommet; i++)
            {
                int cornerIndex = i / quality % 4;
                double angle = (Math.PI / 2) * (cornerIndex) + (Math.PI / 2) * (i % quality) / quality;

                m_VertexArray[i] = new PointF(
                    m_corners[cornerIndex].X + (float)(Math.Cos(angle) * m_cornerRadius),
                    m_corners[cornerIndex].Y + (float)(Math.Sin(angle) * m_cornerRadius)
                );
            }
        }
    }
}