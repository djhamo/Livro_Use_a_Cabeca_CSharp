using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'elementDB.ElementNote' table. You can move, or remove it, as needed.
            this.elementNoteTableAdapter.Fill(this.elementDB.ElementNote);
            // TODO: This line of code loads data into the 'elementDB.Elements' table. You can move, or remove it, as needed
            RefreshElementTable();

            StatusBar.BackColor = System.Drawing.Color.Transparent;
        }

        private void RefreshElementTable()
        {
            this.elementsTableAdapter.Fill(this.elementDB.Elements, "%" + SearchTB.Text + "%");
        }

        private void ElementGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            this.elementsTableAdapter.Update(elementDB);
        }

        private void NotesGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            elementNoteTableAdapter.Update(elementDB);
        }



        private void ElementGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            NameTB.Text = ElementGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (ElementGrid.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                BirthdayPicker.Value = DateTime.Parse(ElementGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            else
                BirthdayPicker.Value = DateTime.Today;

            AddressTB.Text = ElementGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            PhoneTB.Text = ElementGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            EmailTB.Text = ElementGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int TempInd = ElementGrid.CurrentRow.Index;
            ElementDB.ElementsRow row = elementsTableAdapter.GetData("%" + SearchTB.Text + "%").FindByID(Int32.Parse(ElementGrid.CurrentRow.Cells[0].Value.ToString()));
            row.ElementName = NameTB.Text;
            row.Birthday = BirthdayPicker.Value;
            row.Address = AddressTB.Text;
            row.Phone = PhoneTB.Text;
            row.Email = EmailTB.Text;
            elementsTableAdapter.Update(row);
            RefreshElementTable();

            ElementGrid.CurrentCell = ElementGrid.Rows[TempInd].Cells[1];

            StatusBar.Text = "Patient edited succesfully!";
        }

        private void NewAddBtn_Click(object sender, EventArgs e)
        {
            AddNewPatient();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ElementDB.ElementsRow row = elementsTableAdapter.GetData("%" + SearchTB.Text + "%").FindByID(Int32.Parse(ElementGrid.CurrentRow.Cells[0].Value.ToString()));
            row.Delete();
            elementsTableAdapter.Update(row);
            RefreshElementTable();

            StatusBar.Text = "Patient deleted succesfully!";
        }

        private void AddNoteBtn_Click(object sender, EventArgs e)
        {
            int TempInd = ElementGrid.CurrentRow.Index;
            elementNoteTableAdapter.Insert(DateTime.Parse(NoteDatePicker.Value.ToShortDateString()), NotesTB.Text, Int32.Parse(ElementGrid.CurrentRow.Cells[0].Value.ToString()));
            RefreshElementTable();
            elementNoteTableAdapter.Fill(this.elementDB.ElementNote);
            ElementGrid.CurrentCell = ElementGrid.Rows[TempInd].Cells[1];
            NotesTB.Text = "";

            StatusBar.Text = "Notes added successfully!";

            NotesTB.Focus();
        }

        private void AddNewPatient()
        {
            elementsTableAdapter.Insert(NewNameTB.Text, DateTime.Parse(NewBirthdayPicker.Value.ToShortDateString()),
                NewAddressTB.Text, NewPhoneTB.Text, NewEmailTB.Text);

            int InsertedID = Convert.ToInt32(elementsTableAdapter.GetDataByNameAndDOB(NewNameTB.Text, DateTime.Parse(NewBirthdayPicker.Value.ToShortDateString())).Rows[0]["ID"]);
            RefreshElementTable();
            for (int i = 0; i < ElementGrid.Rows.Count; i++)
            {
                if (elementsTableAdapter.GetData("%" + SearchTB.Text + "%").Rows[i]["ID"].ToString() == InsertedID.ToString())
                    ElementGrid.CurrentCell = ElementGrid.Rows[i].Cells[1];
            }

            StatusBar.Text = "Patient added succesfully!";

            NewNameTB.Text = "";
            NewBirthdayPicker.Value = DateTime.Today;
            NewAddressTB.Text = "";
            NewPhoneTB.Text = "";
            NewEmailTB.Text = "";

           // NewNameTB.Focus();
            RightTabControl.SelectedIndex = 1;
        }

        private void NewNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddNewPatient();
            }
        }

        private void RightTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RightTabControl.SelectedIndex == 0)
                NewNameTB.Focus();
            else
                NotesTB.Focus();
        }

        private void ElementGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RightTabControl.SelectedIndex = 1;
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            RefreshElementTable();
        }

        private void SearchTB_Enter(object sender, EventArgs e)
        {
            RightTabControl.SelectedIndex = 1;
            SearchTB.Focus();
        }

        private void VersionLbl_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/programmingms/");
        }
    }
}
