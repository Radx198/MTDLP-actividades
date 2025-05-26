/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/5/2025
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of AgregarEtadoNota.
	/// </summary> EJERCICIO 6 Práctica 4
	public class AgregarEtadoNota : AdicionalDecorator
	{
		public AgregarEtadoNota(IMostrarCalificacion calificacion) : base(calificacion)
		{
			
		}
		public override string mostrarCalificacion()
		{
			string mensaje = calificacion.mostrarCalificacion();
			int c = calificacion.getCalificacion().GetValor();
			if(c >= 7)
				mensaje += "(PROMOCIÓN)";
			else if(c >= 4)
				mensaje += "(APROBADO)";
			else
				mensaje += "(DESAPROBADO)";
				
			return mensaje;
		}

	}
}
