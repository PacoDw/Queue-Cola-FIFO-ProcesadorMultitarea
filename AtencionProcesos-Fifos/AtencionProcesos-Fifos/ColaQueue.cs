using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionProcesos_Fifos
{
    class ColaQueue
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        ListaNodo listaProcesos;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //PROPIEDADES DE LA CLASE
        public int Count { get { return listaProcesos.Count; } }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public ColaQueue()
        {
            listaProcesos = new ListaNodo();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ENQUEUE
        public void Enqueue(Proceso nuevo)
        {
            listaProcesos.addPrimero(nuevo);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO DEQUEUE
        public Proceso Dequeue()
        {
            Proceso ultimo = listaProcesos.Ultimo;

            if (ultimo != null)
                listaProcesos.eliminarUltimo();

            return ultimo;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO PEEK
        public Proceso Peek()
        {
            return listaProcesos.Ultimo;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ToString
        public override string ToString()
        {
            return listaProcesos.ToString();
        }
    }
}
