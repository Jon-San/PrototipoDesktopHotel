namespace WinFormsAppHotel
{
    partial class FrmHuespedes
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
            btnExcel = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            BtnEstancias = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            N = new DataGridViewTextBoxColumn();
            Habitación = new DataGridViewTextBoxColumn();
            Huesped = new DataGridViewTextBoxColumn();
            Nacionalidad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnUsuarios = new Button();
            btnReportes = new Button();
            btnClientes = new Button();
            btnHuespedes = new Button();
            btnReservas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(192, 255, 192);
            btnExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcel.Location = new Point(713, 64);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(62, 31);
            btnExcel.TabIndex = 41;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(629, 67);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 25);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 23);
            textBox1.TabIndex = 39;
            // 
            // BtnEstancias
            // 
            BtnEstancias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstancias.Location = new Point(22, 48);
            BtnEstancias.Name = "BtnEstancias";
            BtnEstancias.Size = new Size(81, 31);
            BtnEstancias.TabIndex = 37;
            BtnEstancias.Text = "Estancias";
            BtnEstancias.UseVisualStyleBackColor = true;
            BtnEstancias.Click += BtnEstancias_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(375, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 36;
            label2.Text = "Huespedes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { N, Habitación, Huesped, Nacionalidad, Telefono, Email });
            dataGridView1.Location = new Point(127, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(659, 302);
            dataGridView1.TabIndex = 35;
            // 
            // N
            // 
            N.HeaderText = "N";
            N.Name = "N";
            // 
            // Habitación
            // 
            Habitación.HeaderText = "Habitación";
            Habitación.Name = "Habitación";
            // 
            // Huesped
            // 
            Huesped.HeaderText = "Huesped";
            Huesped.Name = "Huesped";
            // 
            // Nacionalidad
            // 
            Nacionalidad.HeaderText = "Nacionalidad";
            Nacionalidad.Name = "Nacionalidad";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(22, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.Yes;
            btnSalir.Size = new Size(81, 31);
            btnSalir.TabIndex = 34;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(22, 301);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.Yes;
            btnUsuarios.Size = new Size(81, 31);
            btnUsuarios.TabIndex = 33;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(22, 250);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.Yes;
            btnReportes.Size = new Size(81, 31);
            btnReportes.TabIndex = 32;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(22, 199);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(81, 31);
            btnClientes.TabIndex = 31;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnHuespedes
            // 
            btnHuespedes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuespedes.Location = new Point(22, 147);
            btnHuespedes.Name = "btnHuespedes";
            btnHuespedes.Size = new Size(81, 31);
            btnHuespedes.TabIndex = 30;
            btnHuespedes.Text = "Huespedes";
            btnHuespedes.UseVisualStyleBackColor = true;
            btnHuespedes.Click += btnHuespedes_Click;
            // 
            // btnReservas
            // 
            btnReservas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservas.Location = new Point(22, 94);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(81, 31);
            btnReservas.TabIndex = 29;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // FrmHuespedes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 442);
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
            Name = "FrmHuespedes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHuespedes";
            Load += FrmHuespedes_Load;
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
        private Button btnSalir;
        private Button btnUsuarios;
        private Button btnReportes;
        private Button btnClientes;
        private Button btnHuespedes;
        private Button btnReservas;
        private DataGridViewTextBoxColumn N;
        private DataGridViewTextBoxColumn Habitación;
        private DataGridViewTextBoxColumn Huesped;
        private DataGridViewTextBoxColumn Nacionalidad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Email;
    }
}