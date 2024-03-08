using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10_11_DatagridView
{
    public partial class Form1 : Form
    {
        string nombre;
        string correo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            nombre = txt_nombre.Text;
            correo = txt_email.Text;

            if (txt_nombre.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgv_nombre_correo.Rows.Add(nombre, correo);

                txt_nombre.Clear();
                txt_email.Clear();
            }

            txt_nombre.Focus();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (dgv_nombre_correo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No hay datos para eliminar", "Tabla vacía", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_email.Clear();

            dgv_nombre_correo.Rows.Clear();
            txt_nombre.Focus();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_email.Clear();

            dgv_nombre_correo.Rows.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    }

