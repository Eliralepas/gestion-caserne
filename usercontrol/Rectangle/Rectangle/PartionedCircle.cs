using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Polygon
{
    public partial class PartionedCircle : Circle
    {
        private float[] _segmentAngles;
        private int _valueCount = 0;
        private Dictionary<string, int> _values;
        protected PointF[][] m_VertexArrays;
        private static Color[] colors;
        public int valueCount { get { return _valueCount; } set { _valueCount = value; InitializeSegments(); refreshPolygon(); } }
        public PartionedCircle()
        {
            _valueCount = 5;
            colors = new Color[] { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Purple, Color.Black, Color.Fuchsia };
            InitializeSegments();
            InitializeComponent();
        }

        public PartionedCircle(Dictionary<string, int> values,Color[] colorss)
        {
            _values = values;
            _valueCount = values.Count;
            colors = colorss;
            InitializeSegments();
            InitializeComponent();
        }

        private void InitializeSegments()
        {
            m_VertexArrays = new PointF[_valueCount][];
            _segmentAngles = new float[_valueCount + 1];

            float total = 0;
            for (int i = 0; i <= _valueCount; i++)
            {
                _segmentAngles[i] = total;
                total += (float)(2 * Math.PI / _valueCount);
            }
        }

        protected override void GeneratePolygonPoint()
        {
            if (_values != null && _values.Count > 0)
            {
                int total = 0;
                foreach (var val in _values.Values) total += val;

                float currentAngle = 0;
                _segmentAngles = new float[_valueCount + 1];
                _segmentAngles[0] = 0;

                int index = 1;
                foreach (var val in _values.Values)
                {
                    float segmentSize = (float)(2 * Math.PI * val / total);
                    currentAngle += segmentSize;
                    _segmentAngles[index++] = currentAngle;
                }
            }
            else
            {
                _segmentAngles = new float[_valueCount + 1];
                for (int i = 0; i <= _valueCount; i++)
                {
                    _segmentAngles[i] = (float)(i * 2 * Math.PI / _valueCount);
                }
            }
            for (int j = 0; j < _valueCount; j++)
            {
                m_VertexArrays[j] = new PointF[m_nbSommet];
                m_VertexArrays[j][0] = new PointF(m_center.X, m_center.Y);

                float startAngle = _segmentAngles[j];
                float endAngle = _segmentAngles[j + 1];

                for (int i = 1; i < m_nbSommet; i++)
                {
                    float t = (float)(i - 1) / (m_nbSommet - 2);
                    double angle = startAngle + t * (endAngle - startAngle);

                    m_VertexArrays[j][i] = new PointF(
                        m_center.X + (float)(Math.Cos(angle) * m_PolygonRadius),
                        m_center.Y + (float)(Math.Sin(angle) * m_PolygonRadius)
                    );
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (m_VertexArrays == null || m_VertexArrays.Length == 0)
                GeneratePolygonPoint();

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i < m_VertexArrays.Length; i++)
            {
                if (m_VertexArrays[i] != null && m_VertexArrays[i].Length > 2)
                {
                    using (Pen pen = new Pen(colors[i % colors.Length], m_edgeSize))
                    using (Brush brush = new SolidBrush(colors[i % colors.Length]))
                    {
                        g.FillPolygon(brush, m_VertexArrays[i]);
                        g.DrawPolygon(pen, m_VertexArrays[i]);
                    }
                }
            }
        }

        private void PartionedCircle_Load(object sender, EventArgs e)
        {
            // Load event handler
        }
    }
}
