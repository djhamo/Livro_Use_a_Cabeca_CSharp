using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretIngredient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        private void btIngredients_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
            {
                Console.WriteLine("I'll add " + ingredientMethod((int)amount.Value));
            }
            else
                Console.WriteLine("I don't have a secret ingredient... sorry");
        }

        private void btSuzanne_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);
        }

        private void btAmy_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmysSecretIngredientMethod);
        }


    }
}
