/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/4/2025
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of IObservado.
	/// </summary> //EJERCICIO 12 Práctica 3
	public interface IObservado
	{
		void agregarObservador(IObservador o);
		void quitarObservador(IObservador o);
		void notificar(string accion);
	}
}
