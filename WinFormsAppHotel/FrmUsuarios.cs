using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppHotel
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Recargar la página actual
            this.Refresh();
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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmHuespedes frmHuespedes = new FrmHuespedes();

            // Mostrar el formulario principal
            frmHuespedes.Show();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Recargar la página actual
            /*this.Refresh();*/
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            /*comboBox2.Items = "o";
            comboBox4.Items = "";
            comboBox3.Items = ;*/
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmMostrarUsuarios frmMostrarUsuarios = new FrmMostrarUsuarios();

            // Mostrar el formulario principal
            frmMostrarUsuarios.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario principal
            FrmMostrarUsuarios frmMostrarUsuarios = new FrmMostrarUsuarios();

            // Mostrar el formulario principal
            frmMostrarUsuarios.Show();

            // Opcionalmente, puedes ocultar el formulario de inicio de sesión si lo deseas
            this.Hide();
        }
    }
}
