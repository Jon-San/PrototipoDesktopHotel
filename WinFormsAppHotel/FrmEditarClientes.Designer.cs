namespace WinFormsAppHotel
{
    partial class FrmEditarClientes
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
            button1 = new Button();
            btnCancelar = new Button();
            textBox7 = new TextBox();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnGuardar = new Button();
            textBox1 = new TextBox();
            BtnEstancias = new Button();
            label2 = new Label();
            btnSalir = new Button();
            btnUsuarios = new Button();
            btnReportes = new Button();
            btnClientes = new Button();
            btnHuespedes = new Button();
            btnReservas = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(613, 382);
            button1.Name = "button1";
            button1.Size = new Size(168, 25);
            button1.TabIndex = 114;
            button1.Text = "Mostrar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(613, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 25);
            btnCancelar.TabIndex = 113;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(410, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(178, 23);
            textBox7.TabIndex = 112;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(410, 272);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 111;
            label12.Text = "Observaciones";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Peru", "Chile", "Argentina", "Bolivia", "Mexico", "Venezuela", "Colombia", "Ecuador" });
            comboBox4.Location = new Point(410, 234);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(178, 23);
            comboBox4.TabIndex = 110;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(410, 210);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 109;
            label11.Text = "País";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(410, 171);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 23);
            textBox6.TabIndex = 108;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(410, 147);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 107;
            label10.Text = "Teléfono";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(410, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 23);
            textBox5.TabIndex = 106;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 86);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 105;
            label9.Text = "Email";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Soltero", "Casado", "Viudo", "Divorsiado" });
            comboBox3.Location = new Point(613, 221);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(168, 23);
            comboBox3.TabIndex = 104;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(613, 203);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 103;
            label8.Text = "Estado Civil";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Femenino", "Masculino" });
            comboBox2.Location = new Point(613, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(168, 23);
            comboBox2.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(613, 150);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 101;
            label7.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 84);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 100;
            label6.Text = "Dirección";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(613, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 23);
            textBox4.TabIndex = 99;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 270);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 98;
            label5.Text = "Apellidos";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 97;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 208);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 96;
            label4.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 145);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 94;
            label3.Text = "Nº Documento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "DNI", "PASAPORTE", "CARNET DE EXTRANJERIA", "CELULA DE IDENTIDAD" });
            comboBox1.Location = new Point(163, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 86);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 92;
            label1.Text = "Tipo Documento";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(708, 339);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 25);
            btnGuardar.TabIndex = 91;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 90;
            // 
            // BtnEstancias
            // 
            BtnEstancias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstancias.Location = new Point(19, 64);
            BtnEstancias.Name = "BtnEstancias";
            BtnEstancias.Size = new Size(81, 31);
            BtnEstancias.TabIndex = 89;
            BtnEstancias.Text = "Estancias";
            BtnEstancias.UseVisualStyleBackColor = true;
            BtnEstancias.Click += BtnEstancias_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 25);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 88;
            label2.Text = "Editar Clientes";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(19, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.Yes;
            btnSalir.Size = new Size(81, 31);
            btnSalir.TabIndex = 87;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(19, 317);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.Yes;
            btnUsuarios.Size = new Size(81, 31);
            btnUsuarios.TabIndex = 86;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(19, 266);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.Yes;
            btnReportes.Size = new Size(81, 31);
            btnReportes.TabIndex = 85;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(19, 215);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(81, 31);
            btnClientes.TabIndex = 84;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnHuespedes
            // 
            btnHuespedes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuespedes.Location = new Point(19, 163);
            btnHuespedes.Name = "btnHuespedes";
            btnHuespedes.Size = new Size(81, 31);
            btnHuespedes.TabIndex = 83;
            btnHuespedes.Text = "Huespedes";
            btnHuespedes.UseVisualStyleBackColor = true;
            btnHuespedes.Click += btnHuespedes_Click;
            // 
            // btnReservas
            // 
            btnReservas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservas.Location = new Point(19, 110);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(81, 31);
            btnReservas.TabIndex = 82;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // FrmEditarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(textBox7);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(comboBox3);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(textBox1);
            Controls.Add(BtnEstancias);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnUsuarios);
            Controls.Add(btnReportes);
            Controls.Add(btnClientes);
            Controls.Add(btnHuespedes);
            Controls.Add(btnReservas);
            Name = "FrmEditarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarClientes";
            Load += FrmEditarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCancelar;
        private TextBox textBox7;
        private Label label12;
        private ComboBox comboBox4;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
        private ComboBox comboBox3;
        private Label label8;
        private ComboBox comboBox2;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnGuardar;
        private TextBox textBox1;
        private Button BtnEstancias;
        private Label label2;
        private Button btnSalir;
        private Button btnUsuarios;
        private Button btnReportes;
        private Button btnClientes;
        private Button btnHuespedes;
        private Button btnReservas;
    }
}