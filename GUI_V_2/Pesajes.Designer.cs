namespace PESOYTARA
{
    partial class Pesajes
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
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.text_tara = new System.Windows.Forms.TextBox();
            this.text_item = new System.Windows.Forms.TextBox();
            this.comboBox_proceso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_placa = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.text_observaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.display_peso = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.but_desconectar = new System.Windows.Forms.Button();
            this.but_conectar = new System.Windows.Forms.Button();
            this.comboBox_bascula = new System.Windows.Forms.ComboBox();
            this.comboBox_puertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.but_capturar = new System.Windows.Forms.Button();
            this.text_peso = new System.Windows.Forms.TextBox();
            this.comboBox_ejes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label_sobre = new System.Windows.Forms.Label();
            this.label_ejes = new System.Windows.Forms.Label();
            this.label_neto = new System.Windows.Forms.Label();
            this.label_tara = new System.Windows.Forms.Label();
            this.label_pesofin = new System.Windows.Forms.Label();
            this.label_pesoini = new System.Windows.Forms.Label();
            this.label_placa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.but_guardar = new System.Windows.Forms.Button();
            this.dgv_eventos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.but_imprimir = new System.Windows.Forms.Button();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eventos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(378, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 73;
            this.label11.Text = "Tara";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(214, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 15);
            this.label18.TabIndex = 74;
            this.label18.Text = "# Contenedor / Ítem";
            // 
            // text_tara
            // 
            this.text_tara.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_tara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_tara.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_tara.Location = new System.Drawing.Point(379, 144);
            this.text_tara.Name = "text_tara";
            this.text_tara.Size = new System.Drawing.Size(98, 27);
            this.text_tara.TabIndex = 64;
            this.text_tara.Text = "0";
            this.text_tara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_tara.TextChanged += new System.EventHandler(this.text_tara_TextChanged);
            this.text_tara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_tara_KeyPress);
            // 
            // text_item
            // 
            this.text_item.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_item.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_item.Location = new System.Drawing.Point(217, 144);
            this.text_item.Name = "text_item";
            this.text_item.Size = new System.Drawing.Size(135, 27);
            this.text_item.TabIndex = 63;
            this.text_item.Text = "0";
            this.text_item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_item.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_item_KeyPress);
            // 
            // comboBox_proceso
            // 
            this.comboBox_proceso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_proceso.DisplayMember = "IdProcedimiento";
            this.comboBox_proceso.DropDownWidth = 100;
            this.comboBox_proceso.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_proceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_proceso.FormattingEnabled = true;
            this.comboBox_proceso.IntegralHeight = false;
            this.comboBox_proceso.Items.AddRange(new object[] {
            "Pesaje Inicial",
            "Pesaje Final",
            "Repesaje"});
            this.comboBox_proceso.Location = new System.Drawing.Point(20, 89);
            this.comboBox_proceso.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_proceso.MaxDropDownItems = 6;
            this.comboBox_proceso.Name = "comboBox_proceso";
            this.comboBox_proceso.Size = new System.Drawing.Size(263, 27);
            this.comboBox_proceso.TabIndex = 61;
            this.comboBox_proceso.SelectedIndexChanged += new System.EventHandler(this.comboBox_proceso_SelectedIndexChanged);
            this.comboBox_proceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_proceso_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(17, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 72;
            this.label5.Text = "Proceso";
            // 
            // text_placa
            // 
            this.text_placa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.text_placa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_placa.Location = new System.Drawing.Point(20, 29);
            this.text_placa.MaxLength = 6;
            this.text_placa.Name = "text_placa";
            this.text_placa.Size = new System.Drawing.Size(122, 31);
            this.text_placa.TabIndex = 60;
            this.text_placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_placa.TextChanged += new System.EventHandler(this.text_placa_TextChanged);
            this.text_placa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_placa_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(17, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 15);
            this.label21.TabIndex = 76;
            this.label21.Text = "Observaciones";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(17, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 15);
            this.label20.TabIndex = 69;
            this.label20.Text = "Placa";
            // 
            // text_observaciones
            // 
            this.text_observaciones.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_observaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_observaciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_observaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_observaciones.Location = new System.Drawing.Point(20, 197);
            this.text_observaciones.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.text_observaciones.MaxLength = 47;
            this.text_observaciones.Name = "text_observaciones";
            this.text_observaciones.Size = new System.Drawing.Size(457, 27);
            this.text_observaciones.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(17, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 71;
            this.label4.Text = "PESO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(166, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 15);
            this.label19.TabIndex = 70;
            this.label19.Text = "Categoría";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.display_peso);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(29, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 139);
            this.panel2.TabIndex = 77;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Gray;
            this.label22.Font = new System.Drawing.Font("DigitsDB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Cyan;
            this.label22.Location = new System.Drawing.Point(211, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 20);
            this.label22.TabIndex = 79;
            this.label22.Text = "Kg";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // display_peso
            // 
            this.display_peso.BackColor = System.Drawing.Color.Gray;
            this.display_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_peso.Font = new System.Drawing.Font("Digital SF", 45.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_peso.ForeColor = System.Drawing.Color.Cyan;
            this.display_peso.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.display_peso.Location = new System.Drawing.Point(18, 22);
            this.display_peso.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.display_peso.Name = "display_peso";
            this.display_peso.Size = new System.Drawing.Size(228, 97);
            this.display_peso.TabIndex = 78;
            this.display_peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Controls.Add(this.but_desconectar);
            this.panel5.Controls.Add(this.but_conectar);
            this.panel5.Controls.Add(this.comboBox_bascula);
            this.panel5.Controls.Add(this.comboBox_puertos);
            this.panel5.Location = new System.Drawing.Point(262, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 97);
            this.panel5.TabIndex = 96;
            // 
            // but_desconectar
            // 
            this.but_desconectar.BackColor = System.Drawing.Color.Gainsboro;
            this.but_desconectar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_desconectar.ForeColor = System.Drawing.Color.Black;
            this.but_desconectar.Location = new System.Drawing.Point(115, 53);
            this.but_desconectar.Name = "but_desconectar";
            this.but_desconectar.Size = new System.Drawing.Size(86, 27);
            this.but_desconectar.TabIndex = 21;
            this.but_desconectar.Text = "Desconectar";
            this.but_desconectar.UseVisualStyleBackColor = false;
            this.but_desconectar.Click += new System.EventHandler(this.but_desconectar_Click);
            // 
            // but_conectar
            // 
            this.but_conectar.BackColor = System.Drawing.Color.Gainsboro;
            this.but_conectar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_conectar.ForeColor = System.Drawing.Color.Black;
            this.but_conectar.Location = new System.Drawing.Point(115, 17);
            this.but_conectar.Name = "but_conectar";
            this.but_conectar.Size = new System.Drawing.Size(86, 27);
            this.but_conectar.TabIndex = 87;
            this.but_conectar.Text = "Conectar";
            this.but_conectar.UseVisualStyleBackColor = false;
            this.but_conectar.Click += new System.EventHandler(this.but_conectar_Click);
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
            this.comboBox_bascula.Items.AddRange(new object[] {
            "Entrada  1",
            "Entrada 2",
            "Salida 3",
            "Salida 4",
            "Salida 5"});
            this.comboBox_bascula.Location = new System.Drawing.Point(6, 17);
            this.comboBox_bascula.Name = "comboBox_bascula";
            this.comboBox_bascula.Size = new System.Drawing.Size(100, 26);
            this.comboBox_bascula.TabIndex = 86;
            this.comboBox_bascula.Text = "Seleccione";
            this.comboBox_bascula.SelectedIndexChanged += new System.EventHandler(this.comboBox_bascula_SelectedIndexChanged);
            // 
            // comboBox_puertos
            // 
            this.comboBox_puertos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_puertos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_puertos.ForeColor = System.Drawing.Color.Black;
            this.comboBox_puertos.FormattingEnabled = true;
            this.comboBox_puertos.Location = new System.Drawing.Point(6, 54);
            this.comboBox_puertos.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_puertos.Name = "comboBox_puertos";
            this.comboBox_puertos.Size = new System.Drawing.Size(100, 26);
            this.comboBox_puertos.TabIndex = 85;
            this.comboBox_puertos.Text = "Seleccione";
            this.comboBox_puertos.SelectedIndexChanged += new System.EventHandler(this.comboBox_puertos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(265, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "CONEXION";
            // 
            // label_fecha
            // 
            this.label_fecha.BackColor = System.Drawing.Color.Gray;
            this.label_fecha.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label_fecha.ForeColor = System.Drawing.Color.Cyan;
            this.label_fecha.Location = new System.Drawing.Point(300, 11);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(175, 32);
            this.label_fecha.TabIndex = 83;
            this.label_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_capturar
            // 
            this.but_capturar.BackColor = System.Drawing.Color.Gainsboro;
            this.but_capturar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_capturar.ForeColor = System.Drawing.Color.Black;
            this.but_capturar.Location = new System.Drawing.Point(396, 25);
            this.but_capturar.Name = "but_capturar";
            this.but_capturar.Size = new System.Drawing.Size(81, 35);
            this.but_capturar.TabIndex = 67;
            this.but_capturar.Text = "Capturar";
            this.but_capturar.UseVisualStyleBackColor = false;
            this.but_capturar.Click += new System.EventHandler(this.but_capturar_Click);
            // 
            // text_peso
            // 
            this.text_peso.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.text_peso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_peso.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_peso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_peso.Location = new System.Drawing.Point(283, 27);
            this.text_peso.Name = "text_peso";
            this.text_peso.ReadOnly = true;
            this.text_peso.Size = new System.Drawing.Size(116, 33);
            this.text_peso.TabIndex = 66;
            this.text_peso.TabStop = false;
            this.text_peso.Text = "0";
            this.text_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_ejes
            // 
            this.comboBox_ejes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_ejes.DisplayMember = "IdCategorias";
            this.comboBox_ejes.DropDownWidth = 90;
            this.comboBox_ejes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ejes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_ejes.FormattingEnabled = true;
            this.comboBox_ejes.IntegralHeight = false;
            this.comboBox_ejes.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "2S1",
            "2S2",
            "2S3",
            "2R1",
            "2R2",
            "3R2",
            "3R3",
            "3S2",
            "3S3",
            "EXTRA"});
            this.comboBox_ejes.Location = new System.Drawing.Point(169, 33);
            this.comboBox_ejes.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_ejes.MaxDropDownItems = 6;
            this.comboBox_ejes.Name = "comboBox_ejes";
            this.comboBox_ejes.Size = new System.Drawing.Size(90, 27);
            this.comboBox_ejes.TabIndex = 62;
            this.comboBox_ejes.SelectedIndexChanged += new System.EventHandler(this.comboBox_ejes_SelectedIndexChanged);
            this.comboBox_ejes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_ejes_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(233, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "PESO NETO :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(223, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 12);
            this.label24.TabIndex = 28;
            this.label24.Text = "PESO INICIAL :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(230, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 27;
            this.label25.Text = "PESO FINAL :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(58, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 12);
            this.label23.TabIndex = 29;
            this.label23.Text = "TARA :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(53, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 12);
            this.label27.TabIndex = 31;
            this.label27.Text = "PLACA :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(228, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 12);
            this.label29.TabIndex = 33;
            this.label29.Text = "SOBREPESO :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(61, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 12);
            this.label28.TabIndex = 32;
            this.label28.Text = "EJES :";
            // 
            // label_sobre
            // 
            this.label_sobre.BackColor = System.Drawing.Color.Transparent;
            this.label_sobre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_sobre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sobre.ForeColor = System.Drawing.Color.White;
            this.label_sobre.Location = new System.Drawing.Point(327, 91);
            this.label_sobre.Name = "label_sobre";
            this.label_sobre.Size = new System.Drawing.Size(95, 25);
            this.label_sobre.TabIndex = 63;
            this.label_sobre.Text = " - - - - -";
            this.label_sobre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ejes
            // 
            this.label_ejes.BackColor = System.Drawing.Color.Transparent;
            this.label_ejes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ejes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ejes.ForeColor = System.Drawing.Color.White;
            this.label_ejes.Location = new System.Drawing.Point(111, 61);
            this.label_ejes.Name = "label_ejes";
            this.label_ejes.Size = new System.Drawing.Size(95, 25);
            this.label_ejes.TabIndex = 62;
            this.label_ejes.Text = " - - - - -";
            this.label_ejes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_neto
            // 
            this.label_neto.BackColor = System.Drawing.Color.Transparent;
            this.label_neto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_neto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_neto.ForeColor = System.Drawing.Color.White;
            this.label_neto.Location = new System.Drawing.Point(327, 57);
            this.label_neto.Name = "label_neto";
            this.label_neto.Size = new System.Drawing.Size(95, 25);
            this.label_neto.TabIndex = 61;
            this.label_neto.Text = " - - - - -";
            this.label_neto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tara
            // 
            this.label_tara.BackColor = System.Drawing.Color.Transparent;
            this.label_tara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_tara.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tara.ForeColor = System.Drawing.Color.White;
            this.label_tara.Location = new System.Drawing.Point(111, 88);
            this.label_tara.Name = "label_tara";
            this.label_tara.Size = new System.Drawing.Size(95, 25);
            this.label_tara.TabIndex = 60;
            this.label_tara.Text = " - - - - -";
            this.label_tara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pesofin
            // 
            this.label_pesofin.BackColor = System.Drawing.Color.Transparent;
            this.label_pesofin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pesofin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesofin.ForeColor = System.Drawing.Color.White;
            this.label_pesofin.Location = new System.Drawing.Point(327, 32);
            this.label_pesofin.Name = "label_pesofin";
            this.label_pesofin.Size = new System.Drawing.Size(95, 25);
            this.label_pesofin.TabIndex = 59;
            this.label_pesofin.Text = " - - - - -";
            this.label_pesofin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pesoini
            // 
            this.label_pesoini.BackColor = System.Drawing.Color.Transparent;
            this.label_pesoini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pesoini.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesoini.ForeColor = System.Drawing.Color.White;
            this.label_pesoini.Location = new System.Drawing.Point(327, 5);
            this.label_pesoini.Name = "label_pesoini";
            this.label_pesoini.Size = new System.Drawing.Size(95, 25);
            this.label_pesoini.TabIndex = 58;
            this.label_pesoini.Text = " - - - - -";
            this.label_pesoini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_placa
            // 
            this.label_placa.BackColor = System.Drawing.Color.Transparent;
            this.label_placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_placa.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_placa.ForeColor = System.Drawing.Color.White;
            this.label_placa.Location = new System.Drawing.Point(111, 35);
            this.label_placa.Name = "label_placa";
            this.label_placa.Size = new System.Drawing.Size(95, 25);
            this.label_placa.TabIndex = 57;
            this.label_placa.Text = " - - - - -";
            this.label_placa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Dubai", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(20, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 32);
            this.label6.TabIndex = 79;
            this.label6.Text = "TIQUETE DE BÁSCULA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label_date);
            this.panel3.Controls.Add(this.label_neto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label_sobre);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label_tara);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.label_pesofin);
            this.panel3.Controls.Add(this.label_ejes);
            this.panel3.Controls.Add(this.label_placa);
            this.panel3.Controls.Add(this.label_pesoini);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Location = new System.Drawing.Point(20, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 124);
            this.panel3.TabIndex = 80;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label_date
            // 
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_date.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(111, 9);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(95, 25);
            this.label_date.TabIndex = 85;
            this.label_date.Text = " - - - - -";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 84;
            this.label9.Text = "FECHA :";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(315, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "____________________";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // but_guardar
            // 
            this.but_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.but_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_guardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_guardar.Location = new System.Drawing.Point(928, 283);
            this.but_guardar.Name = "but_guardar";
            this.but_guardar.Size = new System.Drawing.Size(83, 50);
            this.but_guardar.TabIndex = 12;
            this.but_guardar.Text = "Guardar";
            this.but_guardar.UseVisualStyleBackColor = false;
            this.but_guardar.Click += new System.EventHandler(this.but_guardar_Click);
            // 
            // dgv_eventos
            // 
            this.dgv_eventos.AllowUserToAddRows = false;
            this.dgv_eventos.AllowUserToDeleteRows = false;
            this.dgv_eventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_eventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eventos.Location = new System.Drawing.Point(29, 363);
            this.dgv_eventos.Name = "dgv_eventos";
            this.dgv_eventos.ReadOnly = true;
            this.dgv_eventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_eventos.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_eventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_eventos.Size = new System.Drawing.Size(995, 224);
            this.dgv_eventos.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.but_imprimir);
            this.panel1.Controls.Add(this.but_guardar);
            this.panel1.Controls.Add(this.dgv_eventos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 605);
            this.panel1.TabIndex = 77;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.but_capturar);
            this.panel6.Controls.Add(this.text_observaciones);
            this.panel6.Controls.Add(this.text_peso);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.text_tara);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.comboBox_proceso);
            this.panel6.Controls.Add(this.comboBox_ejes);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.text_placa);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.text_item);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(534, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(490, 241);
            this.panel6.TabIndex = 96;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DisplayMember = "IdCategorias";
            this.comboBox1.DropDownWidth = 90;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "Carga Seca",
            "Early EOL",
            "Terminal MLT",
            "",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(319, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.MaxDropDownItems = 6;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 27);
            this.comboBox1.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(316, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 90;
            this.label2.Text = "Terminal";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(114, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 27);
            this.textBox1.TabIndex = 91;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(20, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 27);
            this.textBox2.TabIndex = 93;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(24, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "GSV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(120, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 94;
            this.label7.Text = "A.P.I";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label_fecha);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(29, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 190);
            this.panel4.TabIndex = 95;
            // 
            // but_imprimir
            // 
            this.but_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.but_imprimir.BackColor = System.Drawing.Color.Gainsboro;
            this.but_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_imprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_imprimir.ForeColor = System.Drawing.Color.Black;
            this.but_imprimir.Location = new System.Drawing.Point(825, 283);
            this.but_imprimir.Name = "but_imprimir";
            this.but_imprimir.Size = new System.Drawing.Size(83, 50);
            this.but_imprimir.TabIndex = 22;
            this.but_imprimir.Text = "Imprimir";
            this.but_imprimir.UseVisualStyleBackColor = false;
            // 
            // SerialPort1
            // 
            this.SerialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.SerialPort1_ErrorReceived);
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pesajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Pesajes";
            this.Size = new System.Drawing.Size(1050, 605);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eventos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox text_tara;
        private System.Windows.Forms.TextBox text_item;
        private System.Windows.Forms.ComboBox comboBox_proceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_placa;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox text_observaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button but_capturar;
        public System.Windows.Forms.Label display_peso;
        private System.Windows.Forms.TextBox text_peso;
        private System.Windows.Forms.ComboBox comboBox_ejes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label_sobre;
        private System.Windows.Forms.Label label_ejes;
        private System.Windows.Forms.Label label_neto;
        private System.Windows.Forms.Label label_tara;
        private System.Windows.Forms.Label label_pesofin;
        private System.Windows.Forms.Label label_pesoini;
        private System.Windows.Forms.Label label_placa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button but_guardar;
        private System.Windows.Forms.Button but_desconectar;
        private System.Windows.Forms.DataGridView dgv_eventos;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.ComboBox comboBox_puertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_bascula;
        private System.Windows.Forms.Button but_conectar;
        private System.Windows.Forms.Button but_imprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
    }
}
