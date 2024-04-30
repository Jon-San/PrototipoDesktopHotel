using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppHotel
{
    public partial class FrmNuevaReserva : Form
    {
        public FrmNuevaReserva()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmNuevaReserva_Load(object sender, EventArgs e)
        {
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnReservas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmReservas frmReservas = new FrmReservas();

            // Mostrar el formulario principal
            frmReservas.Show();

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmLogin frmLogin = new FrmLogin();

            // Mostrar el formulario principal
            frmLogin.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmReservas frmReservas = new FrmReservas();

            // Mostrar el formulario principal
            frmReservas.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmReservas frmReservas = new FrmReservas();

            // Mostrar el formulario principal
            frmReservas.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Recargar la página actual
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
