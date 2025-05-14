/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary> EJERCICIO 3 Práctica 1
	public interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable comparable);
		bool contiene(Comparable comparable);
	}
}
