/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Numero.
	/// </summary> EJERCICIO 2 Práctica 1
	public class Numero : Comparable
	{
		private int valor;
		public Numero(int v)
		{
			valor = v;
		}
		public int GetValor(){return valor;}
		
		public override string ToString()
		{
			return valor.ToString();
		}

		
		//métodos implementados por la interfaz Comparable
		public bool sosIgual(Comparable comparable){
			return valor == ((Numero)comparable).GetValor();
		}
		
		public bool sosMenor(Comparable comparable)
		{
			return valor < ((Numero)comparable).GetValor();
		}
		
		public bool sosMayor(Comparable comparable)
		{
			return valor > ((Numero)comparable).GetValor();
		}
		
	}
}
