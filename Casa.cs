using System;
namespace Casa{

/*Casa
● Cree una clase "Casa", con un atributo "área", un constructor que establece su valor y un método "ShowData" 
para mostrar "Soy una casa, mi área es de 200 m2" (en lugar de 200, mostrará la superficie real). 
Incluya también los captadores y los setters para el área.




 */
    public class Casa{

        private double area;
        private Puerta puerta;

        public Casa(double area){
            this.area = area;
        }


        public double getArea(){
            return this.area;
        }

        public void setArea(double area){
            this.area = area;
        }

        public Puerta getPuerta(){
            return this.puerta;
        }

        public void setPuerta(Puerta puerta){
            this.puerta = puerta;
        }

        public void ShowData(){
            Console.WriteLine($"Soy una casa, mi área es de {this.getArea()} m2."); 
        }


    }
}