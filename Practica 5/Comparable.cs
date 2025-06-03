/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 23/3/2025
 * Time: 11:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	/// 
	//EJERCICIO 1 Práctica 1
	public interface Comparable
	{
		bool sosIgual(Comparable comparable);
		bool sosMenor(Comparable comparable);
		bool sosMayor(Comparable comparable);
	}
}
