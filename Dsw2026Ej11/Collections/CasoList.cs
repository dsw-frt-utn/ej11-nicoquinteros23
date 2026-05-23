namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;

// Crear un campo que represente una lista de alumnos (List<>)
// Incluir un método para agregar alumnos a la lista
// Incluir un método para retornar la lista
// Incluir un método para buscar un alumno por nombre
// Incluir un método para eliminar un alumno (debe recibir un alumno)
// Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
	private readonly List<Alumno> _alumnos;

	public CasoList()
	{
		_alumnos = new List<Alumno>();
	}

	public void AgregarAlumno(Alumno alumno)
	{
		_alumnos.Add(alumno);
	}

	public List<Alumno> ObtenerLista()
	{
		return _alumnos;
	}

	public Alumno? BuscarAlumnoPorNombre(string nombre)
	{
		foreach (Alumno alumno in _alumnos)
		{
			if (alumno.Nombre == nombre)
			{
				return alumno;
			}
		}

		return null;
	}

	public bool EliminarAlumno(Alumno alumno)
	{
		return _alumnos.Remove(alumno);
	}

	public bool EliminarAlumnoEnPosicion(int posicion)
	{
		if (posicion < 0 || posicion >= _alumnos.Count)
		{
			return false;
		}

		_alumnos.RemoveAt(posicion);
		return true;
	}
}
