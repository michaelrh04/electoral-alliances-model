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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Logic for/class representing a single political party.
    /// </summary>
    public class Party
    {
        /// <summary>
        /// The name of the party. Identical to the respective vote column header within a dataset file.
        /// </summary>
        public string Name { get; set; }
    }
}
