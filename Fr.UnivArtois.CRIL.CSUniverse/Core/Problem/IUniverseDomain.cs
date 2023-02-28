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
using System.Numerics;

namespace Fr.UnivArtois.CRIL.CSUniverse.Core.Problem
{
    /// <summary>
    /// The IUniverseDomain represents the Domain of a Variable in constraint problem.
    /// </summary>
    public interface IUniverseDomain
    {

        /// <summary>
        /// Gives the minimum value of this domain.
        /// </summary>
        /// <returns> The minimum value.</returns>
        BigInteger Min();

        /// <summary>
        ///  Gives the maximum value of this domain.
        /// </summary>
        /// <returns> The maximum value.</returns>
        BigInteger Max();

        /// <summary>
        /// Gives the number of values of this domain.
        /// </summary>
        /// <returns>The number of values.</returns>
        long Size();

        /// <summary>
        /// Gives the list of values of this domain.
        /// </summary>
        /// <returns> The list of values.</returns>
        List<BigInteger> GetValues();
    }
}
