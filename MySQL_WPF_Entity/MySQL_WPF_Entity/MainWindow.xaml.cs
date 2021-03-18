using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace MySQL_WPF_Entity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private testEntities testcontext;
        ObservableCollection<employee> mEmployees;
        employee selectEmployee;

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                testcontext = new testEntities();
                mEmployees = new ObservableCollection<employee>(testcontext.employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridView1.ItemsSource = mEmployees;
        }

        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectEmployee = dataGridView1.SelectedItem as employee;
            //Se dominar o data bind isso some
            if (selectEmployee != null)
            {
                txtId.Text = selectEmployee.EmpId.ToString();
                txtName.Text = selectEmployee.EmpName;
                txtAddress.Text = selectEmployee.EmpAddress;
            }
        }


        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                employee nemp = new employee();
                nemp.EmpId = testcontext.employee.Max(p => p.EmpId) + 1;
                nemp.EmpName = txtName.Text;
                nemp.EmpAddress = txtAddress.Text;

                mEmployees.Add(nemp);
                testcontext.employee.Add(nemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Incluir", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                testcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (selectEmployee != null)
            {
                try
                {
                    testcontext.employee.Remove(selectEmployee);
                    mEmployees.Remove(selectEmployee);
                    dataGridView1.Items.Refresh();
                    selectEmployee = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir", "Excluir", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                testcontext = new testEntities();
                mEmployees = new ObservableCollection<employee>(testcontext.employee);
                dataGridView1.ItemsSource = mEmployees;
                dataGridView1.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
