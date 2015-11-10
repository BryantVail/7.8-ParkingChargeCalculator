using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryantVCh7_8
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine(ParkingGarage.MessageWelcome());
            int intHours;
            double parkingCost = 0;
            string strHoursParked;
            bool Continue = true;


            //DateTime DailyClock = new DateTime();
            //DateTime Today = new DateTime();
            //Today = DateTime.Today;
            //DailyClock = Today;

            //Loop for Parking Tally
            while (Continue == true)
            {

                Console.WriteLine(ParkingGarage.MessageInputValue());
                Console.Read();
                strHoursParked = Console.ReadLine();
                double dblHoursParked;

                //Validate Input
                intHours = ParkingGarage.ConsoleInputValidation(strHoursParked);
                //try
                //{
                    
                //    dblHours = double.Parse(strHoursParked);
                //    dblHoursParked = dblHours;
                //    //dblHours = dblHoursParked;
                                                          
                //}
                //catch
                //{
                //    //if the input does not return a valid value
                //    Console.WriteLine(ParkingGarage.MessageOutOfRange());
                //}//end try catch

                 ParkingGarage CalculateParkingCost = new ParkingGarage(intHours);
                Console.WriteLine("Your total Cost for the parking duration:\t" + CalculateParkingCost.TotalCost + "\nRunning Total for the day:\t" + CalculateParkingCost.RunningTotal + "\nCars Total:\t" + CalculateParkingCost.CarCounter);
                //Console.Read();
                
                //ParkingGarage.InputString2DoubleHoursParked( strHoursParked);
              //parkingCost = CalculateParkingCost.CalculateCharges(hoursParked);
               //ParkingGarage.RunningTotal += parkingCost; 
            //ParkingGarage TotalTally = new ParkingGarage();
                }
            


        }
    }
}
