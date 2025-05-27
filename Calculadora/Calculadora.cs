namespace EspacioCalculadora
{
    class Calculadora
    {
        private double resultado;

        public Calculadora(double resultado)
        {
            this.resultado = resultado;
        }

        //Usamos la propiedad "get" para que solo pueda leer el resultado y no modificarlo
        public double Resultado { get => resultado; }

        public void Sumar(double termino)
        {
            resultado += termino;
        }
        public void Restar(double termino)
        {
            resultado -= termino;
        }
        public void Multiplicar(double termino)
        {
            resultado *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0) resultado /= termino;
        }
        public void Limpiar(double termino)
        {
            
        }
    }
}