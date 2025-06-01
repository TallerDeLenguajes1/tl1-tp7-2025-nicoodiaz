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
        private char estadoCivil;
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
    }
}