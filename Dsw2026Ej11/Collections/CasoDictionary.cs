namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;

// Crear un diccionario donde la clave sea el legajo y el valor el alumno.
// En esta clase se usa Alumno.Id como legajo.
public class CasoDictionary
{
	private readonly Dictionary<int, Alumno> _alumnos;

	public CasoDictionary()
	{
		_alumnos = new Dictionary<int, Alumno>();
	}

	public void AgregarAlumno(Alumno alumno)
	{
		_alumnos[alumno.Id] = alumno;
	}

	public Alumno? BuscarAlumno(int legajo)
	{
		_alumnos.TryGetValue(legajo, out Alumno? alumno);
		return alumno;
	}

	public Dictionary<int, Alumno> ObtenerDiccionario()
	{
		return _alumnos;
	}

	public bool EliminarAlumno(int legajo)
	{
		return _alumnos.Remove(legajo);
	}
}
