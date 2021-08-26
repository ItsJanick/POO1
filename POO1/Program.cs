using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //AQUI TENGO DUDAS, METODO TOSTRING


            //Coche c = new Coche(1, "Supra", "GTR", 10000, 230000, false);
            //Moto m = new Moto(2, "Susuki", "FXR", 23000, 10000, true);

            //Console.WriteLine("Precio del coche: " + c.Precio);
            //Console.WriteLine("Precio de la moto: " + m.Precio);

            //Console.WriteLine(c.ToString());
            //Console.WriteLine(m.ToString());

            //Console.ReadLine();


           Concesionario concesionario = new Concesionario(8);

            Coche c1 = new Coche(1, "Supra", "GTR", 40000, 1300000);
            Coche c2 = new Coche(2, "Tesla", "BH", 56000, 1000000);
            Coche c3 = new Coche(3, "Hummer", "UY", 120000, 1000000);
            Coche c4 = new Coche(4, "Jeep", "GT", 20000, 100000);
            Coche c5 = new Coche(5, "Honda", "civic", 1000,150000);
            Coche c6 = new Coche(6, "Audi", "Cy", 20000, 4500000);


            concesionario.aniadirCoche(c1);
            concesionario.aniadirCoche(c2);
            concesionario.aniadirCoche(c3);
            concesionario.aniadirCoche(c4);
            concesionario.aniadirCoche(c5);
            concesionario.aniadirCoche(c6);

            Console.WriteLine("Todos los vehiculos");
            concesionario.mostrarCoches();




            //concesionario.eliminarCoche(c3);
            //concesionario.eliminarCoche(c1);
            //concesionario.eliminarCoche(c2);
            ////concesionario.eliminarCoche(c4);

            //Console.WriteLine("Se elimina vehiculos");
            //concesionario.mostrarCoches();

            //concesionario.aniadirCoche(c3);
            //Console.WriteLine("Se agrega un vehiculo");
            //concesionario.mostrarCoches();

            //Console.WriteLine("Vacio");
            //concesionario.vaciarCoches();
            //concesionario.mostrarCoches();

            //Console.WriteLine(c.ToString());
            //Console.WriteLine(m.ToString());
            //Console.ReadLine();

        }
    }
}
