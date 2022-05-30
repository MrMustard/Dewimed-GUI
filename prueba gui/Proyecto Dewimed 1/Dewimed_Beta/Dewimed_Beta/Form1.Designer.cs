namespace Dewimed_Beta
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_On = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.button_field_mas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_field_menos = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.button_menos = new System.Windows.Forms.Button();
            this.button_ambi = new System.Windows.Forms.Button();
            this.button_mas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_Serial_Receive = new System.Windows.Forms.TextBox();
            this.groupBox_Terminal_Send = new System.Windows.Forms.GroupBox();
            this.TextBox_Serial_Send = new System.Windows.Forms.TextBox();
            this.button_Config_Menu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button_Serial_Close = new System.Windows.Forms.Button();
            this.Button_Serial_Open = new System.Windows.Forms.Button();
            this.Combo_Baud = new System.Windows.Forms.ComboBox();
            this.Combo_Port = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialport1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Group_Terminal = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Terminal_Send.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Group_Terminal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_On
            // 
            this.button_On.Location = new System.Drawing.Point(6, 32);
            this.button_On.Name = "button_On";
            this.button_On.Size = new System.Drawing.Size(90, 90);
            this.button_On.TabIndex = 0;
            this.button_On.Text = "ON/OFF";
            this.button_On.UseVisualStyleBackColor = true;
            this.button_On.Click += new System.EventHandler(this.button_On_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.LabelStatus);
            this.groupBox1.Controls.Add(this.button_field_mas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_field_menos);
            this.groupBox1.Controls.Add(this.button_On);
            this.groupBox1.Controls.Add(this.button_color);
            this.groupBox1.Controls.Add(this.button_menos);
            this.groupBox1.Controls.Add(this.button_ambi);
            this.groupBox1.Controls.Add(this.button_mas);
            this.groupBox1.Location = new System.Drawing.Point(275, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teclado Virtual";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(113, 125);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(66, 25);
            this.LabelStatus.TabIndex = 9;
            this.LabelStatus.Text = "STAT";
            // 
            // button_field_mas
            // 
            this.button_field_mas.Location = new System.Drawing.Point(714, 32);
            this.button_field_mas.Name = "button_field_mas";
            this.button_field_mas.Size = new System.Drawing.Size(90, 90);
            this.button_field_mas.TabIndex = 8;
            this.button_field_mas.Text = "FIELD +";
            this.button_field_mas.UseVisualStyleBackColor = true;
            this.button_field_mas.Click += new System.EventHandler(this.button_field_mas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STATUS:";
            // 
            // button_field_menos
            // 
            this.button_field_menos.Location = new System.Drawing.Point(596, 32);
            this.button_field_menos.Name = "button_field_menos";
            this.button_field_menos.Size = new System.Drawing.Size(90, 90);
            this.button_field_menos.TabIndex = 7;
            this.button_field_menos.Text = "FIELD -";
            this.button_field_menos.UseVisualStyleBackColor = true;
            this.button_field_menos.Click += new System.EventHandler(this.button_field_menos_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(478, 32);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(90, 90);
            this.button_color.TabIndex = 6;
            this.button_color.Text = "COLOR";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_menos
            // 
            this.button_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menos.Location = new System.Drawing.Point(124, 32);
            this.button_menos.Name = "button_menos";
            this.button_menos.Size = new System.Drawing.Size(90, 90);
            this.button_menos.TabIndex = 3;
            this.button_menos.Text = "-";
            this.button_menos.UseVisualStyleBackColor = true;
            this.button_menos.Click += new System.EventHandler(this.button_menos_Click);
            // 
            // button_ambi
            // 
            this.button_ambi.Location = new System.Drawing.Point(360, 32);
            this.button_ambi.Name = "button_ambi";
            this.button_ambi.Size = new System.Drawing.Size(90, 90);
            this.button_ambi.TabIndex = 5;
            this.button_ambi.Text = "AMBI";
            this.button_ambi.UseVisualStyleBackColor = true;
            this.button_ambi.Click += new System.EventHandler(this.button_ambi_Click);
            // 
            // button_mas
            // 
            this.button_mas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mas.Location = new System.Drawing.Point(242, 32);
            this.button_mas.Name = "button_mas";
            this.button_mas.Size = new System.Drawing.Size(90, 90);
            this.button_mas.TabIndex = 4;
            this.button_mas.Text = "+";
            this.button_mas.UseVisualStyleBackColor = true;
            this.button_mas.Click += new System.EventHandler(this.button_mas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_Serial_Receive);
            this.groupBox2.Location = new System.Drawing.Point(6, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Recibidos";
            // 
            // TextBox_Serial_Receive
            // 
            this.TextBox_Serial_Receive.Location = new System.Drawing.Point(6, 35);
            this.TextBox_Serial_Receive.Multiline = true;
            this.TextBox_Serial_Receive.Name = "TextBox_Serial_Receive";
            this.TextBox_Serial_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Serial_Receive.Size = new System.Drawing.Size(625, 131);
            this.TextBox_Serial_Receive.TabIndex = 0;
            // 
            // groupBox_Terminal_Send
            // 
            this.groupBox_Terminal_Send.Controls.Add(this.TextBox_Serial_Send);
            this.groupBox_Terminal_Send.Location = new System.Drawing.Point(6, 19);
            this.groupBox_Terminal_Send.Name = "groupBox_Terminal_Send";
            this.groupBox_Terminal_Send.Size = new System.Drawing.Size(678, 62);
            this.groupBox_Terminal_Send.TabIndex = 5;
            this.groupBox_Terminal_Send.TabStop = false;
            this.groupBox_Terminal_Send.Text = "Enviar Datos";
            // 
            // TextBox_Serial_Send
            // 
            this.TextBox_Serial_Send.Location = new System.Drawing.Point(6, 19);
            this.TextBox_Serial_Send.Multiline = true;
            this.TextBox_Serial_Send.Name = "TextBox_Serial_Send";
            this.TextBox_Serial_Send.Size = new System.Drawing.Size(666, 33);
            this.TextBox_Serial_Send.TabIndex = 3;
            // 
            // button_Config_Menu
            // 
            this.button_Config_Menu.Location = new System.Drawing.Point(1167, 12);
            this.button_Config_Menu.Name = "button_Config_Menu";
            this.button_Config_Menu.Size = new System.Drawing.Size(140, 42);
            this.button_Config_Menu.TabIndex = 6;
            this.button_Config_Menu.Text = "Config";
            this.button_Config_Menu.UseVisualStyleBackColor = true;
            this.button_Config_Menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1167, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(711, 32);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(91, 31);
            this.button_Enviar.TabIndex = 8;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Button_Serial_Close);
            this.groupBox4.Controls.Add(this.Button_Serial_Open);
            this.groupBox4.Controls.Add(this.Combo_Baud);
            this.groupBox4.Controls.Add(this.Combo_Port);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 202);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UART CONFIG";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(185, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(589, 21);
            this.progressBar1.TabIndex = 11;
            // 
            // Button_Serial_Close
            // 
            this.Button_Serial_Close.Location = new System.Drawing.Point(6, 156);
            this.Button_Serial_Close.Name = "Button_Serial_Close";
            this.Button_Serial_Close.Size = new System.Drawing.Size(239, 31);
            this.Button_Serial_Close.TabIndex = 10;
            this.Button_Serial_Close.Text = "Cerrar";
            this.Button_Serial_Close.UseVisualStyleBackColor = true;
            this.Button_Serial_Close.Click += new System.EventHandler(this.Button_Serial_Close_Click);
            // 
            // Button_Serial_Open
            // 
            this.Button_Serial_Open.Location = new System.Drawing.Point(6, 119);
            this.Button_Serial_Open.Name = "Button_Serial_Open";
            this.Button_Serial_Open.Size = new System.Drawing.Size(239, 31);
            this.Button_Serial_Open.TabIndex = 9;
            this.Button_Serial_Open.Text = "Abrir";
            this.Button_Serial_Open.UseVisualStyleBackColor = true;
            this.Button_Serial_Open.Click += new System.EventHandler(this.Button_Serial_Open_Click);
            // 
            // Combo_Baud
            // 
            this.Combo_Baud.FormattingEnabled = true;
            this.Combo_Baud.Location = new System.Drawing.Point(128, 85);
            this.Combo_Baud.Name = "Combo_Baud";
            this.Combo_Baud.Size = new System.Drawing.Size(121, 21);
            this.Combo_Baud.TabIndex = 3;
            // 
            // Combo_Port
            // 
            this.Combo_Port.FormattingEnabled = true;
            this.Combo_Port.Location = new System.Drawing.Point(128, 39);
            this.Combo_Port.Name = "Combo_Port";
            this.Combo_Port.Size = new System.Drawing.Size(121, 21);
            this.Combo_Port.TabIndex = 2;
            this.Combo_Port.SelectedIndexChanged += new System.EventHandler(this.Combo_Port_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "BAUD RATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "COM PORT:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // serialport1
            // 
            this.serialport1.BaudRate = 38400;
            this.serialport1.PortName = "COM8";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 159);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "FIRMWARE: 0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "HARDWARE : 1.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "DEWILUX ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mextronics";
            // 
            // Group_Terminal
            // 
            this.Group_Terminal.Controls.Add(this.button1);
            this.Group_Terminal.Controls.Add(this.groupBox_Terminal_Send);
            this.Group_Terminal.Controls.Add(this.button_Enviar);
            this.Group_Terminal.Controls.Add(this.groupBox2);
            this.Group_Terminal.Location = new System.Drawing.Point(277, 183);
            this.Group_Terminal.Name = "Group_Terminal";
            this.Group_Terminal.Size = new System.Drawing.Size(815, 265);
            this.Group_Terminal.TabIndex = 4;
            this.Group_Terminal.TabStop = false;
            this.Group_Terminal.Text = "Terminal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 472);
            this.Controls.Add(this.Group_Terminal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Config_Menu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEWIMED";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Terminal_Send.ResumeLayout(false);
            this.groupBox_Terminal_Send.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Group_Terminal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_On;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button button_field_mas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_field_menos;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_menos;
        private System.Windows.Forms.Button button_ambi;
        private System.Windows.Forms.Button button_mas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_Terminal_Send;
        private System.Windows.Forms.TextBox TextBox_Serial_Send;
        private System.Windows.Forms.Button button_Config_Menu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Enviar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Serial_Close;
        private System.Windows.Forms.Button Button_Serial_Open;
        private System.Windows.Forms.ComboBox Combo_Baud;
        private System.Windows.Forms.ComboBox Combo_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialport1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Group_Terminal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_Serial_Receive;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

