using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GoFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Entre com o seu NOME para o jogo começar", "Não posso começar o jogo");
                return;
            }

            game = new Game(textName.Text, new List<String> { "Joe", "Bob" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardsNames())
            {
                listHand.Items.Add(cardName);
            }
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();

        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Por Favor selecione uma Carta");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "O Vencedor é... " + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                buttonAsk.Enabled = false;
            }
            else
                UpdateForm();
        }


    }
}
