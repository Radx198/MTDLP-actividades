/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Numero(gen.numeroAleatorio(10));
		}
		public override Comparable crearPorTeclado()
		{
			return new Numero(lec.numeroPorTeclado());
		}
		
		public override Comparable crearComparable() //EJERCICIO 5 Práctica 3
		{
			return new Numero(PedirNumero("numero"));
		}
	}
}
