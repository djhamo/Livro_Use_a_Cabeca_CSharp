using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace MDIProject
{

    public partial class LINQtoSQL : Form
    {
        public LINQtoSQL()
        {
            InitializeComponent();
        }

        private void LINQtoSQL_Load(object sender, EventArgs e)
        {
            string connString = @" server=BLONDIE\BLONDIESQL; database=AdventureWorks; Integrated Security=true";

            try
            {
                DataContext db = new DataContext(connString);

                Table<Contact> contacts = db.GetTable<Contact>();

                var contactDetails =
                    from c in contacts
                    where c.Title == "Mr."
                    orderby c.FirstName
                    select c;

                foreach (var c in contactDetails)
                {
                    txtLinqSql.AppendText(c.Title);
                    txtLinqSql.AppendText("\t");
                    txtLinqSql.AppendText(c.FirstName);
                    txtLinqSql.AppendText("\t");
                    txtLinqSql.AppendText(c.LastName);
                    txtLinqSql.AppendText("\r\n");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
        }
    }

    [Table(Name = "Person.Contact")]
    public class Contact
    {
        [Column]
        public string Title;
        [Column]
        public string FirstName;
        [Column]
        public string LastName;

    }
}
