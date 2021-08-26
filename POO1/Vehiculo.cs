using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Vehiculo
    {
        //propiedades
        public int ID { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int KM { get; set; }

        //se sobreecribe con el virtual para el precio
        public virtual double Precio { get; set; }


        //Contructor
        public Vehiculo(int iD, string marca, string modelo, int kM, double precio)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            KM = kM;
            Precio = precio;

        }

        public override string ToString()
        {
            return "Marca: " + Marca + ", modelo: " + Modelo +
                   " con un precio de " + Precio + "KM" + KM;
        }

    }
}
