/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_3
{
	class Program
	{
		public static void Main(string[] args)
		{

			// EJERCICIO  1 Práctica 3: La única diferencia es que cada método llena un Coleccionable con objetos distintos.
			// Tuve que sobreescribir el método ToString para imprimir información utíl sin importar el objeto que contengan el Coleccionable.
			// Tendría que crear otro método 'llenarProfesores()' y en cuanto al método 'informar()' no habría cambios notables siempre que Profesor sea un Comparable y tenga sobreescrito su ToString().
			

			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
//			llenar(pila,"1");
//			llenar(cola,"1");

//			informar(pila,"1");
//			informar(cola,"1");
//			informar(multiple,"1");

			
//			llenar(pila,"2");
//			llenar(cola,"2");
			
//			informar(pila,"2");
//			informar(cola,"2");
//			informar(multiple,"2");



			
			
			
			// EJERCICIO 7 Práctica 3: Una solución sería implementar el patron Factory method,
			// crear una clase FabricaDeComparables, con un método CrearColeccionables y depiendiendo
			// de la opción del usuario crea un pila, cola, etc y en el main crear una función
			// que llame al método de la fabricaDeColeccionables y dependiendo de la entrada del usuario retorne una estructura de datos
			// la guarde en una variable.
//			Coleccionable p = crearColeccion();
//			Console.Write(p.cuantos());
			
			
			
			//EJERCICIO 10 Práctica 3
			// Las clases Profesor y Alumno tienen en que común que son subclases de la superclase Persona
			// Podría ampliarse implementando la clase FabricaDePersonas y que las fabricas de alumno y profesor herenden el método CrearPersona.
			
			
			
			//EJERCICIO 14 y 15 Práctica 3
			Profesor profesor = new Profesor("Pepe", new Numero(12345), new Numero(15));
			AlumnoFavorito favorito = new AlumnoFavorito("Francisco", new Numero(1021), new Numero(2021), new Numero(10));
			
			favorito.agregarObservador(profesor); // EL favorito observa al profesor(Si escribe en el pizarrón se va a distraer)
			profesor.agregarObservador(favorito); // El profesor observa al favorito(Si los compañeros del favorito lanzan un avion de papel, este le avisa al profesor)
			
			string[] nombres = new string[]{"Juan", "Lucia", "Braulio", "Sofía", "Marcos", "Valentina", "Diego", "Camila", "Agustin", "Florencia", "Tomás", "Daniel", "Facundo", "Carla", "Nicolás", "Mariana", "Sebastián", "Micaela", "Pablo", "Carolina"};
			
			for (int i = 0; i < nombres.Length; i++)
			{
				int dni = 1001 + i;
				int legajo = 2001 + i;
				Alumno alumno = new Alumno(nombres[i], new Numero(dni), new Numero(legajo), new Numero(dni));
				profesor.agregarObservador(alumno); // El profesor son observados por los alumnos
				alumno.agregarObservador(favorito); // Los alumnos son observados por el favorito
			}
			
			

			dictadoDeClases(profesor);
			
		
			
			
			Console.ReadKey(true);
		}
		//EJERCICIO 8 Práctica 2
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
		
		//EJERCICIO 6 Práctica 2
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
		//EJERCICIO 13 Practica 1
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

			//si el usuario ingreso un numero, retorna true y se guarda la variable input en una variable entera, caso contrario retorna false
			if(coleccion.maximo() is Numero)
				Console.WriteLine(int.TryParse(input, out output) && coleccion.contiene(new Numero(output)) ?
				                  "El elemento leído está en la colección" : "El elemento leído no está en la colección");
			else
				Console.WriteLine(int.TryParse(input, out output) && coleccion.contiene(new Alumno(input,new Numero(output),new Numero(output),new Numero(output))) ?
				                  "El elemento leído está en la colección" : "El elemento leído no está en la colección");
		}
		
		static public void llenar(Coleccionable coleccion, string opcion) // EJERCICIO 6 Práctica 3
		{
			for(int i=0; i<20; i++)
			{
				Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
				coleccion.agregar(comparable);
			}

		}
		
		static public void informar(Coleccionable coleccion, string opcion) // EJERCICIO 6 Práctica 3
		{
			Console.WriteLine("\nCantidad: " + coleccion.cuantos());
			Console.WriteLine("Minimo: " + coleccion.minimo().ToString());
			Console.WriteLine("Maximo: " + coleccion.maximo().ToString());
			
			Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
			
			if (coleccion.contiene(comparable))
				Console.WriteLine("El elemento leído está en la colección.");
			else
				Console.WriteLine("El elemento leído no está en la colección.");
		}
		static public Coleccionable crearColeccion() // EJERCICIO 7 Práctica 3
		{
			Console.WriteLine("Pila, cola, colección múltiple, conjunto.");
			string opcion = Console.ReadLine();
			return FabricaDeColeccionables.CrearColeccionable(opcion);
		}
		
		
		static public void dictadoDeClases(Profesor profesor)// EJERCICIO 11 Práctica 3
		{
			for(int i = 0; i<5; i++)
			{
				profesor.hablarALaClase();
				profesor.escribirEnElPizarron();
			}
		}
		
		
	}
}