/* A working program Created by Paul 2/14/2018. */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace LoveForFamily
{
	class Father
	{
		
		public static void Main(string[] args)
		{
			var me = new Father();
			me.TellFamilyAboutLove();
		}
		
		private void TellFamilyAboutLove()
		{
			Console.WriteLine("Calculations of love for Family!");
						
			var incalculable = CalculateLoveForFamily();

			foreach (var currentMeasureOfLove in incalculable){
				Tell(currentMeasureOfLove);
				
				if(I_Am_Alive() == false){ break; }
			}
		}
		
		//Algorithm: measureOfLove will grow every second of every minute of every hour of every day.
		private IEnumerable<long> CalculateLoveForFamily()
		{
			long measureOfLove = 1;
			
			const int dayYouWereBorn = 0;
			int dayIDie = (120 * 365);
						
			for (int day = dayYouWereBorn; day < dayIDie; day++){
				for(int hour = 1; hour <= 24; hour++){
					for (int minute = 0; minute < 60; minute++){
						for(int second = 0; second < 60; second++){
							measureOfLove++;
							yield return measureOfLove;
						}
					}
				}
			}
		}
				
		
		bool I_Am_Alive() { var heartBeat = Thread.CurrentThread; return heartBeat.IsAlive; }
		
		private void Tell(long currentMeasureOfLove) { 
			Console.WriteLine("I love you! " + currentMeasureOfLove.ToString());
		}
	}
}