// CSUniverse, a solver interface.
// Copyright (c) 2022 - Univ Artois, CNRS & Exakis Nelite.
// All rights reserved.
//
// This library is free software, you can redistribute it and/or.
// modify it under the terms of the GNU Lesser General Public.
// License as published by the Free Software Foundation, eithe.
// version 3 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful.
// but WITHOUT ANY WARRANTY without even the implied warranty o.
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public.
// License along with this library.
// If not, see {@link http://www.gnu.org/licenses}.
//

namespace Fr.UnivArtois.CRIL.CSUniverse.Core
{
    /// <summary>
    ///  The UniverseAssumption represents an assumption made when solving constraint problem.
    /// </summary>
    /// <typeparam name="T">The type of the assumed value.</typeparam>
    public class UniverseAssumption<T>
    {
        /// <summary>
        /// The variableId of the variable involved in this assumption.
        /// </summary>
        public string VariableId { get; }
        /// <summary>
        ///  Indicates if this assumption represents a equality or not.
        /// </summary>
        private bool equal;
        /// <summary>
        /// The value of the variable in this assumption.
        /// </summary>
        private T value;

        /// <summary>
        /// Creates a new UniverseAssumption.
        /// </summary>
        /// <param name="variableId">The variableId of the variable involved in this assumption.</param>
        /// <param name="equal">Indicates if this assumption represents a equality or not.</param>
        /// <param name="value">The value of the variable in this assumption.</param>
        public UniverseAssumption(string variableId, bool equal, T value)
        {
            this.VariableId = variableId;
            this.equal = equal;
            this.value = value;
        }
        /// <summary>
        /// Gives the equal of this UniverseAssumption.
        /// </summary>
        /// <returns>This UniverseAssumption's equal.</returns>
        public bool IsEqual()
        {
            return equal;
        }

        public T GetValue()
        {
            return this.value;
        }

        public override string ToString()
        {

            return $"{VariableId}{(equal ? '=' : '!')} {value}";
        }
    }
}
