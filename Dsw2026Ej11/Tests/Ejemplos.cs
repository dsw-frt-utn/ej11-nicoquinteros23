namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Ana", 8.5);
        Alumno alumno2 = new Alumno(2, "Bruno", 7.2);
        Alumno alumno3 = new Alumno(3, "Carla", 9.1);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        MostrarAlumnos(casoList.ObtenerLista());

        Console.WriteLine(casoList.BuscarAlumnoPorNombre("Bruno") ?? new Alumno(0, "No existe", 0));
        Console.WriteLine(casoList.BuscarAlumnoPorNombre("Diego") ?? new Alumno(0, "No existe", 0));

        casoList.EliminarAlumno(alumno2);
        MostrarAlumnos(casoList.ObtenerLista());

        casoList.EliminarAlumnoEnPosicion(0);
        MostrarAlumnos(casoList.ObtenerLista());
    }

    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Ana", 8.5);
        Alumno alumno2 = new Alumno(2, "Bruno", 7.2);
        Alumno alumno3 = new Alumno(3, "Carla", 9.1);

        casoDictionary.AgregarAlumno(alumno1);
        casoDictionary.AgregarAlumno(alumno2);
        casoDictionary.AgregarAlumno(alumno3);

        MostrarAlumnos(casoDictionary.ObtenerDiccionario().Values);

        Console.WriteLine(casoDictionary.BuscarAlumno(2) ?? new Alumno(0, "No existe", 0));
        Console.WriteLine(casoDictionary.BuscarAlumno(99) ?? new Alumno(0, "No existe", 0));

        casoDictionary.EliminarAlumno(2);
        MostrarAlumnos(casoDictionary.ObtenerDiccionario().Values);
    }

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine(casoLinq.GetPrimero());
        Console.WriteLine(casoLinq.GetUltimo());
        Console.WriteLine($"Total precios: {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio precios: {casoLinq.GetPromedioPrecios():C}");

        MostrarLibros(casoLinq.GetListById());

        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine(casoLinq.GetMayorPrecio());
        Console.WriteLine(casoLinq.GetMenorPrecio());

        MostrarLibros(casoLinq.GetMayorPromedio());
        MostrarLibros(casoLinq.GetLibrosOrdenadosDescendente());
    }

    private static void MostrarAlumnos(IEnumerable<Alumno> alumnos)
    {
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine();
    }

    private static void MostrarLibros(IEnumerable<Libro> libros)
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine($"{libro.Id} - {libro.Titulo} - {libro.Precio:C}");
        }

        Console.WriteLine();
    }
}
