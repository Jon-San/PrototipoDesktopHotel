using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppHotel
{
    public partial class FrmReservas : Form
    {
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {

        }

        private void BtnEstancias_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmMain frmMain = new FrmMain();

            // Mostrar el formulario principal
            frmMain.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmLogin frmLogin = new FrmLogin();

            // Mostrar el formulario principal
            frmLogin.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmHuespedes frmHuespedes = new FrmHuespedes();

            // Mostrar el formulario principal
            frmHuespedes.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmHuespedes frmHuespedes = new FrmHuespedes();

            // Mostrar el formulario principal
            frmHuespedes.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmReportes frmReportes = new FrmReportes();

            // Mostrar el formulario principal
            frmReportes.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmUsuarios frmUsuarios = new FrmUsuarios();

            // Mostrar el formulario principal
            frmUsuarios.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmEditarReserva frmEditarReserva = new FrmEditarReserva();

            // Mostrar el formulario principal
            frmEditarReserva.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmNuevaReserva frmNuevaReserva = new FrmNuevaReserva();

            // Mostrar el formulario principal
            frmNuevaReserva.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarReserva_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmMain frmMain = new FrmMain();

            // Mostrar el formulario principal
            frmMain.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnReserv_Click(object sender, EventArgs e)
        {
            // Recargar la página actual
            this.Refresh();
        }
    }
}
