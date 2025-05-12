using System.Drawing;
using System.Windows.Forms;
using System;

namespace Polygon
{
    public class PolygonM : UserControl
    {
        /*private attribut */
        protected int m_nbSommet;
        protected PointF m_center;
        protected int m_PolygonRadius;
        protected PointF[] m_VertexArray;
        protected PointF[] m_corners;

        protected Color m_backgroundColor = Color.Black;
        protected Color m_edgeColor = Color.Black;
        protected int m_edgeSize = 2;
        protected int m_minpoints = 2;


        protected Label m_label;
        protected string m_text;
        protected Color m_textfontColor = Color.White;
        protected Font m_textFont;
       

        /*getter et setter*/
        public int m_NBSommet { get { return m_nbSommet; } set { if (value >= m_minpoints) { m_nbSommet = value; refreshPolygon(); } } }
        public Size m_Size { get { return this.Size; } set { this.Size = value; refreshPolygon(); } }
        public Color m_BackGroundColor { get { return m_backgroundColor; } set { m_backgroundColor = value; refreshPolygon(); } }
        public Color m_EdgeColor { get { return m_edgeColor; } set { m_edgeColor = value; refreshPolygon(); } }
        public int m_EdgeSize { get { return m_edgeSize; } set { m_edgeSize = value; refreshPolygon(); } }

        public string m_Text { get { return m_text; }set { m_text = value;refreshPolygon(); }  }

        public Font m_TextFont { get { return m_textFont; }set { m_textFont = value;refreshPolygon(); } }
        public Color m_FontColor { get { return m_textfontColor; } set { m_textfontColor = value;refreshPolygon(); } }

        public PolygonM()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.FromArgb(0, 255, 255, 255);
            
        }

        public PolygonM(Point location, Size size, int quality)
        {
            this.DoubleBuffered = true;
            m_backgroundColor = Color.Black;
            m_edgeColor = Color.Black;
            this.m_nbSommet = quality;
            this.m_PolygonRadius = Math.Max(size.Width, size.Height);
            this.m_center = new PointF(size.Width / 2, size.Height / 2);
            this.Size = new Size(size.Width + m_edgeSize, size.Height*2 + m_edgeSize*5);
            this.Location = location;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            GeneratePosition(size, location);
            GeneratePolygonPoint();
            GenerateText();
            Invalidate();
        }

        protected void refreshPolygon()
        {
            this.BackColor = Color.FromArgb(0, 255, 255, 255);
            GeneratePolygonPoint();
            GenerateText();
            Invalidate();
        }

        protected void GenerateText()
        {
            if (m_label == null)
            {
                m_label = new Label();
                this.Controls.Add(m_label);
            }
            m_label.Text = m_text;
            m_label.ForeColor = m_textfontColor;
            m_label.Font = m_textFont;
            m_label.AutoSize = true;
            int labelX = (this.Width - m_label.Width) / 2;
            int labelY = (this.Height - m_label.Height) / 2;
            m_label.Location = new Point(labelX, labelY);
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            m_center = new PointF(Width / 2, Height / 2);
            m_PolygonRadius = Math.Max(Width-m_edgeSize, Height-m_edgeSize*2);
            GeneratePolygonPoint();
            GenerateText();
            Invalidate();
        }
        

        

        protected override void OnPaint(PaintEventArgs e)
        {
            if (m_VertexArray == null)
            {
                GeneratePolygonPoint();
            }
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(m_EdgeColor, m_edgeSize))
            using (Brush brush = new SolidBrush(m_backgroundColor))
            {
                if (m_VertexArray != null && m_VertexArray.Length > 2)
                {
                    g.FillPolygon(brush, m_VertexArray);
                    g.DrawPolygon(pen, m_VertexArray);
                    
                }
            }
        }

        protected virtual void GeneratePosition(Size size, Point location)
        {
            this.m_PolygonRadius = Math.Max(size.Width, size.Height);
            this.m_center = new PointF(size.Width / 2, size.Height / 2);
            this.Size = new Size(size.Width + m_edgeSize, size.Height*2 + m_edgeSize*2);
            this.Location = location;
        }

        protected virtual void GeneratePolygonPoint()
        { return; }



        private void PolygonM_Load(object sender, EventArgs e)
        {

        }
    }
}