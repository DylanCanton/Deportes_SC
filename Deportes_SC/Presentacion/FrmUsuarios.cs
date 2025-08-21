using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Deportes_SC.Datos;
using Deportes_SC.Objetos;

namespace Deportes_SC.Presentacion
{
    public partial class FrmUsuarios : Form
    {
        BDUsuarios usuarios = new BDUsuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuariosEnGrid();
        }

        private void volver_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        //-------------------------------------------------------//

        private void limpiar()
        {
            txt_id.Text = "";
            txt_usr.Text = "";
            txt_psw.Text = "";
            cmb_tipo.Text = "";
            cmb_estado.Text = "";
        }

        private void CargarUsuariosEnGrid()
        {
            dgv_Usuarios.DataSource = usuarios.ListarUsuariosSQL();

            // Oculta campos sensibles/auxiliares
            if (dgv_Usuarios.Columns.Contains("Contrasenna"))
                dgv_Usuarios.Columns["Contrasenna"].Visible = false;

            if (dgv_Usuarios.Columns.Contains("Estado"))
                dgv_Usuarios.Columns["Estado"].Visible = false;

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            // Validacion de campos vacios
            if (txt_id.Text == "" || txt_usr.Text == "" || txt_psw.Text == "" ||
                cmb_estado.SelectedIndex == -1 || cmb_tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usr = new Usuario();
            usr.Id = int.Parse(txt_id.Text);
            usr.Nusuario = txt_usr.Text;
            usr.Contrasenna = txt_psw.Text;
            usr.Estado = cmb_estado.SelectedIndex;
            usr.Rol = cmb_tipo.Text;

            usuarios.guardarUsuarioSQL(usr);
            MessageBox.Show("Registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            CargarUsuariosEnGrid();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.Id = int.Parse(txt_id.Text);
            usr.Nusuario = txt_usr.Text;
            usr.Contrasenna = txt_psw.Text;
            usr.Estado = cmb_estado.SelectedIndex;
            usr.Rol = cmb_tipo.Text;

            usuarios.modificarUsuarioSQL(usr);
            MessageBox.Show("Modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            CargarUsuariosEnGrid();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);

            usuarios.eliminarUsuarioSQL(id);
            MessageBox.Show("Eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            limpiar();
            CargarUsuariosEnGrid();
        }

        private void dgv_Usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgv_Usuarios.Rows[e.RowIndex];

            txt_id.Text = fila.Cells["Id"].Value?.ToString();
            txt_usr.Text = fila.Cells["Usuario"].Value?.ToString();
            txt_psw.Text = fila.Cells["Contrasenna"].Value?.ToString();
            cmb_tipo.Text = fila.Cells["Rol"].Value?.ToString();
            cmb_estado.SelectedIndex = Convert.ToInt32(fila.Cells["Estado"].Value ?? 0);
            
        }
    }
}
