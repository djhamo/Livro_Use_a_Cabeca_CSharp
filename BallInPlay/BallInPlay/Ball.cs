using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallInPlay
{
    class Ball
    {
        public event EventHandler BallInPLay;
        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPLay = BallInPLay;
            if (ballInPLay != null)
                ballInPLay(this, e);
        }
    }

    class BallEventArgs : EventArgs
    {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }
        public BallEventArgs(int trajectory, int distance)
        {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }

}
