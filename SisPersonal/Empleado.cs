using System.ComponentModel;

namespace EspacioEmpleado
{
    //Declaracion de la variable enum cargos
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private char estadoCivil; // 'c'= casado , 's'= soltero
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int Antiguedad()
        {
            int aniosAntiguedad;
            //Tomamos la fecha en ese momento
            DateTime fechaActual = DateTime.Now;
            //Restamos los años de la fecha de ingreso con la actual
            aniosAntiguedad = fechaActual.Year - FechaIngreso.Year;
            //Retornamos la diferencia
            return aniosAntiguedad;
        }

        public int EdadEmpleado()
        {
            int edad;
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - FechaDeNacimiento.Year;
            return edad;
        }

        public int AniosRestantesParaJubilarse(int edadCalculada)
        {
            int aniosRestantes = 65 - edadCalculada;
            if (aniosRestantes > 0)
            {
                return aniosRestantes;
            }
            return 0;
        }

        public double CalcularSalario(double sueldoBsico, int aniosAntiguedad)
        {
            double adicional = 0;
            if (aniosAntiguedad < 20 && aniosAntiguedad > 0)
            {   //Por cada año, es 1%
                adicional += sueldoBsico * aniosAntiguedad / 100; //Calculo el adicional respecto de si tiene menos de 20 años de antiguedad
            }
            else if (aniosAntiguedad >= 20)
            {
                adicional += sueldoBsico * 0.25;//Dsp de los 20 años, ya son un 25% fijo
            }
            //Dependiendo el cargo, aumentar o no el adicional
            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional += adicional * 0.5;
            }
            //Dependiendo del estado civil
            if (char.ToLower(EstadoCivil) == 'c') //Convierto a minuscula lo ingresado, para evitar errores
            {
                adicional += 150000;
            }
            double salario = sueldoBsico + adicional; //Le sumo al basico el adicional calculado
            return salario; //Devuelvo el sueldo a cobrar
        }
    }
}