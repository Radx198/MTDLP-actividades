/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 13:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_2
{
	/// <summary>
	/// Description of Cola.
	/// </summary> //EJERCICIO 4 Práctica 1
	public class Cola : Coleccionable, Iterable // EJERCICIO Práctica 2
	{
		private List<Comparable> lista;
		public Cola()
		{
			lista = new List<Comparable>();
		}
		
		//Métodos comunes en una estructura de datos cola(enqueue)
		public void Encolar(Comparable dato){lista.Add(dato);}
		public Comparable Desencolar()
		{
			Comparable dato = lista[0];
			lista.RemoveAt(0);
			return dato;
		}
		public Comparable peek(){return lista[0];}
		public bool EstaVacia(){return lista.Count == 0;}
		public void Limpiar(){lista.Clear();}
		
		
		//Método implementado por la interfaz Iterable
		public Iterador crearIiterador()
		{
			return new IteradorDeListas(lista);
		}
		
		
		//Métodos implementados de la interfaz Coleccionable
		public int cuantos(){return lista.Count;}
		public Comparable minimo()
		{
			Comparable minimo = lista[0];
			foreach(Comparable c in lista)
				if(minimo.sosMayor(c))
					minimo = c;
			return minimo;
		}
		public Comparable maximo()
		{
			Comparable maximo = lista[0];
			foreach(Comparable c in lista)
				if(maximo.sosMenor(c))
					maximo = c;
			return maximo;
		}
		public void agregar(Comparable comparable)
		{
			Encolar(comparable);
		}
		public bool contiene(Comparable comparable)
		{
			foreach(Comparable c in lista)
				if(comparable.sosIgual(c))
					return true;
			return false;
		}
		
	}
}
