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

using System;
using System.Collections.Generic;
using System.Numerics;
using Fr.UnivArtois.CRIL.CSUniverse.Core;

namespace Fr.UnivArtois.CRIL.CSUniverse.Sat
{
    public interface IUniverseSatSolver : IUniverseSolver
    {
        /// <summary>
        /// Create a clause from a set of literals The literals are represented by
        /// non null integers such that opposite literals a represented by opposite
        /// values. (classical Dimacs way of representing literals).
        /// </summary>
        /// <param name="literals">  a set of literals</param>
        void AddClause(IList<int> literals);

        /// <summary>
        /// Create clauses from a set of set of literals. This is convenient to
        /// create in a single call all the clauses.
        /// It is mainly a loop to addClause().
        /// </summary>
        /// <param name="clauses">a vector of set (VecInt) of literals in the dimacs format. The
        ///            vector can be reused since the solver is not supposed to keep
        ///            a reference to that vector.</param>
        void AddAllClauses(IList<IList<int>> clauses)
        {
            foreach (var v in clauses)
            {
                AddClause(v);
            }
        }


        /// <summary>
        /// Solves the problem associated to this solver.
        /// </summary>
        /// <param name="assumptions">The assumptions to consider when solving.</param>
        /// <returns>The outcome of the search conducted by the solver.</returns>
        UniverseSolverResult SolveBoolean(IList<UniverseAssumption<bool>> assumptions);

        /// <summary>
        /// Solves the problem associated to this solver.
        /// </summary>
        /// <param name="assumptions"> The assumptions to consider when solving.</param>
        /// <returns>The outcome of the search conducted by the solver.</returns>
        UniverseSolverResult SolveBoolean(IList<UniverseAssumption<BigInteger>> assumptions)
        {
            List<UniverseAssumption<bool>> booleanAssumptions = new List<UniverseAssumption<bool>>(assumptions.Count);
            foreach (var i in assumptions)
            {
                BigInteger v = i.GetValue();
                bool e = i.IsEqual();

                if (v.Sign != 0 && !v.Equals(BigInteger.One))
                {
                    throw new ArgumentException("Assumption must be boolean");
                }

                booleanAssumptions.Add(new UniverseAssumption<bool>(i.VariableId, e, v.Equals(BigInteger.One)));
            }
            return SolveBoolean(booleanAssumptions);
        }
    }
}
