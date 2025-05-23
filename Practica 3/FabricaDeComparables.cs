/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_3
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary> // EJERCICIO 4 Práctica 3
	public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lec = new LectorDeDatos();
		

		public static Comparable  crearAleatorio(string opcion)
		{
			FabricaDeComparables fabrica = null;
			switch(opcion)
			{
					case "1" : fabrica = new FabricaDeNumeros(); break;
					case "2": fabrica = new FabricaDeAlumnos(); break;
					case "3": fabrica = new FabricaDeProfesores(); break;
				default:
					throw new ArgumentException("Opcion invalida.");
			}
			return fabrica.crearAleatorio();
		}
		public static Comparable crearPorTeclado(string opcion)
		{
			FabricaDeComparables fabrica = null;
			switch(opcion)
			{
					case "1" : fabrica = new FabricaDeNumeros(); break;
					case "2": fabrica = new FabricaDeAlumnos(); break;
					case "3": fabrica = new FabricaDeProfesores(); break;
				default:
					throw new ArgumentException("Opcion invalida.");
			}
			return fabrica.crearPorTeclado();
		}
		
		public static Comparable crearComparable(string opcion) //EJERCICIO 5 Práctica 3
		{
			FabricaDeComparables c = null;
			
			if (opcion == "1")
				c = new FabricaDeNumeros();
			if (opcion == "2")
				c = new FabricaDeAlumnos();
			if (opcion == "3")
				c = new FabricaDeProfesores();
			return c.crearComparable();
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		public abstract Comparable crearComparable();
		
		
		
		protected static int PedirNumero(string tipoDeNumero)
		{
			string input;
			int output;
			
			do
			{
				Console.Write("\nIngrese un {0}: ",tipoDeNumero);
				input = Console.ReadLine();
			} while(!int.TryParse(input, out output));
			
			return output;
		}
		
	}
}
