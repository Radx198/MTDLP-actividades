/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearComparable() //EJERCICIO 5 Práctica 3
		{ 
			string nombre = Console.ReadLine();
			int dni = PedirNumero("DNI");
			int legajo = PedirNumero("legajo");
			int promedio = PedirNumero("promedio");
			return new Alumno(nombre, new Numero(dni), new Numero(legajo), new Numero(promedio));
		}
	}
}
