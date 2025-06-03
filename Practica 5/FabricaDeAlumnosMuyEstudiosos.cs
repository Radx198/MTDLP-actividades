/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 17:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of FabricaDeAlumnosMuyEstudiosos.
	/// </summary> EJERCICIO 10 Práctica 5
	public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
	{ 
		public override Comparable crearAleatorio()
		{
			return new AlumnoMuyEstudioso(gen.stringAleatorio(5), new Numero(gen.numeroAleatorio(40000)), new Numero(gen.numeroAleatorio(1000)), new Numero(gen.numeroAleatorio(10)));
		}
		public override Comparable crearPorTeclado()
		{
			return new AlumnoMuyEstudioso(lec.stringPorTeclado(), new Numero(lec.numeroPorTeclado()), new Numero(lec.numeroPorTeclado()), new Numero(lec.numeroPorTeclado()));
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
