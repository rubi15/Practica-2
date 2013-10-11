
using System;

namespace Practica_2
{
	public class Main{
		
		
		public Main(){
			
		}
		
		public void iniciar(){
			Console.Clear();
			
			int h=DateTime.Now.Hour;
			int m=DateTime.Now.Minute;
			int s=DateTime.Now.Second;

			for(int hora=h; hora<= 23; hora++)
				for(int minuto=m; minuto<= 59; minuto++)
					for(int segundo=s; segundo<= 59; segundo++){
						Console.WriteLine(hora + ":" + minuto + ":" + segundo);
						System.Threading.Thread.Sleep(1000);
						Console.Clear();
				}
		}

		public void cronometro(){
			Console.Clear();

			for(int hora=0; hora<= 23; hora++)
				for(int minuto=0; minuto<= 59; minuto++)
					for(int segundo=0; segundo<= 59; segundo++){
						Console.WriteLine(hora + ":" + minuto + ":" + segundo);
						System.Threading.Thread.Sleep(1000);
						Console.Clear();
					}
		}
	}
}
