using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polygon
{
    public partial class Circle : PolygonM
    {
        public Circle() : base()
        {
            m_PolygonRadius = Math.Min(Width, Height) / 2;  
            m_center = new PointF(Width / 2, Height / 2);
            m_nbSommet = 90;
            InitializeComponent();
        }

        public Circle(int[] pos, Size size, int quality) : base(new System.Drawing.Point(pos[0], pos[1]), size, quality)
        {
            InitializeComponent();
        }

        protected override void GeneratePolygonPoint()
        {
            m_VertexArray = new PointF[m_nbSommet];
            for (int i = 0; i < m_nbSommet; i++)
            {
                double angle = (2 * Math.PI * i) / m_nbSommet;
                m_VertexArray[i] = new PointF(
                    m_center.X + (float)(Math.Cos(-angle) * m_PolygonRadius),
                    m_center.Y + (float)(Math.Sin(-angle) * m_PolygonRadius)
                );
            }
        }


        protected override void GeneratePosition(Size size, Point location)
        {
            m_PolygonRadius = Math.Min(size.Width, size.Height) / 2;
            m_center = new PointF(size.Width / 2, size.Height / 2);
            this.Size = new Size(size.Width * 2 + m_edgeSize, size.Height * 2 + m_edgeSize);
            this.Location = location;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            m_PolygonRadius = Math.Min(Width, Height) / 2; 
            m_center = new PointF(Width / 2, Height / 2);
            GeneratePolygonPoint();
            Invalidate(); 
        }
        
    }
}