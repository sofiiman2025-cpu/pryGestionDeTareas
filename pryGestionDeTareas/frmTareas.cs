using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionDeTareas
{
    public partial class frmTareas : Form
    {
        public frmTareas()
        {
            InitializeComponent();
        }

        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Ingrese el título");
            }
            else if (cmbUsuario.Text == "")
            {
                MessageBox.Show("Seleccione un usuario");
            }
            else if (cmbCategoria.Text == "")
            {
                MessageBox.Show("Seleccione una categoría");
            }
            else if (cmbPrioridad.Text == "")
            {
                MessageBox.Show("Seleccione una prioridad");
            }
            else
            {
                MessageBox.Show("Tarea guardada correctamente");

                // limpiar campos
                txtTitulo.Text = "";
                txtDescripcion.Text = "";
                cmbCategoria.Text = "";
                cmbPrioridad.Text = "";
                cmbUsuario.Text = "";
            }

            dgvTareas.Rows.Add(txtTitulo.Text, txtDescripcion.Text, cmbCategoria.Text, cmbPrioridad.Text, cmbUsuario.Text);
        }

        private void btnCompletada_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una tarea");
            }
            else
            {         
                MessageBox.Show("Tarea completada");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
        }
    }
}





