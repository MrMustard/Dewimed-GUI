﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Dewimed_Beta
{


    public partial class Form2 : Form
    {
        int Tiempo = 150;
        double[] Registro_F0_C0 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F0_C0 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F0_C0 = new double[10];//Vector que indica valores de mA
        double[] DC_F0_C0 = new double[10];//Vector que indica el %DC

        double[] Registro_F0_C1 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F0_C1 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F0_C1 = new double[10];//Vector que indica valores de mA
        double[] DC_F0_C1 = new double[10];//Vector que indica el %DC


        double[] Registro_F0_C2 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F0_C2 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F0_C2 = new double[10];//Vector que indica valores de mA
        double[] DC_F0_C2 = new double[10];//Vector que indica el %DC

        double[] Registro_F0_C3 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F0_C3 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F0_C3 = new double[10];//Vector que indica valores de mA
        double[] DC_F0_C3 = new double[10];//Vector que indica el %DC

        double[] Registro_F0_C4 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F0_C4 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F0_C4 = new double[10];//Vector que indica valores de mA
        double[] DC_F0_C4 = new double[10];//Vector que indica el %DC




        double[] Registro_F1_C0 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F1_C0 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F1_C0 = new double[10];//Vector que indica valores de mA
        double[] DC_F1_C0 = new double[10];//Vector que indica el %DC

        double[] Registro_F1_C1 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F1_C1 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F1_C1 = new double[10];//Vector que indica valores de mA
        double[] DC_F1_C1 = new double[10];//Vector que indica el %DC


        double[] Registro_F1_C2 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F1_C2 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F1_C2 = new double[10];//Vector que indica valores de mA
        double[] DC_F1_C2 = new double[10];//Vector que indica el %DC

        double[] Registro_F1_C3 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F1_C3 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F1_C3 = new double[10];//Vector que indica valores de mA
        double[] DC_F1_C3 = new double[10];//Vector que indica el %DC

        double[] Registro_F1_C4 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F1_C4 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F1_C4 = new double[10];//Vector que indica valores de mA
        double[] DC_F1_C4 = new double[10];//Vector que indica el %DC




        double[] Registro_F2_C0 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F2_C0 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F2_C0 = new double[10];//Vector que indica valores de mA
        double[] DC_F2_C0 = new double[10];//Vector que indica el %DC

        double[] Registro_F2_C1 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F2_C1 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F2_C1 = new double[10];//Vector que indica valores de mA
        double[] DC_F2_C1 = new double[10];//Vector que indica el %DC


        double[] Registro_F2_C2 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F2_C2 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F2_C2 = new double[10];//Vector que indica valores de mA
        double[] DC_F2_C2 = new double[10];//Vector que indica el %DC

        double[] Registro_F2_C3 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F2_C3 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F2_C3 = new double[10];//Vector que indica valores de mA
        double[] DC_F2_C3 = new double[10];//Vector que indica el %DC

        double[] Registro_F2_C4 = new double[10]; // vector donde guardaraemos los valores de registros.
        double[] Incremento_F2_C4 = new double[10]; // vector donde guardaraemos los valores de incremento
        double[] mA_F2_C4 = new double[10];//Vector que indica valores de mA
        double[] DC_F2_C4 = new double[10];//Vector que indica el %DC



        /*String para dar ormato y enviar*/
        /*-------------F0---------------------*/
        string [] Val_F0_C0 = new string[10];
        string[] Val_F0_C1 = new string[10];
        string[] Val_F0_C2 = new string[10];
        string[] Val_F0_C3 = new string[10];
        string[] Val_F0_C4 = new string[10];
        /*-------------F1---------------------*/
        string[] Val_F1_C0 = new string[10];
        string[] Val_F1_C1 = new string[10];
        string[] Val_F1_C2 = new string[10];
        string[] Val_F1_C3 = new string[10];
        string[] Val_F1_C4 = new string[10];
        /*-------------F1---------------------*/

        string[] Val_F2_C0 = new string[10];
        string[] Val_F2_C1 = new string[10];
        string[] Val_F2_C2 = new string[10];
        string[] Val_F2_C3 = new string[10];
        string[] Val_F2_C4 = new string[10];


        /*para convertir a int*/
        /* F0 */

        int[] Num_F0_C0 = new int[10];
        int[] Num_F0_C1 = new int[10];
        int[] Num_F0_C2 = new int[10];
        int[] Num_F0_C3 = new int[10];
        int[] Num_F0_C4 = new int[10];
        /* F1 */
        int[] Num_F1_C0 = new int[10];
        int[] Num_F1_C1 = new int[10];
        int[] Num_F1_C2 = new int[10];
        int[] Num_F1_C3 = new int[10];
        int[] Num_F1_C4 = new int[10];
        /* F2 */
        int[] Num_F2_C0 = new int[10];
        int[] Num_F2_C1 = new int[10];
        int[] Num_F2_C2 = new int[10];
        int[] Num_F2_C3 = new int[10];
        int[] Num_F2_C4 = new int[10];



        string factorv, factorc;





        string SerialDataIn;// string que recibe los datos enviados por el microcontrolador 

        string SerialDataIn2;// string que recibe los datos enviados por el microcontrolador 

        //variable para identificar los index
        int   indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI, indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP, 
                indexOfQ,indexOfR, indexOfS, indexOfT, indexOfU, indexOfV, indexOfW, indexOfX, indexOfY, indexOfZ, indexOfa, indexOfb, indexOfc, indexOfd ;

        int indexOff, indexOfg, indexOfh, indexOfi, indexOfj, indexOfk, indexOfl;// indices para leer voltajes 

        // STRING DONDE GUARDAREMOS LOS VALORES MAXIMOS Y MINIMOS
        string  String_F0_C0_MAX, String_F0_C0_MIN,
                String_F0_C1_MAX, String_F0_C1_MIN,
                String_F0_C2_MAX, String_F0_C2_MIN,
                String_F0_C3_MAX, String_F0_C3_MIN,
                String_F0_C4_MAX, String_F0_C4_MIN,
            /*-------------------------------------------*/
                String_F1_C0_MAX, String_F1_C0_MIN,
                String_F1_C1_MAX, String_F1_C1_MIN,
                String_F1_C2_MAX, String_F1_C2_MIN,
                String_F1_C3_MAX, String_F1_C3_MIN,
                String_F1_C4_MAX, String_F1_C4_MIN,
            /*-------------------------------------------*/
                String_F2_C0_MAX, String_F2_C0_MIN,
                String_F2_C1_MAX, String_F2_C1_MIN,
                String_F2_C2_MAX, String_F2_C2_MIN,
                String_F2_C3_MAX, String_F2_C3_MIN,
                String_F2_C4_MAX, String_F2_C4_MIN

            ;



        string StringTemp, StringVolt, StringI, StringF0, StringF1, StringF2;

        private void TextBox_F2_Campo3_mA_Max_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_DC_F0_Campo0_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button_leer.Enabled = false;
            button_calcular.Enabled = false;
            button_guardar.Enabled = false;
            button_restaurar.Enabled = false;
            button_limpiar.Enabled = false;
            button_desconectar2.Enabled = false;
            button_teclado.Enabled = false;

            button_apagar.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;






            try
            {
                // esto lo debemos que quitar a la hora de enviar al microcontrolador.
                //serialPort_Form2.WriteLine("Debemos enviar las siguentes cadenas: \n");


                double voltafac, currafact;

                voltafac = Convert.ToDouble( factorVolt.Value);
                currafact= Convert.ToDouble(factorCurr.Value);
                //Siempre vamos a sumar 0.001 a voltafac y currafactpara asegurar que siempre se envien los 3 puntos decimales 

                //**************************************************






                //Correccion para corrientes


                //Siempre vamos a sumar 0.001 a voltafac y currafactpara asegurar que siempre se envien los 3 puntos decimales 


                //**************************************************





                // factorv = Convert.ToString(factorVolt.Value);// COVNERTIMOS LOS VALORES A STRING
                //factorc = Convert.ToString(factorCurr.Value);// COVNERTIMOS LOS VALORES A STRING

                //serialPort_Form2.WriteLine("F0 C0 \n");

                serialPort_Form2.WriteLine("X");// COMANDO PARA QUE PUEDA LEER LOS COMANDOS DE 3 CARACTERES
                Thread.Sleep(100);//delay


                serialPort_Form2.WriteLine("[V]");// COMANDO PARA QUE PUEDA LEER LOS COMANDOS DE 3 CARACTERES
                Thread.Sleep(100);//delay



               
                serialPort_Form2.WriteLine(String.Format("{0:F3},{1:F3}", voltafac, currafact));
                Thread.Sleep(1000);//delay
               // serialPort_Form2.WriteLine("[N]");// COMANDO PARA QUE PUEDA LEER LOS COMANDOS DE 3 CARACTERES
                //Thread.Sleep(100);//delay
            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);



            }

            Thread.Sleep(2000);//delay
            button_leer.Enabled = true;
            button_calcular.Enabled = true;
            button_guardar.Enabled = true;
            button_restaurar.Enabled = true;
            button_limpiar.Enabled = true;
            button_desconectar2.Enabled = true;
            button_teclado.Enabled = true;
            button_apagar.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


        }

        private void label201_Click(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();//creamos un nuevo form
            this.Hide();//escondemos el form 1
            f1.ShowDialog();//mostramos form2
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Valor minimo que puede introducir:1300.\nValor maximo que se puede introducir:9999\nValor 1300 equivale a 13% DC\nValor 9999 equivale a 99% DC");
        }

        private void label199_Click(object sender, EventArgs e)
        {

        }

        private void label203_Click(object sender, EventArgs e)
        {

        }

        private void label204_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (serialPort_Form2.IsOpen)


            {

                button_leer.Enabled = false;
                button_calcular.Enabled = false;
                button_guardar.Enabled = false;
                button_restaurar.Enabled = false;
                button_limpiar.Enabled = false;
                button_desconectar2.Enabled = false;
                button_teclado.Enabled = false;

                button_apagar.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;



                try

                {




                    serialPort_Form2.WriteLine("X");// COMANDO PARA QUE PUEDA LEER LOS COMANDOS DE 3 CARACTERES
                    Thread.Sleep(1000);//delay

                    serialPort_Form2.DiscardInBuffer();//descartamos el buffer de entrada si es que esta llegnado algo
                    serialPort_Form2.WriteLine("[T]");

                    SerialDataIn = serialPort_Form2.ReadLine();
                    //SerialDataIn = serialPort_Form2.ReadExisting();

                    //********************************************************************************************

                    Thread.Sleep(1000);//delay
                    Serial_IndexVolt();//realizamos la index

                    Thread.Sleep(300);//delay
                    serialPort_Form2.WriteLine("[N]");//indicamos que debe de volver a leer comandos de 1 caracter  
                    Thread.Sleep(500);//delay


                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }


                button_leer.Enabled = true;
                button_calcular.Enabled = true;
                button_guardar.Enabled = true;
                button_restaurar.Enabled = true;
                button_limpiar.Enabled = true;
                button_desconectar2.Enabled = true;
                button_teclado.Enabled = true;
                button_apagar.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //TextBox_Resultados.Text = string.Empty;//limpiamos el textbox


            button_guardar.Enabled = false;
            tempTextBox.Text = String.Empty;
            voltTextBox.Text = String.Empty;
            If0TextBox.Text = String.Empty;
            f0.Text = String.Empty;
            f1.Text = String.Empty;
            f2.Text= String.Empty;
            /*------------------------------------------------------------------------------------------*/

            TextBox_F0_Campo0_mA_Max.Text = String.Empty;

            TextBox_F0_Campo0_mA_Min.Text = String.Empty;


            TextBox_F0_Campo1_mA_Max.Text = String.Empty;
            TextBox_F0_Campo1_mA_Min.Text = String.Empty;


            TextBox_F0_Campo2_mA_Max.Text = String.Empty;
            TextBox_F0_Campo2_mA_Min.Text = String.Empty;


            TextBox_F0_Campo3_mA_Max.Text = String.Empty;
            TextBox_F0_Campo3_mA_Min.Text = String.Empty;


            TextBox_F0_Campo4_mA_Max.Text = String.Empty;
            TextBox_F0_Campo4_mA_Min.Text = String.Empty;


            /*------------------------------------------------------------------------------------------*/

            TextBox_F1_Campo0_mA_Max.Text = String.Empty;
            TextBox_F1_Campo0_mA_Min.Text = String.Empty;


            TextBox_F1_Campo1_mA_Max.Text = String.Empty;
            TextBox_F1_Campo1_mA_Min.Text = String.Empty;


            TextBox_F1_Campo2_mA_Max.Text = String.Empty;
            TextBox_F1_Campo2_mA_Min.Text = String.Empty;


            TextBox_F1_Campo3_mA_Max.Text = String.Empty;
            TextBox_F1_Campo3_mA_Min.Text = String.Empty;


            TextBox_F1_Campo4_mA_Max.Text = String.Empty;
            TextBox_F1_Campo4_mA_Min.Text = String.Empty;





            /*------------------------------------------------------------------------------------------*/

            TextBox_F2_Campo0_mA_Max.Text = String.Empty;
            TextBox_F2_Campo0_mA_Min.Text = String.Empty;


            TextBox_F2_Campo1_mA_Max.Text = String.Empty;
            TextBox_F2_Campo1_mA_Min.Text = String.Empty;


            TextBox_F2_Campo2_mA_Max.Text = String.Empty;
            TextBox_F2_Campo2_mA_Min.Text = String.Empty;


            TextBox_F2_Campo3_mA_Max.Text = String.Empty;
            TextBox_F2_Campo3_mA_Min.Text = String.Empty;


            TextBox_F2_Campo4_mA_Max.Text = String.Empty;
            TextBox_F2_Campo4_mA_Min.Text = String.Empty;


            /*---------------------------------------------------------------------------------*/

            TextBox_DC_F0_Campo0_Max.Text = string.Empty;
            TextBox_DC_F0_Campo0_Min.Text = string.Empty;

            TextBox_DC_F0_Campo1_Max.Text = string.Empty;
            TextBox_DC_F0_Campo1_Min.Text = string.Empty;

            TextBox_DC_F0_Campo2_Max.Text = string.Empty;
            TextBox_DC_F0_Campo2_Min.Text = string.Empty;

            TextBox_DC_F0_Campo3_Max.Text = string.Empty;
            TextBox_DC_F0_Campo3_Min.Text = string.Empty;

            TextBox_DC_F0_Campo4_Max.Text = string.Empty;
            TextBox_DC_F0_Campo4_Min.Text = string.Empty;


            /*------------------------------------------------------------------------*/


            TextBox_DC_F1_Campo0_Max.Text = string.Empty;
            TextBox_DC_F1_Campo0_Min.Text = string.Empty;

            TextBox_DC_F1_Campo1_Max.Text = string.Empty;
            TextBox_DC_F1_Campo1_Min.Text = string.Empty;

            TextBox_DC_F1_Campo2_Max.Text = string.Empty;
            TextBox_DC_F1_Campo2_Min.Text = string.Empty;

            TextBox_DC_F1_Campo3_Max.Text = string.Empty;
            TextBox_DC_F1_Campo3_Min.Text = string.Empty;

            TextBox_DC_F1_Campo4_Max.Text = string.Empty;
            TextBox_DC_F1_Campo4_Min.Text = string.Empty;


            /*------------------------------------------------------------------------*/

            TextBox_DC_F2_Campo0_Max.Text = string.Empty;
            TextBox_DC_F2_Campo0_Min.Text = string.Empty;

            TextBox_DC_F2_Campo1_Max.Text = string.Empty;
            TextBox_DC_F2_Campo1_Min.Text = string.Empty;

            TextBox_DC_F2_Campo2_Max.Text = string.Empty;
            TextBox_DC_F2_Campo2_Min.Text = string.Empty;

            TextBox_DC_F2_Campo3_Max.Text = string.Empty;
            TextBox_DC_F2_Campo3_Min.Text = string.Empty;

            TextBox_DC_F2_Campo4_Max.Text = string.Empty;
            TextBox_DC_F2_Campo4_Min.Text = string.Empty;


            /*--------------------------------------------------------------------------------*/

            TextBox_F0_Campo0_Max.Text = String.Empty;
            TextBox_F0_Campo0_Min.Text = String.Empty;

            TextBox_F0_Campo1_Max.Text = String.Empty;
            TextBox_F0_Campo1_Min.Text = String.Empty;

            TextBox_F0_Campo2_Max.Text = String.Empty;
            TextBox_F0_Campo2_Min.Text = String.Empty;

            TextBox_F0_Campo3_Max.Text = String.Empty;
            TextBox_F0_Campo3_Min.Text = String.Empty;

            TextBox_F0_Campo4_Max.Text = String.Empty;
            TextBox_F0_Campo4_Min.Text = String.Empty;

            /*--------------------------------------------------------------------------------*/

            TextBox_F1_Campo0_Max.Text = String.Empty;
            TextBox_F1_Campo0_Min.Text = String.Empty;

            TextBox_F1_Campo1_Max.Text = String.Empty;
            TextBox_F1_Campo1_Min.Text = String.Empty;

            TextBox_F1_Campo2_Max.Text = String.Empty;
            TextBox_F1_Campo2_Min.Text = String.Empty;

            TextBox_F1_Campo3_Max.Text = String.Empty;
            TextBox_F1_Campo3_Min.Text = String.Empty;

            TextBox_F1_Campo4_Max.Text = String.Empty;
            TextBox_F1_Campo4_Min.Text = String.Empty;



            /*--------------------------------------------------------------------------------*/

            TextBox_F2_Campo0_Max.Text = String.Empty;
            TextBox_F2_Campo0_Min.Text = String.Empty;

            TextBox_F2_Campo1_Max.Text = String.Empty;
            TextBox_F2_Campo1_Min.Text = String.Empty;

            TextBox_F2_Campo2_Max.Text = String.Empty;
            TextBox_F2_Campo2_Min.Text = String.Empty;

            TextBox_F2_Campo3_Max.Text = String.Empty;
            TextBox_F2_Campo3_Min.Text = String.Empty;

            TextBox_F2_Campo4_Max.Text = String.Empty;
            TextBox_F2_Campo4_Min.Text = String.Empty;



            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F0 C0--------------------------------------*/
            TextBox_F0_Campo0_1.Text = String.Empty;
            TextBox_F0_Campo0_2.Text = String.Empty;
            TextBox_F0_Campo0_3.Text = String.Empty;
            TextBox_F0_Campo0_4.Text = String.Empty;
            TextBox_F0_Campo0_5.Text = String.Empty;
            TextBox_F0_Campo0_6.Text = String.Empty;
            TextBox_F0_Campo0_7.Text = String.Empty;
            TextBox_F0_Campo0_8.Text = String.Empty;

            TextBox_DC_F0_Campo0_1.Text = String.Empty;
            TextBox_DC_F0_Campo0_2.Text = String.Empty;
            TextBox_DC_F0_Campo0_3.Text = String.Empty;
            TextBox_DC_F0_Campo0_4.Text = String.Empty;
            TextBox_DC_F0_Campo0_5.Text = String.Empty;
            TextBox_DC_F0_Campo0_6.Text = String.Empty;
            TextBox_DC_F0_Campo0_7.Text = String.Empty;
            TextBox_DC_F0_Campo0_8.Text = String.Empty;

            TextBox_F0_C0_mA_1.Text = String.Empty;
            TextBox_F0_C0_mA_2.Text = String.Empty;
            TextBox_F0_C0_mA_3.Text = String.Empty;
            TextBox_F0_C0_mA_4.Text = String.Empty;
            TextBox_F0_C0_mA_5.Text = String.Empty;
            TextBox_F0_C0_mA_6.Text = String.Empty;
            TextBox_F0_C0_mA_7.Text = String.Empty;
            TextBox_F0_C0_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F0 C1--------------------------------------*/
            TextBox_F0_Campo1_1.Text = String.Empty;
            TextBox_F0_Campo1_2.Text = String.Empty;
            TextBox_F0_Campo1_3.Text = String.Empty;
            TextBox_F0_Campo1_4.Text = String.Empty;
            TextBox_F0_Campo1_5.Text = String.Empty;
            TextBox_F0_Campo1_6.Text = String.Empty;
            TextBox_F0_Campo1_7.Text = String.Empty;
            TextBox_F0_Campo1_8.Text = String.Empty;

            TextBox_DC_F0_Campo1_1.Text = String.Empty;
            TextBox_DC_F0_Campo1_2.Text = String.Empty;
            TextBox_DC_F0_Campo1_3.Text = String.Empty;
            TextBox_DC_F0_Campo1_4.Text = String.Empty;
            TextBox_DC_F0_Campo1_5.Text = String.Empty;
            TextBox_DC_F0_Campo1_6.Text = String.Empty;
            TextBox_DC_F0_Campo1_7.Text = String.Empty;
            TextBox_DC_F0_Campo1_8.Text = String.Empty;

            TextBox_F0_C1_mA_1.Text = String.Empty;
            TextBox_F0_C1_mA_2.Text = String.Empty;
            TextBox_F0_C1_mA_3.Text = String.Empty;
            TextBox_F0_C1_mA_4.Text = String.Empty;
            TextBox_F0_C1_mA_5.Text = String.Empty;
            TextBox_F0_C1_mA_6.Text = String.Empty;
            TextBox_F0_C1_mA_7.Text = String.Empty;
            TextBox_F0_C1_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F0 C2--------------------------------------*/
            TextBox_F0_Campo2_1.Text = String.Empty;
            TextBox_F0_Campo2_2.Text = String.Empty;
            TextBox_F0_Campo2_3.Text = String.Empty;
            TextBox_F0_Campo2_4.Text = String.Empty;
            TextBox_F0_Campo2_5.Text = String.Empty;
            TextBox_F0_Campo2_6.Text = String.Empty;
            TextBox_F0_Campo2_7.Text = String.Empty;
            TextBox_F0_Campo2_8.Text = String.Empty;

            TextBox_DC_F0_Campo2_1.Text = String.Empty;
            TextBox_DC_F0_Campo2_2.Text = String.Empty;
            TextBox_DC_F0_Campo2_3.Text = String.Empty;
            TextBox_DC_F0_Campo2_4.Text = String.Empty;
            TextBox_DC_F0_Campo2_5.Text = String.Empty;
            TextBox_DC_F0_Campo2_6.Text = String.Empty;
            TextBox_DC_F0_Campo2_7.Text = String.Empty;
            TextBox_DC_F0_Campo2_8.Text = String.Empty;

            TextBox_F0_C2_mA_1.Text = String.Empty;
            TextBox_F0_C2_mA_2.Text = String.Empty;
            TextBox_F0_C2_mA_3.Text = String.Empty;
            TextBox_F0_C2_mA_4.Text = String.Empty;
            TextBox_F0_C2_mA_5.Text = String.Empty;
            TextBox_F0_C2_mA_6.Text = String.Empty;
            TextBox_F0_C2_mA_7.Text = String.Empty;
            TextBox_F0_C2_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F0 C3--------------------------------------*/
            TextBox_F0_Campo3_1.Text = String.Empty;
            TextBox_F0_Campo3_2.Text = String.Empty;
            TextBox_F0_Campo3_3.Text = String.Empty;
            TextBox_F0_Campo3_4.Text = String.Empty;
            TextBox_F0_Campo3_5.Text = String.Empty;
            TextBox_F0_Campo3_6.Text = String.Empty;
            TextBox_F0_Campo3_7.Text = String.Empty;
            TextBox_F0_Campo3_8.Text = String.Empty;

            TextBox_DC_F0_Campo3_1.Text = String.Empty;
            TextBox_DC_F0_Campo3_2.Text = String.Empty;
            TextBox_DC_F0_Campo3_3.Text = String.Empty;
            TextBox_DC_F0_Campo3_4.Text = String.Empty;
            TextBox_DC_F0_Campo3_5.Text = String.Empty;
            TextBox_DC_F0_Campo3_6.Text = String.Empty;
            TextBox_DC_F0_Campo3_7.Text = String.Empty;
            TextBox_DC_F0_Campo3_8.Text = String.Empty;

            TextBox_F0_C3_mA_1.Text = String.Empty;
            TextBox_F0_C3_mA_2.Text = String.Empty;
            TextBox_F0_C3_mA_3.Text = String.Empty;
            TextBox_F0_C3_mA_4.Text = String.Empty;
            TextBox_F0_C3_mA_5.Text = String.Empty;
            TextBox_F0_C3_mA_6.Text = String.Empty;
            TextBox_F0_C3_mA_7.Text = String.Empty;
            TextBox_F0_C3_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F0 C4--------------------------------------*/
            TextBox_F0_Campo4_1.Text = String.Empty;
            TextBox_F0_Campo4_2.Text = String.Empty;
            TextBox_F0_Campo4_3.Text = String.Empty;
            TextBox_F0_Campo4_4.Text = String.Empty;
            TextBox_F0_Campo4_5.Text = String.Empty;
            TextBox_F0_Campo4_6.Text = String.Empty;
            TextBox_F0_Campo4_7.Text = String.Empty;
            TextBox_F0_Campo4_8.Text = String.Empty;

            TextBox_DC_F0_Campo4_1.Text = String.Empty;
            TextBox_DC_F0_Campo4_2.Text = String.Empty;
            TextBox_DC_F0_Campo4_3.Text = String.Empty;
            TextBox_DC_F0_Campo4_4.Text = String.Empty;
            TextBox_DC_F0_Campo4_5.Text = String.Empty;
            TextBox_DC_F0_Campo4_6.Text = String.Empty;
            TextBox_DC_F0_Campo4_7.Text = String.Empty;
            TextBox_DC_F0_Campo4_8.Text = String.Empty;

            TextBox_F0_C4_mA_1.Text = String.Empty;
            TextBox_F0_C4_mA_2.Text = String.Empty;
            TextBox_F0_C4_mA_3.Text = String.Empty;
            TextBox_F0_C4_mA_4.Text = String.Empty;
            TextBox_F0_C4_mA_5.Text = String.Empty;
            TextBox_F0_C4_mA_6.Text = String.Empty;
            TextBox_F0_C4_mA_7.Text = String.Empty;
            TextBox_F0_C4_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F1 C0--------------------------------------*/
            TextBox_F1_Campo0_1.Text = String.Empty;
            TextBox_F1_Campo0_2.Text = String.Empty;
            TextBox_F1_Campo0_3.Text = String.Empty;
            TextBox_F1_Campo0_4.Text = String.Empty;
            TextBox_F1_Campo0_5.Text = String.Empty;
            TextBox_F1_Campo0_6.Text = String.Empty;
            TextBox_F1_Campo0_7.Text = String.Empty;
            TextBox_F1_Campo0_8.Text = String.Empty;

            TextBox_DC_F1_Campo0_1.Text = String.Empty;
            TextBox_DC_F1_Campo0_2.Text = String.Empty;
            TextBox_DC_F1_Campo0_3.Text = String.Empty;
            TextBox_DC_F1_Campo0_4.Text = String.Empty;
            TextBox_DC_F1_Campo0_5.Text = String.Empty;
            TextBox_DC_F1_Campo0_6.Text = String.Empty;
            TextBox_DC_F1_Campo0_7.Text = String.Empty;
            TextBox_DC_F1_Campo0_8.Text = String.Empty;

            TextBox_F1_C0_mA_1.Text = String.Empty;
            TextBox_F1_C0_mA_2.Text = String.Empty;
            TextBox_F1_C0_mA_3.Text = String.Empty;
            TextBox_F1_C0_mA_4.Text = String.Empty;
            TextBox_F1_C0_mA_5.Text = String.Empty;
            TextBox_F1_C0_mA_6.Text = String.Empty;
            TextBox_F1_C0_mA_7.Text = String.Empty;
            TextBox_F1_C0_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F1 C1--------------------------------------*/
            TextBox_F1_Campo1_1.Text = String.Empty;
            TextBox_F1_Campo1_2.Text = String.Empty;
            TextBox_F1_Campo1_3.Text = String.Empty;
            TextBox_F1_Campo1_4.Text = String.Empty;
            TextBox_F1_Campo1_5.Text = String.Empty;
            TextBox_F1_Campo1_6.Text = String.Empty;
            TextBox_F1_Campo1_7.Text = String.Empty;
            TextBox_F1_Campo1_8.Text = String.Empty;

            TextBox_DC_F1_Campo1_1.Text = String.Empty;
            TextBox_DC_F1_Campo1_2.Text = String.Empty;
            TextBox_DC_F1_Campo1_3.Text = String.Empty;
            TextBox_DC_F1_Campo1_4.Text = String.Empty;
            TextBox_DC_F1_Campo1_5.Text = String.Empty;
            TextBox_DC_F1_Campo1_6.Text = String.Empty;
            TextBox_DC_F1_Campo1_7.Text = String.Empty;
            TextBox_DC_F1_Campo1_8.Text = String.Empty;

            TextBox_F1_C1_mA_1.Text = String.Empty;
            TextBox_F1_C1_mA_2.Text = String.Empty;
            TextBox_F1_C1_mA_3.Text = String.Empty;
            TextBox_F1_C1_mA_4.Text = String.Empty;
            TextBox_F1_C1_mA_5.Text = String.Empty;
            TextBox_F1_C1_mA_6.Text = String.Empty;
            TextBox_F1_C1_mA_7.Text = String.Empty;
            TextBox_F1_C1_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F1 C2--------------------------------------*/
            TextBox_F1_Campo2_1.Text = String.Empty;
            TextBox_F1_Campo2_2.Text = String.Empty;
            TextBox_F1_Campo2_3.Text = String.Empty;
            TextBox_F1_Campo2_4.Text = String.Empty;
            TextBox_F1_Campo2_5.Text = String.Empty;
            TextBox_F1_Campo2_6.Text = String.Empty;
            TextBox_F1_Campo2_7.Text = String.Empty;
            TextBox_F1_Campo2_8.Text = String.Empty;

            TextBox_DC_F1_Campo2_1.Text = String.Empty;
            TextBox_DC_F1_Campo2_2.Text = String.Empty;
            TextBox_DC_F1_Campo2_3.Text = String.Empty;
            TextBox_DC_F1_Campo2_4.Text = String.Empty;
            TextBox_DC_F1_Campo2_5.Text = String.Empty;
            TextBox_DC_F1_Campo2_6.Text = String.Empty;
            TextBox_DC_F1_Campo2_7.Text = String.Empty;
            TextBox_DC_F1_Campo2_8.Text = String.Empty;

            TextBox_F1_C2_mA_1.Text = String.Empty;
            TextBox_F1_C2_mA_2.Text = String.Empty;
            TextBox_F1_C2_mA_3.Text = String.Empty;
            TextBox_F1_C2_mA_4.Text = String.Empty;
            TextBox_F1_C2_mA_5.Text = String.Empty;
            TextBox_F1_C2_mA_6.Text = String.Empty;
            TextBox_F1_C2_mA_7.Text = String.Empty;
            TextBox_F1_C2_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F1 C3--------------------------------------*/
            TextBox_F1_Campo3_1.Text = String.Empty;
            TextBox_F1_Campo3_2.Text = String.Empty;
            TextBox_F1_Campo3_3.Text = String.Empty;
            TextBox_F1_Campo3_4.Text = String.Empty;
            TextBox_F1_Campo3_5.Text = String.Empty;
            TextBox_F1_Campo3_6.Text = String.Empty;
            TextBox_F1_Campo3_7.Text = String.Empty;
            TextBox_F1_Campo3_8.Text = String.Empty;

            TextBox_DC_F1_Campo3_1.Text = String.Empty;
            TextBox_DC_F1_Campo3_2.Text = String.Empty;
            TextBox_DC_F1_Campo3_3.Text = String.Empty;
            TextBox_DC_F1_Campo3_4.Text = String.Empty;
            TextBox_DC_F1_Campo3_5.Text = String.Empty;
            TextBox_DC_F1_Campo3_6.Text = String.Empty;
            TextBox_DC_F1_Campo3_7.Text = String.Empty;
            TextBox_DC_F1_Campo3_8.Text = String.Empty;

            TextBox_F1_C3_mA_1.Text = String.Empty;
            TextBox_F1_C3_mA_2.Text = String.Empty;
            TextBox_F1_C3_mA_3.Text = String.Empty;
            TextBox_F1_C3_mA_4.Text = String.Empty;
            TextBox_F1_C3_mA_5.Text = String.Empty;
            TextBox_F1_C3_mA_6.Text = String.Empty;
            TextBox_F1_C3_mA_7.Text = String.Empty;
            TextBox_F1_C3_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F1 C4--------------------------------------*/
            TextBox_F1_Campo4_1.Text = String.Empty;
            TextBox_F1_Campo4_2.Text = String.Empty;
            TextBox_F1_Campo4_3.Text = String.Empty;
            TextBox_F1_Campo4_4.Text = String.Empty;
            TextBox_F1_Campo4_5.Text = String.Empty;
            TextBox_F1_Campo4_6.Text = String.Empty;
            TextBox_F1_Campo4_7.Text = String.Empty;
            TextBox_F1_Campo4_8.Text = String.Empty;

            TextBox_DC_F1_Campo4_1.Text = String.Empty;
            TextBox_DC_F1_Campo4_2.Text = String.Empty;
            TextBox_DC_F1_Campo4_3.Text = String.Empty;
            TextBox_DC_F1_Campo4_4.Text = String.Empty;
            TextBox_DC_F1_Campo4_5.Text = String.Empty;
            TextBox_DC_F1_Campo4_6.Text = String.Empty;
            TextBox_DC_F1_Campo4_7.Text = String.Empty;
            TextBox_DC_F1_Campo4_8.Text = String.Empty;

            TextBox_F1_C4_mA_1.Text = String.Empty;
            TextBox_F1_C4_mA_2.Text = String.Empty;
            TextBox_F1_C4_mA_3.Text = String.Empty;
            TextBox_F1_C4_mA_4.Text = String.Empty;
            TextBox_F1_C4_mA_5.Text = String.Empty;
            TextBox_F1_C4_mA_6.Text = String.Empty;
            TextBox_F1_C4_mA_7.Text = String.Empty;
            TextBox_F1_C4_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F2 C0--------------------------------------*/
            TextBox_F2_Campo0_1.Text = String.Empty;
            TextBox_F2_Campo0_2.Text = String.Empty;
            TextBox_F2_Campo0_3.Text = String.Empty;
            TextBox_F2_Campo0_4.Text = String.Empty;
            TextBox_F2_Campo0_5.Text = String.Empty;
            TextBox_F2_Campo0_6.Text = String.Empty;
            TextBox_F2_Campo0_7.Text = String.Empty;
            TextBox_F2_Campo0_8.Text = String.Empty;

            TextBox_DC_F2_Campo0_1.Text = String.Empty;
            TextBox_DC_F2_Campo0_2.Text = String.Empty;
            TextBox_DC_F2_Campo0_3.Text = String.Empty;
            TextBox_DC_F2_Campo0_4.Text = String.Empty;
            TextBox_DC_F2_Campo0_5.Text = String.Empty;
            TextBox_DC_F2_Campo0_6.Text = String.Empty;
            TextBox_DC_F2_Campo0_7.Text = String.Empty;
            TextBox_DC_F2_Campo0_8.Text = String.Empty;

            TextBox_F2_C0_mA_1.Text = String.Empty;
            TextBox_F2_C0_mA_2.Text = String.Empty;
            TextBox_F2_C0_mA_3.Text = String.Empty;
            TextBox_F2_C0_mA_4.Text = String.Empty;
            TextBox_F2_C0_mA_5.Text = String.Empty;
            TextBox_F2_C0_mA_6.Text = String.Empty;
            TextBox_F2_C0_mA_7.Text = String.Empty;
            TextBox_F2_C0_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F2 C1--------------------------------------*/
            TextBox_F2_Campo1_1.Text = String.Empty;
            TextBox_F2_Campo1_2.Text = String.Empty;
            TextBox_F2_Campo1_3.Text = String.Empty;
            TextBox_F2_Campo1_4.Text = String.Empty;
            TextBox_F2_Campo1_5.Text = String.Empty;
            TextBox_F2_Campo1_6.Text = String.Empty;
            TextBox_F2_Campo1_7.Text = String.Empty;
            TextBox_F2_Campo1_8.Text = String.Empty;

            TextBox_DC_F2_Campo1_1.Text = String.Empty;
            TextBox_DC_F2_Campo1_2.Text = String.Empty;
            TextBox_DC_F2_Campo1_3.Text = String.Empty;
            TextBox_DC_F2_Campo1_4.Text = String.Empty;
            TextBox_DC_F2_Campo1_5.Text = String.Empty;
            TextBox_DC_F2_Campo1_6.Text = String.Empty;
            TextBox_DC_F2_Campo1_7.Text = String.Empty;
            TextBox_DC_F2_Campo1_8.Text = String.Empty;

            TextBox_F2_C1_mA_1.Text = String.Empty;
            TextBox_F2_C1_mA_2.Text = String.Empty;
            TextBox_F2_C1_mA_3.Text = String.Empty;
            TextBox_F2_C1_mA_4.Text = String.Empty;
            TextBox_F2_C1_mA_5.Text = String.Empty;
            TextBox_F2_C1_mA_6.Text = String.Empty;
            TextBox_F2_C1_mA_7.Text = String.Empty;
            TextBox_F2_C1_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F2 C2--------------------------------------*/
            TextBox_F2_Campo2_1.Text = String.Empty;
            TextBox_F2_Campo2_2.Text = String.Empty;
            TextBox_F2_Campo2_3.Text = String.Empty;
            TextBox_F2_Campo2_4.Text = String.Empty;
            TextBox_F2_Campo2_5.Text = String.Empty;
            TextBox_F2_Campo2_6.Text = String.Empty;
            TextBox_F2_Campo2_7.Text = String.Empty;
            TextBox_F2_Campo2_8.Text = String.Empty;

            TextBox_DC_F2_Campo2_1.Text = String.Empty;
            TextBox_DC_F2_Campo2_2.Text = String.Empty;
            TextBox_DC_F2_Campo2_3.Text = String.Empty;
            TextBox_DC_F2_Campo2_4.Text = String.Empty;
            TextBox_DC_F2_Campo2_5.Text = String.Empty;
            TextBox_DC_F2_Campo2_6.Text = String.Empty;
            TextBox_DC_F2_Campo2_7.Text = String.Empty;
            TextBox_DC_F2_Campo2_8.Text = String.Empty;

            TextBox_F2_C2_mA_1.Text = String.Empty;
            TextBox_F2_C2_mA_2.Text = String.Empty;
            TextBox_F2_C2_mA_3.Text = String.Empty;
            TextBox_F2_C2_mA_4.Text = String.Empty;
            TextBox_F2_C2_mA_5.Text = String.Empty;
            TextBox_F2_C2_mA_6.Text = String.Empty;
            TextBox_F2_C2_mA_7.Text = String.Empty;
            TextBox_F2_C2_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F2 C3--------------------------------------*/
            TextBox_F2_Campo3_1.Text = String.Empty;
            TextBox_F2_Campo3_2.Text = String.Empty;
            TextBox_F2_Campo3_3.Text = String.Empty;
            TextBox_F2_Campo3_4.Text = String.Empty;
            TextBox_F2_Campo3_5.Text = String.Empty;
            TextBox_F2_Campo3_6.Text = String.Empty;
            TextBox_F2_Campo3_7.Text = String.Empty;
            TextBox_F2_Campo3_8.Text = String.Empty;

            TextBox_DC_F2_Campo3_1.Text = String.Empty;
            TextBox_DC_F2_Campo3_2.Text = String.Empty;
            TextBox_DC_F2_Campo3_3.Text = String.Empty;
            TextBox_DC_F2_Campo3_4.Text = String.Empty;
            TextBox_DC_F2_Campo3_5.Text = String.Empty;
            TextBox_DC_F2_Campo3_6.Text = String.Empty;
            TextBox_DC_F2_Campo3_7.Text = String.Empty;
            TextBox_DC_F2_Campo3_8.Text = String.Empty;

            TextBox_F2_C3_mA_1.Text = String.Empty;
            TextBox_F2_C3_mA_2.Text = String.Empty;
            TextBox_F2_C3_mA_3.Text = String.Empty;
            TextBox_F2_C3_mA_4.Text = String.Empty;
            TextBox_F2_C3_mA_5.Text = String.Empty;
            TextBox_F2_C3_mA_6.Text = String.Empty;
            TextBox_F2_C3_mA_7.Text = String.Empty;
            TextBox_F2_C3_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*----------------------------------F2 C4--------------------------------------*/
            TextBox_F2_Campo4_1.Text = String.Empty;
            TextBox_F2_Campo4_2.Text = String.Empty;
            TextBox_F2_Campo4_3.Text = String.Empty;
            TextBox_F2_Campo4_4.Text = String.Empty;
            TextBox_F2_Campo4_5.Text = String.Empty;
            TextBox_F2_Campo4_6.Text = String.Empty;
            TextBox_F2_Campo4_7.Text = String.Empty;
            TextBox_F2_Campo4_8.Text = String.Empty;

            TextBox_DC_F2_Campo4_1.Text = String.Empty;
            TextBox_DC_F2_Campo4_2.Text = String.Empty;
            TextBox_DC_F2_Campo4_3.Text = String.Empty;
            TextBox_DC_F2_Campo4_4.Text = String.Empty;
            TextBox_DC_F2_Campo4_5.Text = String.Empty;
            TextBox_DC_F2_Campo4_6.Text = String.Empty;
            TextBox_DC_F2_Campo4_7.Text = String.Empty;
            TextBox_DC_F2_Campo4_8.Text = String.Empty;

            TextBox_F2_C4_mA_1.Text = String.Empty;
            TextBox_F2_C4_mA_2.Text = String.Empty;
            TextBox_F2_C4_mA_3.Text = String.Empty;
            TextBox_F2_C4_mA_4.Text = String.Empty;
            TextBox_F2_C4_mA_5.Text = String.Empty;
            TextBox_F2_C4_mA_6.Text = String.Empty;
            TextBox_F2_C4_mA_7.Text = String.Empty;
            TextBox_F2_C4_mA_8.Text = String.Empty;
            /*-----------------------------------------------------------------------------*/



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (serialPort_Form2.IsOpen)
                {
                    serialPort_Form2.Close();//cerramos el puerto serie
                }


                

                Form1 f1 = new Form1();//creamos un nuevo form
                this.Hide();//escondemos el form 1
                f1.ShowDialog();//mostramos form2
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TextBox_F0_Campo0_Max.Text

            if (serialPort_Form2.IsOpen)
            {
                try

                {
                    serialPort_Form2.WriteLine("X");// COMANDO PARA QUE PUEDA LEER LOS COMANDOS DE 3 CARACTERES
                    Thread.Sleep(100);//delay

                    serialPort_Form2.DiscardInBuffer();//descartamos el buffer de entrada si es que esta llegnado algo
                    serialPort_Form2.WriteLine("[R]");

                    SerialDataIn = serialPort_Form2.ReadLine();
                    //SerialDataIn = serialPort_Form2.ReadExisting();

                    //********************************************************************************************


                    Serial_Index();//realizamos la index


                    serialPort_Form2.WriteLine("[N]");//indicamos que debe de volver a leer comandos de 1 caracter  
                    Thread.Sleep(100);//delay



                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }

            }


           

        }

        private void button3_Click(object sender, EventArgs e)
        {

            

            try {

                //primero preguntamos si alguna cadena esta vacia, si lo esta debemos rellenarla con cero.

                Preguntar_is_Vacio();// pregutnamos si los valores estan vacios, y si lo estan llenamos llenamos con los valores minimos establecidos. 
               

                LeerRegistro();//leemos los datos de registro.

                Preguntar_Menor_1300();// preguntamos si el registro es menor a 1300 pero mayor a 0
                Preguntar_Mayor_9999();//preguntamos si es mayor a 9999 y si es mayor seteamos a 9999



                Calcular_DC_MaxMin();// calculamos los valores de DC masximo y minimo
                mA_Max_Min_Cal();//calculamos ma maximo y minim   
                Calculo_Incremento();// PRIMERO CALUCLAMOS EL INCRMENTO 
                Calculo_mA();//calculamos los demas mA
                Calculo_Dc();// calculamos los valores de DC.
                Calcular_Registro();// calculamos los registros 

                // ahora debemos ver si registro maximo op minimo es == 0 entonces toda la tabla debe ser cero.
                Preguntar_Si_Cero();








                ImprimirDc();// imrpimrimos los valores en los textbox de DC
                Imprimir_mA();// imprimirmos mA maximo y minimo

                

                // AHORA LO TENEMOS QUE IMPRIMIR.


                Imprimir_mA_Tablas();// imrpimmos mA 

                
                Imprimir_Dc_Tablas();// imrpimos valores de tablas

               
                Imprimir_Reistro_Tablas();// imprimimos los valores de tablase de registro
                button_guardar.Enabled = true;//Habilitamos el boton



            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);


            }


        }

        private void TextBox_Resultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            button_leer.Enabled = false;
            button_calcular.Enabled = false;
            button_guardar.Enabled = false;
            button_restaurar.Enabled = false;
            button_limpiar.Enabled = false;
            button_desconectar2.Enabled = false;
            button_teclado.Enabled = false;

            button_apagar.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;




            try
            {
                // esto lo debemos que quitar a la hora de enviar al microcontrolador.
                //serialPort_Form2.WriteLine("Debemos enviar las siguentes cadenas: \n");



                //serialPort_Form2.WriteLine("F0 C0 \n");

                MessageBox.Show("No desconecte la CPU mientras se guardan los datos.Tiempo de grabado aproximado: 15 Segundos. CLICK en aceptar para coninuar.");
                Convertir_Entero();// convertimos a enteros
                Covnertir_a_String();//convertirmos enteros a string
                Imprimir_Valores_Registros();// ahora imprimirmos los valores
                Thread.Sleep(500);//delay
                serialPort_Form2.WriteLine("X");// 
                Thread.Sleep(500);//delay
                serialPort_Form2.WriteLine("$Z$");
                Thread.Sleep(2000);//delay.
                serialPort_Form2.WriteLine("[W]");
                Thread.Sleep(500);//delay
                MessageBox.Show("Datos guardados con éxito");

            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);



            }
            button_leer.Enabled = true;
            button_calcular.Enabled = true;
            button_guardar.Enabled = true;
            button_restaurar.Enabled = true;
            button_limpiar.Enabled = true;
            button_desconectar2.Enabled = true;
            button_teclado.Enabled = true;
            button_apagar.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            //label_Listo.Visible = false;




        }

        private void TextBox_F0_Campo3_Max_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

           
            //Guardando el valor minimo
            Registro_F0_C0[0] = 1590;// valor minimo
            Registro_F0_C0[9] = 4230;// valor maximo

            Registro_F0_C1[0] = 1570;
            Registro_F0_C1[9] = 2410;

            Registro_F0_C2[0] = 1470;
            Registro_F0_C2[9] = 3350;

            Registro_F0_C3[0] = 1360;
            Registro_F0_C3[9] = 2720;

            Registro_F0_C4[0] = 1300;
            Registro_F0_C4[9] = 1680;

            /*---------------------------------------------------------------------------------------*/
            Registro_F1_C0[0] = 0;
            Registro_F1_C0[9] = 0;

            Registro_F1_C1[0] = 1470;
            Registro_F1_C1[9] = 4190;

            Registro_F1_C2[0] = 1680;
            Registro_F1_C2[9] = 2930;

            Registro_F1_C3[0] = 1680;
            Registro_F1_C3[9] = 6499;

            Registro_F1_C4[0] = 2100;
            Registro_F1_C4[9] = 4400;

            /*----------------------------------------------------------------------------------------*/

            Registro_F2_C0[0] = 0;
            Registro_F2_C0[9] = 0;

            Registro_F2_C1[0] = 0;
            Registro_F2_C1[9] = 0;

            Registro_F2_C2[0] = 1360;
            Registro_F2_C2[9] = 2100;

            Registro_F2_C3[0] = 1890;
            Registro_F2_C3[9] = 3560;

            Registro_F2_C4[0] = 2520;
            Registro_F2_C4[9] = 7330;


            // ya que estan cargados los valores, procedemos a cargalos a lso text box

            TextBox_F0_Campo0_Min.Text = Registro_F0_C0[0].ToString();// cargamos el valor minimo
            TextBox_F0_Campo0_Max.Text = Registro_F0_C0[9].ToString();//cargamos el valor maximo

            TextBox_F0_Campo1_Min.Text = Registro_F0_C1[0].ToString();// cargamos el valor minimo
            TextBox_F0_Campo1_Max.Text = Registro_F0_C1[9].ToString();//cargamos el valor maximo

            TextBox_F0_Campo2_Min.Text = Registro_F0_C2[0].ToString();// cargamos el valor minimo
            TextBox_F0_Campo2_Max.Text = Registro_F0_C2[9].ToString();//cargamos el valor maximo

            TextBox_F0_Campo3_Min.Text = Registro_F0_C3[0].ToString();// cargamos el valor minimo
            TextBox_F0_Campo3_Max.Text = Registro_F0_C3[9].ToString();//cargamos el valor maximo

            TextBox_F0_Campo4_Min.Text = Registro_F0_C4[0].ToString();// cargamos el valor minimo
            TextBox_F0_Campo4_Max.Text = Registro_F0_C4[9].ToString();//cargamos el valor maximo
            /*----------------------------------------------------------------------------------------------------------*/



            TextBox_F1_Campo0_Min.Text = Registro_F1_C0[0].ToString();// cargamos el valor minimo
            TextBox_F1_Campo0_Max.Text = Registro_F1_C0[9].ToString();//cargamos el valor maximo

            TextBox_F1_Campo1_Min.Text = Registro_F1_C1[0].ToString();// cargamos el valor minimo
            TextBox_F1_Campo1_Max.Text = Registro_F1_C1[9].ToString();//cargamos el valor maximo

            TextBox_F1_Campo2_Min.Text = Registro_F1_C2[0].ToString();// cargamos el valor minimo
            TextBox_F1_Campo2_Max.Text = Registro_F1_C2[9].ToString();//cargamos el valor maximo

            TextBox_F1_Campo3_Min.Text = Registro_F1_C3[0].ToString();// cargamos el valor minimo
            TextBox_F1_Campo3_Max.Text = Registro_F1_C3[9].ToString();//cargamos el valor maximo

            TextBox_F1_Campo4_Min.Text = Registro_F1_C4[0].ToString();// cargamos el valor minimo
            TextBox_F1_Campo4_Max.Text = Registro_F1_C4[9].ToString();//cargamos el valor maximo
            /*----------------------------------------------------------------------------------------------------------*/





            TextBox_F2_Campo0_Min.Text = Registro_F2_C0[0].ToString();// cargamos el valor minimo
            TextBox_F2_Campo0_Max.Text = Registro_F2_C0[9].ToString();//cargamos el valor maximo

            TextBox_F2_Campo1_Min.Text = Registro_F2_C1[0].ToString();// cargamos el valor minimo
            TextBox_F2_Campo1_Max.Text = Registro_F2_C1[9].ToString();//cargamos el valor maximo

            TextBox_F2_Campo2_Min.Text = Registro_F2_C2[0].ToString();// cargamos el valor minimo
            TextBox_F2_Campo2_Max.Text = Registro_F2_C2[9].ToString();//cargamos el valor maximo

            TextBox_F2_Campo3_Min.Text = Registro_F2_C3[0].ToString();// cargamos el valor minimo
            TextBox_F2_Campo3_Max.Text = Registro_F2_C3[9].ToString();//cargamos el valor maximo

            TextBox_F2_Campo4_Min.Text = Registro_F2_C4[0].ToString();// cargamos el valor minimo
            TextBox_F2_Campo4_Max.Text = Registro_F2_C4[9].ToString();//cargamos el valor maximo
            /*----------------------------------------------------------------------------------------------------------*/









        }

        private void TextBox_DC_F0_Campo2_Max_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_DC_F0_Campo3_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button_apagar.Enabled = false;
            button_desconectar2.Enabled = false;
            button_teclado.Enabled = true;
            button_leer.Enabled = false;
            button_calcular.Enabled = false;
            button_guardar.Enabled = false;
            button_restaurar.Enabled = false;
            button_limpiar.Enabled = false;
            combo_baud.Text = "38400";
            string[] portList2 = SerialPort.GetPortNames();
            
            comboBox_port.Items.AddRange(portList2);//añadimos el array de los com conectados


            

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {



            System.Windows.Forms.Application.Exit();//INDICAMOS QUE QUEREMOS CERRAR LA APLICACIO
        }



        public void LeerRegistro() // Esta funcion lee los textbox de registro, los convierte en un valor numerico y guarda en vector
        {


            //Guardando el valor minimo
            Registro_F0_C0[0] = Convert.ToUInt16(TextBox_F0_Campo0_Min.Text);//Valor F0 C0 MIN
            Registro_F0_C0[9] = Convert.ToUInt16(TextBox_F0_Campo0_Max.Text);//Valor F0 C0 MAX

            Registro_F0_C1[0] = Convert.ToUInt16(TextBox_F0_Campo1_Min.Text);//Valor F0 C1 MIN
            Registro_F0_C1[9] = Convert.ToUInt16(TextBox_F0_Campo1_Max.Text);//Valor F0 C1 MAX

            Registro_F0_C2[0] = Convert.ToUInt16(TextBox_F0_Campo2_Min.Text);//Valor F0 C2 MIN
            Registro_F0_C2[9] = Convert.ToUInt16(TextBox_F0_Campo2_Max.Text);//Valor F0 C2 MAX

            Registro_F0_C3[0] = Convert.ToUInt16(TextBox_F0_Campo3_Min.Text);//Valor F0 C3 MIN
            Registro_F0_C3[9] = Convert.ToUInt16(TextBox_F0_Campo3_Max.Text);//Valor F0 C3 MAX

            Registro_F0_C4[0] = Convert.ToUInt16(TextBox_F0_Campo4_Min.Text);//Valor F0 C4 MIN
            Registro_F0_C4[9] = Convert.ToUInt16(TextBox_F0_Campo4_Max.Text);//Valor F0 C4 MAX

            /*---------------------------------------------------------------------------------------*/
            Registro_F1_C0[0] = Convert.ToUInt16(TextBox_F1_Campo0_Min.Text);//Valor F1 C0 MIN
            Registro_F1_C0[9] = Convert.ToUInt16(TextBox_F1_Campo0_Max.Text);//Valor F1 C0 MAX

            Registro_F1_C1[0] = Convert.ToUInt16(TextBox_F1_Campo1_Min.Text);//Valor F1 C1 MIN
            Registro_F1_C1[9] = Convert.ToUInt16(TextBox_F1_Campo1_Max.Text);//Valor F1 C1 MAX

            Registro_F1_C2[0] = Convert.ToUInt16(TextBox_F1_Campo2_Min.Text);//Valor F1 C2 MIN
            Registro_F1_C2[9] = Convert.ToUInt16(TextBox_F1_Campo2_Max.Text);//Valor F1 C2 MAX

            Registro_F1_C3[0] = Convert.ToUInt16(TextBox_F1_Campo3_Min.Text);//Valor F1 C3 MIN
            Registro_F1_C3[9] = Convert.ToUInt16(TextBox_F1_Campo3_Max.Text);//Valor F1 C3 MAX

            Registro_F1_C4[0] = Convert.ToUInt16(TextBox_F1_Campo4_Min.Text);//Valor F1 C4 MIN
            Registro_F1_C4[9] = Convert.ToUInt16(TextBox_F1_Campo4_Max.Text);//Valor F1 C4 MAX

            /*----------------------------------------------------------------------------------------*/

            Registro_F2_C0[0] = Convert.ToUInt16(TextBox_F2_Campo0_Min.Text);//Valor F1 C0 MIN
            Registro_F2_C0[9] = Convert.ToUInt16(TextBox_F2_Campo0_Max.Text);//Valor F1 C0 MAX

            Registro_F2_C1[0] = Convert.ToUInt16(TextBox_F2_Campo1_Min.Text);//Valor F1 C1 MIN
            Registro_F2_C1[9] = Convert.ToUInt16(TextBox_F2_Campo1_Max.Text);//Valor F1 C1 MAX

            Registro_F2_C2[0] = Convert.ToUInt16(TextBox_F2_Campo2_Min.Text);//Valor F1 C2 MIN
            Registro_F2_C2[9] = Convert.ToUInt16(TextBox_F2_Campo2_Max.Text);//Valor F1 C2 MAX

            Registro_F2_C3[0] = Convert.ToUInt16(TextBox_F2_Campo3_Min.Text);//Valor F1 C3 MIN
            Registro_F2_C3[9] = Convert.ToUInt16(TextBox_F2_Campo3_Max.Text);//Valor F1 C3 MAX

            Registro_F2_C4[0] = Convert.ToUInt16(TextBox_F2_Campo4_Min.Text);//Valor F1 C4 MIN
            Registro_F2_C4[9] = Convert.ToUInt16(TextBox_F2_Campo4_Max.Text);//Valor F1 C4 MAX


        }


        public void Calcular_DC_MaxMin()
        {


            //Ahora tenemos que calcular los porcentajes de ciclo util para F0

            DC_F0_C0[0] = (Registro_F0_C0[0] * 100) / 9999;// minimo de DC%
            DC_F0_C0[9] = (Registro_F0_C0[9] * 100) / 9999;// maximo de DC%

            DC_F0_C1[0] = (Registro_F0_C1[0] * 100) / 9999;// minimo de DC%
            DC_F0_C1[9] = (Registro_F0_C1[9] * 100) / 9999;// maximo de DC%

            DC_F0_C2[0] = (Registro_F0_C2[0] * 100) / 9999;// minimo de DC%
            DC_F0_C2[9] = (Registro_F0_C2[9] * 100) / 9999;// maximo de DC%

            DC_F0_C3[0] = (Registro_F0_C3[0] * 100) / 9999;// minimo de DC%
            DC_F0_C3[9] = (Registro_F0_C3[9] * 100) / 9999;// maximo de DC%

            DC_F0_C4[0] = (Registro_F0_C4[0] * 100) / 9999;// minimo de DC%
            DC_F0_C4[9] = (Registro_F0_C4[9] * 100) / 9999;// maximo de DC%

            // fin de obtener los porcentajes de ciclo util para F0


            //Ahora tenemos que calcular los porcentajes de ciclo util para F1

            DC_F1_C0[0] = (Registro_F1_C0[0] * 100) / 9999;// minimo de DC%
            DC_F1_C0[9] = (Registro_F1_C0[9] * 100) / 9999;// maximo de DC%

            DC_F1_C1[0] = (Registro_F1_C1[0] * 100) / 9999;// minimo de DC%
            DC_F1_C1[9] = (Registro_F1_C1[9] * 100) / 9999;// maximo de DC%

            DC_F1_C2[0] = (Registro_F1_C2[0] * 100) / 9999;// minimo de DC%
            DC_F1_C2[9] = (Registro_F1_C2[9] * 100) / 9999;// maximo de DC%

            DC_F1_C3[0] = (Registro_F1_C3[0] * 100) / 9999;// minimo de DC%
            DC_F1_C3[9] = (Registro_F1_C3[9] * 100) / 9999;// maximo de DC%

            DC_F1_C4[0] = (Registro_F1_C4[0] * 100) / 9999;// minimo de DC%
            DC_F1_C4[9] = (Registro_F1_C4[9] * 100) / 9999;// maximo de DC%

            // fin de obtener los porcentajes de ciclo util para F1




            //Ahora tenemos que calcular los porcentajes de ciclo util para F2

            DC_F2_C0[0] = (Registro_F2_C0[0] * 100) / 9999;// minimo de DC%
            DC_F2_C0[9] = (Registro_F2_C0[9] * 100) / 9999;// maximo de DC%

            DC_F2_C1[0] = (Registro_F2_C1[0] * 100) / 9999;// minimo de DC%
            DC_F2_C1[9] = (Registro_F2_C1[9] * 100) / 9999;// maximo de DC%

            DC_F2_C2[0] = (Registro_F2_C2[0] * 100) / 9999;// minimo de DC%
            DC_F2_C2[9] = (Registro_F2_C2[9] * 100) / 9999;// maximo de DC%

            DC_F2_C3[0] = (Registro_F2_C3[0] * 100) / 9999;// minimo de DC%
            DC_F2_C3[9] = (Registro_F2_C3[9] * 100) / 9999;// maximo de DC%

            DC_F2_C4[0] = (Registro_F2_C4[0] * 100) / 9999;// minimo de DC%
            DC_F2_C4[9] = (Registro_F2_C4[9] * 100) / 9999;// maximo de DC%

            // fin de obtener los porcentajes de ciclo util para F2



        }



        public void ImprimirDc()
        {
            //serialPort_Form2.WriteLine(String.Format("{0:F3},{1:F3}", voltafac, currafact));
            TextBox_DC_F0_Campo0_Min.Text =DC_F0_C0[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F0_Campo0_Max.Text = DC_F0_C0[9].ToString("N2");// imprimirmos el valor maximo 

            TextBox_DC_F0_Campo1_Min.Text = DC_F0_C1[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F0_Campo1_Max.Text = DC_F0_C1[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F0_Campo2_Min.Text = DC_F0_C2[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F0_Campo2_Max.Text = DC_F0_C2[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F0_Campo3_Min.Text = DC_F0_C3[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F0_Campo3_Max.Text = DC_F0_C3[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F0_Campo4_Min.Text =DC_F0_C4[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F0_Campo4_Max.Text = DC_F0_C4[9].ToString("N2");// imprimirmos el valor maximo 


            /*ahora para F1*/


            TextBox_DC_F1_Campo0_Min.Text = DC_F1_C0[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F1_Campo0_Max.Text = DC_F1_C0[9].ToString("N2");// imprimirmos el valor maximo 

            TextBox_DC_F1_Campo1_Min.Text = DC_F1_C1[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F1_Campo1_Max.Text = DC_F1_C1[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F1_Campo2_Min.Text = DC_F1_C2[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F1_Campo2_Max.Text = DC_F1_C2[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F1_Campo3_Min.Text = DC_F1_C3[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F1_Campo3_Max.Text =DC_F1_C3[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F1_Campo4_Min.Text = DC_F1_C4[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F1_Campo4_Max.Text = DC_F1_C4[9].ToString("N2");// imprimirmos el valor maximo 

            /*Ahora para campo F2 */



            TextBox_DC_F2_Campo0_Min.Text = DC_F2_C0[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F2_Campo0_Max.Text =DC_F2_C0[9].ToString("N2");// imprimirmos el valor maximo 

            TextBox_DC_F2_Campo1_Min.Text = DC_F2_C1[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F2_Campo1_Max.Text = DC_F2_C1[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F2_Campo2_Min.Text = DC_F2_C2[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F2_Campo2_Max.Text =DC_F2_C2[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F2_Campo3_Min.Text = DC_F2_C3[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F2_Campo3_Max.Text = DC_F2_C3[9].ToString("N2");// imprimirmos el valor maximo 


            TextBox_DC_F2_Campo4_Min.Text = DC_F2_C4[0].ToString("N2");// imprimirmos el valor minimo
            TextBox_DC_F2_Campo4_Max.Text = DC_F2_C4[9].ToString("N2");// imprimirmos el valor maximo 

        }

        public void mA_Max_Min_Cal()
        {


            mA_F0_C0[0] = (4.78f * DC_F0_C0[0] - 40.22f);// calculo de mA F0, C0 MIN
            mA_F0_C0[9] = (4.78f * DC_F0_C0[9] - 40.22f);// calculo de mA F0, C0 MAX


            mA_F0_C1[0] = (4.78f * DC_F0_C1[0] - 40.22f);// calculo de mA F0, C1 MIN
            mA_F0_C1[9] = (4.78f * DC_F0_C1[9] - 40.22f);// calculo de mA F0, C1 MAX


            mA_F0_C2[0] = (4.78f * DC_F0_C2[0] - 40.22f);// calculo de mA F0, C1 MIN
            mA_F0_C2[9] = (4.78f * DC_F0_C2[9] - 40.22f);// calculo de mA F0, C1 MAX


            mA_F0_C3[0] = (4.78f * DC_F0_C3[0] - 40.22f);// calculo de mA F0, C1 MIN
            mA_F0_C3[9] = (4.78f * DC_F0_C3[9] - 40.22f);// calculo de mA F0, C1 MAX

            mA_F0_C4[0] = (4.78f * DC_F0_C4[0] - 40.22f);// calculo de mA F0, C1 MIN
            mA_F0_C4[9] = (4.78f * DC_F0_C4[9] - 40.22f);// calculo de mA F0, C1 MAX

            /*-----------------------------------------------------------------------------------*/

            mA_F1_C0[0] = (4.78f * DC_F1_C0[0] - 40.22f);// calculo de mA F1, C0 MIN
            mA_F1_C0[9] = (4.78f * DC_F1_C0[9] - 40.22f);// calculo de mA F1, C0 MAX


            mA_F1_C1[0] = (4.78f * DC_F1_C1[0] - 40.22f);// calculo de mA F1, C1 MIN
            mA_F1_C1[9] = (4.78f * DC_F1_C1[9] - 40.22f);// calculo de mA F1, C1 MAX


            mA_F1_C2[0] = (4.78f * DC_F1_C2[0] - 40.22f);// calculo de mA F1, C1 MIN
            mA_F1_C2[9] = (4.78f * DC_F1_C2[9] - 40.22f);// calculo de mA F1, C1 MAX


            mA_F1_C3[0] = (4.78f * DC_F1_C3[0] - 40.22f);// calculo de mA F1, C1 MIN
            mA_F1_C3[9] = (4.78f * DC_F1_C3[9] - 40.22f);// calculo de mA F1, C1 MAX

            mA_F1_C4[0] = (4.78f * DC_F1_C4[0] - 40.22f);// calculo de mA F1, C1 MIN
            mA_F1_C4[9] = (4.78f * DC_F1_C4[9] - 40.22f);// calculo de mA F1, C1 MAX

            /*-----------------------------------------------------------------------------------*/

            mA_F2_C0[0] = (4.78f * DC_F2_C0[0] - 40.22f);// calculo de mA F2, C0 MIN
            mA_F2_C0[9] = (4.78f * DC_F2_C0[9] - 40.22f);// calculo de mA F2, C0 MAX


            mA_F2_C1[0] = (4.78f * DC_F2_C1[0] - 40.22f);// calculo de mA F2, C1 MIN
            mA_F2_C1[9] = (4.78f * DC_F2_C1[9] - 40.22f);// calculo de mA F2, C1 MAX


            mA_F2_C2[0] = (4.78f * DC_F2_C2[0] - 40.22f);// calculo de mA F2, C1 MIN
            mA_F2_C2[9] = (4.78f * DC_F2_C2[9] - 40.22f);// calculo de mA F2, C1 MAX


            mA_F2_C3[0] = (4.78f * DC_F2_C3[0] - 40.22f);// calculo de mA F2, C1 MIN
            mA_F2_C3[9] = (4.78f * DC_F2_C3[9] - 40.22f);// calculo de mA F2, C1 MAX

            mA_F2_C4[0] = (4.78f * DC_F2_C4[0] - 40.22f);// calculo de mA F2, C1 MIN
            mA_F2_C4[9] = (4.78f * DC_F2_C4[9] - 40.22f);// calculo de mA F2, C1 MAX


        }


        public void Imprimir_mA()
        {
            TextBox_F0_Campo0_mA_Max.Text = mA_F0_C0[0].ToString("N2");// imprimimos valor minimo
            TextBox_F0_Campo0_mA_Min.Text = mA_F0_C0[9].ToString("N2");// imprimimos valor minimo

            TextBox_F0_Campo1_mA_Max.Text = mA_F0_C1[0].ToString("N2");// imprimimos valor minimo
            TextBox_F0_Campo1_mA_Min.Text = mA_F0_C1[9].ToString("N2");// imprimimos valor minimo

            TextBox_F0_Campo2_mA_Max.Text = mA_F0_C2[0].ToString("N2");// imprimimos valor minimo
            TextBox_F0_Campo2_mA_Min.Text = mA_F0_C2[9].ToString("N2");// imprimimos valor minimo

            TextBox_F0_Campo3_mA_Max.Text =mA_F0_C3[0].ToString("N2");// imprimimos valor minimo
            TextBox_F0_Campo3_mA_Min.Text = mA_F0_C3[9].ToString("N2");// imprimimos valor minimo

            TextBox_F0_Campo4_mA_Max.Text = mA_F0_C4[0].ToString("N2");// imprimimos valor minimo
            TextBox_F0_Campo4_mA_Min.Text = mA_F0_C4[9].ToString("N2");// imprimimos valor minimo

            /*------------------------------------------------------------------------------------------------*/


            TextBox_F1_Campo0_mA_Max.Text = mA_F1_C0[0].ToString("N2");// imprimimos valor minimo
            TextBox_F1_Campo0_mA_Min.Text = mA_F1_C0[9].ToString("N2");// imprimimos valor minimo

            TextBox_F1_Campo1_mA_Max.Text = mA_F1_C1[0].ToString("N2");// imprimimos valor minimo
            TextBox_F1_Campo1_mA_Min.Text = mA_F1_C1[9].ToString("N2");// imprimimos valor minimo

            TextBox_F1_Campo2_mA_Max.Text = mA_F1_C2[0].ToString("N2");// imprimimos valor minimo
            TextBox_F1_Campo2_mA_Min.Text = mA_F1_C2[9].ToString("N2");// imprimimos valor minimo

            TextBox_F1_Campo3_mA_Max.Text = mA_F1_C3[0].ToString("N2");// imprimimos valor minimo
            TextBox_F1_Campo3_mA_Min.Text = mA_F1_C3[9].ToString("N2");// imprimimos valor minimo

            TextBox_F1_Campo4_mA_Max.Text = mA_F1_C4[0].ToString("N2");// imprimimos valor minimo
            TextBox_F1_Campo4_mA_Min.Text = mA_F1_C4[9].ToString("N2");// imprimimos valor minimo

            /*------------------------------------------------------------------------------------------------*/

            TextBox_F2_Campo0_mA_Max.Text = mA_F2_C0[0].ToString("N2");// imprimimos valor minimo
            TextBox_F2_Campo0_mA_Min.Text = mA_F2_C0[9].ToString("N2");// imprimimos valor minimo

            TextBox_F2_Campo1_mA_Max.Text = mA_F2_C1[0].ToString("N2");// imprimimos valor minimo
            TextBox_F2_Campo1_mA_Min.Text = mA_F2_C1[9].ToString("N2");// imprimimos valor minimo

            TextBox_F2_Campo2_mA_Max.Text = mA_F2_C2[0].ToString("N2");// imprimimos valor minimo
            TextBox_F2_Campo2_mA_Min.Text = mA_F2_C2[9].ToString("N2");// imprimimos valor minimo

            TextBox_F2_Campo3_mA_Max.Text = mA_F2_C3[0].ToString("N2");// imprimimos valor minimo
            TextBox_F2_Campo3_mA_Min.Text = mA_F2_C3[9].ToString("N2");// imprimimos valor minimo

            TextBox_F2_Campo4_mA_Max.Text = mA_F2_C4[0].ToString("N2");// imprimimos valor minimo
            TextBox_F2_Campo4_mA_Min.Text = mA_F2_C4[9].ToString("N2");// imprimimos valor minimo

            /*------------------------------------------------------------------------------------------------*/




        }


        public void Preguntar_Menor_1300()
        {

            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F0 MIN-----------------------------------------------*/

            if ((Registro_F0_C0[0] < 1300) && Registro_F0_C0[0] > 0)
            {
                Registro_F0_C0[0] = 1300;


            }

            if ((Registro_F0_C1[0] < 1300) && Registro_F0_C1[0] > 0)
            {
                Registro_F0_C1[0] = 1300;
            }

            if ((Registro_F0_C2[0] < 1300) && Registro_F0_C2[0] > 0)
            {
                Registro_F0_C2[0] = 1300;
            }

            if ((Registro_F0_C3[0] < 1300) && Registro_F0_C3[0] > 0)
            {
                Registro_F0_C3[0] = 1300;
            }

            if ((Registro_F0_C4[0] < 1300) && Registro_F0_C4[0] > 0)
            {
                Registro_F0_C4[0] = 1300;
            }

            /*--------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F1  MIN-----------------------------------------------*/

            if ((Registro_F1_C0[0] < 1300) && Registro_F1_C0[0] > 0)
            {
                Registro_F1_C0[0] = 1300;
            }

            if ((Registro_F1_C1[0] < 1300) && Registro_F1_C1[0] > 0)
            {
                Registro_F1_C1[0] = 1300;
            }

            if ((Registro_F1_C2[0] < 1300) && Registro_F1_C2[0] > 0)
            {
                Registro_F1_C2[0] = 1300;
            }

            if ((Registro_F1_C3[0] < 1300) && Registro_F1_C3[0] > 0)
            {
                Registro_F1_C3[0] = 1300;
            }

            if ((Registro_F1_C4[0] < 1300) && Registro_F1_C4[0] > 0)
            {
                Registro_F1_C4[0] = 1300;
            }

            /*--------------------------------------------------------------------------------------*/








            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F2  MIN-----------------------------------------------*/

            if ((Registro_F2_C0[0] < 1300) && Registro_F2_C0[0] > 0)
            {
                Registro_F2_C0[0] = 1300;
            }

            if ((Registro_F2_C1[0] < 1300) && Registro_F2_C1[0] > 0)
            {
                Registro_F2_C1[0] = 1300;
            }

            if ((Registro_F2_C2[0] < 1300) && Registro_F2_C2[0] > 0)
            {
                Registro_F2_C2[0] = 1300;
            }

            if ((Registro_F2_C3[0] < 1300) && Registro_F2_C3[0] > 0)
            {
                Registro_F2_C3[0] = 1300;
            }

            if ((Registro_F2_C4[0] < 1300) && Registro_F2_C4[0] > 0)
            {
                Registro_F2_C4[0] = 1300;
            }

            /*--------------------------------------------------------------------------------------*/




            /*---------------------------------------MAX-----------------------------------------------*/
            /*---------------------------------F0 MAX-----------------------------------------------*/

            if ((Registro_F0_C0[9] < 1300) && Registro_F0_C0[9] > 0)
            {
                Registro_F0_C0[9] = 1300;
            }

            if ((Registro_F0_C1[9] < 1300) && Registro_F0_C1[9] > 0)
            {
                Registro_F0_C1[9] = 1300;
            }

            if ((Registro_F0_C2[9] < 1300) && Registro_F0_C2[9] > 0)
            {
                Registro_F0_C2[9] = 1300;
            }

            if ((Registro_F0_C3[9] < 1300) && Registro_F0_C3[9] > 0)
            {
                Registro_F0_C3[9] = 1300;
            }

            if ((Registro_F0_C4[9] < 1300) && Registro_F0_C4[9] > 0)
            {
                Registro_F0_C4[9] = 1300;
            }

            /*--------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F1  MAX-----------------------------------------------*/

            if ((Registro_F1_C0[9] < 1300) && Registro_F1_C0[9] > 0)
            {
                Registro_F1_C0[9] = 1300;
            }

            if ((Registro_F1_C1[9] < 1300) && Registro_F1_C1[9] > 0)
            {
                Registro_F1_C1[9] = 1300;
            }

            if ((Registro_F1_C2[9] < 1300) && Registro_F1_C2[9] > 0)
            {
                Registro_F1_C2[9] = 1300;
            }

            if ((Registro_F1_C3[9] < 1300) && Registro_F1_C3[9] > 0)
            {
                Registro_F1_C3[9] = 1300;
            }

            if ((Registro_F1_C4[9] < 1300) && Registro_F1_C4[9] > 0)
            {
                Registro_F1_C4[9] = 1300;
            }

            /*--------------------------------------------------------------------------------------*/








            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F2  MAX-----------------------------------------------*/

            if ((Registro_F2_C0[9] < 1300) && Registro_F2_C0[9] > 0)
            {
                Registro_F2_C0[9] = 1300;
            }

            if ((Registro_F2_C1[9] < 1300) && Registro_F2_C1[9] > 0)
            {
                Registro_F2_C1[9] = 1300;
            }

            if ((Registro_F2_C2[9] < 1300) && Registro_F2_C2[9] > 0)
            {
                Registro_F2_C2[9] = 1300;
            }

            if ((Registro_F2_C3[9] < 1300) && Registro_F2_C3[9] > 0)
            {
                Registro_F2_C3[9] = 1300;
            }

            if ((Registro_F2_C4[9] < 1300) && Registro_F2_C4[9] > 0)
            {
                Registro_F2_C4[9] = 1300;
            }

            /*--------------------------------------------------------------------------------------*/
        }

        public void Preguntar_is_Vacio()
        {


            /*--------------------------------------------------------------------------------------*/

            if (String.IsNullOrEmpty(TextBox_F0_Campo0_Max.Text))
            {
                TextBox_F0_Campo0_Max.Text = "4230";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo1_Max.Text))
            {
                TextBox_F0_Campo1_Max.Text = "2410";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo2_Max.Text))
            {
                TextBox_F0_Campo2_Max.Text = "3350";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo3_Max.Text))
            {
                TextBox_F0_Campo3_Max.Text = "2720";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo4_Max.Text))
            {
                TextBox_F0_Campo4_Max.Text = "1680";



            }



            /*-----------------------------------------------------*/

            if (String.IsNullOrEmpty(TextBox_F1_Campo0_Max.Text))
            {
                TextBox_F1_Campo0_Max.Text = "0";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo1_Max.Text))
            {
                TextBox_F1_Campo1_Max.Text = "4190";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo2_Max.Text))
            {
                TextBox_F1_Campo2_Max.Text = "2930";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo3_Max.Text))
            {
                TextBox_F1_Campo3_Max.Text = "6499";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo4_Max.Text))
            {
                TextBox_F1_Campo4_Max.Text = "4400";



            }

            /*-------------------------------------------------------*/



            if (String.IsNullOrEmpty(TextBox_F2_Campo0_Max.Text))
            {
                TextBox_F2_Campo0_Max.Text = "0";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo1_Max.Text))
            {
                TextBox_F2_Campo1_Max.Text = "0";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo2_Max.Text))
            {
                TextBox_F2_Campo2_Max.Text = "2100";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo3_Max.Text))
            {
                TextBox_F2_Campo3_Max.Text = "3560";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo4_Max.Text))
            {
                TextBox_F2_Campo4_Max.Text = "7330";



            }

            /*-------------------------------------------------------------------------------------------*/
            /*Ahora para valores minimos*/


            if (String.IsNullOrEmpty(TextBox_F0_Campo0_Min.Text))
            {
                TextBox_F0_Campo0_Min.Text = "1590";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo1_Min.Text))
            {
                TextBox_F0_Campo1_Min.Text = "1570";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo2_Min.Text))
            {
                TextBox_F0_Campo2_Min.Text = "1470";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo3_Min.Text))
            {
                TextBox_F0_Campo3_Min.Text = "1360";



            }


            if (String.IsNullOrEmpty(TextBox_F0_Campo4_Min.Text))
            {
                TextBox_F0_Campo4_Min.Text = "1300";



            }



            /*-----------------------------------------------------*/

            if (String.IsNullOrEmpty(TextBox_F1_Campo0_Min.Text))
            {
                TextBox_F1_Campo0_Min.Text = "0";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo1_Min.Text))
            {
                TextBox_F1_Campo1_Min.Text = "1470";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo2_Min.Text))
            {
                TextBox_F1_Campo2_Min.Text = "1680";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo3_Min.Text))
            {
                TextBox_F1_Campo3_Min.Text = "1680";



            }


            if (String.IsNullOrEmpty(TextBox_F1_Campo4_Min.Text))
            {
                TextBox_F1_Campo4_Min.Text = "2100";



            }

            /*-------------------------------------------------------*/



            if (String.IsNullOrEmpty(TextBox_F2_Campo0_Min.Text))
            {
                TextBox_F2_Campo0_Min.Text = "0";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo1_Min.Text))
            {
                TextBox_F2_Campo1_Min.Text = "0";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo2_Min.Text))
            {
                TextBox_F2_Campo2_Min.Text = "1360";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo3_Min.Text))
            {
                TextBox_F2_Campo3_Min.Text = "1890";



            }


            if (String.IsNullOrEmpty(TextBox_F2_Campo4_Min.Text))
            {
                TextBox_F2_Campo4_Min.Text = "2520";



            }


            /*Fin para valores minimos*/
            /*-------------------------------------------------------------------------------------------*/








        }

        public void Calculo_Incremento()
        {
            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C0--------------------------------------------------------*/
            

            Incremento_F0_C0[0] = 0;
            Incremento_F0_C0[1] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9) - 1;
            Incremento_F0_C0[2] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9);
            Incremento_F0_C0[3] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9);
            Incremento_F0_C0[4] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9);
            Incremento_F0_C0[5] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9) - 1;
            Incremento_F0_C0[6] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9);
            Incremento_F0_C0[7] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9);
            Incremento_F0_C0[8] = ((mA_F0_C0[9] - mA_F0_C0[0]) / 9);
            Incremento_F0_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C1--------------------------------------------------------*/
            Incremento_F0_C1[0] = 0;
            Incremento_F0_C1[1] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9) - 1);
            Incremento_F0_C1[2] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[3] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[4] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[5] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[5] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9) - 1);
            Incremento_F0_C1[6] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[7] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[8] = (((mA_F0_C1[9] - mA_F0_C1[0]) / 9));
            Incremento_F0_C1[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C2--------------------------------------------------------*/
            Incremento_F0_C2[0] = 0;
            Incremento_F0_C2[1] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9) - 1);
            Incremento_F0_C2[2] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9));
            Incremento_F0_C2[3] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9));
            Incremento_F0_C2[4] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9));
            Incremento_F0_C2[5] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9) - 1);
            Incremento_F0_C2[6] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9));
            Incremento_F0_C2[7] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9));
            Incremento_F0_C2[8] = (((mA_F0_C2[9] - mA_F0_C2[0]) / 9));
            Incremento_F0_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C3--------------------------------------------------------*/
            Incremento_F0_C3[0] = 0;
            Incremento_F0_C3[1] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9) - 1);
            Incremento_F0_C3[2] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9));
            Incremento_F0_C3[3] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9));
            Incremento_F0_C3[4] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9));
            Incremento_F0_C3[5] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9) - 1);
            Incremento_F0_C3[6] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9));
            Incremento_F0_C3[7] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9));
            Incremento_F0_C3[8] = (((mA_F0_C3[9] - mA_F0_C3[0]) / 9));
            Incremento_F0_C3[9] = 0;
            /*--------------------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C4--------------------------------------------------------*/
            Incremento_F0_C4[0] = 0;
            Incremento_F0_C4[1] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9) - 1);
            Incremento_F0_C4[2] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9));
            Incremento_F0_C4[3] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9));
            Incremento_F0_C4[4] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9));
            Incremento_F0_C4[5] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9) - 1);
            Incremento_F0_C4[6] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9));
            Incremento_F0_C4[7] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9));
            Incremento_F0_C4[8] = (((mA_F0_C4[9] - mA_F0_C4[0]) / 9));
            Incremento_F0_C4[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C0--------------------------------------------------------*/
            Incremento_F1_C0[0] = 0;
            Incremento_F1_C0[1] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9) - 1);
            Incremento_F1_C0[2] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9));
            Incremento_F1_C0[3] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9));
            Incremento_F1_C0[4] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9));
            Incremento_F1_C0[5] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9) - 1);
            Incremento_F1_C0[6] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9));
            Incremento_F1_C0[7] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9));
            Incremento_F1_C0[8] = (((mA_F1_C0[9] - mA_F1_C0[0]) / 9));
            Incremento_F1_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C1--------------------------------------------------------*/
            Incremento_F1_C1[0] = 0;
            Incremento_F1_C1[1] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9) - 1);
            Incremento_F1_C1[2] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9));
            Incremento_F1_C1[3] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9));
            Incremento_F1_C1[4] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9));
            Incremento_F1_C1[5] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9) - 1);
            Incremento_F1_C1[6] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9));
            Incremento_F1_C1[7] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9));
            Incremento_F1_C1[8] = (((mA_F1_C1[9] - mA_F1_C1[0]) / 9));
            Incremento_F1_C1[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C2--------------------------------------------------------*/
            Incremento_F1_C2[0] = 0;
            Incremento_F1_C2[1] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9) - 1);
            Incremento_F1_C2[2] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9));
            Incremento_F1_C2[3] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9));
            Incremento_F1_C2[4] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9));
            Incremento_F1_C2[5] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9) - 1);
            Incremento_F1_C2[6] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9));
            Incremento_F1_C2[7] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9));
            Incremento_F1_C2[8] = (((mA_F1_C2[9] - mA_F1_C2[0]) / 9));
            Incremento_F1_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C3--------------------------------------------------------*/
            Incremento_F1_C3[0] = 0;
            Incremento_F1_C3[1] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9) - 1);
            Incremento_F1_C3[2] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9));
            Incremento_F1_C3[3] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9));
            Incremento_F1_C3[4] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9));
            Incremento_F1_C3[5] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9) - 1);
            Incremento_F1_C3[6] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9));
            Incremento_F1_C3[7] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9));
            Incremento_F1_C3[8] = (((mA_F1_C3[9] - mA_F1_C3[0]) / 9));
            Incremento_F1_C3[9] = 0;
            /*--------------------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C4--------------------------------------------------------*/
            Incremento_F1_C4[0] = 0;
            Incremento_F1_C4[1] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9) - 1);
            Incremento_F1_C4[2] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9));
            Incremento_F1_C4[3] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9));
            Incremento_F1_C4[4] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9));
            Incremento_F1_C4[5] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9) - 1);
            Incremento_F1_C4[6] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9));
            Incremento_F1_C4[7] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9));
            Incremento_F1_C4[8] = (((mA_F1_C4[9] - mA_F1_C4[0]) / 9));
            Incremento_F1_C4[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C0--------------------------------------------------------*/
            Incremento_F2_C0[0] = 0;
            Incremento_F2_C0[1] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9) - 1);
            Incremento_F2_C0[2] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9));
            Incremento_F2_C0[3] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9));
            Incremento_F2_C0[4] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9));
            Incremento_F2_C0[5] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9) - 1);
            Incremento_F2_C0[6] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9));
            Incremento_F2_C0[7] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9));
            Incremento_F2_C0[8] = (((mA_F2_C0[9] - mA_F2_C0[0]) / 9));
            Incremento_F2_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C1--------------------------------------------------------*/
            Incremento_F2_C1[0] = 0;
            Incremento_F2_C1[1] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9) - 1);
            Incremento_F2_C1[2] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9));
            Incremento_F2_C1[3] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9));
            Incremento_F2_C1[4] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9));
            Incremento_F2_C1[5] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9) - 1);
            Incremento_F2_C1[6] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9));
            Incremento_F2_C1[7] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9));
            Incremento_F2_C1[8] = (((mA_F2_C1[9] - mA_F2_C1[0]) / 9));
            Incremento_F2_C1[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C2--------------------------------------------------------*/
            Incremento_F2_C2[0] = 0;
            Incremento_F2_C2[1] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9) - 1);
            Incremento_F2_C2[2] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9));
            Incremento_F2_C2[3] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9));
            Incremento_F2_C2[4] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9));
            Incremento_F2_C2[5] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9) - 1);
            Incremento_F2_C2[6] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9));
            Incremento_F2_C2[7] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9));
            Incremento_F2_C2[8] = (((mA_F2_C2[9] - mA_F2_C2[0]) / 9));
            Incremento_F2_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C3--------------------------------------------------------*/
            Incremento_F2_C3[0] = 0;
            Incremento_F2_C3[1] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9) - 1);
            Incremento_F2_C3[2] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9));
            Incremento_F2_C3[3] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9));
            Incremento_F2_C3[4] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9));
            Incremento_F2_C3[5] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9) - 1);
            Incremento_F2_C3[6] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9));
            Incremento_F2_C3[7] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9));
            Incremento_F2_C3[8] = (((mA_F2_C3[9] - mA_F2_C3[0]) / 9));
            Incremento_F2_C3[9] = 0;
            /*--------------------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C4--------------------------------------------------------*/
            Incremento_F2_C4[0] = 0;
            Incremento_F2_C4[1] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9) - 1);
            Incremento_F2_C4[2] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9));
            Incremento_F2_C4[3] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9));
            Incremento_F2_C4[4] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9));
            Incremento_F2_C4[5] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9) - 1);
            Incremento_F2_C4[6] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9));
            Incremento_F2_C4[7] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9));
            Incremento_F2_C4[8] = (((mA_F2_C4[9] - mA_F2_C4[0]) / 9));
            Incremento_F2_C4[9] = 0;
            /*--------------------------------------------------------------------------------------------*/













        }

        public void Calculo_mA()
        {

            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F0 C0 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F0_C0[1] = mA_F0_C0[0] + Incremento_F0_C0[1];
            mA_F0_C0[2] = mA_F0_C0[1] + Incremento_F0_C0[2];
            mA_F0_C0[3] = mA_F0_C0[2] + Incremento_F0_C0[3];
            mA_F0_C0[4] = mA_F0_C0[3] + Incremento_F0_C0[4];
            mA_F0_C0[5] = mA_F0_C0[4] + Incremento_F0_C0[5];
            mA_F0_C0[6] = mA_F0_C0[5] + Incremento_F0_C0[6];
            mA_F0_C0[7] = mA_F0_C0[6] + Incremento_F0_C0[7];
            mA_F0_C0[8] = mA_F0_C0[7] + Incremento_F0_C0[8];



            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F0 C1 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F0_C1[1] = mA_F0_C1[0] + Incremento_F0_C1[1];
            mA_F0_C1[2] = mA_F0_C1[1] + Incremento_F0_C1[2];
            mA_F0_C1[3] = mA_F0_C1[2] + Incremento_F0_C1[3];
            mA_F0_C1[4] = mA_F0_C1[3] + Incremento_F0_C1[4];
            mA_F0_C1[5] = mA_F0_C1[4] + Incremento_F0_C1[5];
            mA_F0_C1[6] = mA_F0_C1[5] + Incremento_F0_C1[6];
            mA_F0_C1[7] = mA_F0_C1[6] + Incremento_F0_C1[7];
            mA_F0_C1[8] = mA_F0_C1[7] + Incremento_F0_C1[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F0 C2 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F0_C2[1] = mA_F0_C2[0] + Incremento_F0_C2[1];
            mA_F0_C2[2] = mA_F0_C2[1] + Incremento_F0_C2[2];
            mA_F0_C2[3] = mA_F0_C2[2] + Incremento_F0_C2[3];
            mA_F0_C2[4] = mA_F0_C2[3] + Incremento_F0_C2[4];
            mA_F0_C2[5] = mA_F0_C2[4] + Incremento_F0_C2[5];
            mA_F0_C2[6] = mA_F0_C2[5] + Incremento_F0_C2[6];
            mA_F0_C2[7] = mA_F0_C2[6] + Incremento_F0_C2[7];
            mA_F0_C2[8] = mA_F0_C2[7] + Incremento_F0_C2[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F0 C3 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F0_C3[1] = mA_F0_C3[0] + Incremento_F0_C3[1];
            mA_F0_C3[2] = mA_F0_C3[1] + Incremento_F0_C3[2];
            mA_F0_C3[3] = mA_F0_C3[2] + Incremento_F0_C3[3];
            mA_F0_C3[4] = mA_F0_C3[3] + Incremento_F0_C3[4];
            mA_F0_C3[5] = mA_F0_C3[4] + Incremento_F0_C3[5];
            mA_F0_C3[6] = mA_F0_C3[5] + Incremento_F0_C3[6];
            mA_F0_C3[7] = mA_F0_C3[6] + Incremento_F0_C3[7];
            mA_F0_C3[8] = mA_F0_C3[7] + Incremento_F0_C3[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F0 C4 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F0_C4[1] = mA_F0_C4[0] + Incremento_F0_C4[1];
            mA_F0_C4[2] = mA_F0_C4[1] + Incremento_F0_C4[2];
            mA_F0_C4[3] = mA_F0_C4[2] + Incremento_F0_C4[3];
            mA_F0_C4[4] = mA_F0_C4[3] + Incremento_F0_C4[4];
            mA_F0_C4[5] = mA_F0_C4[4] + Incremento_F0_C4[5];
            mA_F0_C4[6] = mA_F0_C4[5] + Incremento_F0_C4[6];
            mA_F0_C4[7] = mA_F0_C4[6] + Incremento_F0_C4[7];
            mA_F0_C4[8] = mA_F0_C4[7] + Incremento_F0_C4[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F1 C0 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F1_C0[1] = mA_F1_C0[0] + Incremento_F1_C0[1];
            mA_F1_C0[2] = mA_F1_C0[1] + Incremento_F1_C0[2];
            mA_F1_C0[3] = mA_F1_C0[2] + Incremento_F1_C0[3];
            mA_F1_C0[4] = mA_F1_C0[3] + Incremento_F1_C0[4];
            mA_F1_C0[5] = mA_F1_C0[4] + Incremento_F1_C0[5];
            mA_F1_C0[6] = mA_F1_C0[5] + Incremento_F1_C0[6];
            mA_F1_C0[7] = mA_F1_C0[6] + Incremento_F1_C0[7];
            mA_F1_C0[8] = mA_F1_C0[7] + Incremento_F1_C0[8];



            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F1 C1 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F1_C1[1] = mA_F1_C1[0] + Incremento_F1_C1[1];
            mA_F1_C1[2] = mA_F1_C1[1] + Incremento_F1_C1[2];
            mA_F1_C1[3] = mA_F1_C1[2] + Incremento_F1_C1[3];
            mA_F1_C1[4] = mA_F1_C1[3] + Incremento_F1_C1[4];
            mA_F1_C1[5] = mA_F1_C1[4] + Incremento_F1_C1[5];
            mA_F1_C1[6] = mA_F1_C1[5] + Incremento_F1_C1[6];
            mA_F1_C1[7] = mA_F1_C1[6] + Incremento_F1_C1[7];
            mA_F1_C1[8] = mA_F1_C1[7] + Incremento_F1_C1[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F1 C2 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F1_C2[1] = mA_F1_C2[0] + Incremento_F1_C2[1];
            mA_F1_C2[2] = mA_F1_C2[1] + Incremento_F1_C2[2];
            mA_F1_C2[3] = mA_F1_C2[2] + Incremento_F1_C2[3];
            mA_F1_C2[4] = mA_F1_C2[3] + Incremento_F1_C2[4];
            mA_F1_C2[5] = mA_F1_C2[4] + Incremento_F1_C2[5];
            mA_F1_C2[6] = mA_F1_C2[5] + Incremento_F1_C2[6];
            mA_F1_C2[7] = mA_F1_C2[6] + Incremento_F1_C2[7];
            mA_F1_C2[8] = mA_F1_C2[7] + Incremento_F1_C2[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F1 C3 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F1_C3[1] = mA_F1_C3[0] + Incremento_F1_C3[1];
            mA_F1_C3[2] = mA_F1_C3[1] + Incremento_F1_C3[2];
            mA_F1_C3[3] = mA_F1_C3[2] + Incremento_F1_C3[3];
            mA_F1_C3[4] = mA_F1_C3[3] + Incremento_F1_C3[4];
            mA_F1_C3[5] = mA_F1_C3[4] + Incremento_F1_C3[5];
            mA_F1_C3[6] = mA_F1_C3[5] + Incremento_F1_C3[6];
            mA_F1_C3[7] = mA_F1_C3[6] + Incremento_F1_C3[7];
            mA_F1_C3[8] = mA_F1_C3[7] + Incremento_F1_C3[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F1 C4 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F1_C4[1] = mA_F1_C4[0] + Incremento_F1_C4[1];
            mA_F1_C4[2] = mA_F1_C4[1] + Incremento_F1_C4[2];
            mA_F1_C4[3] = mA_F1_C4[2] + Incremento_F1_C4[3];
            mA_F1_C4[4] = mA_F1_C4[3] + Incremento_F1_C4[4];
            mA_F1_C4[5] = mA_F1_C4[4] + Incremento_F1_C4[5];
            mA_F1_C4[6] = mA_F1_C4[5] + Incremento_F1_C4[6];
            mA_F1_C4[7] = mA_F1_C4[6] + Incremento_F1_C4[7];
            mA_F1_C4[8] = mA_F1_C4[7] + Incremento_F1_C4[8];



            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F2 C0 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F2_C0[1] = mA_F2_C0[0] + Incremento_F2_C0[1];
            mA_F2_C0[2] = mA_F2_C0[1] + Incremento_F2_C0[2];
            mA_F2_C0[3] = mA_F2_C0[2] + Incremento_F2_C0[3];
            mA_F2_C0[4] = mA_F2_C0[3] + Incremento_F2_C0[4];
            mA_F2_C0[5] = mA_F2_C0[4] + Incremento_F2_C0[5];
            mA_F2_C0[6] = mA_F2_C0[5] + Incremento_F2_C0[6];
            mA_F2_C0[7] = mA_F2_C0[6] + Incremento_F2_C0[7];
            mA_F2_C0[8] = mA_F2_C0[7] + Incremento_F2_C0[8];



            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F2 C1 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F2_C1[1] = mA_F2_C1[0] + Incremento_F2_C1[1];
            mA_F2_C1[2] = mA_F2_C1[1] + Incremento_F2_C1[2];
            mA_F2_C1[3] = mA_F2_C1[2] + Incremento_F2_C1[3];
            mA_F2_C1[4] = mA_F2_C1[3] + Incremento_F2_C1[4];
            mA_F2_C1[5] = mA_F2_C1[4] + Incremento_F2_C1[5];
            mA_F2_C1[6] = mA_F2_C1[5] + Incremento_F2_C1[6];
            mA_F2_C1[7] = mA_F2_C1[6] + Incremento_F2_C1[7];
            mA_F2_C1[8] = mA_F2_C1[7] + Incremento_F2_C1[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F2 C2 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F2_C2[1] = mA_F2_C2[0] + Incremento_F2_C2[1];
            mA_F2_C2[2] = mA_F2_C2[1] + Incremento_F2_C2[2];
            mA_F2_C2[3] = mA_F2_C2[2] + Incremento_F2_C2[3];
            mA_F2_C2[4] = mA_F2_C2[3] + Incremento_F2_C2[4];
            mA_F2_C2[5] = mA_F2_C2[4] + Incremento_F2_C2[5];
            mA_F2_C2[6] = mA_F2_C2[5] + Incremento_F2_C2[6];
            mA_F2_C2[7] = mA_F2_C2[6] + Incremento_F2_C2[7];
            mA_F2_C2[8] = mA_F2_C2[7] + Incremento_F2_C2[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F2 C3 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F2_C3[1] = mA_F2_C3[0] + Incremento_F2_C3[1];
            mA_F2_C3[2] = mA_F2_C3[1] + Incremento_F2_C3[2];
            mA_F2_C3[3] = mA_F2_C3[2] + Incremento_F2_C3[3];
            mA_F2_C3[4] = mA_F2_C3[3] + Incremento_F2_C3[4];
            mA_F2_C3[5] = mA_F2_C3[4] + Incremento_F2_C3[5];
            mA_F2_C3[6] = mA_F2_C3[5] + Incremento_F2_C3[6];
            mA_F2_C3[7] = mA_F2_C3[6] + Incremento_F2_C3[7];
            mA_F2_C3[8] = mA_F2_C3[7] + Incremento_F2_C3[8];



            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*--------------------------------F2 C4 mA-------------------------------------*/

            //mA_F0_C0[0]= mA_F0_C0[0] + Incremento_F0_C0[0];// minimo

            mA_F2_C4[1] = mA_F2_C4[0] + Incremento_F2_C4[1];
            mA_F2_C4[2] = mA_F2_C4[1] + Incremento_F2_C4[2];
            mA_F2_C4[3] = mA_F2_C4[2] + Incremento_F2_C4[3];
            mA_F2_C4[4] = mA_F2_C4[3] + Incremento_F2_C4[4];
            mA_F2_C4[5] = mA_F2_C4[4] + Incremento_F2_C4[5];
            mA_F2_C4[6] = mA_F2_C4[5] + Incremento_F2_C4[6];
            mA_F2_C4[7] = mA_F2_C4[6] + Incremento_F2_C4[7];
            mA_F2_C4[8] = mA_F2_C4[7] + Incremento_F2_C4[8];



            /*-----------------------------------------------------------------------------*/












        }


        public void Imprimir_mA_Tablas()




        {

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C0-------------------------------------------*/
            TextBox_F0_C0_mA_1.Text = mA_F0_C0[1].ToString("N2");
            TextBox_F0_C0_mA_2.Text = mA_F0_C0[2].ToString("N2");
            TextBox_F0_C0_mA_3.Text = mA_F0_C0[3].ToString("N2");
            TextBox_F0_C0_mA_4.Text = mA_F0_C0[4].ToString("N2");
            TextBox_F0_C0_mA_5.Text = mA_F0_C0[5].ToString("N2");
            TextBox_F0_C0_mA_6.Text = mA_F0_C0[6].ToString("N2");
            TextBox_F0_C0_mA_7.Text = mA_F0_C0[7].ToString("N2");
            TextBox_F0_C0_mA_8.Text = mA_F0_C0[8].ToString("N2");
            /*------------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C1-------------------------------------------*/
            TextBox_F0_C1_mA_1.Text = mA_F0_C1[1].ToString("N2");
            TextBox_F0_C1_mA_2.Text = mA_F0_C1[2].ToString("N2");
            TextBox_F0_C1_mA_3.Text = mA_F0_C1[3].ToString("N2");
            TextBox_F0_C1_mA_4.Text = mA_F0_C1[4].ToString("N2");
            TextBox_F0_C1_mA_5.Text = mA_F0_C1[5].ToString("N2");
            TextBox_F0_C1_mA_6.Text = mA_F0_C1[6].ToString("N2");
            TextBox_F0_C1_mA_7.Text = mA_F0_C1[7].ToString("N2");
            TextBox_F0_C1_mA_8.Text = mA_F0_C1[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C2-------------------------------------------*/
            TextBox_F0_C2_mA_1.Text = mA_F0_C2[1].ToString("N2");
            TextBox_F0_C2_mA_2.Text = mA_F0_C2[2].ToString("N2");
            TextBox_F0_C2_mA_3.Text = mA_F0_C2[3].ToString("N2");
            TextBox_F0_C2_mA_4.Text = mA_F0_C2[4].ToString("N2");
            TextBox_F0_C2_mA_5.Text = mA_F0_C2[5].ToString("N2");
            TextBox_F0_C2_mA_6.Text = mA_F0_C2[6].ToString("N2");
            TextBox_F0_C2_mA_7.Text = mA_F0_C2[7].ToString("N2");
            TextBox_F0_C2_mA_8.Text = mA_F0_C2[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C3-------------------------------------------*/
            TextBox_F0_C3_mA_1.Text = mA_F0_C3[1].ToString("N2");
            TextBox_F0_C3_mA_2.Text = mA_F0_C3[2].ToString("N2");
            TextBox_F0_C3_mA_3.Text = mA_F0_C3[3].ToString("N2");
            TextBox_F0_C3_mA_4.Text = mA_F0_C3[4].ToString("N2");
            TextBox_F0_C3_mA_5.Text = mA_F0_C3[5].ToString("N2");
            TextBox_F0_C3_mA_6.Text = mA_F0_C3[6].ToString("N2");
            TextBox_F0_C3_mA_7.Text = mA_F0_C3[7].ToString("N2");
            TextBox_F0_C3_mA_8.Text = mA_F0_C3[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C4-------------------------------------------*/
            TextBox_F0_C4_mA_1.Text = mA_F0_C4[1].ToString("N2");
            TextBox_F0_C4_mA_2.Text = mA_F0_C4[2].ToString("N2");
            TextBox_F0_C4_mA_3.Text = mA_F0_C4[3].ToString("N2");
            TextBox_F0_C4_mA_4.Text = mA_F0_C4[4].ToString("N2");
            TextBox_F0_C4_mA_5.Text = mA_F0_C4[5].ToString("N2");
            TextBox_F0_C4_mA_6.Text = mA_F0_C4[6].ToString("N2");
            TextBox_F0_C4_mA_7.Text = mA_F0_C4[7].ToString("N2");
            TextBox_F0_C4_mA_8.Text = mA_F0_C4[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C0-------------------------------------------*/
            TextBox_F1_C0_mA_1.Text = mA_F1_C0[1].ToString("N2");
            TextBox_F1_C0_mA_2.Text = mA_F1_C0[2].ToString("N2");
            TextBox_F1_C0_mA_3.Text = mA_F1_C0[3].ToString("N2");
            TextBox_F1_C0_mA_4.Text = mA_F1_C0[4].ToString("N2");
            TextBox_F1_C0_mA_5.Text = mA_F1_C0[5].ToString("N2");
            TextBox_F1_C0_mA_6.Text = mA_F1_C0[6].ToString("N2");
            TextBox_F1_C0_mA_7.Text = mA_F1_C0[7].ToString("N2");
            TextBox_F1_C0_mA_8.Text = mA_F1_C0[8].ToString("N2");
            /*------------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C1-------------------------------------------*/
            TextBox_F1_C1_mA_1.Text = mA_F1_C1[1].ToString("N2");
            TextBox_F1_C1_mA_2.Text = mA_F1_C1[2].ToString("N2");
            TextBox_F1_C1_mA_3.Text = mA_F1_C1[3].ToString("N2");
            TextBox_F1_C1_mA_4.Text = mA_F1_C1[4].ToString("N2");
            TextBox_F1_C1_mA_5.Text = mA_F1_C1[5].ToString("N2");
            TextBox_F1_C1_mA_6.Text = mA_F1_C1[6].ToString("N2");
            TextBox_F1_C1_mA_7.Text = mA_F1_C1[7].ToString("N2");
            TextBox_F1_C1_mA_8.Text = mA_F1_C1[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C2-------------------------------------------*/
            TextBox_F1_C2_mA_1.Text = mA_F1_C2[1].ToString("N2");
            TextBox_F1_C2_mA_2.Text = mA_F1_C2[2].ToString("N2");
            TextBox_F1_C2_mA_3.Text = mA_F1_C2[3].ToString("N2");
            TextBox_F1_C2_mA_4.Text = mA_F1_C2[4].ToString("N2");
            TextBox_F1_C2_mA_5.Text = mA_F1_C2[5].ToString("N2");
            TextBox_F1_C2_mA_6.Text = mA_F1_C2[6].ToString("N2");
            TextBox_F1_C2_mA_7.Text = mA_F1_C2[7].ToString("N2");
            TextBox_F1_C2_mA_8.Text = mA_F1_C2[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C3-------------------------------------------*/
            TextBox_F1_C3_mA_1.Text = mA_F1_C3[1].ToString("N2");
            TextBox_F1_C3_mA_2.Text = mA_F1_C3[2].ToString("N2");
            TextBox_F1_C3_mA_3.Text = mA_F1_C3[3].ToString("N2");
            TextBox_F1_C3_mA_4.Text = mA_F1_C3[4].ToString("N2");
            TextBox_F1_C3_mA_5.Text = mA_F1_C3[5].ToString("N2");
            TextBox_F1_C3_mA_6.Text = mA_F1_C3[6].ToString("N2");
            TextBox_F1_C3_mA_7.Text = mA_F1_C3[7].ToString("N2");
            TextBox_F1_C3_mA_8.Text = mA_F1_C3[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C4-------------------------------------------*/
            TextBox_F1_C4_mA_1.Text = mA_F1_C4[1].ToString("N2");
            TextBox_F1_C4_mA_2.Text =mA_F1_C4[2].ToString("N2");
            TextBox_F1_C4_mA_3.Text = mA_F1_C4[3].ToString("N2");
            TextBox_F1_C4_mA_4.Text = mA_F1_C4[4].ToString("N2");
            TextBox_F1_C4_mA_5.Text = mA_F1_C4[5].ToString("N2");
            TextBox_F1_C4_mA_6.Text = mA_F1_C4[6].ToString("N2");
            TextBox_F1_C4_mA_7.Text = mA_F1_C4[7].ToString("N2");
            TextBox_F1_C4_mA_8.Text = mA_F1_C4[8].ToString("N2");
            /*------------------------------------------------------------------------------*/



            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C0-------------------------------------------*/
            TextBox_F2_C0_mA_1.Text = mA_F2_C0[1].ToString("N2");
            TextBox_F2_C0_mA_2.Text = mA_F2_C0[2].ToString("N2");
            TextBox_F2_C0_mA_3.Text = mA_F2_C0[3].ToString("N2");
            TextBox_F2_C0_mA_4.Text = mA_F2_C0[4].ToString("N2");
            TextBox_F2_C0_mA_5.Text = mA_F2_C0[5].ToString("N2");
            TextBox_F2_C0_mA_6.Text = mA_F2_C0[6].ToString("N2");
            TextBox_F2_C0_mA_7.Text = mA_F2_C0[7].ToString("N2");
            TextBox_F2_C0_mA_8.Text = mA_F2_C0[8].ToString("N2");
            /*------------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C1-------------------------------------------*/
            TextBox_F2_C1_mA_1.Text = mA_F2_C1[1].ToString("N2");
            TextBox_F2_C1_mA_2.Text = mA_F2_C1[2].ToString("N2");
            TextBox_F2_C1_mA_3.Text = mA_F2_C1[3].ToString("N2");
            TextBox_F2_C1_mA_4.Text = mA_F2_C1[4].ToString("N2");
            TextBox_F2_C1_mA_5.Text = mA_F2_C1[5].ToString("N2");
            TextBox_F2_C1_mA_6.Text = mA_F2_C1[6].ToString("N2");
            TextBox_F2_C1_mA_7.Text = mA_F2_C1[7].ToString("N2");
            TextBox_F2_C1_mA_8.Text = mA_F2_C1[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C2-------------------------------------------*/
            TextBox_F2_C2_mA_1.Text = mA_F2_C2[1].ToString("N2");
            TextBox_F2_C2_mA_2.Text = mA_F2_C2[2].ToString("N2");
            TextBox_F2_C2_mA_3.Text = mA_F2_C2[3].ToString("N2");
            TextBox_F2_C2_mA_4.Text = mA_F2_C2[4].ToString("N2");
            TextBox_F2_C2_mA_5.Text = mA_F2_C2[5].ToString("N2");
            TextBox_F2_C2_mA_6.Text = mA_F2_C2[6].ToString("N2");
            TextBox_F2_C2_mA_7.Text = mA_F2_C2[7].ToString("N2");
            TextBox_F2_C2_mA_8.Text = mA_F2_C2[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C3-------------------------------------------*/
            TextBox_F2_C3_mA_1.Text = mA_F2_C3[1].ToString("N2");
            TextBox_F2_C3_mA_2.Text = mA_F2_C3[2].ToString("N2");
            TextBox_F2_C3_mA_3.Text = mA_F2_C3[3].ToString("N2");
            TextBox_F2_C3_mA_4.Text = mA_F2_C3[4].ToString("N2");
            TextBox_F2_C3_mA_5.Text = mA_F2_C3[5].ToString("N2");
            TextBox_F2_C3_mA_6.Text = mA_F2_C3[6].ToString("N2");
            TextBox_F2_C3_mA_7.Text = mA_F2_C3[7].ToString("N2");
            TextBox_F2_C3_mA_8.Text = mA_F2_C3[8].ToString("N2");
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C4-------------------------------------------*/
            TextBox_F2_C4_mA_1.Text = mA_F2_C4[1].ToString("N2");
            TextBox_F2_C4_mA_2.Text = mA_F2_C4[2].ToString("N2");
            TextBox_F2_C4_mA_3.Text = mA_F2_C4[3].ToString("N2");
            TextBox_F2_C4_mA_4.Text = mA_F2_C4[4].ToString("N2");
            TextBox_F2_C4_mA_5.Text = mA_F2_C4[5].ToString("N2");
            TextBox_F2_C4_mA_6.Text = mA_F2_C4[6].ToString("N2");
            TextBox_F2_C4_mA_7.Text = mA_F2_C4[7].ToString("N2");
            TextBox_F2_C4_mA_8.Text = mA_F2_C4[8].ToString("N2");
            /*------------------------------------------------------------------------------*/



        }



        public void Calculo_Dc()
        {
            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F0 C0--------------------------------------*/

            DC_F0_C0[1] = (140f + ((mA_F0_C0[1] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[2] = (140f + ((mA_F0_C0[2] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[3] = (140f + ((mA_F0_C0[3] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[4] = (140f + ((mA_F0_C0[4] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[5] = (140f + ((mA_F0_C0[5] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[6] = (140f + ((mA_F0_C0[6] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[7] = (140f + ((mA_F0_C0[7] - 26.7f) / 0.478f)) / 10;
            DC_F0_C0[8] = (140f + ((mA_F0_C0[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F0 C1--------------------------------------*/

            DC_F0_C1[1] = (140f + ((mA_F0_C1[1] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[2] = (140f + ((mA_F0_C1[2] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[3] = (140f + ((mA_F0_C1[3] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[4] = (140f + ((mA_F0_C1[4] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[5] = (140f + ((mA_F0_C1[5] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[6] = (140f + ((mA_F0_C1[6] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[7] = (140f + ((mA_F0_C1[7] - 26.7f) / 0.478f)) / 10;
            DC_F0_C1[8] = (140f + ((mA_F0_C1[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F0 C2--------------------------------------*/

            DC_F0_C2[1] = (140f + ((mA_F0_C2[1] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[2] = (140f + ((mA_F0_C2[2] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[3] = (140f + ((mA_F0_C2[3] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[4] = (140f + ((mA_F0_C2[4] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[5] = (140f + ((mA_F0_C2[5] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[6] = (140f + ((mA_F0_C2[6] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[7] = (140f + ((mA_F0_C2[7] - 26.7f) / 0.478f)) / 10;
            DC_F0_C2[8] = (140f + ((mA_F0_C2[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F0 C3--------------------------------------*/

            DC_F0_C3[1] = (140f + ((mA_F0_C3[1] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[2] = (140f + ((mA_F0_C3[2] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[3] = (140f + ((mA_F0_C3[3] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[4] = (140f + ((mA_F0_C3[4] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[5] = (140f + ((mA_F0_C3[5] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[6] = (140f + ((mA_F0_C3[6] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[7] = (140f + ((mA_F0_C3[7] - 26.7f) / 0.478f)) / 10;
            DC_F0_C3[8] = (140f + ((mA_F0_C3[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F0 C4--------------------------------------*/

            DC_F0_C4[1] = (140f + ((mA_F0_C4[1] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[2] = (140f + ((mA_F0_C4[2] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[3] = (140f + ((mA_F0_C4[3] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[4] = (140f + ((mA_F0_C4[4] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[5] = (140f + ((mA_F0_C4[5] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[6] = (140f + ((mA_F0_C4[6] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[7] = (140f + ((mA_F0_C4[7] - 26.7f) / 0.478f)) / 10;
            DC_F0_C4[8] = (140f + ((mA_F0_C4[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/



            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F1 C0--------------------------------------*/

            DC_F1_C0[1] = (140f + ((mA_F1_C0[1] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[2] = (140f + ((mA_F1_C0[2] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[3] = (140f + ((mA_F1_C0[3] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[4] = (140f + ((mA_F1_C0[4] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[5] = (140f + ((mA_F1_C0[5] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[6] = (140f + ((mA_F1_C0[6] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[7] = (140f + ((mA_F1_C0[7] - 26.7f) / 0.478f)) / 10;
            DC_F1_C0[8] = (140f + ((mA_F1_C0[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F1 C1--------------------------------------*/

            DC_F1_C1[1] = (140f + ((mA_F1_C1[1] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[2] = (140f + ((mA_F1_C1[2] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[3] = (140f + ((mA_F1_C1[3] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[4] = (140f + ((mA_F1_C1[4] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[5] = (140f + ((mA_F1_C1[5] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[6] = (140f + ((mA_F1_C1[6] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[7] = (140f + ((mA_F1_C1[7] - 26.7f) / 0.478f)) / 10;
            DC_F1_C1[8] = (140f + ((mA_F1_C1[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F1 C2--------------------------------------*/

            DC_F1_C2[1] = (140f + ((mA_F1_C2[1] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[2] = (140f + ((mA_F1_C2[2] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[3] = (140f + ((mA_F1_C2[3] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[4] = (140f + ((mA_F1_C2[4] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[5] = (140f + ((mA_F1_C2[5] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[6] = (140f + ((mA_F1_C2[6] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[7] = (140f + ((mA_F1_C2[7] - 26.7f) / 0.478f)) / 10;
            DC_F1_C2[8] = (140f + ((mA_F1_C2[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F1 C3--------------------------------------*/

            DC_F1_C3[1] = (140f + ((mA_F1_C3[1] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[2] = (140f + ((mA_F1_C3[2] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[3] = (140f + ((mA_F1_C3[3] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[4] = (140f + ((mA_F1_C3[4] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[5] = (140f + ((mA_F1_C3[5] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[6] = (140f + ((mA_F1_C3[6] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[7] = (140f + ((mA_F1_C3[7] - 26.7f) / 0.478f)) / 10;
            DC_F1_C3[8] = (140f + ((mA_F1_C3[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F1 C4--------------------------------------*/

            DC_F1_C4[1] = (140f + ((mA_F1_C4[1] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[2] = (140f + ((mA_F1_C4[2] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[3] = (140f + ((mA_F1_C4[3] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[4] = (140f + ((mA_F1_C4[4] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[5] = (140f + ((mA_F1_C4[5] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[6] = (140f + ((mA_F1_C4[6] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[7] = (140f + ((mA_F1_C4[7] - 26.7f) / 0.478f)) / 10;
            DC_F1_C4[8] = (140f + ((mA_F1_C4[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/




            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F2 C0--------------------------------------*/

            DC_F2_C0[1] = (140f + ((mA_F2_C0[1] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[2] = (140f + ((mA_F2_C0[2] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[3] = (140f + ((mA_F2_C0[3] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[4] = (140f + ((mA_F2_C0[4] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[5] = (140f + ((mA_F2_C0[5] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[6] = (140f + ((mA_F2_C0[6] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[7] = (140f + ((mA_F2_C0[7] - 26.7f) / 0.478f)) / 10;
            DC_F2_C0[8] = (140f + ((mA_F2_C0[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F2 C1--------------------------------------*/

            DC_F2_C1[1] = (140f + ((mA_F2_C1[1] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[2] = (140f + ((mA_F2_C1[2] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[3] = (140f + ((mA_F2_C1[3] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[4] = (140f + ((mA_F2_C1[4] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[5] = (140f + ((mA_F2_C1[5] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[6] = (140f + ((mA_F2_C1[6] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[7] = (140f + ((mA_F2_C1[7] - 26.7f) / 0.478f)) / 10;
            DC_F2_C1[8] = (140f + ((mA_F2_C1[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F2 C2--------------------------------------*/

            DC_F2_C2[1] = (140f + ((mA_F2_C2[1] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[2] = (140f + ((mA_F2_C2[2] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[3] = (140f + ((mA_F2_C2[3] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[4] = (140f + ((mA_F2_C2[4] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[5] = (140f + ((mA_F2_C2[5] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[6] = (140f + ((mA_F2_C2[6] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[7] = (140f + ((mA_F2_C2[7] - 26.7f) / 0.478f)) / 10;
            DC_F2_C2[8] = (140f + ((mA_F2_C2[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F2 C3--------------------------------------*/

            DC_F2_C3[1] = (140f + ((mA_F2_C3[1] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[2] = (140f + ((mA_F2_C3[2] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[3] = (140f + ((mA_F2_C3[3] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[4] = (140f + ((mA_F2_C3[4] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[5] = (140f + ((mA_F2_C3[5] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[6] = (140f + ((mA_F2_C3[6] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[7] = (140f + ((mA_F2_C3[7] - 26.7f) / 0.478f)) / 10;
            DC_F2_C3[8] = (140f + ((mA_F2_C3[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------------*/
            /*-----------------------------------------F2 C4--------------------------------------*/

            DC_F2_C4[1] = (140f + ((mA_F2_C4[1] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[2] = (140f + ((mA_F2_C4[2] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[3] = (140f + ((mA_F2_C4[3] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[4] = (140f + ((mA_F2_C4[4] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[5] = (140f + ((mA_F2_C4[5] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[6] = (140f + ((mA_F2_C4[6] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[7] = (140f + ((mA_F2_C4[7] - 26.7f) / 0.478f)) / 10;
            DC_F2_C4[8] = (140f + ((mA_F2_C4[8] - 26.7f) / 0.478f)) / 10;

            /*------------------------------------------------------------------------------------*/
        }


        public void Imprimir_Dc_Tablas()
        {
            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C0----------------------------------------*/
            TextBox_DC_F0_Campo0_1.Text = DC_F0_C0[1].ToString("N2");
            TextBox_DC_F0_Campo0_2.Text = DC_F0_C0[2].ToString("N2");
            TextBox_DC_F0_Campo0_3.Text = DC_F0_C0[3].ToString("N2");
            TextBox_DC_F0_Campo0_4.Text = DC_F0_C0[4].ToString("N2");
            TextBox_DC_F0_Campo0_5.Text = DC_F0_C0[5].ToString("N2");
            TextBox_DC_F0_Campo0_6.Text = DC_F0_C0[6].ToString("N2");
            TextBox_DC_F0_Campo0_7.Text = DC_F0_C0[7].ToString("N2");
            TextBox_DC_F0_Campo0_8.Text = DC_F0_C0[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C1----------------------------------------*/
            TextBox_DC_F0_Campo1_1.Text = DC_F0_C1[1].ToString("N2");
            TextBox_DC_F0_Campo1_2.Text = DC_F0_C1[2].ToString("N2");
            TextBox_DC_F0_Campo1_3.Text = DC_F0_C1[3].ToString("N2");
            TextBox_DC_F0_Campo1_4.Text = DC_F0_C1[4].ToString("N2");
            TextBox_DC_F0_Campo1_5.Text = DC_F0_C1[5].ToString("N2");
            TextBox_DC_F0_Campo1_6.Text = DC_F0_C1[6].ToString("N2");
            TextBox_DC_F0_Campo1_7.Text = DC_F0_C1[7].ToString("N2");
            TextBox_DC_F0_Campo1_8.Text = DC_F0_C1[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C2----------------------------------------*/
            TextBox_DC_F0_Campo2_1.Text = DC_F0_C2[1].ToString("N2");
            TextBox_DC_F0_Campo2_2.Text = DC_F0_C2[2].ToString("N2");
            TextBox_DC_F0_Campo2_3.Text = DC_F0_C2[3].ToString("N2");
            TextBox_DC_F0_Campo2_4.Text = DC_F0_C2[4].ToString("N2");
            TextBox_DC_F0_Campo2_5.Text = DC_F0_C2[5].ToString("N2");
            TextBox_DC_F0_Campo2_6.Text = DC_F0_C2[6].ToString("N2");
            TextBox_DC_F0_Campo2_7.Text = DC_F0_C2[7].ToString("N2");
            TextBox_DC_F0_Campo2_8.Text = DC_F0_C2[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C3----------------------------------------*/
            TextBox_DC_F0_Campo3_1.Text = DC_F0_C3[1].ToString("N2");
            TextBox_DC_F0_Campo3_2.Text = DC_F0_C3[2].ToString("N2");
            TextBox_DC_F0_Campo3_3.Text = DC_F0_C3[3].ToString("N2");
            TextBox_DC_F0_Campo3_4.Text = DC_F0_C3[4].ToString("N2");
            TextBox_DC_F0_Campo3_5.Text = DC_F0_C3[5].ToString("N2");
            TextBox_DC_F0_Campo3_6.Text = DC_F0_C3[6].ToString("N2");
            TextBox_DC_F0_Campo3_7.Text = DC_F0_C3[7].ToString("N2");
            TextBox_DC_F0_Campo3_8.Text = DC_F0_C3[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C4----------------------------------------*/
            TextBox_DC_F0_Campo4_1.Text = DC_F0_C4[1].ToString("N2");
            TextBox_DC_F0_Campo4_2.Text = DC_F0_C4[2].ToString("N2");
            TextBox_DC_F0_Campo4_3.Text = DC_F0_C4[3].ToString("N2");
            TextBox_DC_F0_Campo4_4.Text =DC_F0_C4[4].ToString("N2");
            TextBox_DC_F0_Campo4_5.Text = DC_F0_C4[5].ToString("N2");
            TextBox_DC_F0_Campo4_6.Text = DC_F0_C4[6].ToString("N2");
            TextBox_DC_F0_Campo4_7.Text = DC_F0_C4[7].ToString("N2");
            TextBox_DC_F0_Campo4_8.Text = DC_F0_C4[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C0----------------------------------------*/
            TextBox_DC_F1_Campo0_1.Text = DC_F1_C0[1].ToString("N2");
            TextBox_DC_F1_Campo0_2.Text = DC_F1_C0[2].ToString("N2");
            TextBox_DC_F1_Campo0_3.Text = DC_F1_C0[3].ToString("N2");
            TextBox_DC_F1_Campo0_4.Text = DC_F1_C0[4].ToString("N2");
            TextBox_DC_F1_Campo0_5.Text = DC_F1_C0[5].ToString("N2");
            TextBox_DC_F1_Campo0_6.Text = DC_F1_C0[6].ToString("N2");
            TextBox_DC_F1_Campo0_7.Text = DC_F1_C0[7].ToString("N2");
            TextBox_DC_F1_Campo0_8.Text = DC_F1_C0[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C1----------------------------------------*/
            TextBox_DC_F1_Campo1_1.Text = DC_F1_C1[1].ToString("N2");
            TextBox_DC_F1_Campo1_2.Text = DC_F1_C1[2].ToString("N2");
            TextBox_DC_F1_Campo1_3.Text = DC_F1_C1[3].ToString("N2");
            TextBox_DC_F1_Campo1_4.Text = DC_F1_C1[4].ToString("N2");
            TextBox_DC_F1_Campo1_5.Text = DC_F1_C1[5].ToString("N2");
            TextBox_DC_F1_Campo1_6.Text = DC_F1_C1[6].ToString("N2");
            TextBox_DC_F1_Campo1_7.Text = DC_F1_C1[7].ToString("N2");
            TextBox_DC_F1_Campo1_8.Text = DC_F1_C1[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C2----------------------------------------*/
            TextBox_DC_F1_Campo2_1.Text = DC_F1_C2[1].ToString("N2");
            TextBox_DC_F1_Campo2_2.Text = DC_F1_C2[2].ToString("N2");
            TextBox_DC_F1_Campo2_3.Text =DC_F1_C2[3].ToString("N2");
            TextBox_DC_F1_Campo2_4.Text = DC_F1_C2[4].ToString("N2");
            TextBox_DC_F1_Campo2_5.Text = DC_F1_C2[5].ToString("N2");
            TextBox_DC_F1_Campo2_6.Text = DC_F1_C2[6].ToString("N2");
            TextBox_DC_F1_Campo2_7.Text = DC_F1_C2[7].ToString("N2");
            TextBox_DC_F1_Campo2_8.Text = DC_F1_C2[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C3----------------------------------------*/
            TextBox_DC_F1_Campo3_1.Text = DC_F1_C3[1].ToString("N2");
            TextBox_DC_F1_Campo3_2.Text = DC_F1_C3[2].ToString("N2");
            TextBox_DC_F1_Campo3_3.Text = DC_F1_C3[3].ToString("N2");
            TextBox_DC_F1_Campo3_4.Text =DC_F1_C3[4].ToString("N2");
            TextBox_DC_F1_Campo3_5.Text = DC_F1_C3[5].ToString("N2");
            TextBox_DC_F1_Campo3_6.Text = DC_F1_C3[6].ToString("N2");
            TextBox_DC_F1_Campo3_7.Text = DC_F1_C3[7].ToString("N2");
            TextBox_DC_F1_Campo3_8.Text = DC_F1_C3[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C4----------------------------------------*/
            TextBox_DC_F1_Campo4_1.Text = DC_F1_C4[1].ToString("N2");
            TextBox_DC_F1_Campo4_2.Text = DC_F1_C4[2].ToString("N2");
            TextBox_DC_F1_Campo4_3.Text = DC_F1_C4[3].ToString("N2");
            TextBox_DC_F1_Campo4_4.Text = DC_F1_C4[4].ToString("N2");
            TextBox_DC_F1_Campo4_5.Text = DC_F1_C4[5].ToString("N2");
            TextBox_DC_F1_Campo4_6.Text = DC_F1_C4[6].ToString("N2");
            TextBox_DC_F1_Campo4_7.Text = DC_F1_C4[7].ToString("N2");
            TextBox_DC_F1_Campo4_8.Text = DC_F1_C4[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/






            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C0----------------------------------------*/
            TextBox_DC_F2_Campo0_1.Text = DC_F2_C0[1].ToString("N2");
            TextBox_DC_F2_Campo0_2.Text = DC_F2_C0[2].ToString("N2");
            TextBox_DC_F2_Campo0_3.Text = DC_F2_C0[3].ToString("N2");
            TextBox_DC_F2_Campo0_4.Text = DC_F2_C0[4].ToString("N2");
            TextBox_DC_F2_Campo0_5.Text = DC_F2_C0[5].ToString("N2");
            TextBox_DC_F2_Campo0_6.Text = DC_F2_C0[6].ToString("N2");
            TextBox_DC_F2_Campo0_7.Text = DC_F2_C0[7].ToString("N2");
            TextBox_DC_F2_Campo0_8.Text = DC_F2_C0[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C1----------------------------------------*/
            TextBox_DC_F2_Campo1_1.Text = DC_F2_C1[1].ToString("N2");
            TextBox_DC_F2_Campo1_2.Text = DC_F2_C1[2].ToString("N2");
            TextBox_DC_F2_Campo1_3.Text = DC_F2_C1[3].ToString("N2");
            TextBox_DC_F2_Campo1_4.Text = DC_F2_C1[4].ToString("N2");
            TextBox_DC_F2_Campo1_5.Text = DC_F2_C1[5].ToString("N2");
            TextBox_DC_F2_Campo1_6.Text = DC_F2_C1[6].ToString("N2");
            TextBox_DC_F2_Campo1_7.Text = DC_F2_C1[7].ToString("N2");
            TextBox_DC_F2_Campo1_8.Text = DC_F2_C1[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C2----------------------------------------*/
            TextBox_DC_F2_Campo2_1.Text = DC_F2_C2[1].ToString("N2");
            TextBox_DC_F2_Campo2_2.Text = DC_F2_C2[2].ToString("N2");
            TextBox_DC_F2_Campo2_3.Text = DC_F2_C2[3].ToString("N2");
            TextBox_DC_F2_Campo2_4.Text = DC_F2_C2[4].ToString("N2");
            TextBox_DC_F2_Campo2_5.Text = DC_F2_C2[5].ToString("N2");
            TextBox_DC_F2_Campo2_6.Text = DC_F2_C2[6].ToString("N2");
            TextBox_DC_F2_Campo2_7.Text = DC_F2_C2[7].ToString("N2");
            TextBox_DC_F2_Campo2_8.Text = DC_F2_C2[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C3----------------------------------------*/
            TextBox_DC_F2_Campo3_1.Text = DC_F2_C3[1].ToString("N2");
            TextBox_DC_F2_Campo3_2.Text = DC_F2_C3[2].ToString("N2");
            TextBox_DC_F2_Campo3_3.Text = DC_F2_C3[3].ToString("N2");
            TextBox_DC_F2_Campo3_4.Text = DC_F2_C3[4].ToString("N2");
            TextBox_DC_F2_Campo3_5.Text = DC_F2_C3[5].ToString("N2");
            TextBox_DC_F2_Campo3_6.Text = DC_F2_C3[6].ToString("N2");
            TextBox_DC_F2_Campo3_7.Text = DC_F2_C3[7].ToString("N2");
            TextBox_DC_F2_Campo3_8.Text = DC_F2_C3[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C4----------------------------------------*/
            TextBox_DC_F2_Campo4_1.Text = DC_F2_C4[1].ToString("N2");
            TextBox_DC_F2_Campo4_2.Text = DC_F2_C4[2].ToString("N2");
            TextBox_DC_F2_Campo4_3.Text =DC_F2_C4[3].ToString("N2");
            TextBox_DC_F2_Campo4_4.Text = DC_F2_C4[4].ToString("N2");
            TextBox_DC_F2_Campo4_5.Text = DC_F2_C4[5].ToString("N2");
            TextBox_DC_F2_Campo4_6.Text = DC_F2_C4[6].ToString("N2");
            TextBox_DC_F2_Campo4_7.Text = DC_F2_C4[7].ToString("N2");
            TextBox_DC_F2_Campo4_8.Text = DC_F2_C4[8].ToString("N2");


            /*--------------------------------------------------------------------------------*/

        }



        public void Calcular_Registro()
        {




            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F0 C0 ---------------------------------------*/
            Registro_F0_C0[1] = Convert.ToInt16((DC_F0_C0[1] * 9999f) / 100f);
            Registro_F0_C0[2] = Convert.ToInt16((DC_F0_C0[2] * 9999f) / 100f);
            Registro_F0_C0[3] = Convert.ToInt16((DC_F0_C0[3] * 9999f) / 100f);
            Registro_F0_C0[4] = Convert.ToInt16((DC_F0_C0[4] * 9999f) / 100f);
            Registro_F0_C0[5] = Convert.ToInt16((DC_F0_C0[5] * 9999f) / 100f);
            Registro_F0_C0[6] = Convert.ToInt16((DC_F0_C0[6] * 9999f) / 100f);
            Registro_F0_C0[7] = Convert.ToInt16((DC_F0_C0[7] * 9999f) / 100f);
            Registro_F0_C0[8] = Convert.ToInt16((DC_F0_C0[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F0 C1 ---------------------------------------*/
            Registro_F0_C1[1] = Convert.ToInt16((DC_F0_C1[1] * 9999f) / 100f);
            Registro_F0_C1[2] = Convert.ToInt16((DC_F0_C1[2] * 9999f) / 100f);
            Registro_F0_C1[3] = Convert.ToInt16((DC_F0_C1[3] * 9999f) / 100f);
            Registro_F0_C1[4] = Convert.ToInt16((DC_F0_C1[4] * 9999f) / 100f);
            Registro_F0_C1[5] = Convert.ToInt16((DC_F0_C1[5] * 9999f) / 100f);
            Registro_F0_C1[6] = Convert.ToInt16((DC_F0_C1[6] * 9999f) / 100f);
            Registro_F0_C1[7] = Convert.ToInt16((DC_F0_C1[7] * 9999f) / 100f);
            Registro_F0_C1[8] = Convert.ToInt16((DC_F0_C1[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F0 C2 ---------------------------------------*/
            Registro_F0_C2[1] = Convert.ToInt16((DC_F0_C2[1] * 9999f) / 100f);
            Registro_F0_C2[2] = Convert.ToInt16((DC_F0_C2[2] * 9999f) / 100f);
            Registro_F0_C2[3] = Convert.ToInt16((DC_F0_C2[3] * 9999f) / 100f);
            Registro_F0_C2[4] = Convert.ToInt16((DC_F0_C2[4] * 9999f) / 100f);
            Registro_F0_C2[5] = Convert.ToInt16((DC_F0_C2[5] * 9999f) / 100f);
            Registro_F0_C2[6] = Convert.ToInt16((DC_F0_C2[6] * 9999f) / 100f);
            Registro_F0_C2[7] = Convert.ToInt16((DC_F0_C2[7] * 9999f) / 100f);
            Registro_F0_C2[8] = Convert.ToInt16((DC_F0_C2[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F0 C3 ---------------------------------------*/
            Registro_F0_C3[1] = Convert.ToInt16((DC_F0_C3[1] * 9999f) / 100f);
            Registro_F0_C3[2] = Convert.ToInt16((DC_F0_C3[2] * 9999f) / 100f);
            Registro_F0_C3[3] = Convert.ToInt16((DC_F0_C3[3] * 9999f) / 100f);
            Registro_F0_C3[4] = Convert.ToInt16((DC_F0_C3[4] * 9999f) / 100f);
            Registro_F0_C3[5] = Convert.ToInt16((DC_F0_C3[5] * 9999f) / 100f);
            Registro_F0_C3[6] = Convert.ToInt16((DC_F0_C3[6] * 9999f) / 100f);
            Registro_F0_C3[7] = Convert.ToInt16((DC_F0_C3[7] * 9999f) / 100f);
            Registro_F0_C3[8] = Convert.ToInt16((DC_F0_C3[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F0 C4 ---------------------------------------*/
            Registro_F0_C4[1] = Convert.ToInt16((DC_F0_C4[1] * 9999f) / 100f);
            Registro_F0_C4[2] = Convert.ToInt16((DC_F0_C4[2] * 9999f) / 100f);
            Registro_F0_C4[3] = Convert.ToInt16((DC_F0_C4[3] * 9999f) / 100f);
            Registro_F0_C4[4] = Convert.ToInt16((DC_F0_C4[4] * 9999f) / 100f);
            Registro_F0_C4[5] = Convert.ToInt16((DC_F0_C4[5] * 9999f) / 100f);
            Registro_F0_C4[6] = Convert.ToInt16((DC_F0_C4[6] * 9999f) / 100f);
            Registro_F0_C4[7] = Convert.ToInt16((DC_F0_C4[7] * 9999f) / 100f);
            Registro_F0_C4[8] = Convert.ToInt16((DC_F0_C4[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F1 C0 ---------------------------------------*/
            Registro_F1_C0[1] = Convert.ToInt16((DC_F1_C0[1] * 9999f) / 100f);
            Registro_F1_C0[2] = Convert.ToInt16((DC_F1_C0[2] * 9999f) / 100f);
            Registro_F1_C0[3] = Convert.ToInt16((DC_F1_C0[3] * 9999f) / 100f);
            Registro_F1_C0[4] = Convert.ToInt16((DC_F1_C0[4] * 9999f) / 100f);
            Registro_F1_C0[5] = Convert.ToInt16((DC_F1_C0[5] * 9999f) / 100f);
            Registro_F1_C0[6] = Convert.ToInt16((DC_F1_C0[6] * 9999f) / 100f);
            Registro_F1_C0[7] = Convert.ToInt16((DC_F1_C0[7] * 9999f) / 100f);
            Registro_F1_C0[8] = Convert.ToInt16((DC_F1_C0[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F1 C1 ---------------------------------------*/
            Registro_F1_C1[1] = Convert.ToInt16((DC_F1_C1[1] * 9999f) / 100f);
            Registro_F1_C1[2] = Convert.ToInt16((DC_F1_C1[2] * 9999f) / 100f);
            Registro_F1_C1[3] = Convert.ToInt16((DC_F1_C1[3] * 9999f) / 100f);
            Registro_F1_C1[4] = Convert.ToInt16((DC_F1_C1[4] * 9999f) / 100f);
            Registro_F1_C1[5] = Convert.ToInt16((DC_F1_C1[5] * 9999f) / 100f);
            Registro_F1_C1[6] = Convert.ToInt16((DC_F1_C1[6] * 9999f) / 100f);
            Registro_F1_C1[7] = Convert.ToInt16((DC_F1_C1[7] * 9999f) / 100f);
            Registro_F1_C1[8] = Convert.ToInt16((DC_F1_C1[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F1 C2 ---------------------------------------*/
            Registro_F1_C2[1] = Convert.ToInt16((DC_F1_C2[1] * 9999f) / 100f);
            Registro_F1_C2[2] = Convert.ToInt16((DC_F1_C2[2] * 9999f) / 100f);
            Registro_F1_C2[3] = Convert.ToInt16((DC_F1_C2[3] * 9999f) / 100f);
            Registro_F1_C2[4] = Convert.ToInt16((DC_F1_C2[4] * 9999f) / 100f);
            Registro_F1_C2[5] = Convert.ToInt16((DC_F1_C2[5] * 9999f) / 100f);
            Registro_F1_C2[6] = Convert.ToInt16((DC_F1_C2[6] * 9999f) / 100f);
            Registro_F1_C2[7] = Convert.ToInt16((DC_F1_C2[7] * 9999f) / 100f);
            Registro_F1_C2[8] = Convert.ToInt16((DC_F1_C2[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F1 C3 ---------------------------------------*/
            Registro_F1_C3[1] = Convert.ToInt16((DC_F1_C3[1] * 9999f) / 100f);
            Registro_F1_C3[2] = Convert.ToInt16((DC_F1_C3[2] * 9999f) / 100f);
            Registro_F1_C3[3] = Convert.ToInt16((DC_F1_C3[3] * 9999f) / 100f);
            Registro_F1_C3[4] = Convert.ToInt16((DC_F1_C3[4] * 9999f) / 100f);
            Registro_F1_C3[5] = Convert.ToInt16((DC_F1_C3[5] * 9999f) / 100f);
            Registro_F1_C3[6] = Convert.ToInt16((DC_F1_C3[6] * 9999f) / 100f);
            Registro_F1_C3[7] = Convert.ToInt16((DC_F1_C3[7] * 9999f) / 100f);
            Registro_F1_C3[8] = Convert.ToInt16((DC_F1_C3[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F1 C4 ---------------------------------------*/
            Registro_F1_C4[1] = Convert.ToInt16((DC_F1_C4[1] * 9999f) / 100f);
            Registro_F1_C4[2] = Convert.ToInt16((DC_F1_C4[2] * 9999f) / 100f);
            Registro_F1_C4[3] = Convert.ToInt16((DC_F1_C4[3] * 9999f) / 100f);
            Registro_F1_C4[4] = Convert.ToInt16((DC_F1_C4[4] * 9999f) / 100f);
            Registro_F1_C4[5] = Convert.ToInt16((DC_F1_C4[5] * 9999f) / 100f);
            Registro_F1_C4[6] = Convert.ToInt16((DC_F1_C4[6] * 9999f) / 100f);
            Registro_F1_C4[7] = Convert.ToInt16((DC_F1_C4[7] * 9999f) / 100f);
            Registro_F1_C4[8] = Convert.ToInt16((DC_F1_C4[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/



            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C0 ---------------------------------------*/
            Registro_F2_C0[1] = Convert.ToInt16((DC_F2_C0[1] * 9999f) / 100f);
            Registro_F2_C0[2] = Convert.ToInt16((DC_F2_C0[2] * 9999f) / 100f);
            Registro_F2_C0[3] = Convert.ToInt16((DC_F2_C0[3] * 9999f) / 100f);
            Registro_F2_C0[4] = Convert.ToInt16((DC_F2_C0[4] * 9999f) / 100f);
            Registro_F2_C0[5] = Convert.ToInt16((DC_F2_C0[5] * 9999f) / 100f);
            Registro_F2_C0[6] = Convert.ToInt16((DC_F2_C0[6] * 9999f) / 100f);
            Registro_F2_C0[7] = Convert.ToInt16((DC_F2_C0[7] * 9999f) / 100f);
            Registro_F2_C0[8] = Convert.ToInt16((DC_F2_C0[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C1 ---------------------------------------*/
            Registro_F2_C1[1] = Convert.ToInt16((DC_F2_C1[1] * 9999f) / 100f);
            Registro_F2_C1[2] = Convert.ToInt16((DC_F2_C1[2] * 9999f) / 100f);
            Registro_F2_C1[3] = Convert.ToInt16((DC_F2_C1[3] * 9999f) / 100f);
            Registro_F2_C1[4] = Convert.ToInt16((DC_F2_C1[4] * 9999f) / 100f);
            Registro_F2_C1[5] = Convert.ToInt16((DC_F2_C1[5] * 9999f) / 100f);
            Registro_F2_C1[6] = Convert.ToInt16((DC_F2_C1[6] * 9999f) / 100f);
            Registro_F2_C1[7] = Convert.ToInt16((DC_F2_C1[7] * 9999f) / 100f);
            Registro_F2_C1[8] = Convert.ToInt16((DC_F2_C1[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C2 ---------------------------------------*/
            Registro_F2_C2[1] = Convert.ToInt16((DC_F2_C2[1] * 9999f) / 100f);
            Registro_F2_C2[2] = Convert.ToInt16((DC_F2_C2[2] * 9999f) / 100f);
            Registro_F2_C2[3] = Convert.ToInt16((DC_F2_C2[3] * 9999f) / 100f);
            Registro_F2_C2[4] = Convert.ToInt16((DC_F2_C2[4] * 9999f) / 100f);
            Registro_F2_C2[5] = Convert.ToInt16((DC_F2_C2[5] * 9999f) / 100f);
            Registro_F2_C2[6] = Convert.ToInt16((DC_F2_C2[6] * 9999f) / 100f);
            Registro_F2_C2[7] = Convert.ToInt16((DC_F2_C2[7] * 9999f) / 100f);
            Registro_F2_C2[8] = Convert.ToInt16((DC_F2_C2[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C3 ---------------------------------------*/
            Registro_F2_C3[1] = Convert.ToInt16((DC_F2_C3[1] * 9999f) / 100f);
            Registro_F2_C3[2] = Convert.ToInt16((DC_F2_C3[2] * 9999f) / 100f);
            Registro_F2_C3[3] = Convert.ToInt16((DC_F2_C3[3] * 9999f) / 100f);
            Registro_F2_C3[4] = Convert.ToInt16((DC_F2_C3[4] * 9999f) / 100f);
            Registro_F2_C3[5] = Convert.ToInt16((DC_F2_C3[5] * 9999f) / 100f);
            Registro_F2_C3[6] = Convert.ToInt16((DC_F2_C3[6] * 9999f) / 100f);
            Registro_F2_C3[7] = Convert.ToInt16((DC_F2_C3[7] * 9999f) / 100f);
            Registro_F2_C3[8] = Convert.ToInt16((DC_F2_C3[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C4 ---------------------------------------*/
            Registro_F2_C4[1] = Convert.ToInt16((DC_F2_C4[1] * 9999f) / 100f);
            Registro_F2_C4[2] = Convert.ToInt16((DC_F2_C4[2] * 9999f) / 100f);
            Registro_F2_C4[3] = Convert.ToInt16((DC_F2_C4[3] * 9999f) / 100f);
            Registro_F2_C4[4] = Convert.ToInt16((DC_F2_C4[4] * 9999f) / 100f);
            Registro_F2_C4[5] = Convert.ToInt16((DC_F2_C4[5] * 9999f) / 100f);
            Registro_F2_C4[6] = Convert.ToInt16((DC_F2_C4[6] * 9999f) / 100f);
            Registro_F2_C4[7] = Convert.ToInt16((DC_F2_C4[7] * 9999f) / 100f);
            Registro_F2_C4[8] = Convert.ToInt16((DC_F2_C4[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/









        }



        public void Imprimir_Reistro_Tablas()
        {

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C0-------------------------------------------*/
            TextBox_F0_Campo0_Min.Text = Registro_F0_C0[0].ToString();
            TextBox_F0_Campo0_1.Text = Registro_F0_C0[1].ToString();
            TextBox_F0_Campo0_2.Text = Registro_F0_C0[2].ToString();
            TextBox_F0_Campo0_3.Text = Registro_F0_C0[3].ToString();
            TextBox_F0_Campo0_4.Text = Registro_F0_C0[4].ToString();
            TextBox_F0_Campo0_5.Text = Registro_F0_C0[5].ToString();
            TextBox_F0_Campo0_6.Text = Registro_F0_C0[6].ToString();
            TextBox_F0_Campo0_7.Text = Registro_F0_C0[7].ToString();
            TextBox_F0_Campo0_8.Text = Registro_F0_C0[8].ToString();
            TextBox_F0_Campo0_Max.Text = Registro_F0_C0[9].ToString();

            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C1-------------------------------------------*/
            TextBox_F0_Campo1_Min.Text = Registro_F0_C1[0].ToString();
            TextBox_F0_Campo1_1.Text = Registro_F0_C1[1].ToString();
            TextBox_F0_Campo1_2.Text = Registro_F0_C1[2].ToString();
            TextBox_F0_Campo1_3.Text = Registro_F0_C1[3].ToString();
            TextBox_F0_Campo1_4.Text = Registro_F0_C1[4].ToString();
            TextBox_F0_Campo1_5.Text = Registro_F0_C1[5].ToString();
            TextBox_F0_Campo1_6.Text = Registro_F0_C1[6].ToString();
            TextBox_F0_Campo1_7.Text = Registro_F0_C1[7].ToString();
            TextBox_F0_Campo1_8.Text = Registro_F0_C1[8].ToString();
            TextBox_F0_Campo1_Max.Text = Registro_F0_C1[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C2-------------------------------------------*/
            TextBox_F0_Campo2_Min.Text = Registro_F0_C2[0].ToString();
            TextBox_F0_Campo2_1.Text = Registro_F0_C2[1].ToString();
            TextBox_F0_Campo2_2.Text = Registro_F0_C2[2].ToString();
            TextBox_F0_Campo2_3.Text = Registro_F0_C2[3].ToString();
            TextBox_F0_Campo2_4.Text = Registro_F0_C2[4].ToString();
            TextBox_F0_Campo2_5.Text = Registro_F0_C2[5].ToString();
            TextBox_F0_Campo2_6.Text = Registro_F0_C2[6].ToString();
            TextBox_F0_Campo2_7.Text = Registro_F0_C2[7].ToString();
            TextBox_F0_Campo2_8.Text = Registro_F0_C2[8].ToString();
            TextBox_F0_Campo2_Max.Text = Registro_F0_C2[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C3-------------------------------------------*/
            TextBox_F0_Campo3_Min.Text = Registro_F0_C3[0].ToString();
            TextBox_F0_Campo3_1.Text = Registro_F0_C3[1].ToString();
            TextBox_F0_Campo3_2.Text = Registro_F0_C3[2].ToString();
            TextBox_F0_Campo3_3.Text = Registro_F0_C3[3].ToString();
            TextBox_F0_Campo3_4.Text = Registro_F0_C3[4].ToString();
            TextBox_F0_Campo3_5.Text = Registro_F0_C3[5].ToString();
            TextBox_F0_Campo3_6.Text = Registro_F0_C3[6].ToString();
            TextBox_F0_Campo3_7.Text = Registro_F0_C3[7].ToString();
            TextBox_F0_Campo3_8.Text = Registro_F0_C3[8].ToString();
            TextBox_F0_Campo3_Max.Text = Registro_F0_C3[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C4-------------------------------------------*/
            TextBox_F0_Campo4_Min.Text = Registro_F0_C4[0].ToString();
            TextBox_F0_Campo4_1.Text = Registro_F0_C4[1].ToString();
            TextBox_F0_Campo4_2.Text = Registro_F0_C4[2].ToString();
            TextBox_F0_Campo4_3.Text = Registro_F0_C4[3].ToString();
            TextBox_F0_Campo4_4.Text = Registro_F0_C4[4].ToString();
            TextBox_F0_Campo4_5.Text = Registro_F0_C4[5].ToString();
            TextBox_F0_Campo4_6.Text = Registro_F0_C4[6].ToString();
            TextBox_F0_Campo4_7.Text = Registro_F0_C4[7].ToString();
            TextBox_F0_Campo4_8.Text = Registro_F0_C4[8].ToString();
            TextBox_F0_Campo4_Max.Text = Registro_F0_C4[9].ToString();

            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C0-------------------------------------------*/
            TextBox_F1_Campo0_Min.Text = Registro_F1_C0[0].ToString();
            TextBox_F1_Campo0_1.Text = Registro_F1_C0[1].ToString();
            TextBox_F1_Campo0_2.Text = Registro_F1_C0[2].ToString();
            TextBox_F1_Campo0_3.Text = Registro_F1_C0[3].ToString();
            TextBox_F1_Campo0_4.Text = Registro_F1_C0[4].ToString();
            TextBox_F1_Campo0_5.Text = Registro_F1_C0[5].ToString();
            TextBox_F1_Campo0_6.Text = Registro_F1_C0[6].ToString();
            TextBox_F1_Campo0_7.Text = Registro_F1_C0[7].ToString();
            TextBox_F1_Campo0_8.Text = Registro_F1_C0[8].ToString();
            TextBox_F1_Campo0_Max.Text = Registro_F1_C0[9].ToString();

            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C1-------------------------------------------*/
            TextBox_F1_Campo1_Min.Text = Registro_F1_C1[0].ToString();
            TextBox_F1_Campo1_1.Text = Registro_F1_C1[1].ToString();
            TextBox_F1_Campo1_2.Text = Registro_F1_C1[2].ToString();
            TextBox_F1_Campo1_3.Text = Registro_F1_C1[3].ToString();
            TextBox_F1_Campo1_4.Text = Registro_F1_C1[4].ToString();
            TextBox_F1_Campo1_5.Text = Registro_F1_C1[5].ToString();
            TextBox_F1_Campo1_6.Text = Registro_F1_C1[6].ToString();
            TextBox_F1_Campo1_7.Text = Registro_F1_C1[7].ToString();
            TextBox_F1_Campo1_8.Text = Registro_F1_C1[8].ToString();
            TextBox_F1_Campo1_Max.Text = Registro_F1_C1[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C2-------------------------------------------*/
            TextBox_F1_Campo2_Min.Text = Registro_F1_C2[0].ToString();
            TextBox_F1_Campo2_1.Text = Registro_F1_C2[1].ToString();
            TextBox_F1_Campo2_2.Text = Registro_F1_C2[2].ToString();
            TextBox_F1_Campo2_3.Text = Registro_F1_C2[3].ToString();
            TextBox_F1_Campo2_4.Text = Registro_F1_C2[4].ToString();
            TextBox_F1_Campo2_5.Text = Registro_F1_C2[5].ToString();
            TextBox_F1_Campo2_6.Text = Registro_F1_C2[6].ToString();
            TextBox_F1_Campo2_7.Text = Registro_F1_C2[7].ToString();
            TextBox_F1_Campo2_8.Text = Registro_F1_C2[8].ToString();
            TextBox_F1_Campo2_Max.Text = Registro_F1_C2[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C3-------------------------------------------*/
            TextBox_F1_Campo3_Min.Text = Registro_F1_C3[0].ToString();
            TextBox_F1_Campo3_1.Text = Registro_F1_C3[1].ToString();
            TextBox_F1_Campo3_2.Text = Registro_F1_C3[2].ToString();
            TextBox_F1_Campo3_3.Text = Registro_F1_C3[3].ToString();
            TextBox_F1_Campo3_4.Text = Registro_F1_C3[4].ToString();
            TextBox_F1_Campo3_5.Text = Registro_F1_C3[5].ToString();
            TextBox_F1_Campo3_6.Text = Registro_F1_C3[6].ToString();
            TextBox_F1_Campo3_7.Text = Registro_F1_C3[7].ToString();
            TextBox_F1_Campo3_8.Text = Registro_F1_C3[8].ToString();
            TextBox_F1_Campo3_Max.Text = Registro_F1_C3[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C4-------------------------------------------*/
            TextBox_F1_Campo4_Min.Text = Registro_F1_C4[0].ToString();
            TextBox_F1_Campo4_1.Text = Registro_F1_C4[1].ToString();
            TextBox_F1_Campo4_2.Text = Registro_F1_C4[2].ToString();
            TextBox_F1_Campo4_3.Text = Registro_F1_C4[3].ToString();
            TextBox_F1_Campo4_4.Text = Registro_F1_C4[4].ToString();
            TextBox_F1_Campo4_5.Text = Registro_F1_C4[5].ToString();
            TextBox_F1_Campo4_6.Text = Registro_F1_C4[6].ToString();
            TextBox_F1_Campo4_7.Text = Registro_F1_C4[7].ToString();
            TextBox_F1_Campo4_8.Text = Registro_F1_C4[8].ToString();
            TextBox_F1_Campo4_Max.Text = Registro_F1_C4[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C0-------------------------------------------*/
            TextBox_F2_Campo0_Min.Text = Registro_F2_C0[0].ToString();
            TextBox_F2_Campo0_1.Text = Registro_F2_C0[1].ToString();
            TextBox_F2_Campo0_2.Text = Registro_F2_C0[2].ToString();
            TextBox_F2_Campo0_3.Text = Registro_F2_C0[3].ToString();
            TextBox_F2_Campo0_4.Text = Registro_F2_C0[4].ToString();
            TextBox_F2_Campo0_5.Text = Registro_F2_C0[5].ToString();
            TextBox_F2_Campo0_6.Text = Registro_F2_C0[6].ToString();
            TextBox_F2_Campo0_7.Text = Registro_F2_C0[7].ToString();
            TextBox_F2_Campo0_8.Text = Registro_F2_C0[8].ToString();
            TextBox_F2_Campo0_Max.Text = Registro_F2_C0[9].ToString();

            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C1-------------------------------------------*/
            TextBox_F2_Campo1_Min.Text = Registro_F2_C1[0].ToString();
            TextBox_F2_Campo1_1.Text = Registro_F2_C1[1].ToString();
            TextBox_F2_Campo1_2.Text = Registro_F2_C1[2].ToString();
            TextBox_F2_Campo1_3.Text = Registro_F2_C1[3].ToString();
            TextBox_F2_Campo1_4.Text = Registro_F2_C1[4].ToString();
            TextBox_F2_Campo1_5.Text = Registro_F2_C1[5].ToString();
            TextBox_F2_Campo1_6.Text = Registro_F2_C1[6].ToString();
            TextBox_F2_Campo1_7.Text = Registro_F2_C1[7].ToString();
            TextBox_F2_Campo1_8.Text = Registro_F2_C1[8].ToString();
            TextBox_F2_Campo1_Max.Text = Registro_F2_C1[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C2-------------------------------------------*/
            TextBox_F2_Campo2_Min.Text = Registro_F2_C2[0].ToString();
            TextBox_F2_Campo2_1.Text = Registro_F2_C2[1].ToString();
            TextBox_F2_Campo2_2.Text = Registro_F2_C2[2].ToString();
            TextBox_F2_Campo2_3.Text = Registro_F2_C2[3].ToString();
            TextBox_F2_Campo2_4.Text = Registro_F2_C2[4].ToString();
            TextBox_F2_Campo2_5.Text = Registro_F2_C2[5].ToString();
            TextBox_F2_Campo2_6.Text = Registro_F2_C2[6].ToString();
            TextBox_F2_Campo2_7.Text = Registro_F2_C2[7].ToString();
            TextBox_F2_Campo2_8.Text = Registro_F2_C2[8].ToString();
            TextBox_F2_Campo2_Max.Text = Registro_F2_C2[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C3-------------------------------------------*/
            TextBox_F2_Campo3_Min.Text = Registro_F2_C3[0].ToString();
            TextBox_F2_Campo3_1.Text = Registro_F2_C3[1].ToString();
            TextBox_F2_Campo3_2.Text = Registro_F2_C3[2].ToString();
            TextBox_F2_Campo3_3.Text = Registro_F2_C3[3].ToString();
            TextBox_F2_Campo3_4.Text = Registro_F2_C3[4].ToString();
            TextBox_F2_Campo3_5.Text = Registro_F2_C3[5].ToString();
            TextBox_F2_Campo3_6.Text = Registro_F2_C3[6].ToString();
            TextBox_F2_Campo3_7.Text = Registro_F2_C3[7].ToString();
            TextBox_F2_Campo3_8.Text = Registro_F2_C3[8].ToString();
            TextBox_F2_Campo3_Max.Text = Registro_F2_C3[9].ToString();

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C4-------------------------------------------*/
            TextBox_F2_Campo4_Min.Text = Registro_F2_C4[0].ToString();
            TextBox_F2_Campo4_1.Text = Registro_F2_C4[1].ToString();
            TextBox_F2_Campo4_2.Text = Registro_F2_C4[2].ToString();
            TextBox_F2_Campo4_3.Text = Registro_F2_C4[3].ToString();
            TextBox_F2_Campo4_4.Text = Registro_F2_C4[4].ToString();
            TextBox_F2_Campo4_5.Text = Registro_F2_C4[5].ToString();
            TextBox_F2_Campo4_6.Text = Registro_F2_C4[6].ToString();
            TextBox_F2_Campo4_7.Text = Registro_F2_C4[7].ToString();
            TextBox_F2_Campo4_8.Text = Registro_F2_C4[8].ToString();
            TextBox_F2_Campo4_Max.Text = Registro_F2_C4[9].ToString();

            /*--------------------------------------------------------------------------------*/







        }




        public void Preguntar_Si_Cero()
        {
            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F0 C0------------------------------------------------*/
            if ((Registro_F0_C0[0] == 0) || (Registro_F0_C0[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador =0; contador <= 9; contador++)
                {
                    Registro_F0_C0[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {
                   
                    Incremento_F0_C0[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {
                    
                    DC_F0_C0[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {
                    
                    mA_F0_C0[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F0 C1 ------------------------------------------------*/
            if ((Registro_F0_C1[0] == 0) || (Registro_F0_C1[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F0_C1[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C1[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C1[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C1[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F0 C2 ------------------------------------------------*/
            if ((Registro_F0_C2[0] == 0) || (Registro_F0_C2[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F0_C2[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C2[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C2[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C2[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F0 C3 ------------------------------------------------*/
            if ((Registro_F0_C3[0] == 0) || (Registro_F0_C3[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F0_C3[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C3[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C3[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C3[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/



            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F0 C4 ------------------------------------------------*/
            if ((Registro_F0_C4[0] == 0) || (Registro_F0_C4[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F0_C4[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C4[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C4[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C4[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/



            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F1 C0------------------------------------------------*/
            if ((Registro_F1_C0[0] == 0) || (Registro_F1_C0[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F1_C0[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C0[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C0[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C0[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F1 C1 ------------------------------------------------*/
            if ((Registro_F1_C1[0] == 0) || (Registro_F1_C1[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F1_C1[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C1[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C1[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C1[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F1 C2 ------------------------------------------------*/
            if ((Registro_F1_C2[0] == 0) || (Registro_F1_C2[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F1_C2[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C2[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C2[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C2[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F1 C3 ------------------------------------------------*/
            if ((Registro_F1_C3[0] == 0) || (Registro_F1_C3[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F1_C3[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C3[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C3[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C3[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/



            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F1 C4 ------------------------------------------------*/
            if ((Registro_F1_C4[0] == 0) || (Registro_F1_C4[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F1_C4[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C4[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C4[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C4[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/



            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F2 C0------------------------------------------------*/
            if ((Registro_F2_C0[0] == 0) || (Registro_F2_C0[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F2_C0[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C0[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C0[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C0[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F2 C1 ------------------------------------------------*/
            if ((Registro_F2_C1[0] == 0) || (Registro_F2_C1[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F2_C1[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C1[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C1[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C1[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F2 C2 ------------------------------------------------*/
            if ((Registro_F2_C2[0] == 0) || (Registro_F2_C2[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F2_C2[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C2[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C2[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C2[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/


            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F2 C3 ------------------------------------------------*/
            if ((Registro_F2_C3[0] == 0) || (Registro_F2_C3[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F2_C3[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C3[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C3[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C3[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/



            /*----------------------------------------------------------------------------------*/
            /*----------------------------------F2 C4 ------------------------------------------------*/
            if ((Registro_F2_C4[0] == 0) || (Registro_F2_C4[9] == 0))
            {

                /********************REGISTRO **************************/
                for (byte contador = 0; contador <= 9; contador++)
                {
                    Registro_F2_C4[contador] = 0000;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C4[contador] = 0000;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C4[contador] = 0000;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C4[contador] = 0000;

                }


            }


            /*----------------------------------------------------------------------------------*/















        }



        



        public void Preguntar_Mayor_9999()
        {



            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F0 MIN-----------------------------------------------*/

            if ((Registro_F0_C0[0] > 9999) )
            {
                Registro_F0_C0[0] = 9999;


            }

            if ((Registro_F0_C1[0] > 9999) )
            {
                Registro_F0_C1[0] = 9999;
            }

            if ((Registro_F0_C2[0] > 9999) )
            {
                Registro_F0_C2[0] = 9999;
            }

            if ((Registro_F0_C3[0] > 9999) )
            {
                Registro_F0_C3[0] = 9999;
            }

            if ((Registro_F0_C4[0] > 9999) )
            {
                Registro_F0_C4[0] = 9999;
            }

            /*--------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F1  MIN-----------------------------------------------*/

            if ((Registro_F1_C0[0] > 9999) )
            {
                Registro_F1_C0[0] = 9999;
            }

            if ((Registro_F1_C1[0] > 9999) )
            {
                Registro_F1_C1[0] = 9999;
            }

            if ((Registro_F1_C2[0] > 9999) )
            {
                Registro_F1_C2[0] = 9999;
            }

            if ((Registro_F1_C3[0] > 9999) )
            {
                Registro_F1_C3[0] = 9999;
            }

            if ((Registro_F1_C4[0] > 9999) )
            {
                Registro_F1_C4[0] = 9999;
            }

            /*--------------------------------------------------------------------------------------*/








            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F2  MIN-----------------------------------------------*/

            if ((Registro_F2_C0[0] > 9999) )
            {
                Registro_F2_C0[0] = 9999;
            }

            if ((Registro_F2_C1[0] > 9999) )
            {
                Registro_F2_C1[0] = 9999;
            }

            if ((Registro_F2_C2[0] > 9999) )
            {
                Registro_F2_C2[0] = 9999;
            }

            if ((Registro_F2_C3[0] > 9999) )
            {
                Registro_F2_C3[0] = 9999;
            }

            if ((Registro_F2_C4[0] > 9999) )
            {
                Registro_F2_C4[0] = 9999;
            }

            /*--------------------------------------------------------------------------------------*/




            /*---------------------------------------MAX-----------------------------------------------*/
            /*---------------------------------F0 MAX-----------------------------------------------*/

            if ((Registro_F0_C0[9] > 9999) )
            {
                Registro_F0_C0[9] = 9999;
            }

            if ((Registro_F0_C1[9] > 9999) )
            {
                Registro_F0_C1[9] = 9999;
            }

            if ((Registro_F0_C2[9] > 9999) )
            {
                Registro_F0_C2[9] = 9999;
            }

            if ((Registro_F0_C3[9] > 9999) )
            {
                Registro_F0_C3[9] = 9999;
            }

            if ((Registro_F0_C4[9] > 9999 ) )
            {
                Registro_F0_C4[9] = 9999;
            }

            /*--------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F1  MAX-----------------------------------------------*/

            if ((Registro_F1_C0[9] > 9999) )
            {
                Registro_F1_C0[9] = 9999;
            }

            if ((Registro_F1_C1[9] > 9999) )
            {
                Registro_F1_C1[9] = 9999;
            }

            if ((Registro_F1_C2[9] > 9999) )
            {
                Registro_F1_C2[9] = 9999;
            }

            if ((Registro_F1_C3[9] > 9999) )
            {
                Registro_F1_C3[9] = 9999;
            }

            if ((Registro_F1_C4[9] > 9999) )
            {
                Registro_F1_C4[9] = 9999;
            }

            /*--------------------------------------------------------------------------------------*/








            /*--------------------------------------------------------------------------------------*/
            /*---------------------------------F2  MAX-----------------------------------------------*/

            if ((Registro_F2_C0[9] > 9999) )
            {
                Registro_F2_C0[9] = 9999;
            }

            if ((Registro_F2_C1[9] > 9999) )
            {
                Registro_F2_C1[9] = 9999;
            }

            if ((Registro_F2_C2[9] > 9999) )
            {
                Registro_F2_C2[9] = 9999;
            }

            if ((Registro_F2_C3[9] > 9999))
            {
                Registro_F2_C3[9] = 9999;
            }

            if ((Registro_F2_C4[9] > 9999) )
            {
                Registro_F2_C4[9] = 9999;
            }

            /*--------------------------------------------------------------------------------------*/




        }


        public void Convertir_Entero() // convertirmos los valores flotantes a enteros 
        {

            /*Primero convertirmos todo en int*/
            /*------------------F0----------------------------------------*/
            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F0_C0[contador] = Convert.ToInt32(Registro_F0_C0[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F0_C1[contador] = Convert.ToInt32(Registro_F0_C1[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F0_C2[contador] = Convert.ToInt32(Registro_F0_C2[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F0_C3[contador] = Convert.ToInt32(Registro_F0_C3[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F0_C4[contador] = Convert.ToInt32(Registro_F0_C4[contador]);
            }
            /*----------------------------------------------------------------------------*/


            /*Primero convertirmos todo en int*/
            /*------------------F1----------------------------------------*/
            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F1_C0[contador] = Convert.ToInt32(Registro_F1_C0[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F1_C1[contador] = Convert.ToInt32(Registro_F1_C1[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F1_C2[contador] = Convert.ToInt32(Registro_F1_C2[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F1_C3[contador] = Convert.ToInt32(Registro_F1_C3[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F1_C4[contador] = Convert.ToInt32(Registro_F1_C4[contador]);
            }
            /*----------------------------------------------------------------------------*/




            /*Primero convertirmos todo en int*/
            /*------------------F2----------------------------------------*/
            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F2_C0[contador] = Convert.ToInt32(Registro_F2_C0[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F2_C1[contador] = Convert.ToInt32(Registro_F2_C1[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F2_C2[contador] = Convert.ToInt32(Registro_F2_C2[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F2_C3[contador] = Convert.ToInt32(Registro_F2_C3[contador]);
            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Num_F2_C4[contador] = Convert.ToInt32(Registro_F2_C4[contador]);
            }
            /*----------------------------------------------------------------------------*/

        }

        public void Covnertir_a_String() // convertirmos a strings
        {



            //Ahora debemos de pasar los enteros a string 

            /*----------------------F0---------------------------------------*/


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F0_C0[contador] = Num_F0_C0[contador].ToString("D4");

            }


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F0_C1[contador] = Num_F0_C1[contador].ToString("D4");

            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F0_C2[contador] = Num_F0_C2[contador].ToString("D4");

            }


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F0_C3[contador] = Num_F0_C3[contador].ToString("D4");

            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F0_C4[contador] = Num_F0_C4[contador].ToString("D4");

            }



            /*----------------------------------------------------------------------------*/



            /*----------------------F1---------------------------------------*/


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F1_C0[contador] = Num_F1_C0[contador].ToString("D4");

            }


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F1_C1[contador] = Num_F1_C1[contador].ToString("D4");

            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F1_C2[contador] = Num_F1_C2[contador].ToString("D4");

            }


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F1_C3[contador] = Num_F1_C3[contador].ToString("D4");

            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F1_C4[contador] = Num_F1_C4[contador].ToString("D4");

            }



            /*----------------------------------------------------------------------------*/






            /*----------------------F2---------------------------------------*/


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F2_C0[contador] = Num_F2_C0[contador].ToString("D4");

            }


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F2_C1[contador] = Num_F2_C1[contador].ToString("D4");

            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F2_C2[contador] = Num_F2_C2[contador].ToString("D4");

            }


            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F2_C3[contador] = Num_F2_C3[contador].ToString("D4");

            }

            for (byte contador = 0; contador <= 9; contador++)
            {
                Val_F2_C4[contador] = Num_F2_C4[contador].ToString("D4");

            }



            /*----------------------------------------------------------------------------*/

        }

        public void Serial_IndexVolt()// esta funcion se ejecuta despues de que se envia el comando de lectura de voltajes
        {

            try
            {
                indexOfA = Convert.ToInt32(SerialDataIn.IndexOf("A"));
                indexOfB = Convert.ToInt32(SerialDataIn.IndexOf("B"));
                indexOfC = Convert.ToInt32(SerialDataIn.IndexOf("C"));
                indexOfD = Convert.ToInt32(SerialDataIn.IndexOf("D"));
                indexOfE = Convert.ToInt32(SerialDataIn.IndexOf("E"));
                indexOfF = Convert.ToInt32(SerialDataIn.IndexOf("F"));



                String_F0_C0_MIN = SerialDataIn.Substring(0, indexOfA);
                tempTextBox.Text = String_F0_C0_MIN;//IMPRIMIRMOS EL VALOR 



                String_F0_C0_MAX = SerialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                voltTextBox.Text = String_F0_C0_MAX;



                String_F0_C1_MIN = SerialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                If0TextBox.Text = String_F0_C1_MIN;


                String_F0_C1_MAX = SerialDataIn.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                f0.Text = String_F0_C1_MAX;


                String_F0_C2_MIN = SerialDataIn.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                f1.Text = String_F0_C2_MIN;

                String_F0_C2_MAX = SerialDataIn.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);
                f2.Text = String_F0_C2_MAX;

                SerialDataIn = null;

                //////////////////////////////////////////////////////////////////////////////////////////
                /*
                StringTemp = SerialDataIn.Substring(0, indexOff);
                tempTextBox.Text = StringTemp;//IMPRIMIRMOS EL VALOR 

                StringVolt = SerialDataIn.Substring(indexOff + 1, (indexOfg - indexOff) - 1);
                voltTextBox.Text = StringVolt;

                StringI = SerialDataIn.Substring(indexOfg + 1, (indexOfh - indexOfg) - 1);
                If0TextBox.Text = StringI;



                StringF0 = SerialDataIn.Substring(indexOfh + 1, (indexOfi - indexOfh) - 1);
                TextBox_F0_Campo1_Max.Text = StringF0;


                StringF1 = SerialDataIn.Substring(indexOfi + 1, (indexOfj - indexOfi) - 1);
                TextBox_F0_Campo2_Min.Text = StringF1;


                StringF2 = SerialDataIn.Substring(indexOfj + 1, (indexOfk - indexOfj) - 1);
                TextBox_F0_Campo2_Max.Text = StringF2;

                SerialDataIn2 = null;

                */



            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }



        }
        public void Serial_Index()// esta funcion se ejecuta despues de que se envia el comando de lectura [R] y realiza la index de la trama serial
        {

            try
            {
                indexOfA = Convert.ToInt32(SerialDataIn.IndexOf("A"));
                indexOfB = Convert.ToInt32(SerialDataIn.IndexOf("B"));
                indexOfC = Convert.ToInt32(SerialDataIn.IndexOf("C"));
                indexOfD = Convert.ToInt32(SerialDataIn.IndexOf("D"));
                indexOfE = Convert.ToInt32(SerialDataIn.IndexOf("E"));
                indexOfF = Convert.ToInt32(SerialDataIn.IndexOf("F"));
                indexOfG = Convert.ToInt32(SerialDataIn.IndexOf("G"));
                indexOfH = Convert.ToInt32(SerialDataIn.IndexOf("H"));
                indexOfI = Convert.ToInt32(SerialDataIn.IndexOf("I"));
                indexOfJ = Convert.ToInt32(SerialDataIn.IndexOf("J"));

                indexOfK = Convert.ToInt32(SerialDataIn.IndexOf("K"));
                indexOfL = Convert.ToInt32(SerialDataIn.IndexOf("L"));
                indexOfM = Convert.ToInt32(SerialDataIn.IndexOf("M"));
                indexOfN = Convert.ToInt32(SerialDataIn.IndexOf("N"));
                indexOfO = Convert.ToInt32(SerialDataIn.IndexOf("O"));
                indexOfP = Convert.ToInt32(SerialDataIn.IndexOf("P"));
                indexOfQ = Convert.ToInt32(SerialDataIn.IndexOf("Q"));
                indexOfR = Convert.ToInt32(SerialDataIn.IndexOf("R"));
                indexOfS = Convert.ToInt32(SerialDataIn.IndexOf("S"));
                indexOfT = Convert.ToInt32(SerialDataIn.IndexOf("T"));



                indexOfU = Convert.ToInt32(SerialDataIn.IndexOf("U"));
                indexOfV = Convert.ToInt32(SerialDataIn.IndexOf("V"));
                indexOfW = Convert.ToInt32(SerialDataIn.IndexOf("W"));
                indexOfX = Convert.ToInt32(SerialDataIn.IndexOf("X"));
                indexOfY = Convert.ToInt32(SerialDataIn.IndexOf("Y"));
                indexOfZ = Convert.ToInt32(SerialDataIn.IndexOf("Z"));
                indexOfa = Convert.ToInt32(SerialDataIn.IndexOf("a"));
                indexOfb = Convert.ToInt32(SerialDataIn.IndexOf("b"));
                indexOfc = Convert.ToInt32(SerialDataIn.IndexOf("c"));
                indexOfd = Convert.ToInt32(SerialDataIn.IndexOf("d"));


                String_F0_C0_MIN = SerialDataIn.Substring(0, indexOfA);
                TextBox_F0_Campo0_Min.Text = String_F0_C0_MIN;//IMPRIMIRMOS EL VALOR 



                String_F0_C0_MAX = SerialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                TextBox_F0_Campo0_Max.Text = String_F0_C0_MAX;



                String_F0_C1_MIN = SerialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                TextBox_F0_Campo1_Min.Text = String_F0_C1_MIN;


                String_F0_C1_MAX = SerialDataIn.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                TextBox_F0_Campo1_Max.Text = String_F0_C1_MAX;


                String_F0_C2_MIN = SerialDataIn.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                TextBox_F0_Campo2_Min.Text = String_F0_C2_MIN;


                String_F0_C2_MAX = SerialDataIn.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);
                TextBox_F0_Campo2_Max.Text = String_F0_C2_MAX;


                String_F0_C3_MIN = SerialDataIn.Substring(indexOfF + 1, (indexOfG - indexOfF) - 1);
                TextBox_F0_Campo3_Min.Text = String_F0_C3_MIN;


                String_F0_C3_MAX = SerialDataIn.Substring(indexOfG + 1, (indexOfH - indexOfG) - 1);
                TextBox_F0_Campo3_Max.Text = String_F0_C3_MAX;



                String_F0_C4_MIN = SerialDataIn.Substring(indexOfH + 1, (indexOfI - indexOfH) - 1);
                TextBox_F0_Campo4_Min.Text = String_F0_C4_MIN;


                String_F0_C4_MAX = SerialDataIn.Substring(indexOfI + 1, (indexOfJ - indexOfI) - 1);
                TextBox_F0_Campo4_Max.Text = String_F0_C4_MAX;


                //---------------------------------------------------------------------------------------------



                String_F1_C0_MIN = SerialDataIn.Substring(indexOfJ + 1, (indexOfK - indexOfJ) - 1);
                TextBox_F1_Campo0_Min.Text = String_F1_C0_MIN;




                String_F1_C0_MAX = SerialDataIn.Substring(indexOfK + 1, (indexOfL - indexOfK) - 1);
                TextBox_F1_Campo0_Max.Text = String_F1_C0_MAX;



                String_F1_C1_MIN = SerialDataIn.Substring(indexOfL + 1, (indexOfM - indexOfL) - 1);
                TextBox_F1_Campo1_Min.Text = String_F1_C1_MIN;


                String_F1_C1_MAX = SerialDataIn.Substring(indexOfM + 1, (indexOfN - indexOfM) - 1);
                TextBox_F1_Campo1_Max.Text = String_F1_C1_MAX;



                String_F1_C2_MIN = SerialDataIn.Substring(indexOfN + 1, (indexOfO - indexOfN) - 1);
                TextBox_F1_Campo2_Min.Text = String_F1_C2_MIN;



                String_F1_C2_MAX = SerialDataIn.Substring(indexOfO + 1, (indexOfP - indexOfO) - 1);
                TextBox_F1_Campo2_Max.Text = String_F1_C2_MAX;



                String_F1_C3_MIN = SerialDataIn.Substring(indexOfP + 1, (indexOfQ - indexOfP) - 1);
                TextBox_F1_Campo3_Min.Text = String_F1_C3_MIN;


                String_F1_C3_MAX = SerialDataIn.Substring(indexOfQ + 1, (indexOfR - indexOfQ) - 1);
                TextBox_F1_Campo3_Max.Text = String_F1_C3_MAX;


                String_F1_C4_MIN = SerialDataIn.Substring(indexOfR + 1, (indexOfS - indexOfR) - 1);
                TextBox_F1_Campo4_Min.Text = String_F1_C4_MIN;



                String_F1_C4_MAX = SerialDataIn.Substring(indexOfS + 1, (indexOfT - indexOfS) - 1);
                TextBox_F1_Campo4_Max.Text = String_F1_C4_MAX;



                //-------------------------------------------------------------------------------------------

                String_F2_C0_MIN = SerialDataIn.Substring(indexOfT + 1, (indexOfU - indexOfT) - 1);
                TextBox_F2_Campo0_Min.Text = String_F2_C0_MIN;





                String_F2_C0_MAX = SerialDataIn.Substring(indexOfU + 1, (indexOfV - indexOfU) - 1);
                TextBox_F2_Campo0_Max.Text = String_F2_C0_MAX;




                String_F2_C1_MIN = SerialDataIn.Substring(indexOfV + 1, (indexOfW - indexOfV) - 1);
                TextBox_F2_Campo1_Min.Text = String_F2_C1_MIN;



                String_F2_C1_MAX = SerialDataIn.Substring(indexOfW + 1, (indexOfX - indexOfW) - 1);
                TextBox_F2_Campo1_Max.Text = String_F2_C1_MAX;



                String_F2_C2_MIN = SerialDataIn.Substring(indexOfX + 1, (indexOfY - indexOfX) - 1);
                TextBox_F2_Campo2_Min.Text = String_F2_C2_MIN;



                String_F2_C2_MAX = SerialDataIn.Substring(indexOfY + 1, (indexOfZ - indexOfY) - 1);
                TextBox_F2_Campo2_Max.Text = String_F2_C2_MAX;


                String_F2_C3_MIN = SerialDataIn.Substring(indexOfZ + 1, (indexOfa - indexOfZ) - 1);
                TextBox_F2_Campo3_Min.Text = String_F2_C3_MIN;


                String_F2_C3_MAX = SerialDataIn.Substring(indexOfa + 1, (indexOfb - indexOfa) - 1);
                TextBox_F2_Campo3_Max.Text = String_F2_C3_MAX;



                String_F2_C4_MIN = SerialDataIn.Substring(indexOfb + 1, (indexOfc - indexOfb) - 1);
                TextBox_F2_Campo4_Min.Text = String_F2_C4_MIN;


                String_F2_C4_MAX = SerialDataIn.Substring(indexOfc + 1, (indexOfd - indexOfc) - 1);
                TextBox_F2_Campo4_Max.Text = String_F2_C4_MAX;

                /*ahora debemos de resetear los valores.*/
                SerialDataIn = null;






            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

            }


        }

        public void Imprimir_Valores_Registros()
        {


            /*--------------------------F0--------------------------------------------------*/
            /*Ahora debemos de imprimir las cadenas*/
            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$A$");// mandamos el comando para lectura de F0C0
            Thread.Sleep(Tiempo);//delay de 100 ms
            /*Ahora enviamos F0C0*/
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F0_C0[0], Val_F0_C0[1], Val_F0_C0[2], Val_F0_C0[3], Val_F0_C0[4], Val_F0_C0[5], Val_F0_C0[6], Val_F0_C0[7], Val_F0_C0[8], Val_F0_C0[9]));
            Thread.Sleep(Tiempo);
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$B$");// mandamos el comando para lectura de F0C1
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F0C1
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F0_C1[0], Val_F0_C1[1], Val_F0_C1[2], Val_F0_C1[3], Val_F0_C1[4], Val_F0_C1[5], Val_F0_C1[6], Val_F0_C1[7], Val_F0_C1[8], Val_F0_C1[9]));
            Thread.Sleep(Tiempo);
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(100);//delay





            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$C$");// mandamos el comando para lectura de F0C1
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F0C1
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F0_C2[0], Val_F0_C2[1], Val_F0_C2[2], Val_F0_C2[3], Val_F0_C2[4], Val_F0_C2[5], Val_F0_C2[6], Val_F0_C2[7], Val_F0_C2[8], Val_F0_C2[9]));
            Thread.Sleep(Tiempo);
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay






            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$D$");// mandamos el comando para lectura de F0C3
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F0C3
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F0_C3[0], Val_F0_C3[1], Val_F0_C3[2], Val_F0_C3[3], Val_F0_C3[4], Val_F0_C3[5], Val_F0_C3[6], Val_F0_C3[7], Val_F0_C3[8], Val_F0_C3[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay


            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$E$");// mandamos el comando para lectura de F0C4
           Thread.Sleep(Tiempo);//delay de 100 ms
           //Ahora enviamos F0C4
           serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
               Val_F0_C4[0], Val_F0_C4[1], Val_F0_C4[2], Val_F0_C4[3], Val_F0_C4[4], Val_F0_C4[5], Val_F0_C4[6], Val_F0_C4[7], Val_F0_C4[8], Val_F0_C4[9]));
           Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay


            /*--------------------------F1--------------------------------------------------*/
            /*Ahora debemos de imprimir las cadenas*/


            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$F$");// mandamos el comando para lectura de F1C0
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F1C0
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F1_C0[0], Val_F1_C0[1], Val_F1_C0[2], Val_F1_C0[3], Val_F1_C0[4], Val_F1_C0[5], Val_F1_C0[6], Val_F1_C0[7], Val_F1_C0[8], Val_F1_C0[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$G$");// mandamos el comando para lectura de F1C1
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F1C1
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F1_C1[0], Val_F1_C1[1], Val_F1_C1[2], Val_F1_C1[3], Val_F1_C1[4], Val_F1_C1[5], Val_F1_C1[6], Val_F1_C1[7], Val_F1_C1[8], Val_F1_C1[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(100);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$H$");// mandamos el comando para lectura de F1C2
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F1C2
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F1_C2[0], Val_F1_C2[1], Val_F1_C2[2], Val_F1_C2[3], Val_F1_C2[4], Val_F1_C2[5], Val_F1_C2[6], Val_F1_C2[7], Val_F1_C2[8], Val_F1_C2[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms

            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$I$");// mandamos el comando para lectura de F1C3
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F1C3
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F1_C3[0], Val_F1_C3[1], Val_F1_C3[2], Val_F1_C3[3], Val_F1_C3[4], Val_F1_C3[5], Val_F1_C3[6], Val_F1_C3[7], Val_F1_C3[8], Val_F1_C3[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms

            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$J$");// mandamos el comando para lectura de F1C4
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F1C4
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F1_C4[0], Val_F1_C4[1], Val_F1_C4[2], Val_F1_C4[3], Val_F1_C4[4], Val_F1_C4[5], Val_F1_C4[6], Val_F1_C4[7], Val_F1_C4[8], Val_F1_C4[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay




            /*--------------------------F2--------------------------------------------------*/
            /*Ahora debemos de imprimir las cadenas*/


            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$K$");// mandamos el comando para lectura de F2C0
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F2C0
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F2_C0[0], Val_F2_C0[1], Val_F2_C0[2], Val_F2_C0[3], Val_F2_C0[4], Val_F2_C0[5], Val_F2_C0[6], Val_F2_C0[7], Val_F2_C0[8], Val_F2_C0[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$L$");// mandamos el comando para lectura de F2C1
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F2C1
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F2_C1[0], Val_F2_C1[1], Val_F2_C1[2], Val_F2_C1[3], Val_F2_C1[4], Val_F2_C1[5], Val_F2_C1[6], Val_F2_C1[7], Val_F2_C1[8], Val_F2_C1[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms

            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay


            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$M$");// mandamos el comando para lectura de F2C2
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F2C2
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F2_C2[0], Val_F2_C2[1], Val_F2_C2[2], Val_F2_C2[3], Val_F2_C2[4], Val_F2_C2[5], Val_F2_C2[6], Val_F2_C2[7], Val_F2_C2[8], Val_F2_C2[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay
            serialPort_Form2.WriteLine("$N$");// mandamos el comando para lectura de F2C3
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F2C3
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F2_C3[0], Val_F2_C3[1], Val_F2_C3[2], Val_F2_C3[3], Val_F2_C3[4], Val_F2_C3[5], Val_F2_C3[6], Val_F2_C3[7], Val_F2_C3[8], Val_F2_C3[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("X");// 
            Thread.Sleep(Tiempo);//delay

            serialPort_Form2.WriteLine("$O$");// mandamos el comando para lectura de F2C4
            Thread.Sleep(Tiempo);//delay de 100 ms
            //Ahora enviamos F2C4
            serialPort_Form2.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                Val_F2_C4[0], Val_F2_C4[1], Val_F2_C4[2], Val_F2_C4[3], Val_F2_C4[4], Val_F2_C4[5], Val_F2_C4[6], Val_F2_C4[7], Val_F2_C4[8], Val_F2_C4[9]));
            Thread.Sleep(Tiempo);//delay de 100 ms
            serialPort_Form2.WriteLine("[N]");// 
            Thread.Sleep(Tiempo);//delay







        }



        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox_F1_Campo1_mA_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F1_Campo3_mA_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F1_Campo4_mA_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void textBox365_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox179_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_Min_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_F2_Campo1_Max_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_apagar2_Click(object sender, EventArgs e)
        {
            try

            {
                serialPort_Form2.PortName = comboBox_port.Text;
                serialPort_Form2.BaudRate = Convert.ToInt32(combo_baud.Text);
                serialPort_Form2.Open();



                button_apagar.Enabled = true;
                button_desconectar2.Enabled = true;
                button_teclado.Enabled = true;
                button_leer.Enabled = true;
                button_calcular.Enabled = true;
                button_guardar.Enabled = false;
                button_restaurar.Enabled = true;
                button_limpiar.Enabled = true;
                button_conectar.Enabled = false;
                



            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            
            
            }
        }

        private void button_desconectar2_Click(object sender, EventArgs e)
        {
            try

            {
            
                serialPort_Form2.Close();



                button_apagar.Enabled = false;
                button_desconectar2.Enabled = false;
                button_leer.Enabled = false;
                button_calcular.Enabled = false;
                button_guardar.Enabled = false;
                button_restaurar.Enabled = false;
                button_limpiar.Enabled = false;
                button_conectar.Enabled = true;



            }

            catch (Exception error)
            {

                MessageBox.Show(error.Message);



            }
        }

        private void button_apagar_Click(object sender, EventArgs e)
        {
            


            try

            {
                serialPort_Form2.WriteLine("p");// 



            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            
            }

        }

        private void combo_baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void serialPort_Form2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // SerialDataIn = serialPort_Form2.ReadLine();

            // primero preguntamos si lo que llego contiene un @ si contiene el @ debemos de ignorar
            
            
               // this.BeginInvoke(new EventHandler(ProcessData));

            
            
        }

        /*

        private void ProcessData(object sender, EventArgs e)
        {


           

                try
                {
                    indexOfA = Convert.ToInt32(SerialDataIn.IndexOf("A"));
                    indexOfB = Convert.ToInt32(SerialDataIn.IndexOf("B"));
                    indexOfC = Convert.ToInt32(SerialDataIn.IndexOf("C"));
                    indexOfD = Convert.ToInt32(SerialDataIn.IndexOf("D"));
                    indexOfE = Convert.ToInt32(SerialDataIn.IndexOf("E"));
                    indexOfF = Convert.ToInt32(SerialDataIn.IndexOf("F"));
                    indexOfG = Convert.ToInt32(SerialDataIn.IndexOf("G"));
                    indexOfH = Convert.ToInt32(SerialDataIn.IndexOf("H"));
                    indexOfI = Convert.ToInt32(SerialDataIn.IndexOf("I"));
                    indexOfJ = Convert.ToInt32(SerialDataIn.IndexOf("J"));

                    indexOfK = Convert.ToInt32(SerialDataIn.IndexOf("K"));
                    indexOfL = Convert.ToInt32(SerialDataIn.IndexOf("L"));
                    indexOfM = Convert.ToInt32(SerialDataIn.IndexOf("M"));
                    indexOfN = Convert.ToInt32(SerialDataIn.IndexOf("N"));
                    indexOfO = Convert.ToInt32(SerialDataIn.IndexOf("O"));
                    indexOfP = Convert.ToInt32(SerialDataIn.IndexOf("P"));
                    indexOfQ = Convert.ToInt32(SerialDataIn.IndexOf("Q"));
                    indexOfR = Convert.ToInt32(SerialDataIn.IndexOf("R"));
                    indexOfS = Convert.ToInt32(SerialDataIn.IndexOf("S"));
                    indexOfT = Convert.ToInt32(SerialDataIn.IndexOf("T"));



                    indexOfU = Convert.ToInt32(SerialDataIn.IndexOf("U"));
                    indexOfV = Convert.ToInt32(SerialDataIn.IndexOf("V"));
                    indexOfW = Convert.ToInt32(SerialDataIn.IndexOf("W"));
                    indexOfX = Convert.ToInt32(SerialDataIn.IndexOf("X"));
                    indexOfY = Convert.ToInt32(SerialDataIn.IndexOf("Y"));
                    indexOfZ = Convert.ToInt32(SerialDataIn.IndexOf("Z"));
                    indexOfa = Convert.ToInt32(SerialDataIn.IndexOf("a"));
                    indexOfb = Convert.ToInt32(SerialDataIn.IndexOf("b"));
                    indexOfc = Convert.ToInt32(SerialDataIn.IndexOf("c"));
                    indexOfd = Convert.ToInt32(SerialDataIn.IndexOf("d"));


                    String_F0_C0_MIN = SerialDataIn.Substring(0, indexOfA);
                    TextBox_F0_Campo0_Min.Text = String_F0_C0_MIN;//IMPRIMIRMOS EL VALOR 



                    String_F0_C0_MAX = SerialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                    TextBox_F0_Campo0_Max.Text = String_F0_C0_MAX;



                    String_F0_C1_MIN = SerialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                    TextBox_F0_Campo1_Min.Text = String_F0_C1_MIN;


                    String_F0_C1_MAX = SerialDataIn.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                    TextBox_F0_Campo1_Max.Text = String_F0_C1_MAX;


                    String_F0_C2_MIN = SerialDataIn.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                    TextBox_F0_Campo2_Min.Text = String_F0_C2_MIN;


                    String_F0_C2_MAX = SerialDataIn.Substring(indexOfE + 1, (indexOfF - indexOfE) - 1);
                    TextBox_F0_Campo2_Max.Text = String_F0_C2_MAX;


                    String_F0_C3_MIN = SerialDataIn.Substring(indexOfF + 1, (indexOfG - indexOfF) - 1);
                    TextBox_F0_Campo3_Min.Text = String_F0_C3_MIN;


                    String_F0_C3_MAX = SerialDataIn.Substring(indexOfG + 1, (indexOfH - indexOfG) - 1);
                    TextBox_F0_Campo3_Max.Text = String_F0_C3_MAX;



                    String_F0_C4_MIN = SerialDataIn.Substring(indexOfH + 1, (indexOfI - indexOfH) - 1);
                    TextBox_F0_Campo4_Min.Text = String_F0_C4_MIN;


                    String_F0_C4_MAX = SerialDataIn.Substring(indexOfI + 1, (indexOfJ - indexOfI) - 1);
                    TextBox_F0_Campo4_Max.Text = String_F0_C4_MAX;


                    //---------------------------------------------------------------------------------------------



                    String_F1_C0_MIN = SerialDataIn.Substring(indexOfJ + 1, (indexOfK - indexOfJ) - 1);
                    TextBox_F1_Campo0_Min.Text = String_F1_C0_MIN;




                    String_F1_C0_MAX = SerialDataIn.Substring(indexOfK + 1, (indexOfL - indexOfK) - 1);
                    TextBox_F1_Campo0_Max.Text = String_F1_C0_MAX;



                    String_F1_C1_MIN = SerialDataIn.Substring(indexOfL + 1, (indexOfM - indexOfL) - 1);
                    TextBox_F1_Campo1_Min.Text = String_F1_C1_MIN;


                    String_F1_C1_MAX = SerialDataIn.Substring(indexOfM + 1, (indexOfN - indexOfM) - 1);
                    TextBox_F1_Campo1_Max.Text = String_F1_C1_MAX;



                    String_F1_C2_MIN = SerialDataIn.Substring(indexOfN + 1, (indexOfO - indexOfN) - 1);
                    TextBox_F1_Campo2_Min.Text = String_F1_C2_MIN;



                    String_F1_C2_MAX = SerialDataIn.Substring(indexOfO + 1, (indexOfP - indexOfO) - 1);
                    TextBox_F1_Campo2_Max.Text = String_F1_C2_MAX;



                    String_F1_C3_MIN = SerialDataIn.Substring(indexOfP + 1, (indexOfQ - indexOfP) - 1);
                    TextBox_F1_Campo3_Min.Text = String_F1_C3_MIN;


                    String_F1_C3_MAX = SerialDataIn.Substring(indexOfQ + 1, (indexOfR - indexOfQ) - 1);
                    TextBox_F1_Campo3_Max.Text = String_F1_C3_MAX;


                    String_F1_C4_MIN = SerialDataIn.Substring(indexOfR + 1, (indexOfS - indexOfR) - 1);
                    TextBox_F1_Campo4_Min.Text = String_F1_C4_MIN;



                    String_F1_C4_MAX = SerialDataIn.Substring(indexOfS + 1, (indexOfT - indexOfS) - 1);
                    TextBox_F1_Campo4_Max.Text = String_F1_C4_MAX;



                    //-------------------------------------------------------------------------------------------

                    String_F2_C0_MIN = SerialDataIn.Substring(indexOfT + 1, (indexOfU - indexOfT) - 1);
                    TextBox_F2_Campo0_Min.Text = String_F2_C0_MIN;





                    String_F2_C0_MAX = SerialDataIn.Substring(indexOfU + 1, (indexOfV - indexOfU) - 1);
                    TextBox_F2_Campo0_Max.Text = String_F2_C0_MAX;




                    String_F2_C1_MIN = SerialDataIn.Substring(indexOfV + 1, (indexOfW - indexOfV) - 1);
                    TextBox_F2_Campo1_Min.Text = String_F2_C1_MIN;



                    String_F2_C1_MAX = SerialDataIn.Substring(indexOfW + 1, (indexOfX - indexOfW) - 1);
                    TextBox_F2_Campo1_Max.Text = String_F2_C1_MAX;



                    String_F2_C2_MIN = SerialDataIn.Substring(indexOfX + 1, (indexOfY - indexOfX) - 1);
                    TextBox_F2_Campo2_Min.Text = String_F2_C2_MIN;



                    String_F2_C2_MAX = SerialDataIn.Substring(indexOfY + 1, (indexOfZ - indexOfY) - 1);
                    TextBox_F2_Campo2_Max.Text = String_F2_C2_MAX;


                    String_F2_C3_MIN = SerialDataIn.Substring(indexOfZ + 1, (indexOfa - indexOfZ) - 1);
                    TextBox_F2_Campo3_Min.Text = String_F2_C3_MIN;


                    String_F2_C3_MAX = SerialDataIn.Substring(indexOfa + 1, (indexOfb - indexOfa) - 1);
                    TextBox_F2_Campo3_Max.Text = String_F2_C3_MAX;



                    String_F2_C4_MIN = SerialDataIn.Substring(indexOfb + 1, (indexOfc - indexOfb) - 1);
                    TextBox_F2_Campo4_Min.Text = String_F2_C4_MIN;


                    String_F2_C4_MAX = SerialDataIn.Substring(indexOfc + 1, (indexOfd - indexOfc) - 1);
                    TextBox_F2_Campo4_Max.Text = String_F2_C4_MAX;

        */

                    /*ahora debemos de resetear los valores.*/

        /*
                    SerialDataIn = null;






                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }


            
        
        }

        */
    }


    




}


    