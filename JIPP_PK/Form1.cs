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
            //towrze obiekty po ktorych bede rysowal
            //groupBoxOkrag to ten obiekt graficzny podpisany Animacja okregów
            gCircle = groupBoxOkrag.CreateGraphics();
            //analogicznie
            gStar = groupBoxGwiazda.CreateGraphics();
            //inicjuje timery ktore sa juz gotowe do uzycia i tylko czekaja az zostana uruchomione 
            circleTimer = new System.Timers.Timer(100);
            starTimer = new System.Timers.Timer(100);
            //dodaje do zdarzenia wyrazenie lambda ktore bedzie wywolywane za kazdym razem gdy wywolamy metode AnimationFinishedHandler(int value, string nameOfVariable)
            AnimationFinishedHandler += (
                (value, nameOfVariable) =>  //value to int, nameOfVariable to string wywoałanie metody AnimationFinishedHandler(2,"asd") przypisze tym obiektom odpowiednio 2 i "asd"
                {
                    //zatrzymuje timery
                    circleTimer.Stop();
                    starTimer.Stop();
                    //pojawia sie okno czy kontynuowac
                    DialogResult dialogResult = MessageBox.Show("Obiekt " + nameOfVariable + " = " + value.ToString()+"\n"+"Kontynuować rysowanie?", "Zdarzenie", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {   //jesli tak to je wznawiam
                        circleTimer.Start();
                        starTimer.Start();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //jesli nie to juz nic nie robie bo sa timery zatrzymane
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
            //metoda do uruchomienia timera i przypisania do niego metody ktora rysuje okregi
            circleTimer.Elapsed += CircleAnimation;
            circleTimer.AutoReset = true;
            circleTimer.Enabled = true;
        }
        
        private void buttonOkregiStop_Click(object sender, EventArgs e)
        {
            //zatrzymuje timer i zabieram mu metode do tworzenia okregow (inaczej po kilkukrotnym wcisnieciu przycisku start mialbym kilka razy przypisana ta metode czyli by sie wykonywala kilka razy niepotrzebnie, bo wystarczy raz cos namalowac, a nie kilka razy po tym samym
            circleTimer.Stop();
            circleTimer.Elapsed -= CircleAnimation;
        }

        void CircleAnimation(object sender, EventArgs e)
        {
            //pozmieniaj sobie wartosci by popatrzec co za co odpowiada
            int x = 50;
            int y = 50;
            double marginMultiplayer = 0.5;
            int centerX = (int)(groupBoxOkrag.Width / circleSkalar * marginMultiplayer) + x;
            int centerY = (int)(groupBoxOkrag.Height / circleSkalar * marginMultiplayer) + y;
            int radius = (int)(groupBoxOkrag.Width / circleSkalar * marginMultiplayer);
            circleSkalar++;
            if (circleSkalar > 20)
            {
                //zglaszam to zdarzenie i podaje mu argumenty odpowiadajace animacji okregow. nameof(asd) zwroci "asd"
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
            gStar.RotateTransform(50);
            starAngle += 20;
            gStar.TranslateTransform(10, 0);
            gStar.DrawLine(new Pen(Color.Yellow, 3), groupBoxGwiazda.Width, groupBoxGwiazda.Height, 25, 10);
        }

        private void buttonGwiazdyStop_Click(object sender, EventArgs e)
        {
            starTimer.Stop();
            starTimer.Elapsed -= StarAnimation;
        }
    }
}
