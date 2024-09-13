namespace PESOYTARA
{
    partial class Loggin
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_contraseña = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.Backpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_conectar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Backpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "USUARIO";
            // 
            // text_contraseña
            // 
            this.text_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contraseña.Location = new System.Drawing.Point(120, 154);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.PasswordChar = '☼';
            this.text_contraseña.Size = new System.Drawing.Size(195, 24);
            this.text_contraseña.TabIndex = 12;
            // 
            // text_usuario
            // 
            this.text_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_usuario.Location = new System.Drawing.Point(120, 80);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(195, 24);
            this.text_usuario.TabIndex = 11;
            // 
            // Backpanel
            // 
            this.Backpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.Backpanel.Controls.Add(this.panel1);
            this.Backpanel.Controls.Add(this.label8);
            this.Backpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backpanel.Location = new System.Drawing.Point(0, 0);
            this.Backpanel.Name = "Backpanel";
            this.Backpanel.Size = new System.Drawing.Size(1050, 605);
            this.Backpanel.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.text_contraseña);
            this.panel1.Controls.Add(this.but_conectar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.text_usuario);
            this.panel1.Location = new System.Drawing.Point(340, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 290);
            this.panel1.TabIndex = 72;
            // 
            // but_conectar
            // 
            this.but_conectar.BackColor = System.Drawing.Color.DarkOrange;
            this.but_conectar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_conectar.ForeColor = System.Drawing.Color.Black;
            this.but_conectar.Location = new System.Drawing.Point(161, 219);
            this.but_conectar.Name = "but_conectar";
            this.but_conectar.Size = new System.Drawing.Size(113, 36);
            this.but_conectar.TabIndex = 20;
            this.but_conectar.Text = "Conectar";
            this.but_conectar.UseVisualStyleBackColor = false;
            this.but_conectar.Click += new System.EventHandler(this.but_conectar_Click_1);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DigitalDB", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(450, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 26);
            this.label8.TabIndex = 71;
            this.label8.Text = "Inicio de Sesión";
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Backpanel);
            this.Name = "Loggin";
            this.Size = new System.Drawing.Size(1050, 605);
            this.Backpanel.ResumeLayout(false);
            this.Backpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_contraseña;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Panel Backpanel;
        private System.Windows.Forms.Button but_conectar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
