using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnightRider
{
    public delegate void StateMessage(PlayerStatus status);
    public delegate void MoveMessage(Point ini, Point dest, PlayerStatus status);
}
