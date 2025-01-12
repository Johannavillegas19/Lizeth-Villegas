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
