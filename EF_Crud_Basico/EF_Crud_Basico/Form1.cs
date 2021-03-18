using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;

namespace EF_Crud_Basico
{
    public partial class Form1 : Form
    {
        //ContatoEntities contextoDados;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            using (contextoDados = new ContatoEntities())
            {
                
                DbSet<Person> dset = Db.People;
                bindingList = dset.Local.ToBindingList();

                contactDataGridView.DataSource = contextoDados.Contact;
                bnStudent.BindingSource = new BindingSource(dgStudent.DataSource, null);
                 
            }
            */
        }
    }
}
