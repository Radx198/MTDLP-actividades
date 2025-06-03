/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/5/2025
 * Time: 12:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of AgregarLetras.
	/// </summary> EJERCICIO 6 Práctica 4
	public class AgregarLetras : AdicionalDecorator
	{
		public AgregarLetras(IMostrarCalificacion calificacion) : base(calificacion)
		{
		}
		public override string mostrarCalificacion()
		{
			int c = calificacion.getCalificacion().GetValor();
			string mensaje = calificacion.mostrarCalificacion();
			switch(c)
			{
				case 1:
					mensaje += "(UNO)";
					break;
				case 2:
					mensaje +="(DOS)";
					break;
				case 3:
					mensaje +="(TRES)";
					break;
				case 4:
					mensaje +="(CUATRO)";
					break;
				case 5:
					mensaje +="(CINCO)";
					break;
				case 6:
					mensaje +="(SEIS)";
					break;
				case 7:
					mensaje +="(SIETE)";
					break;
				case 8:
					mensaje +="(OCHO)";
					break;
				case 9:
					mensaje +="(NUEVE)";
					break;
				case 10:
					mensaje +="(DIEZ)";
					break;
					
			}
			
			return mensaje;
			
			
		}
	}
}
