/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/4/2025
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of FabricaDeColeccionables.
	/// </summary>
	public abstract class FabricaDeColeccionables
	{
		public static Coleccionable CrearColeccionable(string opcion)
		{
			Coleccionable c = null;
			
			switch(opcion.ToLower())
			{
				case	"pila":
					c  = new Pila();
					break;
					
				case "cola":
					c = new Cola();
					break;
					
				case "coleccion multiple":
					Pila p = new Pila();
					Cola co = new Cola();
					c = new ColeccionMultiple(p,co);
					break;
					
				case "conjunto":
					c = new Conjunto();
					break;
				default:
					throw new ArgumentException("Opción invalida.");
			}
			//diccionario no está implementada
			return c;
		}
		public abstract Coleccionable CrearColeccionable(); // Por si se complejisa la instanciación de objetos.
			
	}
}
