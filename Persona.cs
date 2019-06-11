using System;
namespace Casa{

/*● También crea una clase de persona, con un nombre (cadena). Cada persona tendrá una casa. 
El método "ShowData" para una persona mostrará su nombre, mostrará los datos de su casa y 
los datos de la puerta de esa casa. */
    public class Persona{
        
        private string nombre;
        private Casa casa;
    


        public Persona(string nombre){
            this.nombre = nombre;
        }

        public void setCasa(Casa casa){
            this.casa = casa;
        }

        public Casa getCasa(){
            return this.casa;
        }


        public void ShowData(){
            Console.WriteLine($"Soy una persona, llamada {this.nombre}.");
            casa.ShowData();
            casa.getPuerta().ShowData();
        }

    }
}