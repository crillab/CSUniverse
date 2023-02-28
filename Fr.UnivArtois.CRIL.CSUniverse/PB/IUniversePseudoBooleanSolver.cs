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
using Fr.UnivArtois.CRIL.CSUniverse.Sat;

namespace Fr.UnivArtois.CRIL.CSUniverse.PB
{
    public interface IUniversePseudoBooleanSolver : IUniverseSatSolver
    {
        /// <summary>
        /// Create a Pseudo-Boolean constraint of the type "at least n or at most n
        /// of those literals must be satisfied"
        /// </summary>
        /// <param name="lits"> a set of literals. The vector can be reused since the solver
        ///            is not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs">the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///            vector.</param>
        /// <param name="moreThan">true if it is a constraint &gt;= degree, false if it is a
        ///            constraint &lt;= degree</param>
        /// <param name="d">the degree of the cardinality constraint</param>
        void AddPseudoBoolean(IList<int> lits, IList<BigInteger> coeffs,
                                     bool moreThan, BigInteger d);

        /// <summary>
        /// Create a pseudo bool constraint of the type "at most".
        /// </summary>
        /// <param name="literals"> a set of literals The vector can be reused since the solver is
        ///            not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs">the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///          vector.</param>
        /// <param name="degree">the degree of the pseudo-bool constraint</param>
        void AddAtMost(IList<int> literals, IList<int> coeffs, int degree);

        /// <summary>
        /// Create a pseudo bool constraint of the type "at most".
        /// </summary>
        /// <param name="literals"> a set of literals The vector can be reused since the solver is
        ///            not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs">the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///            vector.</param>
        /// <param name="degree"> the degree of the pseudo-bool constraint</param>
        void AddAtMost(IList<int> literals, IList<BigInteger> coeffs,
                              BigInteger degree);

        /// <summary>
        /// Create a pseudo-bool constraint of the type "at least"
        /// </summary>
        /// <param name="literals">a set of literals. The vector can be reused since the solver
        ///            is not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs">the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///            vector.</param>
        /// <param name="degree"> the degree of the pseudo-bool constraint</param>
        void AddAtLeast(IList<int> literals, IList<int> coeffs, int degree);


        /// <summary>
        ///  Create a pseudo-bool constraint of the type "at least".
        /// </summary>
        /// <param name="literals"> a set of literals. The vector can be reused since the solver
        ///            is not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs"> the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///            vector.</param>
        /// <param name="degree"> the degree of the pseudo-bool constraint</param>
        void AddAtLeast(IList<int> literals, IList<BigInteger> coeffs,
                               BigInteger degree);

        /// <summary>
        ///  Create a pseudo-bool constraint of the type "subset sum".
        /// </summary>
        /// <param name="literals">a set of literals. The vector can be reused since the solver
        ///            is not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs">the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///            vector.</param>
        /// <param name="weight"> the number of literals that must be satisfied</param>
        void AddExactly(IList<int> literals, IList<int> coeffs, int weight);

        /// <summary>
        /// Create a pseudo-bool constraint of the type "subset sum".
        /// </summary>
        /// <param name="literals"> a set of literals. The vector can be reused since the solver
        ///            is not supposed to keep a reference to that vector.</param>
        /// <param name="coeffs">the coefficients of the literals. The vector can be reused
        ///            since the solver is not supposed to keep a reference to that
        ///            vector.</param>
        /// <param name="weight"> the number of literals that must be satisfied</param>
        void AddExactly(IList<int> literals, IList<BigInteger> coeffs,
                               BigInteger weight);
    }
}
