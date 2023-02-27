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

using Fr.UnivArtois.CRIL.CSUniverse.CSP;
using Fr.UnivArtois.CRIL.CSUniverse.PB;
using Fr.UnivArtois.CRIL.CSUniverse.Sat;

namespace Fr.UnivArtois.CRIL.CSUniverse.Utils;
/// <summary>
/// The ISolverFactory class defines an abstract factory for instantiating solvers
/// implementing different interfaces.
/// </summary>
public interface ISolverFactory
{
    /// <summary>
    ///  Creates a SAT solver implementing Universe's interface.
    /// </summary>
    /// <returns>The created solver.</returns>
    IUniverseSatSolver CreateSatSolver();

    /// <summary>
    /// Creates a pseudo-Boolean solver implementing Universe's interface.
    /// </summary>
    /// <returns>The created solver.</returns>
    IUniversePseudoBooleanSolver CreatePseudoBooleanSolver();

    /// <summary>
    /// Creates a CSP solver implementing Universe's interface.
    /// </summary>
    /// <returns>The created solver.</returns>
    IUniverseCspSolver CreateCspSolver();
}
