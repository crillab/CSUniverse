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

namespace Fr.UnivArtois.CRIL.CSUniverse.Core;

/// <summary>
/// The UniverseSolverResult represents the result of the solver. 
/// </summary>
public interface IUniverseSolver
{
    /// <summary>
    /// Solves the problem associated to this solver.
    /// </summary>
    /// <returns>The outcome of the search conducted by the solver.</returns>
    UniverseSolverResult Solve();
    /// <summary>
    /// Solves the problem stored in the given file. The solver is expected to parse the problem itself.
    /// </summary>
    /// <param name="filename">The name of the file containing the problem to solve.</param>
    /// <returns>The outcome of the search conducted by the solver.</returns>
    UniverseSolverResult Solve(string filename);
    /// <summary>
    /// Solves the problem associated to this solver.
    /// </summary>
    /// <param name="assumptions">The assumptions to consider when solving.</param>
    /// <returns>The outcome of the search conducted by the solver.</returns>
    UniverseSolverResult Solve(IEnumerable<UniverseAssumption<int>> assumptions);
    /// <summary>
    /// Interrupts (asynchronously) the search currently performed by this solver.
    /// </summary>
    void Interrupt();
    /// <summary>
    /// Sets the verbosity level of the solver.
    /// Extreme values(outside the range expected by the underlying solver) should be
    /// handled silently as the minimum or maximum value supported by the solver.
    /// </summary>
    /// <param name="level">The verbosity level to set.</param>
    void SetVerbosity(int level);
    /// <summary>
    /// Sets the time limit before interrupting the search.
    /// </summary>
    /// <param name="seconds">The time limit to set (in seconds).</param>
    void SetTimeout(long seconds);
    /// <summary>
    /// Sets the time limit before interrupting the search.
    /// </summary>
    /// <param name="mseconds">The time limit to set (in milli-seconds).</param>
    void SetTimeoutMs(long mseconds);
    /// <summary>
    /// Resets this solver in its original state.
    /// </summary>
    void Reset();
    /// <summary>
    /// Gives the solution found by this solver (if any).
    /// </summary>
    /// <returns>The solution found by this solver.</returns>
    IEnumerable<int> Solution();

    /// <summary>
    /// Gives the mapping between the id of the variables and the assignment found by this
    /// solver(if any).
    /// </summary>
    /// <returns>The solution found by this solver.</returns>
    Dictionary<string, int> MapSolution();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="excludeAux"></param>
    /// <returns></returns>
    Dictionary<string, int> MapSolution(bool excludeAux);
    /// <summary>
    /// Gives the number of variables defined in this solver.
    /// </summary>
    /// <returns>The number of variables.</returns>
    int NVariables();
    /// <summary>
    /// Gives the number of constraints defined in this solver.
    /// </summary>
    /// <returns> The number of constraints.</returns>
    int NConstraints();
    /// <summary>
    /// Sets the log file to be used by the solver.
    /// </summary>
    /// <param name="filename"> The name of the log file.</param>
    void SetLogFile(string filename);
}
