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


    public partial class Form2 : Form
    {

        float[] Registro_F0_C0 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F0_C0 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F0_C0 = new float[10];//Vector que indica valores de mA
        float[] DC_F0_C0 = new float[10];//Vector que indica el %DC

        float[] Registro_F0_C1 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F0_C1 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F0_C1 = new float[10];//Vector que indica valores de mA
        float[] DC_F0_C1 = new float[10];//Vector que indica el %DC


        float[] Registro_F0_C2 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F0_C2 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F0_C2 = new float[10];//Vector que indica valores de mA
        float[] DC_F0_C2 = new float[10];//Vector que indica el %DC

        float[] Registro_F0_C3 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F0_C3 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F0_C3 = new float[10];//Vector que indica valores de mA
        float[] DC_F0_C3 = new float[10];//Vector que indica el %DC

        float[] Registro_F0_C4 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F0_C4 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F0_C4 = new float[10];//Vector que indica valores de mA
        float[] DC_F0_C4 = new float[10];//Vector que indica el %DC




        float[] Registro_F1_C0 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F1_C0 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F1_C0 = new float[10];//Vector que indica valores de mA
        float[] DC_F1_C0 = new float[10];//Vector que indica el %DC

        float[] Registro_F1_C1 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F1_C1 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F1_C1 = new float[10];//Vector que indica valores de mA
        float[] DC_F1_C1 = new float[10];//Vector que indica el %DC


        float[] Registro_F1_C2 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F1_C2 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F1_C2 = new float[10];//Vector que indica valores de mA
        float[] DC_F1_C2 = new float[10];//Vector que indica el %DC

        float[] Registro_F1_C3 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F1_C3 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F1_C3 = new float[10];//Vector que indica valores de mA
        float[] DC_F1_C3 = new float[10];//Vector que indica el %DC

        float[] Registro_F1_C4 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F1_C4 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F1_C4 = new float[10];//Vector que indica valores de mA
        float[] DC_F1_C4 = new float[10];//Vector que indica el %DC




        float[] Registro_F2_C0 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F2_C0 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F2_C0 = new float[10];//Vector que indica valores de mA
        float[] DC_F2_C0 = new float[10];//Vector que indica el %DC

        float[] Registro_F2_C1 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F2_C1 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F2_C1 = new float[10];//Vector que indica valores de mA
        float[] DC_F2_C1 = new float[10];//Vector que indica el %DC


        float[] Registro_F2_C2 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F2_C2 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F2_C2 = new float[10];//Vector que indica valores de mA
        float[] DC_F2_C2 = new float[10];//Vector que indica el %DC

        float[] Registro_F2_C3 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F2_C3 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F2_C3 = new float[10];//Vector que indica valores de mA
        float[] DC_F2_C3 = new float[10];//Vector que indica el %DC

        float[] Registro_F2_C4 = new float[10]; // vector donde guardaraemos los valores de registros.
        float[] Incremento_F2_C4 = new float[10]; // vector donde guardaraemos los valores de incremento
        float[] mA_F2_C4 = new float[10];//Vector que indica valores de mA
        float[] DC_F2_C4 = new float[10];//Vector que indica el %DC


        string SerialDataIn;// string que recibe los datos enviados por el microcontrolador 

        //variable para identificar los index
        int   indexOfA, indexOfB, indexOfC, indexOfD, indexOfE, indexOfF, indexOfG, indexOfH, indexOfI, indexOfJ, indexOfK, indexOfL, indexOfM, indexOfN, indexOfO, indexOfP, 
                indexOfQ,indexOfR, indexOfS, indexOfT, indexOfU, indexOfV, indexOfW, indexOfX, indexOfY, indexOfZ, indexOfa, indexOfb, indexOfc, indexOfd ;
        
        
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

            try

            {
                serialPort_Form2.WriteLine("[R]");


            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

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

            TextBox_F0_Campo0_Min.Text = Convert.ToString(Registro_F0_C0[0]);// cargamos el valor minimo
            TextBox_F0_Campo0_Max.Text = Convert.ToString(Registro_F0_C0[9]);//cargamos el valor maximo

            TextBox_F0_Campo1_Min.Text = Convert.ToString(Registro_F0_C1[0]);// cargamos el valor minimo
            TextBox_F0_Campo1_Max.Text = Convert.ToString(Registro_F0_C1[9]);//cargamos el valor maximo

            TextBox_F0_Campo2_Min.Text = Convert.ToString(Registro_F0_C2[0]);// cargamos el valor minimo
            TextBox_F0_Campo2_Max.Text = Convert.ToString(Registro_F0_C2[9]);//cargamos el valor maximo

            TextBox_F0_Campo3_Min.Text = Convert.ToString(Registro_F0_C3[0]);// cargamos el valor minimo
            TextBox_F0_Campo3_Max.Text = Convert.ToString(Registro_F0_C3[9]);//cargamos el valor maximo

            TextBox_F0_Campo4_Min.Text = Convert.ToString(Registro_F0_C4[0]);// cargamos el valor minimo
            TextBox_F0_Campo4_Max.Text = Convert.ToString(Registro_F0_C4[9]);//cargamos el valor maximo
            /*----------------------------------------------------------------------------------------------------------*/



            TextBox_F1_Campo0_Min.Text = Convert.ToString(Registro_F1_C0[0]);// cargamos el valor minimo
            TextBox_F1_Campo0_Max.Text = Convert.ToString(Registro_F1_C0[9]);//cargamos el valor maximo

            TextBox_F1_Campo1_Min.Text = Convert.ToString(Registro_F1_C1[0]);// cargamos el valor minimo
            TextBox_F1_Campo1_Max.Text = Convert.ToString(Registro_F1_C1[9]);//cargamos el valor maximo

            TextBox_F1_Campo2_Min.Text = Convert.ToString(Registro_F1_C2[0]);// cargamos el valor minimo
            TextBox_F1_Campo2_Max.Text = Convert.ToString(Registro_F1_C2[9]);//cargamos el valor maximo

            TextBox_F1_Campo3_Min.Text = Convert.ToString(Registro_F1_C3[0]);// cargamos el valor minimo
            TextBox_F1_Campo3_Max.Text = Convert.ToString(Registro_F1_C3[9]);//cargamos el valor maximo

            TextBox_F1_Campo4_Min.Text = Convert.ToString(Registro_F1_C4[0]);// cargamos el valor minimo
            TextBox_F1_Campo4_Max.Text = Convert.ToString(Registro_F1_C4[9]);//cargamos el valor maximo
            /*----------------------------------------------------------------------------------------------------------*/





            TextBox_F2_Campo0_Min.Text = Convert.ToString(Registro_F2_C0[0]);// cargamos el valor minimo
            TextBox_F2_Campo0_Max.Text = Convert.ToString(Registro_F2_C0[9]);//cargamos el valor maximo

            TextBox_F2_Campo1_Min.Text = Convert.ToString(Registro_F2_C1[0]);// cargamos el valor minimo
            TextBox_F2_Campo1_Max.Text = Convert.ToString(Registro_F2_C1[9]);//cargamos el valor maximo

            TextBox_F2_Campo2_Min.Text = Convert.ToString(Registro_F2_C2[0]);// cargamos el valor minimo
            TextBox_F2_Campo2_Max.Text = Convert.ToString(Registro_F2_C2[9]);//cargamos el valor maximo

            TextBox_F2_Campo3_Min.Text = Convert.ToString(Registro_F2_C3[0]);// cargamos el valor minimo
            TextBox_F2_Campo3_Max.Text = Convert.ToString(Registro_F2_C3[9]);//cargamos el valor maximo

            TextBox_F2_Campo4_Min.Text = Convert.ToString(Registro_F2_C4[0]);// cargamos el valor minimo
            TextBox_F2_Campo4_Max.Text = Convert.ToString(Registro_F2_C4[9]);//cargamos el valor maximo
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

            TextBox_DC_F0_Campo0_Min.Text = Convert.ToString(DC_F0_C0[0]);// imprimirmos el valor minimo
            TextBox_DC_F0_Campo0_Max.Text = Convert.ToString(DC_F0_C0[9]);// imprimirmos el valor maximo 

            TextBox_DC_F0_Campo1_Min.Text = Convert.ToString(DC_F0_C1[0]);// imprimirmos el valor minimo
            TextBox_DC_F0_Campo1_Max.Text = Convert.ToString(DC_F0_C1[9]);// imprimirmos el valor maximo 


            TextBox_DC_F0_Campo2_Min.Text = Convert.ToString(DC_F0_C2[0]);// imprimirmos el valor minimo
            TextBox_DC_F0_Campo2_Max.Text = Convert.ToString(DC_F0_C2[9]);// imprimirmos el valor maximo 


            TextBox_DC_F0_Campo3_Min.Text = Convert.ToString(DC_F0_C3[0]);// imprimirmos el valor minimo
            TextBox_DC_F0_Campo3_Max.Text = Convert.ToString(DC_F0_C3[9]);// imprimirmos el valor maximo 


            TextBox_DC_F0_Campo4_Min.Text = Convert.ToString(DC_F0_C4[0]);// imprimirmos el valor minimo
            TextBox_DC_F0_Campo4_Max.Text = Convert.ToString(DC_F0_C4[9]);// imprimirmos el valor maximo 


            /*ahora para F1*/


            TextBox_DC_F1_Campo0_Min.Text = Convert.ToString(DC_F1_C0[0]);// imprimirmos el valor minimo
            TextBox_DC_F1_Campo0_Max.Text = Convert.ToString(DC_F1_C0[9]);// imprimirmos el valor maximo 

            TextBox_DC_F1_Campo1_Min.Text = Convert.ToString(DC_F1_C1[0]);// imprimirmos el valor minimo
            TextBox_DC_F1_Campo1_Max.Text = Convert.ToString(DC_F1_C1[9]);// imprimirmos el valor maximo 


            TextBox_DC_F1_Campo2_Min.Text = Convert.ToString(DC_F1_C2[0]);// imprimirmos el valor minimo
            TextBox_DC_F1_Campo2_Max.Text = Convert.ToString(DC_F1_C2[9]);// imprimirmos el valor maximo 


            TextBox_DC_F1_Campo3_Min.Text = Convert.ToString(DC_F1_C3[0]);// imprimirmos el valor minimo
            TextBox_DC_F1_Campo3_Max.Text = Convert.ToString(DC_F1_C3[9]);// imprimirmos el valor maximo 


            TextBox_DC_F1_Campo4_Min.Text = Convert.ToString(DC_F1_C4[0]);// imprimirmos el valor minimo
            TextBox_DC_F1_Campo4_Max.Text = Convert.ToString(DC_F1_C4[9]);// imprimirmos el valor maximo 

            /*Ahora para campo F2 */



            TextBox_DC_F2_Campo0_Min.Text = Convert.ToString(DC_F2_C0[0]);// imprimirmos el valor minimo
            TextBox_DC_F2_Campo0_Max.Text = Convert.ToString(DC_F2_C0[9]);// imprimirmos el valor maximo 

            TextBox_DC_F2_Campo1_Min.Text = Convert.ToString(DC_F2_C1[0]);// imprimirmos el valor minimo
            TextBox_DC_F2_Campo1_Max.Text = Convert.ToString(DC_F2_C1[9]);// imprimirmos el valor maximo 


            TextBox_DC_F2_Campo2_Min.Text = Convert.ToString(DC_F2_C2[0]);// imprimirmos el valor minimo
            TextBox_DC_F2_Campo2_Max.Text = Convert.ToString(DC_F2_C2[9]);// imprimirmos el valor maximo 


            TextBox_DC_F2_Campo3_Min.Text = Convert.ToString(DC_F2_C3[0]);// imprimirmos el valor minimo
            TextBox_DC_F2_Campo3_Max.Text = Convert.ToString(DC_F2_C3[9]);// imprimirmos el valor maximo 


            TextBox_DC_F2_Campo4_Min.Text = Convert.ToString(DC_F2_C4[0]);// imprimirmos el valor minimo
            TextBox_DC_F2_Campo4_Max.Text = Convert.ToString(DC_F2_C4[9]);// imprimirmos el valor maximo 

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
            TextBox_F0_Campo0_mA_Max.Text = Convert.ToString(mA_F0_C0[0]);// imprimimos valor minimo
            TextBox_F0_Campo0_mA_Min.Text = Convert.ToString(mA_F0_C0[9]);// imprimimos valor minimo

            TextBox_F0_Campo1_mA_Max.Text = Convert.ToString(mA_F0_C1[0]);// imprimimos valor minimo
            TextBox_F0_Campo1_mA_Min.Text = Convert.ToString(mA_F0_C1[9]);// imprimimos valor minimo

            TextBox_F0_Campo2_mA_Max.Text = Convert.ToString(mA_F0_C2[0]);// imprimimos valor minimo
            TextBox_F0_Campo2_mA_Min.Text = Convert.ToString(mA_F0_C2[9]);// imprimimos valor minimo

            TextBox_F0_Campo3_mA_Max.Text = Convert.ToString(mA_F0_C3[0]);// imprimimos valor minimo
            TextBox_F0_Campo3_mA_Min.Text = Convert.ToString(mA_F0_C3[9]);// imprimimos valor minimo

            TextBox_F0_Campo4_mA_Max.Text = Convert.ToString(mA_F0_C4[0]);// imprimimos valor minimo
            TextBox_F0_Campo4_mA_Min.Text = Convert.ToString(mA_F0_C4[9]);// imprimimos valor minimo

            /*------------------------------------------------------------------------------------------------*/


            TextBox_F1_Campo0_mA_Max.Text = Convert.ToString(mA_F1_C0[0]);// imprimimos valor minimo
            TextBox_F1_Campo0_mA_Min.Text = Convert.ToString(mA_F1_C0[9]);// imprimimos valor minimo

            TextBox_F1_Campo1_mA_Max.Text = Convert.ToString(mA_F1_C1[0]);// imprimimos valor minimo
            TextBox_F1_Campo1_mA_Min.Text = Convert.ToString(mA_F1_C1[9]);// imprimimos valor minimo

            TextBox_F1_Campo2_mA_Max.Text = Convert.ToString(mA_F1_C2[0]);// imprimimos valor minimo
            TextBox_F1_Campo2_mA_Min.Text = Convert.ToString(mA_F1_C2[9]);// imprimimos valor minimo

            TextBox_F1_Campo3_mA_Max.Text = Convert.ToString(mA_F1_C3[0]);// imprimimos valor minimo
            TextBox_F1_Campo3_mA_Min.Text = Convert.ToString(mA_F1_C3[9]);// imprimimos valor minimo

            TextBox_F1_Campo4_mA_Max.Text = Convert.ToString(mA_F1_C4[0]);// imprimimos valor minimo
            TextBox_F1_Campo4_mA_Min.Text = Convert.ToString(mA_F1_C4[9]);// imprimimos valor minimo

            /*------------------------------------------------------------------------------------------------*/

            TextBox_F2_Campo0_mA_Max.Text = Convert.ToString(mA_F2_C0[0]);// imprimimos valor minimo
            TextBox_F2_Campo0_mA_Min.Text = Convert.ToString(mA_F2_C0[9]);// imprimimos valor minimo

            TextBox_F2_Campo1_mA_Max.Text = Convert.ToString(mA_F2_C1[0]);// imprimimos valor minimo
            TextBox_F2_Campo1_mA_Min.Text = Convert.ToString(mA_F2_C1[9]);// imprimimos valor minimo

            TextBox_F2_Campo2_mA_Max.Text = Convert.ToString(mA_F2_C2[0]);// imprimimos valor minimo
            TextBox_F2_Campo2_mA_Min.Text = Convert.ToString(mA_F2_C2[9]);// imprimimos valor minimo

            TextBox_F2_Campo3_mA_Max.Text = Convert.ToString(mA_F2_C3[0]);// imprimimos valor minimo
            TextBox_F2_Campo3_mA_Min.Text = Convert.ToString(mA_F2_C3[9]);// imprimimos valor minimo

            TextBox_F2_Campo4_mA_Max.Text = Convert.ToString(mA_F2_C4[0]);// imprimimos valor minimo
            TextBox_F2_Campo4_mA_Min.Text = Convert.ToString(mA_F2_C4[9]);// imprimimos valor minimo

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
            Incremento_F0_C1[1] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9) - 1;
            Incremento_F0_C1[2] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[3] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[4] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[5] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[5] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9) - 1;
            Incremento_F0_C1[6] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[7] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[8] = ((mA_F0_C1[9] - mA_F0_C1[0]) / 9);
            Incremento_F0_C1[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C2--------------------------------------------------------*/
            Incremento_F0_C2[0] = 0;
            Incremento_F0_C2[1] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9) - 1;
            Incremento_F0_C2[2] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9);
            Incremento_F0_C2[3] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9);
            Incremento_F0_C2[4] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9);
            Incremento_F0_C2[5] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9) - 1;
            Incremento_F0_C2[6] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9);
            Incremento_F0_C2[7] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9);
            Incremento_F0_C2[8] = ((mA_F0_C2[9] - mA_F0_C2[0]) / 9);
            Incremento_F0_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C3--------------------------------------------------------*/
            Incremento_F0_C3[0] = 0;
            Incremento_F0_C3[1] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9) - 1;
            Incremento_F0_C3[2] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9);
            Incremento_F0_C3[3] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9);
            Incremento_F0_C3[4] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9);
            Incremento_F0_C3[5] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9) - 1;
            Incremento_F0_C3[6] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9);
            Incremento_F0_C3[7] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9);
            Incremento_F0_C3[8] = ((mA_F0_C3[9] - mA_F0_C3[0]) / 9);
            Incremento_F0_C3[9] = 0;
            /*--------------------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F0 C4--------------------------------------------------------*/
            Incremento_F0_C4[0] = 0;
            Incremento_F0_C4[1] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9) - 1;
            Incremento_F0_C4[2] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9);
            Incremento_F0_C4[3] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9);
            Incremento_F0_C4[4] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9);
            Incremento_F0_C4[5] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9) - 1;
            Incremento_F0_C4[6] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9);
            Incremento_F0_C4[7] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9);
            Incremento_F0_C4[8] = ((mA_F0_C4[9] - mA_F0_C4[0]) / 9);
            Incremento_F0_C4[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C0--------------------------------------------------------*/
            Incremento_F1_C0[0] = 0;
            Incremento_F1_C0[1] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9) - 1;
            Incremento_F1_C0[2] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9);
            Incremento_F1_C0[3] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9);
            Incremento_F1_C0[4] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9);
            Incremento_F1_C0[5] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9) - 1;
            Incremento_F1_C0[6] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9);
            Incremento_F1_C0[7] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9);
            Incremento_F1_C0[8] = ((mA_F1_C0[9] - mA_F1_C0[0]) / 9);
            Incremento_F1_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C1--------------------------------------------------------*/
            Incremento_F1_C1[0] = 0;
            Incremento_F1_C1[1] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9) - 1;
            Incremento_F1_C1[2] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9);
            Incremento_F1_C1[3] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9);
            Incremento_F1_C1[4] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9);
            Incremento_F1_C1[5] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9) - 1;
            Incremento_F1_C1[6] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9);
            Incremento_F1_C1[7] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9);
            Incremento_F1_C1[8] = ((mA_F1_C1[9] - mA_F1_C1[0]) / 9);
            Incremento_F1_C1[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C2--------------------------------------------------------*/
            Incremento_F1_C2[0] = 0;
            Incremento_F1_C2[1] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9) - 1;
            Incremento_F1_C2[2] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9);
            Incremento_F1_C2[3] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9);
            Incremento_F1_C2[4] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9);
            Incremento_F1_C2[5] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9) - 1;
            Incremento_F1_C2[6] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9);
            Incremento_F1_C2[7] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9);
            Incremento_F1_C2[8] = ((mA_F1_C2[9] - mA_F1_C2[0]) / 9);
            Incremento_F1_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C3--------------------------------------------------------*/
            Incremento_F1_C3[0] = 0;
            Incremento_F1_C3[1] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9) - 1;
            Incremento_F1_C3[2] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9);
            Incremento_F1_C3[3] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9);
            Incremento_F1_C3[4] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9);
            Incremento_F1_C3[5] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9) - 1;
            Incremento_F1_C3[6] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9);
            Incremento_F1_C3[7] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9);
            Incremento_F1_C3[8] = ((mA_F1_C3[9] - mA_F1_C3[0]) / 9);
            Incremento_F1_C3[9] = 0;
            /*--------------------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F1 C4--------------------------------------------------------*/
            Incremento_F1_C4[0] = 0;
            Incremento_F1_C4[1] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9) - 1;
            Incremento_F1_C4[2] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9);
            Incremento_F1_C4[3] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9);
            Incremento_F1_C4[4] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9);
            Incremento_F1_C4[5] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9) - 1;
            Incremento_F1_C4[6] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9);
            Incremento_F1_C4[7] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9);
            Incremento_F1_C4[8] = ((mA_F1_C4[9] - mA_F1_C4[0]) / 9);
            Incremento_F1_C4[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C0--------------------------------------------------------*/
            Incremento_F2_C0[0] = 0;
            Incremento_F2_C0[1] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9) - 1;
            Incremento_F2_C0[2] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9);
            Incremento_F2_C0[3] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9);
            Incremento_F2_C0[4] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9);
            Incremento_F2_C0[5] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9) - 1;
            Incremento_F2_C0[6] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9);
            Incremento_F2_C0[7] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9);
            Incremento_F2_C0[8] = ((mA_F2_C0[9] - mA_F2_C0[0]) / 9);
            Incremento_F2_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C1--------------------------------------------------------*/
            Incremento_F2_C1[0] = 0;
            Incremento_F2_C1[1] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9) - 1;
            Incremento_F2_C1[2] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9);
            Incremento_F2_C1[3] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9);
            Incremento_F2_C1[4] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9);
            Incremento_F2_C1[5] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9) - 1;
            Incremento_F2_C1[6] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9);
            Incremento_F2_C1[7] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9);
            Incremento_F2_C1[8] = ((mA_F2_C1[9] - mA_F2_C1[0]) / 9);
            Incremento_F2_C1[9] = 0;
            /*--------------------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C2--------------------------------------------------------*/
            Incremento_F2_C2[0] = 0;
            Incremento_F2_C2[1] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9) - 1;
            Incremento_F2_C2[2] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9);
            Incremento_F2_C2[3] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9);
            Incremento_F2_C2[4] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9);
            Incremento_F2_C2[5] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9) - 1;
            Incremento_F2_C2[6] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9);
            Incremento_F2_C2[7] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9);
            Incremento_F2_C2[8] = ((mA_F2_C2[9] - mA_F2_C2[0]) / 9);
            Incremento_F2_C0[9] = 0;
            /*--------------------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C3--------------------------------------------------------*/
            Incremento_F2_C3[0] = 0;
            Incremento_F2_C3[1] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9) - 1;
            Incremento_F2_C3[2] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9);
            Incremento_F2_C3[3] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9);
            Incremento_F2_C3[4] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9);
            Incremento_F2_C3[5] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9) - 1;
            Incremento_F2_C3[6] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9);
            Incremento_F2_C3[7] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9);
            Incremento_F2_C3[8] = ((mA_F2_C3[9] - mA_F2_C3[0]) / 9);
            Incremento_F2_C3[9] = 0;
            /*--------------------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------------------*/
            /*------------------------------------F2 C4--------------------------------------------------------*/
            Incremento_F2_C4[0] = 0;
            Incremento_F2_C4[1] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9) - 1;
            Incremento_F2_C4[2] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9);
            Incremento_F2_C4[3] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9);
            Incremento_F2_C4[4] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9);
            Incremento_F2_C4[5] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9) - 1;
            Incremento_F2_C4[6] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9);
            Incremento_F2_C4[7] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9);
            Incremento_F2_C4[8] = ((mA_F2_C4[9] - mA_F2_C4[0]) / 9);
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
            /*--------------------------------F0 C2 mA-------------------------------------*/

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
            /*--------------------------------F0 C3 mA-------------------------------------*/

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
            /*--------------------------------F0 C4 mA-------------------------------------*/

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
            TextBox_F0_C0_mA_1.Text = Convert.ToString(mA_F0_C0[1]);
            TextBox_F0_C0_mA_2.Text = Convert.ToString(mA_F0_C0[2]);
            TextBox_F0_C0_mA_3.Text = Convert.ToString(mA_F0_C0[3]);
            TextBox_F0_C0_mA_4.Text = Convert.ToString(mA_F0_C0[4]);
            TextBox_F0_C0_mA_5.Text = Convert.ToString(mA_F0_C0[5]);
            TextBox_F0_C0_mA_6.Text = Convert.ToString(mA_F0_C0[6]);
            TextBox_F0_C0_mA_7.Text = Convert.ToString(mA_F0_C0[7]);
            TextBox_F0_C0_mA_8.Text = Convert.ToString(mA_F0_C0[8]);
            /*------------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C1-------------------------------------------*/
            TextBox_F0_C1_mA_1.Text = Convert.ToString(mA_F0_C1[1]);
            TextBox_F0_C1_mA_2.Text = Convert.ToString(mA_F0_C1[2]);
            TextBox_F0_C1_mA_3.Text = Convert.ToString(mA_F0_C1[3]);
            TextBox_F0_C1_mA_4.Text = Convert.ToString(mA_F0_C1[4]);
            TextBox_F0_C1_mA_5.Text = Convert.ToString(mA_F0_C1[5]);
            TextBox_F0_C1_mA_6.Text = Convert.ToString(mA_F0_C1[6]);
            TextBox_F0_C1_mA_7.Text = Convert.ToString(mA_F0_C1[7]);
            TextBox_F0_C1_mA_8.Text = Convert.ToString(mA_F0_C1[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C2-------------------------------------------*/
            TextBox_F0_C2_mA_1.Text = Convert.ToString(mA_F0_C2[1]);
            TextBox_F0_C2_mA_2.Text = Convert.ToString(mA_F0_C2[2]);
            TextBox_F0_C2_mA_3.Text = Convert.ToString(mA_F0_C2[3]);
            TextBox_F0_C2_mA_4.Text = Convert.ToString(mA_F0_C2[4]);
            TextBox_F0_C2_mA_5.Text = Convert.ToString(mA_F0_C2[5]);
            TextBox_F0_C2_mA_6.Text = Convert.ToString(mA_F0_C2[6]);
            TextBox_F0_C2_mA_7.Text = Convert.ToString(mA_F0_C2[7]);
            TextBox_F0_C2_mA_8.Text = Convert.ToString(mA_F0_C2[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C3-------------------------------------------*/
            TextBox_F0_C3_mA_1.Text = Convert.ToString(mA_F0_C3[1]);
            TextBox_F0_C3_mA_2.Text = Convert.ToString(mA_F0_C3[2]);
            TextBox_F0_C3_mA_3.Text = Convert.ToString(mA_F0_C3[3]);
            TextBox_F0_C3_mA_4.Text = Convert.ToString(mA_F0_C3[4]);
            TextBox_F0_C3_mA_5.Text = Convert.ToString(mA_F0_C3[5]);
            TextBox_F0_C3_mA_6.Text = Convert.ToString(mA_F0_C3[6]);
            TextBox_F0_C3_mA_7.Text = Convert.ToString(mA_F0_C3[7]);
            TextBox_F0_C3_mA_8.Text = Convert.ToString(mA_F0_C3[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F0  C4-------------------------------------------*/
            TextBox_F0_C4_mA_1.Text = Convert.ToString(mA_F0_C4[1]);
            TextBox_F0_C4_mA_2.Text = Convert.ToString(mA_F0_C4[2]);
            TextBox_F0_C4_mA_3.Text = Convert.ToString(mA_F0_C4[3]);
            TextBox_F0_C4_mA_4.Text = Convert.ToString(mA_F0_C4[4]);
            TextBox_F0_C4_mA_5.Text = Convert.ToString(mA_F0_C4[5]);
            TextBox_F0_C4_mA_6.Text = Convert.ToString(mA_F0_C4[6]);
            TextBox_F0_C4_mA_7.Text = Convert.ToString(mA_F0_C4[7]);
            TextBox_F0_C4_mA_8.Text = Convert.ToString(mA_F0_C4[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C0-------------------------------------------*/
            TextBox_F1_C0_mA_1.Text = Convert.ToString(mA_F1_C0[1]);
            TextBox_F1_C0_mA_2.Text = Convert.ToString(mA_F1_C0[2]);
            TextBox_F1_C0_mA_3.Text = Convert.ToString(mA_F1_C0[3]);
            TextBox_F1_C0_mA_4.Text = Convert.ToString(mA_F1_C0[4]);
            TextBox_F1_C0_mA_5.Text = Convert.ToString(mA_F1_C0[5]);
            TextBox_F1_C0_mA_6.Text = Convert.ToString(mA_F1_C0[6]);
            TextBox_F1_C0_mA_7.Text = Convert.ToString(mA_F1_C0[7]);
            TextBox_F1_C0_mA_8.Text = Convert.ToString(mA_F1_C0[8]);
            /*------------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C1-------------------------------------------*/
            TextBox_F1_C1_mA_1.Text = Convert.ToString(mA_F1_C1[1]);
            TextBox_F1_C1_mA_2.Text = Convert.ToString(mA_F1_C1[2]);
            TextBox_F1_C1_mA_3.Text = Convert.ToString(mA_F1_C1[3]);
            TextBox_F1_C1_mA_4.Text = Convert.ToString(mA_F1_C1[4]);
            TextBox_F1_C1_mA_5.Text = Convert.ToString(mA_F1_C1[5]);
            TextBox_F1_C1_mA_6.Text = Convert.ToString(mA_F1_C1[6]);
            TextBox_F1_C1_mA_7.Text = Convert.ToString(mA_F1_C1[7]);
            TextBox_F1_C1_mA_8.Text = Convert.ToString(mA_F1_C1[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C2-------------------------------------------*/
            TextBox_F1_C2_mA_1.Text = Convert.ToString(mA_F1_C2[1]);
            TextBox_F1_C2_mA_2.Text = Convert.ToString(mA_F1_C2[2]);
            TextBox_F1_C2_mA_3.Text = Convert.ToString(mA_F1_C2[3]);
            TextBox_F1_C2_mA_4.Text = Convert.ToString(mA_F1_C2[4]);
            TextBox_F1_C2_mA_5.Text = Convert.ToString(mA_F1_C2[5]);
            TextBox_F1_C2_mA_6.Text = Convert.ToString(mA_F1_C2[6]);
            TextBox_F1_C2_mA_7.Text = Convert.ToString(mA_F1_C2[7]);
            TextBox_F1_C2_mA_8.Text = Convert.ToString(mA_F1_C2[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C3-------------------------------------------*/
            TextBox_F1_C3_mA_1.Text = Convert.ToString(mA_F1_C3[1]);
            TextBox_F1_C3_mA_2.Text = Convert.ToString(mA_F1_C3[2]);
            TextBox_F1_C3_mA_3.Text = Convert.ToString(mA_F1_C3[3]);
            TextBox_F1_C3_mA_4.Text = Convert.ToString(mA_F1_C3[4]);
            TextBox_F1_C3_mA_5.Text = Convert.ToString(mA_F1_C3[5]);
            TextBox_F1_C3_mA_6.Text = Convert.ToString(mA_F1_C3[6]);
            TextBox_F1_C3_mA_7.Text = Convert.ToString(mA_F1_C3[7]);
            TextBox_F1_C3_mA_8.Text = Convert.ToString(mA_F1_C3[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F1  C4-------------------------------------------*/
            TextBox_F1_C4_mA_1.Text = Convert.ToString(mA_F1_C4[1]);
            TextBox_F1_C4_mA_2.Text = Convert.ToString(mA_F1_C4[2]);
            TextBox_F1_C4_mA_3.Text = Convert.ToString(mA_F1_C4[3]);
            TextBox_F1_C4_mA_4.Text = Convert.ToString(mA_F1_C4[4]);
            TextBox_F1_C4_mA_5.Text = Convert.ToString(mA_F1_C4[5]);
            TextBox_F1_C4_mA_6.Text = Convert.ToString(mA_F1_C4[6]);
            TextBox_F1_C4_mA_7.Text = Convert.ToString(mA_F1_C4[7]);
            TextBox_F1_C4_mA_8.Text = Convert.ToString(mA_F1_C4[8]);
            /*------------------------------------------------------------------------------*/



            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C0-------------------------------------------*/
            TextBox_F2_C0_mA_1.Text = Convert.ToString(mA_F2_C0[1]);
            TextBox_F2_C0_mA_2.Text = Convert.ToString(mA_F2_C0[2]);
            TextBox_F2_C0_mA_3.Text = Convert.ToString(mA_F2_C0[3]);
            TextBox_F2_C0_mA_4.Text = Convert.ToString(mA_F2_C0[4]);
            TextBox_F2_C0_mA_5.Text = Convert.ToString(mA_F2_C0[5]);
            TextBox_F2_C0_mA_6.Text = Convert.ToString(mA_F2_C0[6]);
            TextBox_F2_C0_mA_7.Text = Convert.ToString(mA_F2_C0[7]);
            TextBox_F2_C0_mA_8.Text = Convert.ToString(mA_F2_C0[8]);
            /*------------------------------------------------------------------------------*/

            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C1-------------------------------------------*/
            TextBox_F2_C1_mA_1.Text = Convert.ToString(mA_F2_C1[1]);
            TextBox_F2_C1_mA_2.Text = Convert.ToString(mA_F2_C1[2]);
            TextBox_F2_C1_mA_3.Text = Convert.ToString(mA_F2_C1[3]);
            TextBox_F2_C1_mA_4.Text = Convert.ToString(mA_F2_C1[4]);
            TextBox_F2_C1_mA_5.Text = Convert.ToString(mA_F2_C1[5]);
            TextBox_F2_C1_mA_6.Text = Convert.ToString(mA_F2_C1[6]);
            TextBox_F2_C1_mA_7.Text = Convert.ToString(mA_F2_C1[7]);
            TextBox_F2_C1_mA_8.Text = Convert.ToString(mA_F2_C1[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C2-------------------------------------------*/
            TextBox_F2_C2_mA_1.Text = Convert.ToString(mA_F2_C2[1]);
            TextBox_F2_C2_mA_2.Text = Convert.ToString(mA_F2_C2[2]);
            TextBox_F2_C2_mA_3.Text = Convert.ToString(mA_F2_C2[3]);
            TextBox_F2_C2_mA_4.Text = Convert.ToString(mA_F2_C2[4]);
            TextBox_F2_C2_mA_5.Text = Convert.ToString(mA_F2_C2[5]);
            TextBox_F2_C2_mA_6.Text = Convert.ToString(mA_F2_C2[6]);
            TextBox_F2_C2_mA_7.Text = Convert.ToString(mA_F2_C2[7]);
            TextBox_F2_C2_mA_8.Text = Convert.ToString(mA_F2_C2[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C3-------------------------------------------*/
            TextBox_F2_C3_mA_1.Text = Convert.ToString(mA_F2_C3[1]);
            TextBox_F2_C3_mA_2.Text = Convert.ToString(mA_F2_C3[2]);
            TextBox_F2_C3_mA_3.Text = Convert.ToString(mA_F2_C3[3]);
            TextBox_F2_C3_mA_4.Text = Convert.ToString(mA_F2_C3[4]);
            TextBox_F2_C3_mA_5.Text = Convert.ToString(mA_F2_C3[5]);
            TextBox_F2_C3_mA_6.Text = Convert.ToString(mA_F2_C3[6]);
            TextBox_F2_C3_mA_7.Text = Convert.ToString(mA_F2_C3[7]);
            TextBox_F2_C3_mA_8.Text = Convert.ToString(mA_F2_C3[8]);
            /*------------------------------------------------------------------------------*/


            /*------------------------------------------------------------------------------*/
            /*-----------------------------F2  C4-------------------------------------------*/
            TextBox_F2_C4_mA_1.Text = Convert.ToString(mA_F2_C4[1]);
            TextBox_F2_C4_mA_2.Text = Convert.ToString(mA_F2_C4[2]);
            TextBox_F2_C4_mA_3.Text = Convert.ToString(mA_F2_C4[3]);
            TextBox_F2_C4_mA_4.Text = Convert.ToString(mA_F2_C4[4]);
            TextBox_F2_C4_mA_5.Text = Convert.ToString(mA_F2_C4[5]);
            TextBox_F2_C4_mA_6.Text = Convert.ToString(mA_F2_C4[6]);
            TextBox_F2_C4_mA_7.Text = Convert.ToString(mA_F2_C4[7]);
            TextBox_F2_C4_mA_8.Text = Convert.ToString(mA_F2_C4[8]);
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
            TextBox_DC_F0_Campo0_1.Text = Convert.ToString(DC_F0_C0[1]);
            TextBox_DC_F0_Campo0_2.Text = Convert.ToString(DC_F0_C0[2]);
            TextBox_DC_F0_Campo0_3.Text = Convert.ToString(DC_F0_C0[3]);
            TextBox_DC_F0_Campo0_4.Text = Convert.ToString(DC_F0_C0[4]);
            TextBox_DC_F0_Campo0_5.Text = Convert.ToString(DC_F0_C0[5]);
            TextBox_DC_F0_Campo0_6.Text = Convert.ToString(DC_F0_C0[6]);
            TextBox_DC_F0_Campo0_7.Text = Convert.ToString(DC_F0_C0[7]);
            TextBox_DC_F0_Campo0_8.Text = Convert.ToString(DC_F0_C0[8]);


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C1----------------------------------------*/
            TextBox_DC_F0_Campo1_1.Text = Convert.ToString(DC_F0_C1[1]);
            TextBox_DC_F0_Campo1_2.Text = Convert.ToString(DC_F0_C1[2]);
            TextBox_DC_F0_Campo1_3.Text = Convert.ToString(DC_F0_C1[3]);
            TextBox_DC_F0_Campo1_4.Text = Convert.ToString(DC_F0_C1[4]);
            TextBox_DC_F0_Campo1_5.Text = Convert.ToString(DC_F0_C1[5]);
            TextBox_DC_F0_Campo1_6.Text = Convert.ToString(DC_F0_C1[6]);
            TextBox_DC_F0_Campo1_7.Text = Convert.ToString(DC_F0_C1[7]);
            TextBox_DC_F0_Campo1_8.Text = Convert.ToString(DC_F0_C1[8]);


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C2----------------------------------------*/
            TextBox_DC_F0_Campo2_1.Text = Convert.ToString(DC_F0_C2[1]);
            TextBox_DC_F0_Campo2_2.Text = Convert.ToString(DC_F0_C2[2]);
            TextBox_DC_F0_Campo2_3.Text = Convert.ToString(DC_F0_C2[3]);
            TextBox_DC_F0_Campo2_4.Text = Convert.ToString(DC_F0_C2[4]);
            TextBox_DC_F0_Campo2_5.Text = Convert.ToString(DC_F0_C2[5]);
            TextBox_DC_F0_Campo2_6.Text = Convert.ToString(DC_F0_C2[6]);
            TextBox_DC_F0_Campo2_7.Text = Convert.ToString(DC_F0_C2[7]);
            TextBox_DC_F0_Campo2_8.Text = Convert.ToString(DC_F0_C2[8]);


            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C3----------------------------------------*/
            TextBox_DC_F0_Campo3_1.Text = Convert.ToString(DC_F0_C3[1]);
            TextBox_DC_F0_Campo3_2.Text = Convert.ToString(DC_F0_C3[2]);
            TextBox_DC_F0_Campo3_3.Text = Convert.ToString(DC_F0_C3[3]);
            TextBox_DC_F0_Campo3_4.Text = Convert.ToString(DC_F0_C3[4]);
            TextBox_DC_F0_Campo3_5.Text = Convert.ToString(DC_F0_C3[5]);
            TextBox_DC_F0_Campo3_6.Text = Convert.ToString(DC_F0_C3[6]);
            TextBox_DC_F0_Campo3_7.Text = Convert.ToString(DC_F0_C3[7]);
            TextBox_DC_F0_Campo3_8.Text = Convert.ToString(DC_F0_C3[8]);


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C4----------------------------------------*/
            TextBox_DC_F0_Campo4_1.Text = Convert.ToString(DC_F0_C4[1]);
            TextBox_DC_F0_Campo4_2.Text = Convert.ToString(DC_F0_C4[2]);
            TextBox_DC_F0_Campo4_3.Text = Convert.ToString(DC_F0_C4[3]);
            TextBox_DC_F0_Campo4_4.Text = Convert.ToString(DC_F0_C4[4]);
            TextBox_DC_F0_Campo4_5.Text = Convert.ToString(DC_F0_C4[5]);
            TextBox_DC_F0_Campo4_6.Text = Convert.ToString(DC_F0_C4[6]);
            TextBox_DC_F0_Campo4_7.Text = Convert.ToString(DC_F0_C4[7]);
            TextBox_DC_F0_Campo4_8.Text = Convert.ToString(DC_F0_C4[8]);


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C0----------------------------------------*/
            TextBox_DC_F1_Campo0_1.Text = Convert.ToString(DC_F1_C0[1]);
            TextBox_DC_F1_Campo0_2.Text = Convert.ToString(DC_F1_C0[2]);
            TextBox_DC_F1_Campo0_3.Text = Convert.ToString(DC_F1_C0[3]);
            TextBox_DC_F1_Campo0_4.Text = Convert.ToString(DC_F1_C0[4]);
            TextBox_DC_F1_Campo0_5.Text = Convert.ToString(DC_F1_C0[5]);
            TextBox_DC_F1_Campo0_6.Text = Convert.ToString(DC_F1_C0[6]);
            TextBox_DC_F1_Campo0_7.Text = Convert.ToString(DC_F1_C0[7]);
            TextBox_DC_F1_Campo0_8.Text = Convert.ToString(DC_F1_C0[8]);


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C1----------------------------------------*/
            TextBox_DC_F1_Campo1_1.Text = Convert.ToString(DC_F1_C1[1]);
            TextBox_DC_F1_Campo1_2.Text = Convert.ToString(DC_F1_C1[2]);
            TextBox_DC_F1_Campo1_3.Text = Convert.ToString(DC_F1_C1[3]);
            TextBox_DC_F1_Campo1_4.Text = Convert.ToString(DC_F1_C1[4]);
            TextBox_DC_F1_Campo1_5.Text = Convert.ToString(DC_F1_C1[5]);
            TextBox_DC_F1_Campo1_6.Text = Convert.ToString(DC_F1_C1[6]);
            TextBox_DC_F1_Campo1_7.Text = Convert.ToString(DC_F1_C1[7]);
            TextBox_DC_F1_Campo1_8.Text = Convert.ToString(DC_F1_C1[8]);


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C2----------------------------------------*/
            TextBox_DC_F1_Campo2_1.Text = Convert.ToString(DC_F1_C2[1]);
            TextBox_DC_F1_Campo2_2.Text = Convert.ToString(DC_F1_C2[2]);
            TextBox_DC_F1_Campo2_3.Text = Convert.ToString(DC_F1_C2[3]);
            TextBox_DC_F1_Campo2_4.Text = Convert.ToString(DC_F1_C2[4]);
            TextBox_DC_F1_Campo2_5.Text = Convert.ToString(DC_F1_C2[5]);
            TextBox_DC_F1_Campo2_6.Text = Convert.ToString(DC_F1_C2[6]);
            TextBox_DC_F1_Campo2_7.Text = Convert.ToString(DC_F1_C2[7]);
            TextBox_DC_F1_Campo2_8.Text = Convert.ToString(DC_F1_C2[8]);


            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C3----------------------------------------*/
            TextBox_DC_F1_Campo3_1.Text = Convert.ToString(DC_F1_C3[1]);
            TextBox_DC_F1_Campo3_2.Text = Convert.ToString(DC_F1_C3[2]);
            TextBox_DC_F1_Campo3_3.Text = Convert.ToString(DC_F1_C3[3]);
            TextBox_DC_F1_Campo3_4.Text = Convert.ToString(DC_F1_C3[4]);
            TextBox_DC_F1_Campo3_5.Text = Convert.ToString(DC_F1_C3[5]);
            TextBox_DC_F1_Campo3_6.Text = Convert.ToString(DC_F1_C3[6]);
            TextBox_DC_F1_Campo3_7.Text = Convert.ToString(DC_F1_C3[7]);
            TextBox_DC_F1_Campo3_8.Text = Convert.ToString(DC_F1_C3[8]);


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F1 C4----------------------------------------*/
            TextBox_DC_F1_Campo4_1.Text = Convert.ToString(DC_F1_C4[1]);
            TextBox_DC_F1_Campo4_2.Text = Convert.ToString(DC_F1_C4[2]);
            TextBox_DC_F1_Campo4_3.Text = Convert.ToString(DC_F1_C4[3]);
            TextBox_DC_F1_Campo4_4.Text = Convert.ToString(DC_F1_C4[4]);
            TextBox_DC_F1_Campo4_5.Text = Convert.ToString(DC_F1_C4[5]);
            TextBox_DC_F1_Campo4_6.Text = Convert.ToString(DC_F1_C4[6]);
            TextBox_DC_F1_Campo4_7.Text = Convert.ToString(DC_F1_C4[7]);
            TextBox_DC_F1_Campo4_8.Text = Convert.ToString(DC_F1_C4[8]);


            /*--------------------------------------------------------------------------------*/






            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C0----------------------------------------*/
            TextBox_DC_F2_Campo0_1.Text = Convert.ToString(DC_F2_C0[1]);
            TextBox_DC_F2_Campo0_2.Text = Convert.ToString(DC_F2_C0[2]);
            TextBox_DC_F2_Campo0_3.Text = Convert.ToString(DC_F2_C0[3]);
            TextBox_DC_F2_Campo0_4.Text = Convert.ToString(DC_F2_C0[4]);
            TextBox_DC_F2_Campo0_5.Text = Convert.ToString(DC_F2_C0[5]);
            TextBox_DC_F2_Campo0_6.Text = Convert.ToString(DC_F2_C0[6]);
            TextBox_DC_F2_Campo0_7.Text = Convert.ToString(DC_F2_C0[7]);
            TextBox_DC_F2_Campo0_8.Text = Convert.ToString(DC_F2_C0[8]);


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C1----------------------------------------*/
            TextBox_DC_F2_Campo1_1.Text = Convert.ToString(DC_F2_C1[1]);
            TextBox_DC_F2_Campo1_2.Text = Convert.ToString(DC_F2_C1[2]);
            TextBox_DC_F2_Campo1_3.Text = Convert.ToString(DC_F2_C1[3]);
            TextBox_DC_F2_Campo1_4.Text = Convert.ToString(DC_F2_C1[4]);
            TextBox_DC_F2_Campo1_5.Text = Convert.ToString(DC_F2_C1[5]);
            TextBox_DC_F2_Campo1_6.Text = Convert.ToString(DC_F2_C1[6]);
            TextBox_DC_F2_Campo1_7.Text = Convert.ToString(DC_F2_C1[7]);
            TextBox_DC_F2_Campo1_8.Text = Convert.ToString(DC_F2_C1[8]);


            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C2----------------------------------------*/
            TextBox_DC_F2_Campo2_1.Text = Convert.ToString(DC_F2_C2[1]);
            TextBox_DC_F2_Campo2_2.Text = Convert.ToString(DC_F2_C2[2]);
            TextBox_DC_F2_Campo2_3.Text = Convert.ToString(DC_F2_C2[3]);
            TextBox_DC_F2_Campo2_4.Text = Convert.ToString(DC_F2_C2[4]);
            TextBox_DC_F2_Campo2_5.Text = Convert.ToString(DC_F2_C2[5]);
            TextBox_DC_F2_Campo2_6.Text = Convert.ToString(DC_F2_C2[6]);
            TextBox_DC_F2_Campo2_7.Text = Convert.ToString(DC_F2_C2[7]);
            TextBox_DC_F2_Campo2_8.Text = Convert.ToString(DC_F2_C2[8]);


            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F2 C3----------------------------------------*/
            TextBox_DC_F2_Campo3_1.Text = Convert.ToString(DC_F2_C3[1]);
            TextBox_DC_F2_Campo3_2.Text = Convert.ToString(DC_F2_C3[2]);
            TextBox_DC_F2_Campo3_3.Text = Convert.ToString(DC_F2_C3[3]);
            TextBox_DC_F2_Campo3_4.Text = Convert.ToString(DC_F2_C3[4]);
            TextBox_DC_F2_Campo3_5.Text = Convert.ToString(DC_F2_C3[5]);
            TextBox_DC_F2_Campo3_6.Text = Convert.ToString(DC_F2_C3[6]);
            TextBox_DC_F2_Campo3_7.Text = Convert.ToString(DC_F2_C3[7]);
            TextBox_DC_F2_Campo3_8.Text = Convert.ToString(DC_F2_C3[8]);


            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*-----------------------------------F0 C4----------------------------------------*/
            TextBox_DC_F2_Campo4_1.Text = Convert.ToString(DC_F2_C4[1]);
            TextBox_DC_F2_Campo4_2.Text = Convert.ToString(DC_F2_C4[2]);
            TextBox_DC_F2_Campo4_3.Text = Convert.ToString(DC_F2_C4[3]);
            TextBox_DC_F2_Campo4_4.Text = Convert.ToString(DC_F2_C4[4]);
            TextBox_DC_F2_Campo4_5.Text = Convert.ToString(DC_F2_C4[5]);
            TextBox_DC_F2_Campo4_6.Text = Convert.ToString(DC_F2_C4[6]);
            TextBox_DC_F2_Campo4_7.Text = Convert.ToString(DC_F2_C4[7]);
            TextBox_DC_F2_Campo4_8.Text = Convert.ToString(DC_F2_C4[8]);


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
            Registro_F0_C4[6] = Convert.ToInt16((DC_F0_C4[7] * 9999f) / 100f);
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
            Registro_F2_C2[1] = Convert.ToInt16((DC_F0_C2[1] * 9999f) / 100f);
            Registro_F2_C2[2] = Convert.ToInt16((DC_F0_C2[2] * 9999f) / 100f);
            Registro_F2_C2[3] = Convert.ToInt16((DC_F0_C2[3] * 9999f) / 100f);
            Registro_F2_C2[4] = Convert.ToInt16((DC_F0_C2[4] * 9999f) / 100f);
            Registro_F2_C2[5] = Convert.ToInt16((DC_F0_C2[5] * 9999f) / 100f);
            Registro_F2_C2[6] = Convert.ToInt16((DC_F0_C2[6] * 9999f) / 100f);
            Registro_F2_C2[7] = Convert.ToInt16((DC_F0_C2[7] * 9999f) / 100f);
            Registro_F2_C2[8] = Convert.ToInt16((DC_F0_C2[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C3 ---------------------------------------*/
            Registro_F2_C3[1] = Convert.ToInt16((DC_F0_C3[1] * 9999f) / 100f);
            Registro_F2_C3[2] = Convert.ToInt16((DC_F0_C3[2] * 9999f) / 100f);
            Registro_F2_C3[3] = Convert.ToInt16((DC_F0_C3[3] * 9999f) / 100f);
            Registro_F2_C3[4] = Convert.ToInt16((DC_F0_C3[4] * 9999f) / 100f);
            Registro_F2_C3[5] = Convert.ToInt16((DC_F0_C3[5] * 9999f) / 100f);
            Registro_F2_C3[6] = Convert.ToInt16((DC_F0_C3[6] * 9999f) / 100f);
            Registro_F2_C3[7] = Convert.ToInt16((DC_F0_C3[7] * 9999f) / 100f);
            Registro_F2_C3[8] = Convert.ToInt16((DC_F0_C3[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/


            /*-----------------------------------------------------------------------------*/
            /*------------------------------------F2 C4 ---------------------------------------*/
            Registro_F2_C4[1] = Convert.ToInt16((DC_F0_C4[1] * 9999f) / 100f);
            Registro_F2_C4[2] = Convert.ToInt16((DC_F0_C4[2] * 9999f) / 100f);
            Registro_F2_C4[3] = Convert.ToInt16((DC_F0_C4[3] * 9999f) / 100f);
            Registro_F2_C4[4] = Convert.ToInt16((DC_F0_C4[4] * 9999f) / 100f);
            Registro_F2_C4[5] = Convert.ToInt16((DC_F0_C4[5] * 9999f) / 100f);
            Registro_F2_C4[6] = Convert.ToInt16((DC_F0_C4[6] * 9999f) / 100f);
            Registro_F2_C4[7] = Convert.ToInt16((DC_F0_C4[7] * 9999f) / 100f);
            Registro_F2_C4[8] = Convert.ToInt16((DC_F0_C4[8] * 9999f) / 100f);


            /*-----------------------------------------------------------------------------*/









        }



        public void Imprimir_Reistro_Tablas()
        {

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C0-------------------------------------------*/
            TextBox_F0_Campo0_Min.Text = Convert.ToString(Registro_F0_C0[0]);
            TextBox_F0_Campo0_1.Text = Convert.ToString(Registro_F0_C0[1]);
            TextBox_F0_Campo0_2.Text = Convert.ToString(Registro_F0_C0[2]);
            TextBox_F0_Campo0_3.Text = Convert.ToString(Registro_F0_C0[3]);
            TextBox_F0_Campo0_4.Text = Convert.ToString(Registro_F0_C0[4]);
            TextBox_F0_Campo0_5.Text = Convert.ToString(Registro_F0_C0[5]);
            TextBox_F0_Campo0_6.Text = Convert.ToString(Registro_F0_C0[6]);
            TextBox_F0_Campo0_7.Text = Convert.ToString(Registro_F0_C0[7]);
            TextBox_F0_Campo0_8.Text = Convert.ToString(Registro_F0_C0[8]);
            TextBox_F0_Campo0_Max.Text = Convert.ToString(Registro_F0_C0[9]);

            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C1-------------------------------------------*/
            TextBox_F0_Campo1_Min.Text = Convert.ToString(Registro_F0_C1[0]);
            TextBox_F0_Campo1_1.Text = Convert.ToString(Registro_F0_C1[1]);
            TextBox_F0_Campo1_2.Text = Convert.ToString(Registro_F0_C1[2]);
            TextBox_F0_Campo1_3.Text = Convert.ToString(Registro_F0_C1[3]);
            TextBox_F0_Campo1_4.Text = Convert.ToString(Registro_F0_C1[4]);
            TextBox_F0_Campo1_5.Text = Convert.ToString(Registro_F0_C1[5]);
            TextBox_F0_Campo1_6.Text = Convert.ToString(Registro_F0_C1[6]);
            TextBox_F0_Campo1_7.Text = Convert.ToString(Registro_F0_C1[7]);
            TextBox_F0_Campo1_8.Text = Convert.ToString(Registro_F0_C1[8]);
            TextBox_F0_Campo1_Max.Text = Convert.ToString(Registro_F0_C1[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C2-------------------------------------------*/
            TextBox_F0_Campo2_Min.Text = Convert.ToString(Registro_F0_C2[0]);
            TextBox_F0_Campo2_1.Text = Convert.ToString(Registro_F0_C2[1]);
            TextBox_F0_Campo2_2.Text = Convert.ToString(Registro_F0_C2[2]);
            TextBox_F0_Campo2_3.Text = Convert.ToString(Registro_F0_C2[3]);
            TextBox_F0_Campo2_4.Text = Convert.ToString(Registro_F0_C2[4]);
            TextBox_F0_Campo2_5.Text = Convert.ToString(Registro_F0_C2[5]);
            TextBox_F0_Campo2_6.Text = Convert.ToString(Registro_F0_C2[6]);
            TextBox_F0_Campo2_7.Text = Convert.ToString(Registro_F0_C2[7]);
            TextBox_F0_Campo2_8.Text = Convert.ToString(Registro_F0_C2[8]);
            TextBox_F0_Campo2_Max.Text = Convert.ToString(Registro_F0_C2[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C3-------------------------------------------*/
            TextBox_F0_Campo3_Min.Text = Convert.ToString(Registro_F0_C3[0]);
            TextBox_F0_Campo3_1.Text = Convert.ToString(Registro_F0_C3[1]);
            TextBox_F0_Campo3_2.Text = Convert.ToString(Registro_F0_C3[2]);
            TextBox_F0_Campo3_3.Text = Convert.ToString(Registro_F0_C3[3]);
            TextBox_F0_Campo3_4.Text = Convert.ToString(Registro_F0_C3[4]);
            TextBox_F0_Campo3_5.Text = Convert.ToString(Registro_F0_C3[5]);
            TextBox_F0_Campo3_6.Text = Convert.ToString(Registro_F0_C3[6]);
            TextBox_F0_Campo3_7.Text = Convert.ToString(Registro_F0_C3[7]);
            TextBox_F0_Campo3_8.Text = Convert.ToString(Registro_F0_C3[8]);
            TextBox_F0_Campo3_Max.Text = Convert.ToString(Registro_F0_C3[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C4-------------------------------------------*/
            TextBox_F0_Campo4_Min.Text = Convert.ToString(Registro_F0_C4[0]);
            TextBox_F0_Campo4_1.Text = Convert.ToString(Registro_F0_C4[1]);
            TextBox_F0_Campo4_2.Text = Convert.ToString(Registro_F0_C4[2]);
            TextBox_F0_Campo4_3.Text = Convert.ToString(Registro_F0_C4[3]);
            TextBox_F0_Campo4_4.Text = Convert.ToString(Registro_F0_C4[4]);
            TextBox_F0_Campo4_5.Text = Convert.ToString(Registro_F0_C4[5]);
            TextBox_F0_Campo4_6.Text = Convert.ToString(Registro_F0_C4[6]);
            TextBox_F0_Campo4_7.Text = Convert.ToString(Registro_F0_C4[7]);
            TextBox_F0_Campo4_8.Text = Convert.ToString(Registro_F0_C4[8]);
            TextBox_F0_Campo4_Max.Text = Convert.ToString(Registro_F0_C4[9]);

            /*--------------------------------------------------------------------------------*/



            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F0 C0-------------------------------------------*/
            TextBox_F1_Campo0_Min.Text = Convert.ToString(Registro_F1_C0[0]);
            TextBox_F1_Campo0_1.Text = Convert.ToString(Registro_F1_C0[1]);
            TextBox_F1_Campo0_2.Text = Convert.ToString(Registro_F1_C0[2]);
            TextBox_F1_Campo0_3.Text = Convert.ToString(Registro_F1_C0[3]);
            TextBox_F1_Campo0_4.Text = Convert.ToString(Registro_F1_C0[4]);
            TextBox_F1_Campo0_5.Text = Convert.ToString(Registro_F1_C0[5]);
            TextBox_F1_Campo0_6.Text = Convert.ToString(Registro_F1_C0[6]);
            TextBox_F1_Campo0_7.Text = Convert.ToString(Registro_F1_C0[7]);
            TextBox_F1_Campo0_8.Text = Convert.ToString(Registro_F1_C0[8]);
            TextBox_F1_Campo0_Max.Text = Convert.ToString(Registro_F1_C0[9]);

            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C1-------------------------------------------*/
            TextBox_F1_Campo1_Min.Text = Convert.ToString(Registro_F1_C1[0]);
            TextBox_F1_Campo1_1.Text = Convert.ToString(Registro_F1_C1[1]);
            TextBox_F1_Campo1_2.Text = Convert.ToString(Registro_F1_C1[2]);
            TextBox_F1_Campo1_3.Text = Convert.ToString(Registro_F1_C1[3]);
            TextBox_F1_Campo1_4.Text = Convert.ToString(Registro_F1_C1[4]);
            TextBox_F1_Campo1_5.Text = Convert.ToString(Registro_F1_C1[5]);
            TextBox_F1_Campo1_6.Text = Convert.ToString(Registro_F1_C1[6]);
            TextBox_F1_Campo1_7.Text = Convert.ToString(Registro_F1_C1[7]);
            TextBox_F1_Campo1_8.Text = Convert.ToString(Registro_F1_C1[8]);
            TextBox_F1_Campo1_Max.Text = Convert.ToString(Registro_F1_C1[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C2-------------------------------------------*/
            TextBox_F1_Campo2_Min.Text = Convert.ToString(Registro_F1_C2[0]);
            TextBox_F1_Campo2_1.Text = Convert.ToString(Registro_F1_C2[1]);
            TextBox_F1_Campo2_2.Text = Convert.ToString(Registro_F1_C2[2]);
            TextBox_F1_Campo2_3.Text = Convert.ToString(Registro_F1_C2[3]);
            TextBox_F1_Campo2_4.Text = Convert.ToString(Registro_F1_C2[4]);
            TextBox_F1_Campo2_5.Text = Convert.ToString(Registro_F1_C2[5]);
            TextBox_F1_Campo2_6.Text = Convert.ToString(Registro_F1_C2[6]);
            TextBox_F1_Campo2_7.Text = Convert.ToString(Registro_F1_C2[7]);
            TextBox_F1_Campo2_8.Text = Convert.ToString(Registro_F1_C2[8]);
            TextBox_F1_Campo2_Max.Text = Convert.ToString(Registro_F1_C2[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C3-------------------------------------------*/
            TextBox_F1_Campo3_Min.Text = Convert.ToString(Registro_F1_C3[0]);
            TextBox_F1_Campo3_1.Text = Convert.ToString(Registro_F1_C3[1]);
            TextBox_F1_Campo3_2.Text = Convert.ToString(Registro_F1_C3[2]);
            TextBox_F1_Campo3_3.Text = Convert.ToString(Registro_F1_C3[3]);
            TextBox_F1_Campo3_4.Text = Convert.ToString(Registro_F1_C3[4]);
            TextBox_F1_Campo3_5.Text = Convert.ToString(Registro_F1_C3[5]);
            TextBox_F1_Campo3_6.Text = Convert.ToString(Registro_F1_C3[6]);
            TextBox_F1_Campo3_7.Text = Convert.ToString(Registro_F1_C3[7]);
            TextBox_F1_Campo3_8.Text = Convert.ToString(Registro_F1_C3[8]);
            TextBox_F1_Campo3_Max.Text = Convert.ToString(Registro_F1_C3[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F1 C4-------------------------------------------*/
            TextBox_F1_Campo4_Min.Text = Convert.ToString(Registro_F1_C4[0]);
            TextBox_F1_Campo4_1.Text = Convert.ToString(Registro_F1_C4[1]);
            TextBox_F1_Campo4_2.Text = Convert.ToString(Registro_F1_C4[2]);
            TextBox_F1_Campo4_3.Text = Convert.ToString(Registro_F1_C4[3]);
            TextBox_F1_Campo4_4.Text = Convert.ToString(Registro_F1_C4[4]);
            TextBox_F1_Campo4_5.Text = Convert.ToString(Registro_F1_C4[5]);
            TextBox_F1_Campo4_6.Text = Convert.ToString(Registro_F1_C4[6]);
            TextBox_F1_Campo4_7.Text = Convert.ToString(Registro_F1_C4[7]);
            TextBox_F1_Campo4_8.Text = Convert.ToString(Registro_F1_C4[8]);
            TextBox_F1_Campo4_Max.Text = Convert.ToString(Registro_F1_C4[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C0-------------------------------------------*/
            TextBox_F2_Campo0_Min.Text = Convert.ToString(Registro_F2_C0[0]);
            TextBox_F2_Campo0_1.Text = Convert.ToString(Registro_F2_C0[1]);
            TextBox_F2_Campo0_2.Text = Convert.ToString(Registro_F2_C0[2]);
            TextBox_F2_Campo0_3.Text = Convert.ToString(Registro_F2_C0[3]);
            TextBox_F2_Campo0_4.Text = Convert.ToString(Registro_F2_C0[4]);
            TextBox_F2_Campo0_5.Text = Convert.ToString(Registro_F2_C0[5]);
            TextBox_F2_Campo0_6.Text = Convert.ToString(Registro_F2_C0[6]);
            TextBox_F2_Campo0_7.Text = Convert.ToString(Registro_F2_C0[7]);
            TextBox_F2_Campo0_8.Text = Convert.ToString(Registro_F2_C0[8]);
            TextBox_F2_Campo0_Max.Text = Convert.ToString(Registro_F2_C0[9]);

            /*--------------------------------------------------------------------------------*/

            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C1-------------------------------------------*/
            TextBox_F2_Campo1_Min.Text = Convert.ToString(Registro_F2_C1[0]);
            TextBox_F2_Campo1_1.Text = Convert.ToString(Registro_F2_C1[1]);
            TextBox_F2_Campo1_2.Text = Convert.ToString(Registro_F2_C1[2]);
            TextBox_F2_Campo1_3.Text = Convert.ToString(Registro_F2_C1[3]);
            TextBox_F2_Campo1_4.Text = Convert.ToString(Registro_F2_C1[4]);
            TextBox_F2_Campo1_5.Text = Convert.ToString(Registro_F2_C1[5]);
            TextBox_F2_Campo1_6.Text = Convert.ToString(Registro_F2_C1[6]);
            TextBox_F2_Campo1_7.Text = Convert.ToString(Registro_F2_C1[7]);
            TextBox_F2_Campo1_8.Text = Convert.ToString(Registro_F2_C1[8]);
            TextBox_F2_Campo1_Max.Text = Convert.ToString(Registro_F2_C1[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C2-------------------------------------------*/
            TextBox_F2_Campo2_Min.Text = Convert.ToString(Registro_F2_C2[0]);
            TextBox_F2_Campo2_1.Text = Convert.ToString(Registro_F2_C2[1]);
            TextBox_F2_Campo2_2.Text = Convert.ToString(Registro_F2_C2[2]);
            TextBox_F2_Campo2_3.Text = Convert.ToString(Registro_F2_C2[3]);
            TextBox_F2_Campo2_4.Text = Convert.ToString(Registro_F2_C2[4]);
            TextBox_F2_Campo2_5.Text = Convert.ToString(Registro_F2_C2[5]);
            TextBox_F2_Campo2_6.Text = Convert.ToString(Registro_F2_C2[6]);
            TextBox_F2_Campo2_7.Text = Convert.ToString(Registro_F2_C2[7]);
            TextBox_F2_Campo2_8.Text = Convert.ToString(Registro_F2_C2[8]);
            TextBox_F2_Campo2_Max.Text = Convert.ToString(Registro_F2_C2[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C3-------------------------------------------*/
            TextBox_F2_Campo3_Min.Text = Convert.ToString(Registro_F2_C3[0]);
            TextBox_F2_Campo3_1.Text = Convert.ToString(Registro_F2_C3[1]);
            TextBox_F2_Campo3_2.Text = Convert.ToString(Registro_F2_C3[2]);
            TextBox_F2_Campo3_3.Text = Convert.ToString(Registro_F2_C3[3]);
            TextBox_F2_Campo3_4.Text = Convert.ToString(Registro_F2_C3[4]);
            TextBox_F2_Campo3_5.Text = Convert.ToString(Registro_F2_C3[5]);
            TextBox_F2_Campo3_6.Text = Convert.ToString(Registro_F2_C3[6]);
            TextBox_F2_Campo3_7.Text = Convert.ToString(Registro_F2_C3[7]);
            TextBox_F2_Campo3_8.Text = Convert.ToString(Registro_F2_C3[8]);
            TextBox_F2_Campo3_Max.Text = Convert.ToString(Registro_F2_C3[9]);

            /*--------------------------------------------------------------------------------*/


            /*--------------------------------------------------------------------------------*/
            /*---------------------------------F2 C4-------------------------------------------*/
            TextBox_F2_Campo4_Min.Text = Convert.ToString(Registro_F2_C4[0]);
            TextBox_F2_Campo4_1.Text = Convert.ToString(Registro_F2_C4[1]);
            TextBox_F2_Campo4_2.Text = Convert.ToString(Registro_F2_C4[2]);
            TextBox_F2_Campo4_3.Text = Convert.ToString(Registro_F2_C4[3]);
            TextBox_F2_Campo4_4.Text = Convert.ToString(Registro_F2_C4[4]);
            TextBox_F2_Campo4_5.Text = Convert.ToString(Registro_F2_C4[5]);
            TextBox_F2_Campo4_6.Text = Convert.ToString(Registro_F2_C4[6]);
            TextBox_F2_Campo4_7.Text = Convert.ToString(Registro_F2_C4[7]);
            TextBox_F2_Campo4_8.Text = Convert.ToString(Registro_F2_C4[8]);
            TextBox_F2_Campo4_Max.Text = Convert.ToString(Registro_F2_C4[9]);

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
                    Registro_F0_C0[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {
                   
                    Incremento_F0_C0[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {
                    
                    DC_F0_C0[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {
                    
                    mA_F0_C0[contador] = 0;

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
                    Registro_F0_C1[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C1[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C1[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C1[contador] = 0;

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
                    Registro_F0_C2[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C2[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C2[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C2[contador] = 0;

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
                    Registro_F0_C3[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C3[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C3[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C3[contador] = 0;

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
                    Registro_F0_C4[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F0_C4[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F0_C4[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F0_C4[contador] = 0;

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
                    Registro_F1_C0[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C0[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C0[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C0[contador] = 0;

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
                    Registro_F1_C1[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C1[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C1[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C1[contador] = 0;

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
                    Registro_F1_C2[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C2[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C2[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C2[contador] = 0;

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
                    Registro_F1_C3[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C3[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C3[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C3[contador] = 0;

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
                    Registro_F1_C4[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F1_C4[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F1_C4[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F1_C4[contador] = 0;

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
                    Registro_F2_C0[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C0[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C0[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C0[contador] = 0;

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
                    Registro_F2_C1[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C1[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C1[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C1[contador] = 0;

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
                    Registro_F2_C2[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C2[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C2[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C2[contador] = 0;

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
                    Registro_F2_C3[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C3[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C3[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C3[contador] = 0;

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
                    Registro_F2_C4[contador] = 0;

                }


                /********************INCREMENTO  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    Incremento_F2_C4[contador] = 0;

                }

                /********************DC  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    DC_F2_C4[contador] = 0;


                }

                /********************MA  ******************************/

                for (byte contador = 0; contador <= 9; contador++)
                {

                    mA_F2_C4[contador] = 0;

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
                button_guardar.Enabled = true;
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
                button_teclado.Enabled = false;
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
                serialPort_Form2.WriteLine("[P]");


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
            SerialDataIn = serialPort_Form2.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {

            try
            {
                indexOfA = Convert.ToInt32( SerialDataIn.IndexOf("A"));
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

                

                String_F0_C0_MAX = SerialDataIn.Substring(indexOfA  +   1, (indexOfB    -   indexOfA)   -1 );
                TextBox_F0_Campo0_Max.Text = String_F0_C0_MAX;
                

                
                String_F0_C1_MIN = SerialDataIn.Substring(indexOfB  +   1, (indexOfC    -   indexOfB)   - 1);
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
    }


    




}


    