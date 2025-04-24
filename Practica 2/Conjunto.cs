/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 21:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_2
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary> EJERCICIO 3 Práctica 2
	public class Conjunto : Coleccionable, Iterable //EJERCICIO 4, 5 Práctica 2
	{
		private List<Comparable> conjunto;
		
		
		public Conjunto()
		{
			conjunto = new List<Comparable>();
		}
		
		public void agregar(Comparable elemento)
		{
			if (!pertenece(elemento))
				conjunto.Add(elemento);
		}
		public bool pertenece(Comparable elemento)
		{
			foreach(Comparable t in conjunto)
				if(t.sosIgual(elemento))
					return true;
			return false;
		}
		
		//Método implementado por la interfaz Iterable
		public Iterador crearIiterador()
		{
			return new IteradorDeListas(conjunto);
		}
		
		//EJERCICIO 4
		//Métodos implementados por la Interfaz coleccionable.
		
		public int cuantos(){return conjunto.Count;}
		
		public Comparable minimo()
		{
			Comparable minimo = conjunto[0];
			foreach(Comparable c in conjunto)
				if(minimo.sosMayor(c))
					minimo = c;
			return minimo;
		}
		public Comparable maximo()
		{
			Comparable maximo = conjunto[0];
			foreach(Comparable c in conjunto)
				if(maximo.sosMayor(c))
					maximo = c;
			return maximo;
		}
//		void agregar(Comparable comparable); Ya existe un método agrega.
		public bool contiene(Comparable comparable) //Ya existe un método con misma su funcionalidad.
		{return pertenece(comparable);}
		
		
		
	}
}
