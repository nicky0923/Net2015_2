﻿using System;
using System.Collections;
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
using ConsumirServicioWeb.CadenaService;
using ConsumirServicioWeb.EjemploAsmx;
using ConsumirServicioWeb.EjemploWcf;
using PersonaDto = ConsumirServicioWeb.EjemploWcf.PersonaDto;

namespace ConsumirServicioWeb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnConsumir_Click(object sender, RoutedEventArgs e)
        {
            using (EjemploAsmx.EjemploAsmxSoapClient client = new EjemploAsmxSoapClient())
            {

                List<EjemploAsmx.PersonaDto> lista = client.SelectAllPersonas();

                DataGridPersonas.ItemsSource = lista;
                DataGridPersonas.AutoGenerateColumns = false;
            }
        }

        private void BtnConsumirWcf_Click(object sender, RoutedEventArgs e)
        {

            using (EjemploWcfClient client = new EjemploWcfClient())
            {
                int valor = client.CalcularDato(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));

                MessageBox.Show("El valor es " + valor);
            }
        }

        private void BtnConsumirWcfPersonas_Click(object sender, RoutedEventArgs e)
        {
            using (EjemploWcfClient client = new EjemploWcfClient())
            {
                IList<EjemploWcf.PersonaDto> lista = client.SelectAllPersonas();
                DataGridWcf.ItemsSource = lista;
                DataGridWcf.AutoGenerateColumns = false;
            }
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            using (CadenaService.AgenciasViajesApiClient client  = new AgenciasViajesApiClient())
            {
                var listaClientes = client.SelectAllClientes();

                DataGridClientes.ItemsSource = listaClientes;
                DataGridClientes.AutoGenerateColumns = true;
            }
        }
    }
}
