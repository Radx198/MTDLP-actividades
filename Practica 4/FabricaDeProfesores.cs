/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/4/2025
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores : FabricaDeComparables //EJERCICIO 9 Práctica 3
	{
		public override Comparable crearComparable()
		{
			string nombre = Console.ReadLine();
			int dni = PedirNumero("DNI");
			int antiguedad = PedirNumero("años de antigudad");
			return new Profesor(nombre, new Numero(dni), new Numero(antiguedad));
		}
	}
}
