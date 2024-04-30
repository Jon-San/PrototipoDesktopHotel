namespace WinFormsAppHotel
{
    partial class FrmReservas
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            CodigoReserva = new DataGridViewTextBoxColumn();
            FechaReserva = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            F_Llegada = new DataGridViewTextBoxColumn();
            F_Salida = new DataGridViewTextBoxColumn();
            TipoHabitación = new DataGridViewTextBoxColumn();
            N_Habitación = new DataGridViewTextBoxColumn();
            Noches = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            btnUsuarios = new Button();
            btnReportes = new Button();
            btnClientes = new Button();
            btnHuespedes = new Button();
            BtnEstancias = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            btnEditar = new Button();
            button1 = new Button();
            btnNuevaReserva = new Button();
            btnExcel = new Button();
            btnAceptarReserva = new Button();
            btnReserv = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 25);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 17;
            label2.Text = "Reservas";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CodigoReserva, FechaReserva, Estado, Cliente, F_Llegada, F_Salida, TipoHabitación, N_Habitación, Noches, Total });
            dataGridView1.Location = new Point(129, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(659, 316);
            dataGridView1.TabIndex = 16;
            // 
            // CodigoReserva
            // 
            CodigoReserva.HeaderText = "CodigoReserva";
            CodigoReserva.Name = "CodigoReserva";
            // 
            // FechaReserva
            // 
            FechaReserva.HeaderText = "FechaReserva";
            FechaReserva.Name = "FechaReserva";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // F_Llegada
            // 
            F_Llegada.HeaderText = "F_Llegada";
            F_Llegada.Name = "F_Llegada";
            // 
            // F_Salida
            // 
            F_Salida.HeaderText = "F_Salida";
            F_Salida.Name = "F_Salida";
            // 
            // TipoHabitación
            // 
            TipoHabitación.HeaderText = "TipoHabitación";
            TipoHabitación.Name = "TipoHabitación";
            // 
            // N_Habitación
            // 
            N_Habitación.HeaderText = "N_Habitación";
            N_Habitación.Name = "N_Habitación";
            // 
            // Noches
            // 
            Noches.HeaderText = "Noches";
            Noches.Name = "Noches";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(17, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.Yes;
            btnSalir.Size = new Size(81, 31);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(17, 317);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.Yes;
            btnUsuarios.Size = new Size(81, 31);
            btnUsuarios.TabIndex = 14;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(17, 266);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.Yes;
            btnReportes.Size = new Size(81, 31);
            btnReportes.TabIndex = 13;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(17, 215);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(81, 31);
            btnClientes.TabIndex = 12;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnHuespedes
            // 
            btnHuespedes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuespedes.Location = new Point(17, 163);
            btnHuespedes.Name = "btnHuespedes";
            btnHuespedes.Size = new Size(81, 31);
            btnHuespedes.TabIndex = 11;
            btnHuespedes.Text = "Huespedes";
            btnHuespedes.UseVisualStyleBackColor = true;
            btnHuespedes.Click += btnHuespedes_Click;
            // 
            // BtnEstancias
            // 
            BtnEstancias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstancias.Location = new Point(17, 64);
            BtnEstancias.Name = "BtnEstancias";
            BtnEstancias.Size = new Size(81, 31);
            BtnEstancias.TabIndex = 18;
            BtnEstancias.Text = "Estancias";
            BtnEstancias.UseVisualStyleBackColor = true;
            BtnEstancias.Click += BtnEstancias_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 73);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 19;
            label1.Text = "Codigo Reserva";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 23);
            textBox1.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(459, 90);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 25);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(545, 95);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 67);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 24;
            label3.Text = "Fecha Inicial";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(545, 155);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(227, 23);
            dateTimePicker2.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 126);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 26;
            label4.Text = "Fecha Inicial";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 255, 192);
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(275, 163);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(62, 31);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(129, 163);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 28;
            button1.Text = "Eliminar Reserva";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnNuevaReserva
            // 
            btnNuevaReserva.BackColor = Color.FromArgb(255, 255, 192);
            btnNuevaReserva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaReserva.Location = new Point(129, 126);
            btnNuevaReserva.Name = "btnNuevaReserva";
            btnNuevaReserva.Size = new Size(128, 31);
            btnNuevaReserva.TabIndex = 29;
            btnNuevaReserva.Text = "Nueva Reserva";
            btnNuevaReserva.UseVisualStyleBackColor = false;
            btnNuevaReserva.Click += btnNuevaReserva_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(192, 255, 192);
            btnExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcel.Location = new Point(275, 126);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(62, 31);
            btnExcel.TabIndex = 22;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnAceptarReserva
            // 
            btnAceptarReserva.BackColor = Color.FromArgb(192, 255, 192);
            btnAceptarReserva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptarReserva.Location = new Point(352, 163);
            btnAceptarReserva.Name = "btnAceptarReserva";
            btnAceptarReserva.Size = new Size(137, 31);
            btnAceptarReserva.TabIndex = 30;
            btnAceptarReserva.Text = "Aceptar Reserva";
            btnAceptarReserva.UseVisualStyleBackColor = false;
            btnAceptarReserva.Click += btnAceptarReserva_Click;
            // 
            // btnReserv
            // 
            btnReserv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReserv.Location = new Point(17, 110);
            btnReserv.Name = "btnReserv";
            btnReserv.Size = new Size(81, 31);
            btnReserv.TabIndex = 31;
            btnReserv.Text = "Reservas";
            btnReserv.UseVisualStyleBackColor = true;
            btnReserv.Click += btnReserv_Click;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(btnReserv);
            Controls.Add(btnAceptarReserva);
            Controls.Add(btnNuevaReserva);
            Controls.Add(button1);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnExcel);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnEstancias);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalir);
            Controls.Add(btnUsuarios);
            Controls.Add(btnReportes);
            Controls.Add(btnClientes);
            Controls.Add(btnHuespedes);
            Name = "FrmReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReservas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Button btnSalir;
        private Button btnUsuarios;
        private Button btnReportes;
        private Button btnClientes;
        private Button btnHuespedes;
        private Button BtnEstancias;
        private DataGridViewTextBoxColumn CodigoReserva;
        private DataGridViewTextBoxColumn FechaReserva;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn F_Llegada;
        private DataGridViewTextBoxColumn F_Salida;
        private DataGridViewTextBoxColumn TipoHabitación;
        private DataGridViewTextBoxColumn N_Habitación;
        private DataGridViewTextBoxColumn Noches;
        private DataGridViewTextBoxColumn Total;
        private Label label1;
        private TextBox textBox1;
        private Button btnBuscar;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Button btnEditar;
        private Button button1;
        private Button btnNuevaReserva;
        private Button btnExcel;
        private Button btnAceptarReserva;
        private Button btnReserv;
    }
}