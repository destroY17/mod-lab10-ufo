using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Ufo
{
    public partial class MoveForm : Form
    {
        private const float PaintRadius = 10;

        private bool isMoving_ = false;
        private bool isGraph_ = false;

        public MoveForm()
        {
            InitializeComponent();
        }

        private void ClearPoint(Graphics g, PointF point) =>
            g.FillEllipse(new SolidBrush(MovePanel.BackColor), point.X, point.Y, PaintRadius, PaintRadius);

        private void DrawPoint(Graphics g, PointF point) =>
            g.FillEllipse(Brushes.Black, point.X, point.Y, PaintRadius, PaintRadius);

        private void DrawPointMoving(Graphics g, Input data, double accuracy, int maxIteration = 100)
        {
            int members = MoveCalculator.GetMembersToAccuracy(data, accuracy, maxIteration);

            if (members == 0)
            {
                MessageBox.Show("unattainable accuracy");
                return;
            }

            DrawPoint(g, data.Start);
            DrawPoint(g, data.End);

            var coeff = MoveCalculator.GetTiltAngle(data.Start, data.End, members);
            var currentPoint = data.Start;
            double distance = MoveCalculator.GetDistance(data.Start, data.End);

            var sin = MathFunctions.Sin(coeff, members);
            var cos = MathFunctions.Cos(coeff, members);

            while (distance > accuracy)
            {
                Thread.Sleep(50);
                ClearPoint(g, currentPoint);

                currentPoint.X += (float)(data.Step * sin);
                currentPoint.Y += (float)(data.Step * cos);
                distance = MoveCalculator.GetDistance(currentPoint, data.End);

                DrawPoint(g, currentPoint);
            }
        }

        private Input InitInput()
        {
            try
            {
                return new Input(
                    new PointF(float.Parse(xStartTB.Text), float.Parse(yStartTB.Text)),
                    new PointF(float.Parse(xEndTB.Text), float.Parse(yEndTB.Text)),
                    double.Parse(stepTB.Text)
                    );
            }
            catch
            {
                return null;
            }
        }

        private GraphData InitGraphData()
        {
            try
            {
                return new GraphData(
                    double.Parse(minRadiusTB.Text),
                    double.Parse(maxRadiusTB.Text),
                    double.Parse(stepRadiusTB.Text)
                    );
            }
            catch
            {
                return null;
            }
        }

        private void MovePanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.DrawLine(Pens.Black, 0, MovePanel.Height / 2, MovePanel.Width, MovePanel.Height / 2);
            g.DrawLine(Pens.Black, MovePanel.Width / 2, 0, MovePanel.Width / 2, MovePanel.Height);
            g.TranslateTransform(MovePanel.Width / 2, MovePanel.Height / 2);

            var data = InitInput();
            if (isMoving_ && data != null && double.TryParse(accuracyTB.Text, out double accuracy))
            {
                DrawPointMoving(g, data, accuracy);
            }

            var graphData = InitGraphData();
            if (isGraph_ && graphData.Values != null && data != null)
            {
                var path = GetChoosenFilePath();
                GraphBuilder.SaveGraph(MovePanel.Size, data, graphData.Values, path);
                using (var image = Image.FromFile(path))
                { g.DrawImage(image, new Point(-MovePanel.Width / 2, -MovePanel.Height / 2)); }
            }

            isMoving_ = false;
            isGraph_ = false;
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            isMoving_ = true;
            MovePanel.Invalidate();
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            isGraph_ = true;
            MovePanel.Invalidate();
        }

        private string GetChoosenFilePath()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg";

                if (sfd.ShowDialog() == DialogResult.OK)
                    return sfd.FileName;
            }
            return string.Empty;
        }
    }
}
