using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetHouse
{
    public partial class Form1 : Form
    {
        private Greyhound[] greyhounds;
        private Guy[] player;
        private const int NUMCachorros = 4;
        private const int NUMplayer = 3;
        private const int MINUMUMBET = 5;
        private Guy selectPlayer;
        public Form1()
        {
            InitializeComponent();

            Random myRandomizer = new Random();

            int finish = pbTrack.Width - 125;

            greyhounds = new Greyhound[NUMCachorros]
			{
				new Greyhound() {Randomizer = myRandomizer, MyPictureBox = pbDog1, StartingPosition = pbDog1.Location.X, RaceTrackLength = finish},
				new Greyhound() {Randomizer = myRandomizer, MyPictureBox = pbDog2, StartingPosition = pbDog2.Location.X, RaceTrackLength = finish},
				new Greyhound() {Randomizer = myRandomizer, MyPictureBox = pbDog3, StartingPosition = pbDog3.Location.X, RaceTrackLength = finish},
				new Greyhound() {Randomizer = myRandomizer, MyPictureBox = pbDog4, StartingPosition = pbDog4.Location.X, RaceTrackLength = finish}
			};

            player = new Guy[NUMplayer] 
            {
                new Guy() { Name = "Joe", Cash = 50, MyLabel = lbPlayer1, MyRadioButton = rbPlayer1},
                new Guy() { Name = "Bob", Cash = 75, MyLabel = lbPlayer2, MyRadioButton = rbPlayer2},
                new Guy() { Name = "Al", Cash = 45, MyLabel = lbPlayer3, MyRadioButton = rbPlayer3}

            };

            selectPlayer = player[0];
            UpdateLabel();
            numDog.Maximum = NUMCachorros;
            numDog.Minimum = 1;
            numBet.Minimum = MINUMUMBET;
            numBet.Maximum = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool fimCorrida = false;
            while (!fimCorrida)
            {
                for (int i = 0; i < NUMCachorros; i++)
                {
                    fimCorrida = greyhounds[i].Run();
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(2);
                    if (fimCorrida)
                    {
                        int winner = (i + 1);
                        MessageBox.Show("O Vencedor é o Cachorro #" + winner);
                        PayBet(winner);
                        break;
                    }
                }
            }
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            lbet.Text = "Minimum Bet $" + MINUMUMBET;
            for (int i = 0; i < NUMplayer; i++)
            {
                player[i].UpdateLabels();
            }
            lbSelectLabel.Text = selectPlayer.Name;
        }

        private void PayBet(int Winner)
        {
            for (int i = 0; i < NUMplayer; i++)
            {
                player[i].Collect(Winner);
                player[i].ClearBet();
            }
            for (int i = 0; i < NUMCachorros; i++)
            {
                greyhounds[i].TakeStartingPosition();
            }
        }

        private Guy checkRbGuy(RadioButton nRb)
        {
            for (int i = 0; i < NUMplayer; i++)
            {
                if (player[i].MyRadioButton == nRb) return player[i];
            }
            return null;
        }

        private void rbPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            selectPlayer = checkRbGuy(rb);
            UpdateLabel();
        }

        private void rbPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            selectPlayer = checkRbGuy(rb);
            UpdateLabel();
        }

        private void rbPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            selectPlayer = checkRbGuy(rb);
            UpdateLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPlayer.PlaceBet((int)numBet.Value, (int)numDog.Value);
            UpdateLabel();
        }
    }
}
