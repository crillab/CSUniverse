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

using System.Numerics;

namespace Fr.UnivArtois.CRIL.CSUniverse.Optim
{
    public interface IOptimizationSolver
    {
        BigInteger GetLowerBound();
        void SetLowerBound(BigInteger lb);
        BigInteger GetUpperBound();
        void SetUpperBound(BigInteger ub);
        void SetBounds(BigInteger lb, BigInteger ub);
        BigInteger GetCurrentBound();
        bool IsMinimization();
    }
}
