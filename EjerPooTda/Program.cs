namespace EjerPooTda
{
    class Cliente
    {
        private String dni;
        private String nombre;
        private String apellidos;
        private int edad;
        private String direccion;
        
        public Cliente (String dni, String nombre, String apellidos, int edad, String direccion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.direccion = direccion;
        }

        static void Main(String[] args)
        {
            Cliente cliente1 = new Cliente("12345678A", "Pepe", "Muñoz Olivera", 36, "Calle San Pedro, nº3");
            Cliente cliente2 = new Cliente("87654321B", "Maria", "Checa Ruiz", 45, "Calle Reinosos, nº15");
            Cliente cliente3 = new Cliente("12344321C", "Juan", "Perez Vargas", 31, "Avenida Libertad, nº27");

            Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();

            clientes.Add
        }
    }
}