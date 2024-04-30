namespace WinFormsAppHotel
{
    partial class FrmUsuarios
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
            btnCancelar = new Button();
            label12 = new Label();
            comboBox4 = new ComboBox();
            label11 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
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
            label13 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            textBox9 = new TextBox();
            comboBox3 = new ComboBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            btnMostrarUsuarios = new Button();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(603, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 25);
            btnCancelar.TabIndex = 112;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(410, 272);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 110;
            label12.Text = "Nivel";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Peru", "Chile", "Argentina", "Bolivia", "Mexico", "Venezuela", "Colombia", "Ecuador" });
            comboBox4.Location = new Point(410, 234);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(178, 23);
            comboBox4.TabIndex = 109;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(410, 210);
            label11.Name = "label11";
            label11.Size = new Size(28, 15);
            label11.TabIndex = 108;
            label11.Text = "País";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(410, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 23);
            textBox5.TabIndex = 105;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 86);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 104;
            label9.Text = "Email";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Femenino", "Masculino" });
            comboBox2.Location = new Point(410, 172);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(178, 23);
            comboBox2.TabIndex = 101;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 146);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 100;
            label7.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(603, 84);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 99;
            label6.Text = "Nombre de usuario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(603, 110);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 23);
            textBox4.TabIndex = 98;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 270);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 97;
            label5.Text = "Telefono";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 23);
            textBox3.TabIndex = 96;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 208);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 95;
            label4.Text = "Dirección";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 23);
            textBox2.TabIndex = 94;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 145);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 93;
            label3.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 86);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 91;
            label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(698, 348);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 25);
            btnGuardar.TabIndex = 90;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 89;
            // 
            // BtnEstancias
            // 
            BtnEstancias.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstancias.Location = new Point(19, 64);
            BtnEstancias.Name = "BtnEstancias";
            BtnEstancias.Size = new Size(81, 31);
            BtnEstancias.TabIndex = 88;
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
            label2.Size = new Size(79, 21);
            label2.TabIndex = 87;
            label2.Text = "Usuarios";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(19, 394);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.Yes;
            btnSalir.Size = new Size(81, 31);
            btnSalir.TabIndex = 86;
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
            btnUsuarios.TabIndex = 85;
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
            btnReportes.TabIndex = 84;
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
            btnClientes.TabIndex = 83;
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
            btnHuespedes.TabIndex = 82;
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
            btnReservas.TabIndex = 81;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(603, 146);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 114;
            label13.Text = "Contraseña";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(603, 172);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(168, 23);
            textBox8.TabIndex = 113;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 208);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 116;
            label8.Text = "Confirmar contraseña";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(603, 234);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(168, 23);
            textBox9.TabIndex = 115;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Administrador", "Recepcionista" });
            comboBox3.Location = new Point(410, 296);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(178, 23);
            comboBox3.TabIndex = 117;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(401, 353);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 19);
            checkBox1.TabIndex = 118;
            checkBox1.Text = "Permitir eliminar pagos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(401, 394);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(164, 19);
            checkBox2.TabIndex = 119;
            checkBox2.Text = "Ver todas las liquidaciones";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(163, 353);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(199, 19);
            checkBox3.TabIndex = 120;
            checkBox3.Text = "Permitir generar notas de crédito";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(163, 394);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(230, 19);
            checkBox4.TabIndex = 121;
            checkBox4.Text = "Permitir eliminar items de roomservice";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnMostrarUsuarios
            // 
            btnMostrarUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarUsuarios.Location = new Point(603, 394);
            btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            btnMostrarUsuarios.Size = new Size(168, 25);
            btnMostrarUsuarios.TabIndex = 122;
            btnMostrarUsuarios.Text = "Mostrar Usuarios";
            btnMostrarUsuarios.UseVisualStyleBackColor = true;
            btnMostrarUsuarios.Click += btnMostrarUsuarios_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(163, 110);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(219, 23);
            textBox6.TabIndex = 123;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(btnMostrarUsuarios);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox3);
            Controls.Add(label8);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(textBox8);
            Controls.Add(btnCancelar);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
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
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label label12;
        private ComboBox comboBox4;
        private Label label11;
        private TextBox textBox5;
        private Label label9;
        private ComboBox comboBox2;
        private Label label7;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
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
        private Label label13;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private ComboBox comboBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button btnMostrarUsuarios;
        private TextBox textBox6;
    }
}