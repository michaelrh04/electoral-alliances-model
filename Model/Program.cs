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
using Newtonsoft.Json;
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
            #region Model initialisation error handling
            // An election dataset must be provided to the model.
            // Please consult README.md on opening a dataset using this model.
            if (args.Length == 0 || Path.GetExtension(args[0]) != ".csv") { FatalError("You must provide a valid argument (dataset CSV file).\n Please consult the README.md for instructions on using this software.", new ArgumentException()); }
            #endregion
            // The election dataset provided appears valid.
            string path = args[0];
            Console.WriteLine(" The dataset argument appears valid. The model will attempt to use {0}.", Path.GetFileName(path));
            // Instantiate new model class and run model.
        }

        static void FatalError(string message, Exception exception)
        {
            Console.WriteLine($" === MODEL COULD NOT COMPLETE ===\n A fatal exception has occured ({exception.Message.ToLower().Remove(exception.Message.Length - 1)})!\n Next steps: {message}\n\n Press any key to exit.");
            Console.ReadLine();
            Environment.Exit(-1);
        }

        #region Variable and constants
        /// <summary>
        /// A list of all constituencies in this election found in the dataset. After model completion, is also your results list.
        /// </summary>
        static List<Constituency> Constituencies = new List<Constituency>();
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
