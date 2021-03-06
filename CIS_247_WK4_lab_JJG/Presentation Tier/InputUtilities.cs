﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
    public class InputUtilities
    {
        /// <summary>
        /// Prompts for and retrieves user input 
        /// </summary>
        /// <param name="inputType">the name of the input being recieved ie "name", or "hourly wage"</param>
        /// <returns></returns>
        public static string GetInput(string inputType)
            {
                string strInput = String.Empty;
                Console.Write("Enter the " + inputType + ": ");
                strInput = Console.ReadLine();

                return strInput;
            }

        public static string getStringInputValue(string inputType)
            {
                string value = String.Empty;
                bool valid = false;
                string inputString = String.Empty;
                do
                    {
                        inputString = GetInput(inputType);
                        if (!String.IsNullOrEmpty(inputString))
                        {
                            value = inputString;
                            valid = true;
                        }
                        else
                        {
                            value = "Invalid input";
                            valid = false;
                        }
                        if (!valid)
                            Console.WriteLine("Invalid " + inputType + " try again!"); 
                    } while (!valid);

                return value;
            }

        public static int getIntegerInputValue(string inputType)
            {
                bool valid = false;
                int value = 0;
                string inputString = String.Empty;
                do
                    {
                        inputString = GetInput(inputType);
                        if (!(String.IsNullOrEmpty(inputString)))
                        {
                            valid = Int32.TryParse(inputString, out value);
                        }
                        if (!valid)
                            Console.WriteLine("Invalid " + inputType + " try again!"); 
                    } while (!valid);
            
                return value;
            }

        public static double getDoubleInputValue(string inputType)
            {
                bool valid = false;
                double value = 0;
                string inputString = String.Empty;
                do
                    {
                        inputString = GetInput(inputType);
                        if (!(String.IsNullOrEmpty(inputString)))
                        {
                            valid = Double.TryParse(inputString, out value);
                        }
                        if (!valid)
                            Console.WriteLine("Invalid " + inputType + " try again!"); 
                    } while (!valid);

                return value;
            }

        public static char getCharInputValue(string inputType)
            {
                bool valid = false;
                char value = 'u';
                string inputString = String.Empty;
                    do
                        {
                            inputString = GetInput(inputType);
                            if (!(String.IsNullOrEmpty(inputString)))
                            {
                                valid = Char.TryParse(inputString, out value);
                            }
                            if (!valid)
                                Console.WriteLine("Invalid " + inputType + " try again!"); 
                        } while (!valid);

                    return value;
            }
        
    }
}
