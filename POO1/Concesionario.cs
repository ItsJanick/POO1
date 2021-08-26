using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Concesionario
    {
        public Coche[] coches;
        public int limite;

        public int cantcoches;


        public Concesionario(int limite)
        {
            this.limite = limite;
            this.coches = new Coche[limite];
            cantcoches = 0;
        }

        //metodos
        public void aniadirCoche(Coche c)
        {

            if (c != null && cantcoches < coches.Length)
            {
                coches[cantcoches] = c;
                cantcoches++;
            }


        }
        public void mostrarCoches()
        {

            for (int i = 0; i < cantcoches; i++)
            {
                Console.WriteLine(coches[i].ToString());
            }

        }

        public void vaciarCoches()
        {

            this.coches = new Coche[limite];
            cantcoches = 0;

        }
        public void eliminarCoche(Coche c)
        {

            if (c != null && cantcoches != 0)
            {
                //se crea una variable para determinar la posicion del coche y se condiciona para eliminar el coche.
                int posicion = -1;
                for (int i = 0; i < cantcoches; i++)
                {
                    if (c.ID == coches[i].ID)
                    {
                        posicion = i;
                    }
                }

                //
                if (posicion == -1)
                {
                    Console.WriteLine("No existe");
                }
                else
                {
                    coches[posicion] = null;

                    for (int i = posicion; i < cantcoches; i++)
                    {
                        coches[i] = coches[i + 1];

                    }

                    cantcoches--;

                }
            }

        }
    }

}
