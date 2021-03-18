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
using System.ComponentModel;

namespace RebuWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DadosXML _dd;
        RebuDetail selectedRebu;

        public MainWindow()
        {
            InitializeComponent();
            _dd = DataBB.Database;
        }

        private void PopulatTest(DadosXML dd)
        {
            dd.DirectoryOwner = "Luciana Satie Oguma";

            EmpresaDetail emp = new EmpresaDetail();

            emp.EmpresaId = dd.UltimoID;
            emp.Nome = "Telefonica SA";
            emp.Telefone = "(11) 1234-5678";

            //dd.empresas.Add(emp.EmpresaId, emp);
            dd.empresas.Add(emp);

            RebuDetail rebu = new RebuDetail();
            rebu.RebuId = dd.UltimoID;
            rebu.mEmpresa = emp;
            rebu.Data = "01/04/2015";
            rebu.OcorrenciaInicial = "A Internet caiu";

            RebuStepDetail step = new RebuStepDetail();
            step.RebuStepId = dd.UltimoID;
            step.Data = "03/04/2015";
            step.Ocorrencia = "Os caras deram uma de João sem braço";

            //rebu.detalhes.Add(step.RebuStepId, step);
            rebu.detalhes.Add(step);

            step = new RebuStepDetail();
            step.RebuStepId = dd.UltimoID;
            step.Data = "04/04/2015";
            step.Ocorrencia = "O Cara veio e arrumou";

            //rebu.detalhes.Add(step.RebuStepId, step);
            rebu.detalhes.Add(step);

            //dd.rebus.Add(rebu.RebuId, rebu);
            dd.rebus.Add(rebu);

            grRebus.Items.Refresh();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DataBB.Save();
            grRebus.Items.Refresh();
        }

        private void grRebus_Loaded(object sender, RoutedEventArgs e)
        {
            //grRebus.Items.Clear();
            mEmpresat.ItemsSource = _dd.empresas;
            grEmpresa.ItemsSource = _dd.empresas;
            grRebus.ItemsSource = _dd.rebus;
            grRebus.Items.Refresh();
        }

        private void grRebus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grRebus.SelectedIndex >= 0 && grRebus.SelectedIndex < _dd.rebus.Count)
            {
                selectedRebu = grRebus.SelectedItem as RebuDetail;
                //Obter o rebu por ID não pelo indice
                grRebusStep.ItemsSource = selectedRebu.detalhes;

            }
            else
            {
                selectedRebu = null;
            }
                
                
        }

        private void bt_delete_Click(object sender, RoutedEventArgs e)
        {
            RebuDetail temp = grRebus.SelectedItem as RebuDetail;
            _dd.rebus.Remove(temp);
            grRebus.Items.Refresh();
            selectedRebu = null;
        }

        private void bt_del_step_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRebu != null)
            {
                RebuStepDetail temp = grRebusStep.SelectedItem as RebuStepDetail;
                //int idTemp = _dd._dd.rebus.Find(temp);
                selectedRebu.detalhes.Remove(temp);
                grRebusStep.Items.Refresh();
            }
        }

        private void bt_new_Click(object sender, RoutedEventArgs e)
        {
            RebuDetail rebu = new RebuDetail();
            rebu.RebuId = _dd.UltimoID;
            rebu.Data = DateTime.Now.Date.ToString("dd/MM/yyyy");
            rebu.OcorrenciaInicial = "";

            _dd.rebus.Add(rebu);
            grRebus.Items.Refresh();
        }

        private void bt_new_step_Click(object sender, RoutedEventArgs e)
        {
            if (selectedRebu != null)
            {
                RebuStepDetail temp = new RebuStepDetail();
                temp.RebuStepId = _dd.UltimoID;
                temp.Data = DateTime.Now.Date.ToString("dd/MM/yyyy");
                temp.Ocorrencia = "";

                selectedRebu.detalhes.Add(temp);
                grRebusStep.Items.Refresh();
            }
        }

        private void New_Empresa_Click(object sender, RoutedEventArgs e)
        {
            EmpresaDetail newEmp = new EmpresaDetail();
            newEmp.EmpresaId = _dd.UltimoID;

            _dd.empresas.Add(newEmp);
            grEmpresa.Items.Refresh();
        }

        private void del_empresa_Click(object sender, RoutedEventArgs e)
        {
            EmpresaDetail temp = grEmpresa.SelectedItem as EmpresaDetail;
            _dd.empresas.Remove(temp);
            grEmpresa.Items.Refresh();
        }

        private void ID_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            grRebus.ItemsSource = _dd.rebus;
            grRebus.Items.Refresh();
        }

        private void find_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(grRebus.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    RebuDetail p = o as RebuDetail;
                    if (t.Name == "schID")
                        //return p.RebuId.ToString().Contains(filter);
                        return (p.RebuId == Convert.ToInt32(filter));
                    //return (p.Name.ToUpper().StartsWith(filter.ToUpper()));
                    if (t.Name == "schOcoor" && p.OcorrenciaInicial != null)
                        return (p.OcorrenciaInicial.ToUpper().Contains(filter.ToUpper()));

                    if (t.Name == "schEmp" && p.mEmpresa != null)
                        return (p.mEmpresa.Nome.ToUpper().Contains(filter.ToUpper())); 
                    return true;
                };
            }
        }

        private void findDetail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string filter = t.Text;
            ICollectionView cv = CollectionViewSource.GetDefaultView(grRebusStep.ItemsSource);
            if (filter == "")
                cv.Filter = null;
            else
            {
                cv.Filter = o =>
                {
                    RebuStepDetail p = o as RebuStepDetail;
                    if (t.Name == "schIDDet")
                        //return p.RebuStepId.ToString().Contains(filter);
                        return (p.RebuStepId == Convert.ToInt32(filter));
                        
                    if (t.Name == "schProtocolo" && p.Protocolo != null)
                        return (p.Protocolo.ToUpper().Contains(filter.ToUpper()));
                    if (t.Name == "schProtocolo" && p.Protocolo == null)
                        return (false);

                    //return (p.Name.ToUpper().StartsWith(filter.ToUpper()));
                    if (t.Name == "schOcoorDet" && p.Ocorrencia != null)
                        return (p.Ocorrencia.ToUpper().Contains(filter.ToUpper()));

                    return true;
                };
            }
        }
    }
}
