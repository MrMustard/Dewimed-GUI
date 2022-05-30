using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Dewimed_Beta
{
    public partial class Form1 : Form
    {
        private string ReceivedData;//received data form serial port
        private int Valor_Barra = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_On_Click(object sender, EventArgs e)
        {
            try
            {

                //button_menos.Enabled = true;//Desactivamos el boton de menos
                //button_mas.Enabled = true;//desactivamos el boton de mas
               // button_ambi.Enabled = true;//desactivamos el boton de ambi
                //button_color.Enabled = true;//desactivamos el boton de color
                //button_field_menos.Enabled = true; //desactivamos el boton de campo menos
               // button_field_mas.Enabled = true;//desactivamos el boton de campo mas
                serialport1.WriteLine("[P]");
               LabelStatus.Text = "[P]";
                


            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            
            
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            button_On.Enabled = false;
            button_menos.Enabled = false;
            button_mas.Enabled = false;
            button_ambi.Enabled = false;
            button_color.Enabled = false;
            Button_Serial_Close.Enabled = false;
            button_field_menos.Enabled = false;
            button_field_mas.Enabled=false;
            button_Enviar.Enabled = false;
            button_Config_Menu.Enabled = false;
            TextBox_Serial_Receive.Enabled = false;
            TextBox_Serial_Send .Enabled = false;
            Combo_Baud.Enabled = true;
            Combo_Port.Enabled = true;


            string[] rates = { "9600", "38400", "57600", "115200"};
            Combo_Baud.DataSource = rates;
            //Combo_Baud.Text = "38400";
            progressBar1.Value= 0;

            string[] portList = SerialPort.GetPortNames();
            Combo_Port.Items.AddRange(portList);




        

            try

            {
            
                //LabelStatus.Text = "OFF";
                //serialPort1.PortName = "COM8";
                //serialPort1.Open();
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);
                
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialport1.IsOpen)//Si esta abierto el puerto
            {
                try
                {
                    serialport1.Close();//cerramos el puerto serie
                }

                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                
                }
            
            }
            
        }

        private void button_menos_Click(object sender, EventArgs e)
        {
            try

            {
              serialport1.WriteLine("[-]");
                LabelStatus.Text = "[-]";
                
                if (Valor_Barra <= 10)
                {
                    Valor_Barra = 10;
                }
                else
                {
                    Valor_Barra -= 10;
                }

                progressBar1.Value = Valor_Barra;
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }
        }

        private void button_mas_Click(object sender, EventArgs e)
        {
            try

            {
                serialport1.WriteLine("[+]");
                LabelStatus.Text = "[+]";

                if (Valor_Barra >= 100)
                {
                    Valor_Barra = 100;
                }
                else
                {
                    Valor_Barra += 10;                
                }

                progressBar1.Value = Valor_Barra;
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }
        }

        private void button_ambi_Click(object sender, EventArgs e)
        {
            try

            {
                serialport1.WriteLine("[A]");
                LabelStatus.Text = "[A]";
               
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            try

            {
                serialport1.WriteLine("[F]");
                LabelStatus.Text = "[F]";
               
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }
        }

        private void button_field_menos_Click(object sender, EventArgs e)
        {
            try

            {
                serialport1.WriteLine("[L]");
                LabelStatus.Text = "[L]";
               
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }
        }

        private void button_field_mas_Click(object sender, EventArgs e)
        {
            try

            {
                serialport1.WriteLine("[H]");
                LabelStatus.Text = "[H]";
               
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }
        }

        private void EscucharSerial()
        { 
        
       
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            try
            {
                serialport1.Close();//cerramos el puerto serie

                Form2 f2 = new Form2();//creamos un nuevo form
                this.Hide();//escondemos el form 1
                f2.ShowDialog();//mostramos form2
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Serial_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialport1.PortName = Combo_Port.Text;
                serialport1.BaudRate = Convert.ToInt32(Combo_Baud.Text);
                serialport1.Open();
/*
                button_On.Enabled = true;
                button_menos.Enabled = true;
                button_mas.Enabled = true;
                button_ambi.Enabled = true;
                button_color.Enabled = true;
                Button_Serial_Close.Enabled = true;
                button_field_menos.Enabled = true;
                button_field_mas.Enabled = true;
                button_Config_Menu.Enabled = true;
*/

               
                Combo_Baud.Enabled = false;
                Combo_Port.Enabled = false;

                

                button_On.Enabled = true;
                button_menos.Enabled = true;
                button_mas.Enabled = true;
                button_ambi.Enabled = true;
                button_color.Enabled = true;
                Button_Serial_Close.Enabled = true;
                button_field_menos.Enabled = true;
                button_field_mas.Enabled = true;
                button_Enviar.Enabled = true;
                button_Config_Menu.Enabled = true;
                TextBox_Serial_Receive.Enabled = true;
                TextBox_Serial_Send.Enabled = true;

                progressBar1.Value = 10;
                Valor_Barra = 10;
                
                serialport1.DataReceived += serialport1_DataReceived;



            }

            catch (Exception error )
            {

                MessageBox.Show(error.Message);

            }
        }

        private void Button_Serial_Close_Click(object sender, EventArgs e)
        {
            if (serialport1.IsOpen)//Si esta abierto el puerto
            {
                try
                {
                    serialport1.Close();//cerramos el puerto serie
                    button_On.Enabled = false;
                    button_menos.Enabled = false;
                    button_mas.Enabled = false;
                    button_ambi.Enabled = false;
                    button_color.Enabled = false;
                    Button_Serial_Close.Enabled = false;
                    button_field_menos.Enabled = false;
                    button_field_mas.Enabled = false;
                    button_Config_Menu.Enabled = false;
                    progressBar1.Value = 0;
                    Combo_Port.Enabled = true;
                    Combo_Baud.Enabled = true;

                    progressBar1.Value = 0;
                    Valor_Barra = 10;
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }

            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button_Enviar_Click(object sender, EventArgs e)
        {
           


            try

            {
                string Datos_Para_Enviar = TextBox_Serial_Send.Text;

                serialport1.WriteLine(Datos_Para_Enviar);

                TextBox_Serial_Send.Text = string.Empty;//limpiamos el textbox
               
                
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }

        }


        // private void serialport1_Data

        private void serialport1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            ReceivedData = serialport1.ReadLine();//leemos la linea del puerto serial

            this.Invoke(new Action(ProcessingData));



        
        }


        private void ProcessingData()
        { 
           TextBox_Serial_Receive.Text += ReceivedData.ToString() + Environment.NewLine;
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           TextBox_Serial_Receive.Text  = string.Empty;//limpiamos el textbox
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //serialport1.
            //string[] ports = serialport1.GetPortNames();
          
            

        }

        private void Combo_Port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }



}
