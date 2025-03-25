/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 11:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */


/*
 * Ejercicio 2
Implemente la clase Numero:
Numero
valor
constructor(v)
getValor
 Es una variable que almacena un
número entero
 Es el constructor de la clase que
recibe un valor “v” y lo almacena en la
variable “valor”
 Devuelve la variable “valor”
Haga que la clase Numero implemente la interface Comparable.
 */
using System;

namespace Practica_1
{
	/// <summary>
	/// Description of Numero.
	/// </summary> EJERCICIO 2
	public class Numero : Comparable
	{
		private int valor;
		public Numero(int v)
		{
			valor = v;
		}
		public int GetValor(){return valor;}
		
		
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
