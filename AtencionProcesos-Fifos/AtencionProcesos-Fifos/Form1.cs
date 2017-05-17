using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtencionProcesos_Fifos
{
    public partial class Form1 : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        ColaQueue cola;
        private static Random porcent = new Random(5);
        private static Random alea = new Random(5);
        private int _ciclosOcio;
        private int _porcentaje;
        private string _reporte;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public Form1()
        {
            InitializeComponent();

            _ciclosOcio = 0;
            _porcentaje = 0;
            _reporte = string.Empty;
            bttonMostrarProcesos.Enabled = false;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON COMENZAR - realiza todo lo necesario para procesar los ciclos
        private void bttonComenzar_Click(object sender, EventArgs e)
        {
            cola = new ColaQueue();

            //Se limpian todas los textBox
            txtReporte.Text = string.Empty;
            txtNumProFaltantes.Text = string.Empty;
            txtListaProFaltantes.Text = string.Empty;
            txtCiclosOcio.Text = string.Empty;

            //El boton se deshabilita hasta que el porceso de comenzar termine
            bttonMostrarProcesos.Enabled = false;

            Comenzar();

            bttonMostrarProcesos.Enabled = true;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON MOSTRAR PROCESOS - muestra todas las estidisticas
        private void bttonMostrarProcesos_Click(object sender, EventArgs e)
        {
            txtReporte.Text = _reporte;
            txtNumProFaltantes.Text = Convert.ToString(cola.Count);
            txtListaProFaltantes.Text = cola.ToString();
            txtCiclosOcio.Text = Convert.ToString(_ciclosOcio);

        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO COMENZAR 
        private void Comenzar()
        {
            int numProceso = 1;
            _ciclosOcio = 0;
            _reporte = string.Empty;
            _porcentaje = porcent.Next(1, 10);

            //Se inicia el ciclo principal con los cilco que ejecutara el micro
            for (int i = 1; i <= 200; i++)
            {
                //Contamos cada vuelta el ciclo para mostrarlo en el reporte
                _reporte += "===========================" + Environment.NewLine
                          + "             Ciclo:  " + i + Environment.NewLine
                          + "===========================" + Environment.NewLine;

                //Condicionamos si el porcentaje es igual al 25% para que se cree un proceso nuevo y lo almacene en la cola
                if (_porcentaje >= 1 && _porcentaje <= 3)
                {
                    int _vidaCiclo = alea.Next(4, 14);
                    Proceso proceso = new Proceso(_vidaCiclo, numProceso++);

                    cola.Enqueue(proceso);   //El proceso es almacenado en cola 
                }
                
                //Mostramos el proceso que esta por salir para verificar que no este en null
                if (cola.Peek() != null)
                {
                    //si el primero proceso por salir tiene la vida igual a cero es eliminado
                    if (cola.Peek().VidaProceso == 0) 
                    {
                        cola.Dequeue(); //proceso se elimina

                        _reporte += "Proceso: Sin proceso" + Environment.NewLine
                                        + "Ciclos originales: Null" + Environment.NewLine
                                        + "Ciclos restantes:  Null" + Environment.NewLine
                                        + "-----------------------------" + Environment.NewLine;
                        _ciclosOcio++; //almacena el ciclo que el procesador no hace nada
                    }
                    else
                    {
                        //Se copia el proceso que esta en cola por salir en temp
                        Proceso temp = cola.Peek();

                        //Se hace un ciclo para ir recorriendo tada la lista de procesos y rebajarles 1 a su proceso de vida
                        while (temp != null)
                        {
                            if (temp.VidaProceso > 0)
                            {
                                temp.VidaProceso -= 1;
                                _reporte += temp.ToString();
                            }

                            temp = temp.Anterior;
                        }
                    }
                }
                else
                {
                    _reporte += "Proceso: Sin proceso" + Environment.NewLine
                                    + "Ciclos originales:  Null" + Environment.NewLine
                                    + "Ciclos restabtes:   Null" + Environment.NewLine
                                    + "-----------------------------" + Environment.NewLine;
                    _ciclosOcio++;
                }

                _porcentaje = porcent.Next(1, 10);
            }
        }
    }
}
