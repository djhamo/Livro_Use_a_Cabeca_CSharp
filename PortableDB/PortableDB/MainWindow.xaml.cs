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
using System.Data.Entity;
namespace PortableDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductContext _context = new ProductContext(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource categoriesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("categoriesViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // categoriesViewSource.Source = [generic data source]
            
            _context.Categories.Load();

            // After the data is loaded call the DbSet<T>.Local property  
            // to use the DbSet<T> as a binding source. 
            categoriesViewSource.Source = _context.Categories.Local; 
        }


    }
}
