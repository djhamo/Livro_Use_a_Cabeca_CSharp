using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetHouse
{
    class Guy
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Bet MyBet;
        private int cash = 0;
        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        private RadioButton myRadioButton;
        public RadioButton MyRadioButton
        {
            get { return myRadioButton; }
            set { myRadioButton = value; }
        }

        private Label myLabel;
        public Label MyLabel
        {
            get { return myLabel; }
            set { myLabel = value; }
        }

        public void UpdateLabels()
        {
            myRadioButton.Text = this.Name + " tem $" + this.Cash + " reais";
            if (MyBet != null)
            {
                myLabel.Text = this.MyBet.getDescription();
            }
            else
            {
                myLabel.Text = this.Name + " ainda não fez nenhuma aposta";
            }
        }

        public void ClearBet()
        {
            MyBet = new Bet(this);
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet(this) { Amount = Amount, Dog = Dog };
                return true;
            }
            else
            {
                MessageBox.Show("O Jogador " + Name + " Não tem dinheiro para essa aposta");
                return false;
            }
        }

        public void Collect(int Winner)
        {
            if (MyBet != null) Cash += MyBet.PayOut(Winner);
        }
    }
}
