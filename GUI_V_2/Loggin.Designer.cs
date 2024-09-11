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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_contraseña = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Backpanel = new System.Windows.Forms.Panel();
            this.but_conectar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_puertos = new System.Windows.Forms.ComboBox();
            this.comboBox_bascula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Backpanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(281, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "USUARIO";
            // 
            // text_contraseña
            // 
            this.text_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_contraseña.Location = new System.Drawing.Point(275, 368);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.Size = new System.Drawing.Size(195, 24);
            this.text_contraseña.TabIndex = 12;
            // 
            // text_usuario
            // 
            this.text_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_usuario.Location = new System.Drawing.Point(275, 309);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(195, 24);
            this.text_usuario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DigitalDB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(620, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "CONTROL DE PESO Y TARA";
            // 
            // Backpanel
            // 
            this.Backpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(87)))), ((int)(((byte)(95)))));
            this.Backpanel.Controls.Add(this.but_conectar);
            this.Backpanel.Controls.Add(this.groupBox3);
            this.Backpanel.Controls.Add(this.text_contraseña);
            this.Backpanel.Controls.Add(this.label3);
            this.Backpanel.Controls.Add(this.label1);
            this.Backpanel.Controls.Add(this.label2);
            this.Backpanel.Controls.Add(this.text_usuario);
            this.Backpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Backpanel.Location = new System.Drawing.Point(0, 0);
            this.Backpanel.Name = "Backpanel";
            this.Backpanel.Size = new System.Drawing.Size(1050, 605);
            this.Backpanel.TabIndex = 15;
            this.Backpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Backpanel_Paint);
            // 
            // but_conectar
            // 
            this.but_conectar.BackColor = System.Drawing.Color.DarkOrange;
            this.but_conectar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_conectar.ForeColor = System.Drawing.Color.Black;
            this.but_conectar.Location = new System.Drawing.Point(485, 479);
            this.but_conectar.Name = "but_conectar";
            this.but_conectar.Size = new System.Drawing.Size(113, 36);
            this.but_conectar.TabIndex = 20;
            this.but_conectar.Text = "Conectar";
            this.but_conectar.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox_puertos);
            this.groupBox3.Controls.Add(this.comboBox_bascula);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(626, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 157);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            // 
            // comboBox_puertos
            // 
            this.comboBox_puertos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_puertos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_puertos.ForeColor = System.Drawing.Color.Black;
            this.comboBox_puertos.FormattingEnabled = true;
            this.comboBox_puertos.Location = new System.Drawing.Point(9, 105);
            this.comboBox_puertos.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_puertos.Name = "comboBox_puertos";
            this.comboBox_puertos.Size = new System.Drawing.Size(146, 26);
            this.comboBox_puertos.TabIndex = 1;
            this.comboBox_puertos.Text = "Seleccione";
            // 
            // comboBox_bascula
            // 
            this.comboBox_bascula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_bascula.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_bascula.DisplayMember = "IdBasculas";
            this.comboBox_bascula.DropDownHeight = 90;
            this.comboBox_bascula.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_bascula.ForeColor = System.Drawing.Color.Black;
            this.comboBox_bascula.FormattingEnabled = true;
            this.comboBox_bascula.IntegralHeight = false;
            this.comboBox_bascula.Location = new System.Drawing.Point(6, 48);
            this.comboBox_bascula.Name = "comboBox_bascula";
            this.comboBox_bascula.Size = new System.Drawing.Size(255, 26);
            this.comboBox_bascula.TabIndex = 18;
            this.comboBox_bascula.Text = "Seleccione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "BASCULA";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_contraseña;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Backpanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_conectar;
        private System.Windows.Forms.ComboBox comboBox_puertos;
        private System.Windows.Forms.ComboBox comboBox_bascula;
        private System.Windows.Forms.Label label4;
    }
}
