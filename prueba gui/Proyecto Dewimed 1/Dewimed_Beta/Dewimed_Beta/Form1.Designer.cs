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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.Button_Serial_Close = new System.Windows.Forms.Button();
            this.Button_Serial_Open = new System.Windows.Forms.Button();
            this.Combo_Baud = new System.Windows.Forms.ComboBox();
            this.Combo_Port = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialport1 = new System.IO.Ports.SerialPort(this.components);
            this.Group_Terminal = new System.Windows.Forms.GroupBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.button_wdg = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Info = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Terminal_Send.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Group_Terminal.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teclado Virtual";
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(185, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(589, 21);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
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
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Recibidos";
            // 
            // TextBox_Serial_Receive
            // 
            this.TextBox_Serial_Receive.AcceptsReturn = true;
            this.TextBox_Serial_Receive.AcceptsTab = true;
            this.TextBox_Serial_Receive.Location = new System.Drawing.Point(6, 35);
            this.TextBox_Serial_Receive.Multiline = true;
            this.TextBox_Serial_Receive.Name = "TextBox_Serial_Receive";
            this.TextBox_Serial_Receive.ReadOnly = true;
            this.TextBox_Serial_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Serial_Receive.Size = new System.Drawing.Size(625, 131);
            this.TextBox_Serial_Receive.TabIndex = 0;
            this.TextBox_Serial_Receive.TextChanged += new System.EventHandler(this.TextBox_Serial_Receive_TextChanged);
            // 
            // groupBox_Terminal_Send
            // 
            this.groupBox_Terminal_Send.Controls.Add(this.TextBox_Serial_Send);
            this.groupBox_Terminal_Send.Enabled = false;
            this.groupBox_Terminal_Send.Location = new System.Drawing.Point(6, 19);
            this.groupBox_Terminal_Send.Name = "groupBox_Terminal_Send";
            this.groupBox_Terminal_Send.Size = new System.Drawing.Size(678, 62);
            this.groupBox_Terminal_Send.TabIndex = 5;
            this.groupBox_Terminal_Send.TabStop = false;
            this.groupBox_Terminal_Send.Text = "Enviar Datos";
            this.groupBox_Terminal_Send.Visible = false;
            // 
            // TextBox_Serial_Send
            // 
            this.TextBox_Serial_Send.Enabled = false;
            this.TextBox_Serial_Send.Location = new System.Drawing.Point(6, 19);
            this.TextBox_Serial_Send.Multiline = true;
            this.TextBox_Serial_Send.Name = "TextBox_Serial_Send";
            this.TextBox_Serial_Send.Size = new System.Drawing.Size(666, 33);
            this.TextBox_Serial_Send.TabIndex = 3;
            this.TextBox_Serial_Send.Visible = false;
            // 
            // button_Config_Menu
            // 
            this.button_Config_Menu.Location = new System.Drawing.Point(6, 19);
            this.button_Config_Menu.Name = "button_Config_Menu";
            this.button_Config_Menu.Size = new System.Drawing.Size(251, 30);
            this.button_Config_Menu.TabIndex = 6;
            this.button_Config_Menu.Text = "Calibración";
            this.button_Config_Menu.UseVisualStyleBackColor = true;
            this.button_Config_Menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Enviar
            // 
            this.button_Enviar.Enabled = false;
            this.button_Enviar.Location = new System.Drawing.Point(711, 32);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(91, 31);
            this.button_Enviar.TabIndex = 8;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Visible = false;
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
            this.groupBox4.Location = new System.Drawing.Point(844, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 202);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UART CONFIG";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Button_Serial_Close
            // 
            this.Button_Serial_Close.Location = new System.Drawing.Point(18, 156);
            this.Button_Serial_Close.Name = "Button_Serial_Close";
            this.Button_Serial_Close.Size = new System.Drawing.Size(239, 31);
            this.Button_Serial_Close.TabIndex = 10;
            this.Button_Serial_Close.Text = "Cerrar";
            this.Button_Serial_Close.UseVisualStyleBackColor = true;
            this.Button_Serial_Close.Click += new System.EventHandler(this.Button_Serial_Close_Click);
            // 
            // Button_Serial_Open
            // 
            this.Button_Serial_Open.Location = new System.Drawing.Point(18, 119);
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
            // Group_Terminal
            // 
            this.Group_Terminal.Controls.Add(this.button_Limpiar);
            this.Group_Terminal.Controls.Add(this.groupBox_Terminal_Send);
            this.Group_Terminal.Controls.Add(this.button_Enviar);
            this.Group_Terminal.Controls.Add(this.groupBox2);
            this.Group_Terminal.Location = new System.Drawing.Point(12, 173);
            this.Group_Terminal.Name = "Group_Terminal";
            this.Group_Terminal.Size = new System.Drawing.Size(815, 265);
            this.Group_Terminal.TabIndex = 4;
            this.Group_Terminal.TabStop = false;
            this.Group_Terminal.Text = "Terminal";
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(711, 106);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(91, 31);
            this.button_Limpiar.TabIndex = 9;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_wdg
            // 
            this.button_wdg.Location = new System.Drawing.Point(6, 55);
            this.button_wdg.Name = "button_wdg";
            this.button_wdg.Size = new System.Drawing.Size(251, 30);
            this.button_wdg.TabIndex = 11;
            this.button_wdg.Text = "Probar WhatchDog";
            this.button_wdg.UseVisualStyleBackColor = true;
            this.button_wdg.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(6, 91);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(251, 30);
            this.button_reset.TabIndex = 12;
            this.button_reset.Text = "Reset ";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Info);
            this.groupBox3.Controls.Add(this.button_Config_Menu);
            this.groupBox3.Controls.Add(this.button_reset);
            this.groupBox3.Controls.Add(this.button_wdg);
            this.groupBox3.Location = new System.Drawing.Point(844, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 165);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button_Info
            // 
            this.button_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Info.AutoSize = true;
            this.button_Info.Location = new System.Drawing.Point(6, 127);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(251, 30);
            this.button_Info.TabIndex = 13;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Group_Terminal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
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
            this.Group_Terminal.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox Group_Terminal;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.TextBox TextBox_Serial_Receive;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button_wdg;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Info;
    }
}

