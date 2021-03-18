using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BetHouse
{
    class Greyhound
    {
        public Greyhound()
		{
			Location = 0;
			MyPictureBox = new PictureBox();
			Randomizer = new Random();
			RaceTrackLength = 100;
			StartingPosition = 0;
		}

        private int startingPosition;
        public int StartingPosition {
            get { return startingPosition; }
            set {
                startingPosition = value;
            }
        }
        private int raceTrackLength;
        public int RaceTrackLength {
            get { return raceTrackLength; } 
            set { raceTrackLength = value;}
        }
        public PictureBox MyPictureBox = null;
        private int Location = 0;
        private Random randomizer;
        public Random Randomizer {
            get { return randomizer; }
            set { randomizer = value; }
        }
        public Greyhound(PictureBox myPictureBox)
        {
            this.MyPictureBox = myPictureBox;
        }
        public bool Run()
        {
            // Move forward either 1, 2, 3 or 4 spaces at random
			int distance = Randomizer.Next(-1, 5);
			Location += distance;

			// Update the position of my PictureBox on the form
			Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;

			// Return true if I won the race
			return Location > this.RaceTrackLength;
        }

        public void TakeStartingPosition() 
        {
            Point p = MyPictureBox.Location;
            p.X = this.StartingPosition;
            MyPictureBox.Location = p;
            Location = 0;
        }
    }
}
