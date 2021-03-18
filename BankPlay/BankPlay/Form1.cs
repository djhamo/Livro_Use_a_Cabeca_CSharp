using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankPlay
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Cash = 100, Name = "Bob" };
            joe = new Guy() { Name = "Joe", Cash = 50 };
            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "O Banco Possui $" + bank;
        }

        private void bt_give_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O Banco está quebrado");
            }
        }

        private void bt_receive_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            int result = bob.ReceiveCash(joe.GiveCash(10));
            if (result == 0)
            {
                MessageBox.Show("Não Rolou a grana pro bob");
            }
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            int result = joe.ReceiveCash(bob.GiveCash(5));
            if (result == 0)
            {
                MessageBox.Show("Não Rolou a grana pro bob");
            }
            UpdateForm();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            MenuMaker meuMenu = new MenuMaker();
            lb_segunda.Text = meuMenu.getNewMenu();
            lb_terça.Text = meuMenu.getNewMenu();
            lb_quarta.Text = meuMenu.getNewMenu();
            lb_quinta.Text = meuMenu.getNewMenu();
            lb_sexta.Text = meuMenu.getNewMenu();
            lb_sabado.Text = meuMenu.getNewMenu();
            lb_domingo.Text = meuMenu.getNewMenu();

        }


    }
}
