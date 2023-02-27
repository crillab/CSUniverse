﻿// CSUniverse, a solver interface.
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
    /// <summary>
    /// The IUniverseConstraint represents a constraint in constraint problem. 
    /// </summary>
    public interface IUniverseConstraint
    {
        /// <summary>
        /// Gives the scope of this constraint.
        /// </summary>
        /// <returns>The variables involved in this constraint.</returns>
        /// <see cref="IUniverseVariable"/>
        List<IUniverseVariable> Scope();
    }
}
