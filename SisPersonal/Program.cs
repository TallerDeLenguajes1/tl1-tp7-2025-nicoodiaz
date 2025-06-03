using EspacioEmpleado;
using System;

namespace SisPersonal
{
    class Program
    {
        private static void Main(String[] args)
        {
            Empleado[] empleados = new Empleado[3];//Reservo memoria para 3 empleados
            //Creo los 3 empleados y hay que reservar memoria para cada uno
            empleados[0] = new Empleado("Rocio", "Rodriguez", new DateTime(2000, 5, 19), 's', new DateTime(2022, 4, 15), 450000, Cargos.Especialista);
            empleados[1] = new Empleado("Nicolas", "Diaz", new DateTime(2000, 4, 6), 's', new DateTime(2021, 4, 29), 250000, Cargos.Especialista);
            empleados[2] = new Empleado("Pedro", "Juarez", new DateTime(1990, 8, 20), 'c', new DateTime(2015, 10, 14), 650000, Cargos.Ingeniero);

            double montoTotal = 0; //Para sacar lo que se paga total de sueldos
            int antiguedad = 0; //Años de antiguedad
            int restaParaJubilarse = 0;
            int edadEmpleado = 0;
            double salarioIndividualEmpleado = 0;

            //Para calcular el Monto Total que se le paga a los empleados
            for (int i = 0; i < empleados.Length; i++)
            {
                antiguedad = empleados[i].Antiguedad();
                salarioIndividualEmpleado = empleados[i].CalcularSalario(empleados[i].SueldoBasico, antiguedad);
                Console.WriteLine($"El salario del empleado {empleados[i].Nombre} {empleados[i].Apellido} es {salarioIndividualEmpleado}");
                montoTotal += salarioIndividualEmpleado;
            }
            Console.WriteLine($"El monto total que se le paga a todos los empleados es {montoTotal}");

            int numeroIndiceEmpleado = 0;

            for (int i = 0; i < empleados.Length; i++)
            {
                int aux = 0;
                edadEmpleado = empleados[i].EdadEmpleado(); //Para sacar la edad del empleado
                if (edadEmpleado > aux) numeroIndiceEmpleado = i;
                aux = edadEmpleado;
            }

            Console.WriteLine($"La angiguedad del mas proximo a jubilarse es {empleados[numeroIndiceEmpleado].Antiguedad()}");
            Console.WriteLine($"La edad es: {empleados[numeroIndiceEmpleado].EdadEmpleado()}");
            Console.WriteLine($"La cantidad de años que le faltan para jubilarse son: {empleados[numeroIndiceEmpleado].AniosRestantesParaJubilarse(empleados[numeroIndiceEmpleado].EdadEmpleado())}");
            Console.WriteLine($"El salario que se le paga al empleado es: {empleados[numeroIndiceEmpleado].CalcularSalario(empleados[numeroIndiceEmpleado].SueldoBasico, empleados[numeroIndiceEmpleado].Antiguedad())}");
        }
    }
}