
using System;

namespace Practica_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine ("\n1.- Reloj");
			Console.WriteLine ("2.- Cronómetro ");
			Console.Write ("\n ** Seleccione una opcion: ** \n");
			Main M=new Main();

			int opc = Convert.ToInt32(Console.ReadLine());
			switch(opc){
			case 1:
				{
					M.iniciar();
				}break;

			case 2:
				{
					M.cronometro();
				}break;

           default : Console.WriteLine("La opcion que ingreso No es válida.");
				break;
			}
		}
	}
}