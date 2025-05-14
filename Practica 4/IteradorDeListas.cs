/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 19/4/2025
 * Time: 21:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_4
{
	/// <summary>
	/// Description of IteradorDeListas.
	/// </summary> EJERCICIO 5 Práctica 2
	public class IteradorDeListas : Iterador
	{
		private int elementoActual;
		private List<Comparable> lista;
		public IteradorDeListas(List<Comparable> list)
		{
			lista = list;
			primero();
		}
		public void primero(){elementoActual = 0;}
		public void siguiente(){elementoActual++;}
		public bool fin(){return elementoActual >= lista.Count;}
		public Comparable actual(){return lista[elementoActual];}
	}
}
