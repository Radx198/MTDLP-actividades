/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 11:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_1
{
	
	class Program
	{
		
		public static void Main(string[] args)
		{
			//EJERCICIO 7 Y 9 Práctica 1
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
//			llenar(pila);
//			llenar(cola);

			//EJERCICIO 14 Respuesta: No funcionó por que la funcion informar estaba diseñada para objetos Numero,
			//por lo tanto al llamar un método como minimo() me devolvía un objeto Numero, pero si lo pruebo con un
			//objeto alumno, no puedo usar su get para obtener el DNI. Modifiqué un poco la función para que pueda
			//funcionar para la clase Numero y Alumno.
			//Si, fue necesario implementar la interface en Alumno ya que, los métodos minimo, maximo y contiene usan los métodos de la interfaz Comparable.
			//Mi criterio fue comparar los alumnos por su DNI porque puedo usar los métodos y logica de la clase Numero y ahorrarme la lógica de hacer una comparación entre strings.			
			
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			
			
			
//			informar(pila);
//			informar(cola);
			informar(multiple);
			
			//EJERCICIO 10 Práctica 1
			//No tuve que modificar nada de lo realizado en los primeros seis ejercicios.
	
			Console.ReadKey(true);
		}
		
		//EJERCICIO 5 Práctica 1
		static public void llenar(Coleccionable coleccion)
		{
			Random rnd = new Random();
			for(int i=0; i<20; i++)
				coleccion.agregar(new Numero(rnd.Next(-100,101)));
		}
		
		
//		Ejercicio 6 Práctica 1
		static public void informar(Coleccionable coleccion)
		{
			Console.WriteLine("\nCantidad : " + coleccion.cuantos());
			Console.WriteLine("Minimo :" + coleccion.minimo().ToString());
			Console.WriteLine("Maximo: " + coleccion.maximo().ToString());

			
			Console.WriteLine("Ingrese un valor para confirmar si se encuentra en la coleccion: ");
			string input= Console.ReadLine();
			int output;

//			//si el usuario ingreso un numero, retorna true y se guarda la variable input en una variable entera, caso contrario retorna false
			if(coleccion.maximo() is Numero)
				Console.WriteLine(int.TryParse(input, out output) && coleccion.contiene(new Numero(output)) ?
				                  "El elemento leído está en la colección" : "El elemento leído no está en la colección");
			else
				Console.WriteLine(int.TryParse(input, out output) && coleccion.contiene(new Alumno("",new Numero(output),new Numero(output),new Numero(0))) ?
				                  "El elemento leído está en la colección" : "El elemento leído no está en la colección");
		}
		
		//EJERCICIO 13 Práctica 1
		static public void llenarAlumnos(Coleccionable coleccion)
		{
			Random rnd = new Random();
			for(int i=0; i<20; i++)
			{
				Alumno comparable = new Alumno("nombre "+i, new Numero(rnd.Next(100,10000)), new Numero(rnd.Next(500,1500)), new Numero(rnd.Next(1,11)));
				coleccion.agregar(comparable);
			}
		}
		
		
		
	}
}