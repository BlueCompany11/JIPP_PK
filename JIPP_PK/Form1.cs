using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIPP_PK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gCircle = groupBoxOkrag.CreateGraphics();
            gStar = groupBoxGwiazda.CreateGraphics();
            circleTimer = new System.Timers.Timer(100);
            starTimer = new System.Timers.Timer(100);
            AnimationFinishedHandler += (
                (value, nameOfVariable) =>
                {
                    circleTimer.Stop();
                    starTimer.Stop();
                    DialogResult dialogResult = MessageBox.Show("Obiekt " + nameOfVariable + " = " + value.ToString()+"\n"+"Kontynuować rysowanie?", "Zdarzenie", MessageBoxButtons.YesNo);
                    circleTimer.Stop();
                    starTimer.Stop();
                    if (dialogResult == DialogResult.Yes)
                    {
                        circleTimer.Start();
                        starTimer.Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        circleTimer.Stop();
                        starTimer.Stop();
                    }

                }
            );
        }

        delegate void ReactToAnimationFinished(int value, string nameOfVariable);
        event ReactToAnimationFinished AnimationFinishedHandler;

        System.Timers.Timer circleTimer;
        int circleSkalar = 2;
        Graphics gCircle;
        private void buttonOkregiStart_Click(object sender, EventArgs e)
        {
            
            circleTimer.Elapsed += CircleAnimation;
            circleTimer.AutoReset = true;
            circleTimer.Enabled = true;
        }
        
        private void buttonOkregiStop_Click(object sender, EventArgs e)
        {
            circleTimer.Stop();
        }

        void CircleAnimation(object sender, EventArgs e)
        {
            int x = 50;
            int y = 50;
            double marginMultiplayer = 0.5;
            int centerX = (int)(groupBoxOkrag.Width / circleSkalar * marginMultiplayer) + x;
            int centerY = (int)(groupBoxOkrag.Height / circleSkalar * marginMultiplayer) + y;
            int radius = (int)(groupBoxOkrag.Width / circleSkalar * marginMultiplayer);
            circleSkalar++;
            if (circleSkalar > 20)
            {
                AnimationFinishedHandler(circleSkalar, nameof(circleSkalar));
            }
            gCircle.DrawEllipse(Pens.ForestGreen, centerX - radius, centerY - radius,
                      radius + radius, radius + radius);
        }

        System.Timers.Timer starTimer;
        int starAngle = 10;
        Graphics gStar;
        private void buttonGwiazdyStart_Click(object sender, EventArgs e)
        {
            starTimer.Elapsed += StarAnimation;
            starTimer.AutoReset = true;
            starTimer.Enabled = true;
        }
        void StarAnimation(object sender, EventArgs e)
        {
            //groupBoxGwiazda
            int x = 2;
            int y = 20;
            Point firstPoint = new Point(groupBoxGwiazda.Width / y, groupBoxGwiazda.Height / y);
            Point secondPoint = new Point(groupBoxGwiazda.Width/5, groupBoxGwiazda.Height/5 );
            gStar.TranslateTransform(groupBoxGwiazda.Width / x, groupBoxGwiazda.Height / x);
            gStar.RotateTransform(starAngle);
            starAngle += 20;
            if (starAngle > 200)
            {
                AnimationFinishedHandler(starAngle, nameof(starAngle));
            }
            gStar.DrawLines(Pens.SeaGreen, new Point[] { firstPoint, secondPoint });
        }

        private void buttonGwiazdyStop_Click(object sender, EventArgs e)
        {
            starTimer.Stop();
        }
    }
}
