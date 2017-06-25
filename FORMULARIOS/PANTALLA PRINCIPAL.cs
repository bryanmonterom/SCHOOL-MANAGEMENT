using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
            timer1.Enabled=true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblFechayHora_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LABEL DE LA FECHA Y LA HORA
            lblFecha.Text = DateTime.Now.ToLongDateString();
             lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {//VALIDACION DE QUE SI DE VERDAD SE DESEA SALIR POR SI EL USUARIO LE DIO SIN QUERER, LE LLEGA KLK
            if (MessageBox.Show("¿Estás seguro que deseas Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {//VALIDACION DE QUE SI DE VERDAD SE DESEA SALIR POR SI EL USUARIO LE DIO SIN QUERER, LE LLEGA KLK
            if (MessageBox.Show("¿Estás seguro que deseas Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            e.Cancel = true;
        }
    }
    }
