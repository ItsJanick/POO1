using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Moto : Vehiculo
    {

        public bool sidecar { get; set; }

        //constructor y valores de Vehiculo(padre,base)
        public Moto(int iD, string marca, string modelo, int kM, double precio, bool sidecar) : base(iD, marca, modelo, kM, precio)
        {
            this.sidecar = sidecar;
        }

        //se sobreescribe de igual manera aca y se obtiene la propiedad por el get en un IF
        public override double Precio
        {
            get
            {
                if (this.sidecar)
                {
                    return base.Precio + 50;
                }
                else
                {
                    return base.Precio;
                }
            }
        }

        public override string ToString()
        {
            if (this.sidecar)
            {
                return base.ToString() + " Tiene un sidecar";
            }
            else
            {
                return base.ToString() + "No tiene un sidecar";
            }
        }


    }
}