/*  
 *  COPYRIGHT (C) 2021 MICHAEL HARGREAVES
 *  This file is part of the www.michaelrh04.co.uk electoral pacts model.
 *
 *  The model is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  The model is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this copy of the www.michaelrh04 UKGE electoral pacts model.
 *  If not, see <https://www.gnu.org/licenses/>.
 */

using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLicenseNotice();
            #region File interpretation
            string path = args[0];
            Console.WriteLine(" [...] Attempting to use {0}.", Path.GetFileName(path));
            // Many thanks to Alexander Yumashev and editors for this CSV tip-off.
            // Attribution link: https://stackoverflow.com/a/20523165.
            using (TextFieldParser csvReader = new TextFieldParser(path) { TextFieldType = FieldType.Delimited, Delimiters = new string[] { "," } })
            {
                bool headers = true;
                while(!csvReader.EndOfData)
                {
                    Console.WriteLine("Processing new row.");
                    string[] row = csvReader.ReadFields();
                    int fieldRowIndex = 0;
                    foreach(string field in row)
                    {
                        #region Reading dataset headers (party names) and party creation
                        if (headers)
                        {
                            if(fieldRowIndex > 2)
                            {
                                Parties.Add(new Party()
                                {
                                    Name = field
                                });
                                Console.WriteLine("Found party {0}.", field);
                            }
                        }
                        #endregion
                        else
                        {
                            // Here, insert the reading of data and population of Constituencies.
                        }
                        fieldRowIndex++;
                    }
                    headers = false;
                }
            }
            #endregion
            Console.ReadLine();
        }

        #region Variable and constants
        /// <summary>
        /// A list of all constituencies in this election found in the dataset. After model completion, is also your results list.
        /// </summary>
        static List<Constituency> Constituencies;
        /// <summary>
        /// An array of all parties found in the dataset. The index of each party will correspond with its dataset column index.
        /// </summary>
        static List<Party> Parties = new List<Party> { null, null, null };
        /// <summary>
        /// For the sake of convenience.
        /// </summary>
        static void DisplayLicenseNotice() => Console.WriteLine("\n This program is part of the www.michaelrh04.co.uk electoral pacts model.\n It is licensed for re-use, modification, and distribution under the\n GNU General Public License version 3 or later.\n\n COPYRIGHT (C) 2021 MICHAEL HARGREAVES\n"); 
        #endregion
    }
}
