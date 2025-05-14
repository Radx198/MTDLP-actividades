/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 13/5/2025
 * Time: 19:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of AdicionalDecorator.
	/// </summary>
	public abstract class AdicionalDecorator : IMostrarCalificacion
	{
		protected IMostrarCalificacion calificacion;
		public AdicionalDecorator(IMostrarCalificacion calificacion)
		{
			this.calificacion = calificacion;
		}
		public virtual string mostrarCalificacion()
		{
			return calificacion.mostrarCalificacion();
		}
	}
}
