using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallInPlay
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPLay += ball_BallInPLay;
        }

        void ball_BallInPLay(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CatchBall()
        {
            Console.WriteLine("Pitcher: I caught the ball");
        }

        private void CoverFirstBase()
        {
            Console.WriteLine("Pitcher: I covered first Base");
        }
    }
}
