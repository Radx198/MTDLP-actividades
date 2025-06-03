/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 13/5/2025
 * Time: 20:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of AgregarLegajo.
	/// </summary> EJERCICIO 6 Práctica 4
	public class AgregarLegajo : AdicionalDecorator
	{
		public AgregarLegajo(IMostrarCalificacion calificacion) : base(calificacion)
		{
			
		}
		public override string mostrarCalificacion()
		{
			return calificacion.getNombre() +  "("+calificacion.getLegajo()+")" + "       " + calificacion.getCalificacion();
		}

	}
}
