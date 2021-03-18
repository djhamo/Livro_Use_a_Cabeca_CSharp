using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace DemoThreads
{
    public partial class Form1 : Form
    {
        private Thread trd;
        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a thread Principal do programa");
        }

        private void ThreadTarefa()
        {
            int stp;
            int novoValor;
            Random rnd = new Random();

            while (true)
            {
                stp = this.pgdThreads.Step * rnd.Next(-1, 2);
                novoValor = this.pgdThreads.Value + stp;

                if (novoValor > this.pgdThreads.Maximum)
                    novoValor = this.pgdThreads.Maximum;
                else if (novoValor < this.pgdThreads.Minimum)
                    novoValor = this.pgdThreads.Minimum;

                //this.pgdThreads.Value = novoValor;
                SetControlPropertyValue(this.pgdThreads, "value", novoValor);

                Thread.Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trd = new Thread(new ThreadStart(this.ThreadTarefa));
            trd.IsBackground = true;
            trd.Start();
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }
    }
}
