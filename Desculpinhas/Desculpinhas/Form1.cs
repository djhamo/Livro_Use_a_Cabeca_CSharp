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
using System.Runtime.Serialization;



namespace Desculpinhas
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private string selectedFolder = @"d:\Processar";
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            labelLastUsed.Text = DateTime.Now.ToString();
            currentExcuse.LastUsed = DateTime.Parse(labelLastUsed.Text);
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.textExcuse.Text = currentExcuse.Description;
                this.textResults.Text = currentExcuse.Results;
                this.labelLastUsed.Text = currentExcuse.LastUsed.ToString();
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    textFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";

            this.formChanged = changed;
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                buttonSave.Enabled = true;
                buttonOpen.Enabled = true;
                buttonRandom.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textExcuse.Text) 
                || String.IsNullOrEmpty(textResults.Text))
            {
                MessageBox.Show("Please specify an excuse and a result",
                    "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Excuse Files (*.excuse)|*.excuse|Todos os Arquivos (*.*)|*.*";
            saveFileDialog1.FileName = textExcuse.Text + ".excuse";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.LastUsed = DateTime.Now;
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = 
                    "Excuse Files (*.excuse)|*.excuse|Todos os Arquivos (*.*)|*.*";
                openFileDialog1.FileName = textExcuse.Text + ".excuse";

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    bool clearForm = false;
                    try
                    {
                        currentExcuse = new Excuse(openFileDialog1.FileName);
                        try
                        {
                            UpdateForm(false);

                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("The excuse file '"
                                + openFileDialog1.FileName +
                                "' had a invalid data", "Unable to open the excuse");
                            clearForm = true;
                        }
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show("An error occorred while opening the excuse '"
                            + openFileDialog1.FileName + "'" + Environment.NewLine
                            + ex.Message, "Unable to open the excuse", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        clearForm = true;
                    }
                    finally
                    {
                        if (clearForm)
                        {
                            textExcuse.Text = "";
                            textResults.Text = "";
                            labelLastUsed.Text = DateTime.Now.ToString()7;
                        }
                    }
                }
            }

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "The current escuse has not been saved, Continue",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void textExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = textExcuse.Text;
            UpdateForm(true);
        }

        private void textResults_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textResults.Text;
            UpdateForm(true);
        }

        private void labelLastUsed_Click(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = DateTime.Parse(labelLastUsed.Text);
            UpdateForm(true);
        }
    }
}
