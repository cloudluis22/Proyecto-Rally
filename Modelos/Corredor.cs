namespace Modelos
{
    public class Corredor
    {
        public string id { get; set; }
        public string nombreCorredor { get; set; }
        public string nacionalidad { get; set; }

        public int edad { get; set; }
        public string marca { get; set; }
        public int puntos { get; set; }

        // Constructor vacio
        public Corredor() { }

        // Constructor con parametros
        public Corredor(string id, string nombreCorredor, string nacionalidad,int edad, string marca, int puntos)
        {
            this.id = id;
            this.nombreCorredor = nombreCorredor;
            this.nacionalidad = nacionalidad;
            this.edad = edad;
            this.marca = marca;
            this.puntos = puntos;
        }
    }
}