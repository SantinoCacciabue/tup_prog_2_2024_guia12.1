using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        Despachador despachador = new Despachador();
        Paquete p;
        Repartidor camion;
        public Form1()
        {
            InitializeComponent();
            bEntregar.Enabled = false;
            bIniciar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void bRecibir_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = Convert.ToInt32(tBdni.Text);
                string dir = tBdir.Text;
                string nom = tBnombre.Text;
                p = despachador.RecibirCorrespondencia(dni, nom, dir);
                lBpaquetesAlmacen.Items.Add(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            tBdir.Clear();
            tBdni.Clear();
            tBnombre.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camion formCamion = new Camion();
            if (formCamion.ShowDialog() == DialogResult.OK)
            {
                int cap = Convert.ToInt32(formCamion.nCapacidad.Text);
                camion = despachador.PrepararCamion(cap);
            }
            for (int i = 0; i < camion.Capacidad; i++)
            {
                p = despachador.CargarPaquete();
                if (p != null)
                {
                    lBlistadoEntrega.Items.Add(p);
                    lBpaquetesAlmacen.Items.Remove(p);
                }
                else
                {
                    MessageBox.Show("No hay más paquetes para despachar");
                }               
            }
            bIniciar.Enabled = true;
        }

        private void bEntregar_Click(object sender, EventArgs e)
        {
            try
            {
                p = camion.Entrega();
                if (p != null)
                {
                    tBdirEntrega.Text = p.Direccion;
                    tBdniEntrega.Text = p.DNIRemitente.ToString();
                    tBnombreEntrega.Text = p.NombreRemitente;
                    lBlistadoEntrega.Items.Remove(p);
                }
                else
                {
                    tBdirEntrega.Clear();
                    tBdniEntrega.Clear();
                    tBnombreEntrega.Clear();
                    bIniciar.Enabled = false;
                    bEntregar.Enabled = false;
                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                bEntregar.Enabled = true;
                p = camion.Entrega();
                tBdirEntrega.Text = p.Direccion;
                tBdniEntrega.Text = p.DNIRemitente.ToString();
                tBnombreEntrega.Text = p.NombreRemitente;
                lBlistadoEntrega.Items.Remove(p);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
