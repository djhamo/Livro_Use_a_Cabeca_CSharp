using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPlay
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        bool Continuar = true;

        private void bt_change_color_Click(object sender, EventArgs e)
        {
            if (ck_color_ok.Checked == true)
            {
                Continuar = true;
                while (Continuar && Visible)
                {
                    for (int cont = 0; cont < 254 && Visible; cont++)
                    {
                        tx_alvo.BackColor = Color.FromArgb(cont, 255 - cont, cont);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                        if (!Continuar || !Visible)
                        {
                            break;
                        }

                    }
                    Application.DoEvents();
                    if (!Continuar || !Visible)
                    {
                        break;
                    }
                    for (int cont = 255; cont >= 0 && Visible; cont--)
                    {
                        tx_alvo.BackColor = Color.FromArgb(cont, 255 - cont, cont);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                        if (!Continuar || !Visible)
                        {
                            break;
                        }
                        
                    }
                    Application.DoEvents();
                }
                
                tx_alvo.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("The Box is not checked", "Pim Pim");
                tx_alvo.BackColor = Color.LightGray;
            }
        }

        private void bt_parar_Click(object sender, EventArgs e)
        {
            Continuar = false;
        }

        private void bt_speak_Click(object sender, EventArgs e)
        {
            int len = Talker.Blah(tx_say.Text, (int)numericUpDown1.Value);
            MessageBox.Show("The Message length is" + len);
        }
    }
}
