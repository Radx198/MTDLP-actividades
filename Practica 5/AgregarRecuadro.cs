/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/5/2025
 * Time: 13:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of AgregarRecuadro.
	/// </summary> EJERCICIO 6 Práctica 4
	public class AgregarRecuadro : AdicionalDecorator
	{
		public AgregarRecuadro(IMostrarCalificacion calificacion) : base(calificacion)
		{
			
		}
		public override string mostrarCalificacion()
		{
			string nuevoMensaje= "**";
			
			string mensaje = calificacion.mostrarCalificacion();
			int longitudInicial = mensaje.Length + 6; //3 espacios en los costados del mensaje
			for (int i = 0; i < longitudInicial; i++)
			{
				nuevoMensaje += "*";
			}
			nuevoMensaje += "\n*   " + mensaje + "   *\n**";
			for (int i = 0; i < longitudInicial; i++)
			{
				nuevoMensaje += "*";
			}
			return nuevoMensaje;
		}
	}
}
