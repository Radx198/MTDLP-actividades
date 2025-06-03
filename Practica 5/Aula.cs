/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 14:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of Aula.
	/// </summary> EJERCICIO 3 Práctica 5
	public class Aula
	{
		private OrdenAula1 ordenPush;
		private OrdenAula1 ordenPop;
		
		private OrdenAula2 ordenPush2;
		private Teacher t;
		public Aula()
		{

		}
		public void comenzar()
		{//ordeninicio
			
			Console.WriteLine("Comenzando clase...");
			t = new Teacher();
			
			if(ordenPush != null)
			{
				ordenPush.ejecutar();
			}
		}
		public void nuevoAlumno(Alumno al)
		{
			t.goToClass(new AlumnoAdapter(al));
			
			if(ordenPush2 != null)
			{
				ordenPush2.ejecutar(al);
			}
			
		}
		public void crearLista()
		{//ordenAulaLlena
			t.teachingAClass();
			
			
			if(ordenPop != null)
			{
				ordenPop.ejecutar();
			}
		}
		public void setOrdenPush(OrdenAula1 oPush)
		{
			ordenPush = oPush;
		}
		public void setOrdenPush2(OrdenAula2 oPush)
		{
			ordenPush2 = oPush;
		}
		public void setOrdenPop(OrdenAula1 oPop)
		{
			ordenPop = oPop;
		}
	}
}
