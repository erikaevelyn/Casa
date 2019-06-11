using System;

/*● Escriba un Main para crear un SmallApartment, una persona para vivir en él y mostrar 
los datos de la persona. */
namespace Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona = new Persona("Juan");
            SmallApartment departamento = new SmallApartment();
            persona.setCasa(departamento);
            Puerta puerta = new Puerta("rojo");
            departamento.setPuerta(puerta);

            persona.ShowData();
        }
    }
}
