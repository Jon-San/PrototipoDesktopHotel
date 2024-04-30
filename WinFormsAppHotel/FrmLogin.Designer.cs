namespace WinFormsAppHotel
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            btnSalir = new Button();
            txtBoxUsuario = new TextBox();
            label1 = new Label();
            txtBoxClave = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(89, 268);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(107, 38);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(204, 268);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button2_Click;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(204, 107);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(119, 23);
            txtBoxUsuario.TabIndex = 2;
            txtBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 109);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // txtBoxClave
            // 
            txtBoxClave.Location = new Point(204, 173);
            txtBoxClave.Name = "txtBoxClave";
            txtBoxClave.PasswordChar = '*';
            txtBoxClave.Size = new Size(119, 23);
            txtBoxClave.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 175);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 6;
            label2.Text = "Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 34);
            label3.Name = "label3";
            label3.Size = new Size(389, 28);
            label3.TabIndex = 7;
            label3.Text = "Sistema de Administración de Hotelería ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(435, 356);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBoxClave);
            Controls.Add(label1);
            Controls.Add(txtBoxUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Administración de Hotelería";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnSalir;
        private TextBox txtBoxUsuario;
        private Label label1;
        private TextBox txtBoxClave;
        private Label label2;
        private Label label3;
    }
}
