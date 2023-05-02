namespace Modelos
{
    public class Corredor
    {
        public string id { get; set; }
        public string nombreCorredor { get; set; }
        public int edad { get; set; }
        public string marca { get; set; }

        // Constructor vacío
        public Corredor(){}

        // Constructor con parametros
        public Corredor(string id, string nombreCorredor, int edad, string marca)
        {
            this.id = id;
            this.nombreCorredor = nombreCorredor;
            this.edad = edad;
            this.marca = marca;
        }
    }
}