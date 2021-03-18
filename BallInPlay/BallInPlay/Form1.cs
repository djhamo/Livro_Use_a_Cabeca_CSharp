using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallInPlay
{
    public partial class Form1 : Form
    {
        Ball ball = new Ball();
        Pitcher pitcher;
        Fan fan;
        public Form1()
        {
            InitializeComponent();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void PlayBall_Click(object sender, EventArgs e)
        {
            BallEventArgs ballEventArgs = new BallEventArgs(
                (int)udTrajectory.Value, (int)udDistance.Value);
            ball.OnBallInPlay(ballEventArgs);
        }


    }
}
