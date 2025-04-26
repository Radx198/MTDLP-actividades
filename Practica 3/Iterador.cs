/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 19/4/2025
 * Time: 21:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_3
{
	/// <summary>
	/// Description of Iterador.
	/// </summary> EJERCICIO 5 Práctica 2
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
