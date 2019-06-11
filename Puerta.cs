using System;
namespace Casa{

/*● La "casa" contendrá una puerta. Cada puerta tendrá un atributo "color" (una cuerda), 
y un método 
"ShowData" que mostrará "Soy una puerta, mi color es marrón" (o el color que sea). 
Incluye un getter y un setter. 
Además, crea un "GetDoor" en la casa. */

public class Puerta{

    private string color;

    public Puerta(string color){
        this.color = color;
    }

    public string getColor(){
        return this.color;
    }

    public void setColor(string color){
        this.color = color;
    }

    public void ShowData(){
        Console.WriteLine($"Soy una puerta, mi color es {this.getColor()}.");
    }

}
}
