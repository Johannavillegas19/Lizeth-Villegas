Los tipos de datos son un concepto fundamental en la programación, ya que permiten definir la naturaleza de la información que se almacena y procesa en un programa. Cada tipo de dato tiene un conjunto de valores válidos y operaciones que se pueden realizar sobre ellos. Comprender los diferentes tipos de datos y cómo utilizarlos adecuadamente es esencial para escribir código claro, eficiente y seguro.
Tipos de datos simples:
•	Enteros (int): Almacenan números enteros sin decimales, como 1, 2, 3, -5, etc.
•	Reales (float): Almacenan números con decimales, como 1.5, 3.14, -2.78, etc.
•	Caracteres (char): Almacenan un solo carácter, como "a", "B", "9", etc.
•	Booleanos (bool): Almacenan valores de verdad o falsedad, como true o false.
2. Tipos de datos compuestos:
•	Tablas (matriz, arrays, string): Almacenan una colección ordenada de elementos del mismo tipo. Los elementos se acceden mediante índices.
•	Estructura (estructura, record): Almacenan una colección de datos de diferentes tipos, organizados en campos.
•	Tupla (tuple, string): Almacenan una colección ordenada e inmutable de elementos del mismo o diferente tipo. Los elementos no se pueden modificar una vez creados.
•	Lista (list, diccionario): Almacenan una colección mutable de elementos del mismo o diferente tipo. Los elementos se pueden agregar, eliminar y modificar dinámicamente.
•	Diccionario (map, dictionary): Almacenan una colección de pares clave-valor, donde cada clave es única y está asociada a un valor. Los pares se acceden mediante sus claves.
Ejemplo mediante el uso de lenguaje de programación c#: 
using System;
using System.Collections.Generic;

class Paciente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
}

class AgendaTelefonica
{
    private List<Paciente> pacientes;

    public AgendaTelefonica()
    {
        pacientes = new List<Paciente>();
    }

    public void RegistrarPaciente(Paciente paciente)
    {
        pacientes.Add(paciente);
        Console.WriteLine("Paciente registrado exitosamente!");
    }

    public void MostrarPacientes()
    {
        if (pacientes.Count == 0)
        {
            Console.WriteLine("No hay pacientes registrados.");
        }
        else
        {
            Console.WriteLine("** Lista de pacientes: **");
            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine($"Nombre: {paciente.Nombre} {paciente.Apellido}");
                Console.WriteLine($"Teléfono: {paciente.Telefono}");
                Console.WriteLine($"Email: {paciente.Email}");
                Console.WriteLine("-----------------------------");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        AgendaTelefonica agenda = new AgendaTelefonica();

        // Registro de paciente 1
        Paciente paciente1 = new Paciente();
        paciente1.Nombre = "Juan";
        paciente1.Apellido = "Pérez";
        paciente1.Telefono = "123456789";
        paciente1.Email = "juan.perez@correo.com";

        agenda.RegistrarPaciente(paciente1);

        // Registro de paciente 2
        Paciente paciente2 = new Paciente();
        paciente2.Nombre = "María";
        paciente2.Apellido = "García";
        paciente2.Telefono = "0987654321";
        paciente2.Email = "maria.garcia@correo.com";

        agenda.RegistrarPaciente(paciente2);

        // Mostrar lista de pacientes
        agenda.MostrarPacientes();
    }
}
