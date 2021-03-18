using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyEditor
{
    public partial class Form1 : Form
    {
        private string name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"d:\Processar";
            openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt";
            openFileDialog1.FileName = "modelo.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
                this.Text = name;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvando porcarias...";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
