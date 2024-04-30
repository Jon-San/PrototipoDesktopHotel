namespace WinFormsAppHotel
{
    partial class FrmMostrarClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEditar = new Button();
            btnExcel = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            BtnEstancias = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Documento = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            EstadoCivil = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnUsuarios = new Button();
            btnReportes = new Button();
            btnClientes = new Button();
            btnHuespedes = new Button();
            btnReservas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(128, 82);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 31);
            btnEditar.TabIndex = 59;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(192, 255, 192);
            btnExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcel.Location = new Point(196, 82);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(62, 31);
            btnExcel.TabIndex = 58;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(713, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 25);
            btnBuscar.TabIndex = 57;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 23);
            textBox1.TabIndex = 56;
            // 
            // BtnEstancias
            // 
            BtnEstancias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstancias.Location = new Point(14, 80);
            BtnEstancias.Name = "BtnEstancias";
            BtnEstancias.Size = new Size(81, 31);
            BtnEstancias.TabIndex = 55;
            BtnEstancias.Text = "Estancias";
            BtnEstancias.UseVisualStyleBackColor = true;
            BtnEstancias.Click += BtnEstancias_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 41);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 54;
            label2.Text = "Tabla Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Documento, TipoDocumento, Nombre, Apellidos, Email, Telefono, Pais, Dirección, Sexo, EstadoCivil });
            dataGridView1.Location = new Point(128, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(659, 316);
            dataGridView1.TabIndex = 53;
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.Name = "TipoDocumento";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.Name = "Dirección";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // EstadoCivil
            // 
            EstadoCivil.HeaderText = "EstadoCivil";
            EstadoCivil.Name = "EstadoCivil";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(14, 410);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.Yes;
            btnSalir.Size = new Size(81, 31);
            btnSalir.TabIndex = 52;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(14, 333);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.Yes;
            btnUsuarios.Size = new Size(81, 31);
            btnUsuarios.TabIndex = 51;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(14, 282);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.Yes;
            btnReportes.Size = new Size(81, 31);
            btnReportes.TabIndex = 50;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(14, 231);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(81, 31);
            btnClientes.TabIndex = 49;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnHuespedes
            // 
            btnHuespedes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuespedes.Location = new Point(14, 179);
            btnHuespedes.Name = "btnHuespedes";
            btnHuespedes.Size = new Size(81, 31);
            btnHuespedes.TabIndex = 48;
            btnHuespedes.Text = "Huespedes";
            btnHuespedes.UseVisualStyleBackColor = true;
            btnHuespedes.Click += btnHuespedes_Click;
            // 
            // btnReservas
            // 
            btnReservas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservas.Location = new Point(14, 126);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(81, 31);
            btnReservas.TabIndex = 47;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // FrmMostrarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(btnEditar);
            Controls.Add(btnExcel);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(BtnEstancias);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnUsuarios);
            Controls.Add(btnReportes);
            Controls.Add(btnClientes);
            Controls.Add(btnHuespedes);
            Controls.Add(btnReservas);
            Name = "FrmMostrarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMostrarClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Button btnExcel;
        private Button btnBuscar;
        private TextBox textBox1;
        private Button BtnEstancias;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn EstadoCivil;
        private Button btnSalir;
        private Button btnUsuarios;
        private Button btnReportes;
        private Button btnClientes;
        private Button btnHuespedes;
        private Button btnReservas;
    }
}