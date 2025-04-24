/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/3/2025
 * Time: 21:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary> EJERCICIO 8 Práctica 1
	public class ColeccionMultiple : Coleccionable
	{
		private Pila pila;
		private Cola cola;
		public ColeccionMultiple(Pila p, Cola c)
		{
			pila = p;
			cola = c;
		}
		//métodos implementados por la interfaz Coleccionable
		public int cuantos(){return pila.cuantos() + cola.cuantos();}
		
		public Comparable minimo(){
			Comparable minimoP = pila.minimo();
			Comparable minimoC = cola.minimo();
			
			return minimoP.sosMenor(minimoC) ? minimoP : minimoC;
		}
		
		public Comparable maximo()
		{
			Comparable maximoP = pila.maximo();
			Comparable maximoC = cola.maximo();
			return maximoP.sosMayor(maximoC) ? maximoP : maximoC;
		}
		
		public void agregar(Comparable comparable){return;}
		
		public bool contiene(Comparable comparable){return pila.contiene(comparable) || cola.contiene(comparable);}
		
	}
}
