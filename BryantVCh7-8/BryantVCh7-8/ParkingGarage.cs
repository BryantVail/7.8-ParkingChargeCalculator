using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BryantVCh7_8
{
    class ParkingGarage
    {
        //Public counter/accumulators
        protected int carCounter;
        protected double runningTotal = 0;
        protected List<double> listTransactions;
        protected double totalCost;
        protected double hoursParked;

        //Constructor
        public ParkingGarage(int userHoursParked)
        {
            hoursParked = userHoursParked;
        }// Constructor end

        //Calculate parking charges, insert the hours parked in the garage
        public void CalculateCharges()
        {
            totalCost = 0;
                        
           
            //return value = totalCost
            //Minimum Cost to park
            

            //amount being added to the total for each additional hour over the base
	        double additionalHour = .5;

            if (hoursParked <= 3)
            {
                
                totalCost = totalCost + 2.00;
                carCounter++;
                listTransactions.Add(totalCost);
            }

            if (hoursParked > 3)
            {
                totalCost = ((hoursParked - 3) * (additionalHour)) + totalCost;
                
                
                if (totalCost > 10)
                { totalCost = 10.00;
                    listTransactions.Add(totalCost);
                    carCounter++;
                }
                else
                    
                    carCounter = carCounter + 1;
                listTransactions.Add(totalCost);
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Number of Hours Parked");
            }
    

            }

        public double TotalCost
        {
            get
            {
                return totalCost;
            }
            set
            {
                if (value > 0)
                {
                    totalCost = value;
                }
            }
        }

        public int CarCounter
        {
            get
            {
                return carCounter;
            }
            set
            {
                if (value> 0)
                    carCounter = value;
            }
        }



        //query listTransactions for total charges
        protected double runningTotalLinq()
        {
            foreach (var charge in listTransactions)
            {
                runningTotal += charge;
            }
            return runningTotal;
        }

        public double RunningTotal
        {
            get
            {
                return runningTotal;
            }
            set
            {
                if (runningTotal > 0)
                    value = runningTotal;
            }
        }
               
        
        //Message out of range
        public static string MessageOutOfRange()
        {
            string MessageOutOfRange = "Please Enter a number above 0";
            return MessageOutOfRange;
        }// MessageOutOfRange end
        
        public static string MessageInputValue()
        {
            string MessageInputValue = "Please enter the number of hours parked below.";
            return MessageInputValue;
        }

        public static string MessageWelcome()
        {
            string messageWelcome = "Welcome to Charge'em by MacroSoft";
            return messageWelcome;
        }

        public static int ConsoleInputValidation(string strInput)
        {
            try
                {
                    int intHoursPark;
                    intHoursPark = Convert.ToInt32(strInput);

                    return intHoursPark;
                    
                    //dblHours = dblHoursParked;
                                                          
                }
                catch
                {
                    //if the input does not return a valid value
                    return -1;
                    Console.WriteLine(ParkingGarage.MessageOutOfRange());
                }//end try catch
        }

        //public string MessageReturnTotals
        //{
        //    string messageReturnTotals = "Your total Cost for the parking duration:\t" + TotalCost.ToString + "\nRunning Total for the day:\t"+ RunningTotal.ToString;
        //    return MessageReturnTotals;
        }
 
        }


        


        //Collect data from Console.ReadLine() & Validate to double
        // public void  Validate(string hoursParked)
        //{
        //    //Converted value holder
        //    double hoursDouble = 1234567;
        //    bool validEntry = false;
        //    ////IF statement to set bool Valid Entry
        //    //if (hoursDouble == 0)
        //    //    validEntry = false;

        //    while(hoursDouble == 1234567)
        //    {
        //         try
        //        {
        //           hoursDouble = Convert.ToDouble(hoursParked);
                   
        //           hoursParked = hoursDouble;
        //           break;

        //        }
        //            catch
        //        {
        //          Console.WriteLine("Please Enter a Valid Number of hours");
        //          break;
        //        } 
        //    }
            
            
                   
        //}
        
        //public void ParkingCostTally()
        //{ 
        //    double totalRunning = 0;
        //    double totalInstance = 0;



        //    Console.WriteLine("Thank you for calculating parking cost today! \n Cost For Parking Duration:\t " + totalCost +"\t"+ hoursParked + "\t" +" \nRunning Cost For Parking Duration \nTotal \tCars \tTotal Amount \n\t" + carCounter + "\t" + runningTotal);
            
        //}

   


