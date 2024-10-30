using Ej2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        CentroAtencion centro = new CentroAtencion();
        Reclamo r;
        OrdenReparacion o;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tBnombre.Text;
                string mot = tBmotivo.Text;
                r = centro.RecibirReclamo(nom, mot);
                lBreclamos.Items.Add(r);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                o = centro.ResolverReclamo();
                lBreclamos.Items.Remove(o.reclamo);
                lBtrabajosAejecutar.Items.Add(o);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                o = centro.EjecutarOrdenDeTrabajo();
                if (o == null)
                {
                    MessageBox.Show("No hay ordenes para ejecutar ");
                }
                else
                {
                    lBtrabajosAejecutar.Items.Remove(o);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
