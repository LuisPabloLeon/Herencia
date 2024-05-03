using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    class operacion
    {
        //declaracion de variables que usa la clase
        //tipo de acceso        tipo de dato          nombre de dato
        protected               float                     valor1;
        protected               float                      valor2;
        protected               float                     resultado;

        //definicion de atributos: sin atributos
        //metodos o funciondes de operaciones
        /*los meodos que se ponen a continuacion
         * son las funciones de obtener e valor
         * de la caja de texto y guardarlo en la 
         * memoria dentro de la variable indicada*/
        //USAMOS UN contructor POR CADA CAJA DE MEMORIA
        public float Valor1//CAJA DE MEMORIA 1
        {
            get { return valor1; }//Vamos por el valor
                                  //de la caja de texto
            set { valor1 = value; }//lo guardamos en la memoria
        }
        public float Valor2//Caja de memoria 2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public float Resultado//Caja de memoria 3
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
    //creamos nuestras clases hijo que usara los
    //metodos de crear dato
    class Sumar : operacion //los : nos dan permiso de usar
                            //lo que tiene operacion
    {
        /*las clases hijas tambien pueden tener sus
         * propios atributos y metodos
         * pueden tener variables de uso solamente
         * para la clase hijo
         * declarar variables de esta clase
         * atributos de esta clase
         * metodos de clase*/
        public float operar(float v1, float v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class Restar : operacion
    {
        public float operar(float v1, float v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class Multiplicar : operacion
    {
        public float operar(float v1, float v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class Dividir : operacion
    {
        public float operar(float v1, float v2)
        {
            valor1 = v1;
            valor2 = v2;
            if (valor1 == 0)//validacion de que el numero no sea 0
            {
                MessageBox.Show("No puedes dividir entre 0");
            }
            return resultado = valor1 / valor2;
        }
    }
    //esto es un comentario nuevo 26 de abril
    //esto es un segunod comentario nuevo 26 de abril
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
