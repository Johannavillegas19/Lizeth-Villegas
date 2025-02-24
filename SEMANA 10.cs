using System;
using System.Collections.Generic;
using System.Linq;

class Ciudadano
{
    public string Nombre { get; set; }
    public bool VacunadoPfizer { get; set; }
    public bool VacunadoAstrazeneca { get; set; }
    public bool VacunadoCompleto { get; set; }

    public Ciudadano(string nombre)
    {
        Nombre = nombre;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Conjunto de ciudadanos
        var ciudadanos = new HashSet<Ciudadano>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add(new Ciudadano($"Ciudadano {i}"));
        }

        // Conjunto de ciudadanos vacunados con Pfizer
        var vacunadosPfizer = new HashSet<Ciudadano>();
        for (int i = 1; i <= 75; i++)
        {
            var ciudadano = ciudadanos.FirstOrDefault(c => c.Nombre == $"Ciudadano {i}");
            if (ciudadano != null)
            {
                ciudadano.VacunadoPfizer = true;
                vacunadosPfizer.Add(ciudadano);
            }
        }

        // Conjunto de ciudadanos vacunados con Astrazeneca
        var vacunadosAstrazeneca = new HashSet<Ciudadano>();
        for (int i = 76; i <= 150; i++)
        {
            var ciudadano = ciudadanos.FirstOrDefault(c => c.Nombre == $"Ciudadano {i}");
            if (ciudadano != null)
            {
                ciudadano.VacunadoAstrazeneca = true;
                vacunadosAstrazeneca.Add(ciudadano);
            }
        }

        // Ciudadanos vacunados completos (ambas vacunas)
        var vacunadosCompleto = new HashSet<Ciudadano>();
        for (int i = 151; i <= 200; i++)
        {
            var ciudadano = ciudadanos.FirstOrDefault(c => c.Nombre == $"Ciudadano {i}");
            if (ciudadano != null)
            {
                ciudadano.VacunadoPfizer = true;
                ciudadano.VacunadoAstrazeneca = true;
                ciudadano.VacunadoCompleto = true;
                vacunadosCompleto.Add(ciudadano);
            }
        }

        // Listado de ciudadanos que no se han vacunado
        var noVacunados = ciudadanos.Where(c => !c.VacunadoPfizer && !c.VacunadoAstrazeneca).ToList();

        // Listado de ciudadanos que han recibido las dos vacunas
        var vacunadosDosVacunas = ciudadanos.Where(c => c.VacunadoPfizer && c.VacunadoAstrazeneca).ToList();

        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        var soloPfizer = ciudadanos.Where(c => c.VacunadoPfizer && !c.VacunadoAstrazeneca).ToList();

        // Listado de ciudadanos que solamente han recibido la vacuna de Astrazeneca
        var soloAstrazeneca = ciudadanos.Where(c => !c.VacunadoPfizer && c.VacunadoAstrazeneca).ToList();

        // Generar reporte
        Console.WriteLine("Listado de ciudadanos que no se han vacunado:");
        foreach (var ciudadano in noVacunados)
        {
            Console.WriteLine(ciudadano.Nombre);
        }

        Console.WriteLine("\nListado de ciudadanos que han recibido las dos vacunas:");
        foreach (var ciudadano in vacunadosDosVacunas)
        {
            Console.WriteLine(ciudadano.Nombre);
        }

        Console.WriteLine("\nListado de ciudadanos que solamente han recibido la vacuna de Pfizer:");
        foreach (var ciudadano in soloPfizer)
        {
            Console.WriteLine(ciudadano.Nombre);
        }

        Console.WriteLine("\nListado de ciudadanos que solamente han recibido la vacuna de Astrazeneca:");
        foreach (var ciudadano in soloAstrazeneca)
        {
            Console.WriteLine(ciudadano.Nombre);
        }
    }
}
