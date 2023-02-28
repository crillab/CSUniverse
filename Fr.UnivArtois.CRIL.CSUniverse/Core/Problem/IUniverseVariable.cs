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

namespace Fr.UnivArtois.CRIL.CSUniverse.Core.Problem
{
    public interface IUniverseVariable
    {
        /// <summary>
        /// Gives the name of this variable.
        /// </summary>
        /// <returns> The name of this variable.</returns>
        string GetName();

        /// <summary>
        /// Gives the identifier of this variable.
        /// </summary>
        /// <returns>The identifier of this variable.</returns>
        int GetId();

        /// <summary>
        /// Gives the domain of this variable.
        /// </summary>
        /// <returns> The domain of this variable.</returns>
        /// <see cref="IUniverseDomain"/>
        IUniverseDomain GetDomain();
    }
}
