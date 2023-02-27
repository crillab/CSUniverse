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
    /// The BooleanOperator enumerates all operators on Boolean variables.
    /// </summary>
    public sealed class UniverseBooleanOperator : IUniverseOperator
    {
        ///<summary>
        /// The Boolean operator for computing the negation of a Boolean value.
        ///</summary>
        public static UniverseBooleanOperator Not = new();

        ///<summary>
        /// The Boolean operator for computing the conjunction of several Boolean values.
        ///</summary>
        public static UniverseBooleanOperator And = new();

        ///<summary>
        /// The Boolean operator for computing the disjunction of several Boolean values.
        ///</summary>
        public static UniverseBooleanOperator Or = new();

        ///<summary>
        /// The Boolean operator for computing the exclusive disjunction of several Boolean
        /// values.
        ///</summary>
        public static UniverseBooleanOperator Xor = new();

        ///<summary>
        /// The Boolean operator for computing the equivalence of several Boolean values.
        ///</summary>
        public static UniverseBooleanOperator Equiv = new();

        ///<summary>
        /// The Boolean operator for computing the implication between two Boolean values.
        ///</summary>
        public static UniverseBooleanOperator Impl = new();

        public IEnumerable<IUniverseOperator> Values()
        {
            yield return Not;
            yield return And;
            yield return Or;
            yield return Xor;
            yield return Equiv;
            yield return Impl;
        }
    }
}
