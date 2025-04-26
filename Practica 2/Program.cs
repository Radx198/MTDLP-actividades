/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
//			Pila pila = new Pila(); //EJERCICIO 7 Práctica 2
//			Cola cola = new Cola();
//			Conjunto conjunto = new Conjunto();
//			llenarAlumnos(pila);
//			llenarAlumnos(cola);
//			llenarAlumnos(conjunto);
//			conjunto.agregar(new Alumno("d",new Numero(-1),new Numero(-1),new Numero(-1)));
//
//			imprimirElementos(pila);
//			imprimirElementos(cola);
//			imprimirElementos(conjunto);
			
			
			
			

			Pila pila = new Pila();//EJERCICIO 9 Práctica 2
			llenarAlumnos(pila);
			Console.WriteLine();

			cambiarEstrategia(pila, new PorNombre());
			informar(pila); //Cuando imprime si el elemento está en la lista solo admite ingresar elementos enteros, por lo que no funciona con nombres
			cambiarEstrategia(pila, new PorLegajo());
			informar(pila);
			cambiarEstrategia(pila, new PorPromedio());
			informar(pila);
			cambiarEstrategia(pila, new PorDNI());
			informar(pila);

			
			Console.ReadKey(true);
		}
		//EJERCICIO 8, Práctica 2
		static public void cambiarEstrategia (Iterable coleccionable, PoliticaComparacion pc)
		{
			Iterador i = coleccionable.crearIiterador();
			while (! i.fin())
			{
				((Alumno)i.actual()).setComparacion(pc);
				i.siguiente();
			}
		}
		//EJERCICIO 5 Práctica 1
		static public void llenar(Coleccionable coleccion)
		{
			Random rnd = new Random();
			for(int i=0; i<20; i++)
				coleccion.agregar(new Numero(rnd.Next(-100,101)));
		}
		
		//EJERCICIO 6, Práctica 2
		static public void imprimirElementos (Iterable coleccionable)
		{

			Iterador i = coleccionable.crearIiterador();
			
			while (! i.fin())
			{
				Console.Write(i.actual());
				i.siguiente();
				
			}
			Console.WriteLine();
		}
		//EJERCICIO 13, Practica 1
		static public void llenarAlumnos(Coleccionable coleccion)
		{
			Random rnd = new Random();
			for(int i=0; i<20; i++)
			{
				Alumno comparable = new Alumno("nombre " + i, new Numero(40000 + rnd.Next(0,9999)), new Numero(rnd.Next(500,1500)), new Numero(rnd.Next(1,11)));
				comparable.setComparacion(new PorNombre()); // Ejercicio 2 Práctica 2
				coleccion.agregar(comparable);
			}
		}
		
		
		
//		Ejercicio 6 Práctica 1
		static public void informar(Coleccionable coleccion)
		{
			Console.WriteLine("\nCantidad: " + coleccion.cuantos());
			Console.WriteLine("Minimo: " + coleccion.minimo().ToString());
			Console.WriteLine("Maximo: " + coleccion.maximo().ToString());

			
			Console.WriteLine("Ingrese un valor para confirmar si se encuentra en la coleccion: ");
			string input= Console.ReadLine();
			int output;

//			//si el usuario ingreso un numero, retorna true y se guarda la variable input en una variable entera, caso contrario retorna false
			if(coleccion.maximo() is Numero)
				Console.WriteLine(int.TryParse(input, out output) && coleccion.contiene(new Numero(output)) ?
				                  "El elemento leído está en la colección" : "El elemento leído no está en la colección");
			else
				Console.WriteLine(int.TryParse(input, out output) && coleccion.contiene(new Alumno(input,new Numero(output),new Numero(output),new Numero(output))) ?
				                  "El elemento leído está en la colección" : "El elemento leído no está en la colección");
		}
		
		
		
	}
}