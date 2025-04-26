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
		public static Comparable  crearAleatorio(string opcion)
		{
			Random rnd = new Random();
			switch(opcion)
			{
				case "1" :
					return new Numero(rnd.Next(-100,101));
					
				case "2":
					return new Alumno("nombre " + rnd.Next(100), new Numero(40000 + rnd.Next(0,9999)), new Numero(rnd.Next(500,1500)), new Numero(rnd.Next(1,11)));
				case "3":
					return new Profesor("Profesor " + rnd.Next(100), new Numero(40000 + rnd.Next(0,9999)), new Numero(rnd.Next(0,15)));
				default:
					throw new ArgumentException("Opcion invalida.");
			}
		}
		public static Comparable crearPorTeclado(string opcion)
		{
			Comparable c = null;
			if (opcion=="1")
			{
				c = new Numero(PedirNumero("numero"));
			}
			if (opcion=="2")
			{
				Console.Write("Ingrese un nombre: ");
				string nombre = Console.ReadLine();
				int dni = PedirNumero("DNI");
				int legajo = PedirNumero("legajo");
				int promedio = PedirNumero("promedio");
				c = new Alumno(nombre, new Numero(dni), new Numero(legajo), new Numero(promedio));
			}
			if (opcion =="3")
			{
				string nombre = Console.ReadLine();
				int dni = PedirNumero("DNI");
				int antiguedad = PedirNumero("años de antigudad");
				c = new Profesor(nombre, new Numero(dni), new Numero(antiguedad));
			}
			return c;
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
