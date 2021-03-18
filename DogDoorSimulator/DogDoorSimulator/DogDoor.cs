using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace DogDoorSimulator
{
    class DogDoor
    {
        private bool mOpen;
        private System.Timers.Timer myTimer;
        private Config mConfig = INIFile.getConfig;
        public List<Bark> allowedBarks { get; set; } 
            
        public DogDoor()
        {
            allowedBarks = new List<Bark>();
            myTimer = new System.Timers.Timer();
            if (mConfig.AutoClose)
            {
                myTimer.Elapsed += new ElapsedEventHandler(OnTimer);
                myTimer.Interval = mConfig.TimeAutoClose;
                myTimer.AutoReset = false;
            }
            this.mOpen = false;
        }

        public void open()
        {
            Console.WriteLine("A porta para cachorro abre.");
            mOpen = true;
            if (mConfig.AutoClose)
            {
                myTimer.Enabled = true;
            }        
        }

        public void close()
        {
            Console.WriteLine("A porta para cachorro fecha.");
            mOpen = false;
            if (mConfig.AutoClose)
            {
                myTimer.Enabled = false;
            }
        }

        public bool isOpen()
        {
            return mOpen;
        }

        public void OnTimer(Object source, ElapsedEventArgs e)
        {
            close();
        }
    }
}
