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

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Operator
{
    /// <summary>
    /// The RelationalOperator enumerates all possible relational operators.
    /// </summary>
    public sealed class UniverseRelationalOperator : IUniverseOperator
    {


        ///<summary>
        /// The lesser-than ({@code <}) relational operator.
        ///</summary>
        public static readonly UniverseRelationalOperator Lt = new();

        ///<summary>
        /// The lesser-than-or-equal ({@code <=}) relational operator.
        ///</summary>
        public static readonly UniverseRelationalOperator Le = new();

        ///<summary>
        /// The equal ({@code ==}) relational operator.
        ///</summary>
        public static readonly UniverseRelationalOperator Eq = new();

        ///<summary>
        /// The not-equal ({@code !=}) relational operator.
        ///</summary>
        public static readonly UniverseRelationalOperator Neq = new();

        ///<summary>
        /// The greater-than-or-equal ({@code >=}) relational operator.
        ///</summary>
        public static readonly UniverseRelationalOperator Ge = new();

        ///<summary>
        /// The greater-than ({@code >}) relational operator.
        ///</summary>
        public static readonly UniverseRelationalOperator Gt = new();

        public IEnumerable<IUniverseOperator> Values()
        {
            yield return Lt;
            yield return Le;
            yield return Eq;
            yield return Neq;
            yield return Ge;
            yield return Gt;
        }
    }
}
