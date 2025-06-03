/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 29/5/2025
 * Time: 16:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	class Program
	{
		public static void Main(string[] args)
		{ 
			//EJERCICIO 2 Práctica 5
//			iniciarClase();
			
			// EJERCICIO 10 Práctica 5 
			Pila pila = new Pila();
			Aula aula = new Aula();
			
			pila.setOrdenInicio(new OrdenInicioCommand(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLlenaCommand(aula));
			llenar(pila, "2");
			llenar(pila, "4");
				
			Console.ReadKey(true);
		}
		static public void iniciarClase()
		{
			Teacher teacher = new Teacher();
			for(int i = 0; i<10; i++)
			{
				IMostrarCalificacion alumno = (Alumno)FabricaDeAlumnos.crearAleatorio("2");
				
				IMostrarCalificacion alProxy = new AlumnoProxy(alumno.getNombre(), alumno.getDNI(), alumno.getLegajo(), alumno.getPromedio());
				alProxy = new AgregarLegajo(alProxy ); //EJERCICIO 7 Práctica 4
				alProxy = new AgregarLetras(alProxy );
				alProxy = new AgregarEtadoNota(alProxy );
				alProxy = new AgregarRecuadro(alProxy );
				teacher.goToClass(new AlumnoAdapter(alProxy ));
			}
			for(int i = 0; i<10; i++)
			{
				IMostrarCalificacion alumno = (Alumno)FabricaDeAlumnos.crearAleatorio("2");

				
				IMostrarCalificacion al = new AlumnoMuyEstudiosoProxy(alumno.getNombre(), alumno.getDNI(), alumno.getLegajo(), alumno.getPromedio());
				al = new AgregarLegajo(al); //EJERCICIO 7 Práctica 4
				al = new AgregarLetras(al);
				al = new AgregarEtadoNota(al);
				al = new AgregarRecuadro(al);
				
				teacher.goToClass(new AlumnoAdapter(al));
			}
			
			teacher.teachingAClass();
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