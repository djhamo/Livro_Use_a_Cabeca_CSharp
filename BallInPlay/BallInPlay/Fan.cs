using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallInPlay
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPLay += ball_BallInPLay;
        }

        void ball_BallInPLay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEvertArgs = e as BallEventArgs;
                if (ballEvertArgs.Distance > 400 && ballEvertArgs.Trajectory > 30)
                    Console.WriteLine("Fan: Home Run! I'm going for the ball!");
                else
                    Console.WriteLine("Fan: Woo-hoo! Yeah!");
            }
        }
    }
}
