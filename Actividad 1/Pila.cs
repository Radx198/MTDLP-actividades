/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_1
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	/// EJERCICIO 4
	public class Pila : Coleccionable
	{
		private List<Comparable> lista;
		public Pila()
		{
			lista = new List<Comparable>();
		}
		
		//Métodos comunes en una estructura de datos pila(stack)
		public void Apilar(Comparable dato){lista.Add(dato);}
		public Comparable Top(){return lista[lista.Count-1];}
		public bool EstaVacia(){return lista.Count==0;}
		public void Limpiar(){lista.Clear();}
		
		public Comparable Desapilar()
		{
			Comparable dato = lista[lista.Count-1];
			lista.RemoveAt(lista.Count-1);
			return dato;
		}
		
		
		//métodos implementados por la interfaz Coleccionable
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
			Apilar(comparable);
		}
		public bool contiene(Comparable comparable)
		{
			foreach(Comparable c in lista)
			{
				if(comparable.sosIgual(c))
					return true;
			}
			return false;
		}
	}
}
