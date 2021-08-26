using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    class Coche: Vehiculo
    {

        public bool airbag { get; set; }

        //constructor
        public Coche(int iD, string marca, string modelo, int kM, double precio, bool airbag):base(iD, marca, modelo, kM, precio)
        {
            this.airbag = airbag;
        }


        public override double Precio
        {
            get
            {
                if (this.airbag)
                {
                    return base.Precio + 200;
                }
                else
                {
                    return base.Precio;
                }
            }
        }

        public override string ToString()
        {
            if (this.airbag)
            {
                return base.ToString() + " Tiene un airbag";
            }
            else
            {
                return base.ToString() + "No tiene un airbag";
            }
        }


    }
}
