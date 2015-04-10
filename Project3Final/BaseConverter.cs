//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 3
//	File Name:		BaseConverter.cs
//	Description:    Handles conversion of various bases
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Chance Reichenberg, reichenberg@etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    Friday, April 3, 2015
//	Copyright:		Chance Reichenberg, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Static class to handle base conversion
    /// </summary>
    public static class BaseConverter
    {
        /// <summary>
        /// Converts a passed string with its respective base to a decimal value
        /// </summary>
        /// <param name="original">string representing the base value</param>
        /// <param name="originalBase">the base of the string passed in</param>
        /// <returns>The int decimal value</returns>
        public static int ToDecimal(string original, int originalBase)
        {
            int result = 0;
            List<char> baseList = original.ToList();
            List<int> convertedList = new List<int>();            
            foreach(var item in baseList)
            {
                switch (item)
                {
                    case '0':
                        convertedList.Add(0);
                        break;
                    case '1':
                        convertedList.Add(1);
                        break;
                    case '2':
                        convertedList.Add(2);
                        break;
                    case '3':
                        convertedList.Add(3);
                        break;
                    case '4':
                        convertedList.Add(4);
                        break;
                    case '5':
                        convertedList.Add(5);
                        break;
                    case '6':
                        convertedList.Add(6);
                        break;
                    case '7':
                        convertedList.Add(7);
                        break;
                    case '8':
                        convertedList.Add(7);
                        break;
                    case '9':
                        convertedList.Add(7);
                        break;
                    case 'A':
                        convertedList.Add(10);
                        break;
                    case 'B':
                        convertedList.Add(11);
                        break;
                    case 'C':
                        convertedList.Add(12);
                        break;
                    case 'D':
                        convertedList.Add(13);
                        break;
                    case 'E':
                        convertedList.Add(14);
                        break;
                    case 'F':
                        convertedList.Add(15);
                        break;
                }
            }
            result = convertedList[0];
            for (int c = 0; c < convertedList.Count - 1; c++)
            {
                result = (result * originalBase) + convertedList[c + 1];
            }
                return result;
        }

        /// <summary>
        /// Converts base 10 number into a base ranging from 2-16
        /// </summary>
        /// <param name="decimalNum">Decimal number to convert</param>
        /// <param name="toBase">base to convert decimal to</param>
        /// <returns>String representing converted number</returns>
        public static string FromDecimal(int decimalNum, int toBase, int digits)
        {
            //Stack to help base conversion
            Stack<string> convertedBase = new Stack<string>();
            int quotient = decimalNum;
            string converted = "";

            ///While the quotient is not 0, we take the modulus of the quotient to determine what to push on the stack
            while(quotient != 0)
            {
                switch(quotient % toBase)
                {
                    case 0:
                        convertedBase.Push("0");
                        break;
                    case 1:
                        convertedBase.Push("1");
                        break;
                    case 2:
                        convertedBase.Push("2");
                        break;
                    case 3:
                        convertedBase.Push("3");
                        break;
                    case 4:
                        convertedBase.Push("4");
                        break;
                    case 5:
                        convertedBase.Push("5");
                        break;
                    case 6:
                        convertedBase.Push("6");
                        break;
                    case 7:
                        convertedBase.Push("7");
                        break;
                    case 8:
                        convertedBase.Push("8");
                        break;
                    case 9:
                        convertedBase.Push("9");
                        break;
                    case 10:
                        convertedBase.Push("A");
                        break;
                    case 11:
                        convertedBase.Push("B");
                        break;
                    case 12:
                        convertedBase.Push("C");
                        break;
                    case 13:
                        convertedBase.Push("D");
                        break;
                    case 14:
                        convertedBase.Push("E");
                        break;
                    case 15:
                        convertedBase.Push("F");
                        break;
                }
                quotient = quotient / toBase;

            }
            while(convertedBase.Count < digits)
            {
                convertedBase.Push("0");
            }

            //Peeks the values on the list and turns them into a string
            while(convertedBase.Count != 0)
            {
                converted += convertedBase.Peek();
                convertedBase.Pop();
            }
            return converted;
        }
    }
}
