using EspacioCalculadora;
using EspacioInterfaces;


var Interfacess = new Interfaces();

Interfacess.Guiones();
Interfacess.Bienvenida();
Interfacess.Guiones();
//Llave para poder salir del while para pedir el numero resultado
bool llaveParaSalir = true;
double numAOperar;
//Para poder pedir el numero a operar
do
{
    Console.WriteLine("Ingresa un numero para realizarle operaciones: ");
    var numPedidoAOperar = Console.ReadLine();

    bool resultado = double.TryParse(numPedidoAOperar, out numAOperar);
    if (resultado)
    {
        llaveParaSalir = false;
    }
    else
    {
        Interfacess.Guiones();
        Console.WriteLine("No ingresaste un numero, por favor intenta de nuevo");
        Interfacess.Guiones();
    }
} while (llaveParaSalir);

//Creo el nuevo objeto, con el numero pedido como constructor
var Operaciones = new Calculadora(numAOperar);

int opcion = 0;
//Menu de interaccion
do
{
    Interfacess.Guiones();
    Console.WriteLine("Elija una opcion para seleccionar la operacion: ");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Interfacess.Guiones();
    var pedirOpcion = Console.ReadLine();
    bool resultadoSwitch = int.TryParse(pedirOpcion, out opcion);
    if (resultadoSwitch && opcion > 0 && opcion < 6)
    {
        switch (opcion)
        {
            case 1:
                Interfacess.Guiones();
                double numASumar = Interfacess.PedirDatos("sumar");
                Interfacess.Guiones();
                Operaciones.Sumar(numASumar);
                Console.WriteLine($"El despues de sumarlo quedo: {Operaciones.Resultado}");
                break;
            case 2:
                Interfacess.Guiones();
                double numARestar = Interfacess.PedirDatos("restar");
                Interfacess.Guiones();
                Operaciones.Restar(numARestar);
                Console.WriteLine($"El despues de restarlo quedo: {Operaciones.Resultado}");
                break;
            case 3:
                Interfacess.Guiones();
                double numAMultiplicar = Interfacess.PedirDatos("multiplicar");
                Interfacess.Guiones();
                Operaciones.Multiplicar(numAMultiplicar);
                Console.WriteLine($"El despues de multiplicarlo quedo: {Operaciones.Resultado}");
                
                break;
            case 4:
                Interfacess.Guiones();
                double numADividir = Interfacess.PedirDatos("dividir");
                Interfacess.Guiones();
                if (numADividir == 0)
                {
                    Console.WriteLine("No se puede dividir por 0 (cero)");
                }
                else
                {
                    Operaciones.Dividir(numADividir);
                    Console.WriteLine($"El despues de dividirlo quedo: {Operaciones.Resultado}");
                }
                break;
        }
    }

} while (opcion != 5);
Interfacess.Guiones();
Interfacess.Salida();
Interfacess.Guiones();
