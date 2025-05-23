/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 15:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_3
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Alumno(gen.stringAleatorio(5), new Numero(gen.numeroAleatorio(5)), new Numero(gen.numeroAleatorio(5)), new Numero(gen.numeroAleatorio(5)));
		}
		public override Comparable crearPorTeclado()
		{
			return new Alumno(lec.stringPorTeclado(), new Numero(lec.numeroPorTeclado()), new Numero(lec.numeroPorTeclado()), new Numero(lec.numeroPorTeclado()));
		}
		
		
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
