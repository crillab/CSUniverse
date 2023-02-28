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

using System.Collections.Generic;

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Operator
{
    /// <summary>
    /// The SetBelongingOperator enumerates all possible operators for set-belonging.
    /// </summary>
    public sealed class UniverseSetBelongingOperator : IUniverseOperator
    {
        ///<summary>
        /// The operator checking whether a value belongs to a set of values.
        ///</summary>
        public static readonly UniverseRelationalOperator In = new UniverseRelationalOperator();

        ///<summary>
        /// The operator checking whether a value does not belong to a set of values.
        ///</summary>
        public static readonly UniverseRelationalOperator NotIn = new UniverseRelationalOperator();


        public IEnumerable<IUniverseOperator> Values()
        {
            yield return In;
            yield return NotIn;
        }
    }
}
