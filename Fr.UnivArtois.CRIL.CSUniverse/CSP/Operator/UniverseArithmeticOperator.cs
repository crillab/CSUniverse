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
    /// The ArithmeticOperator enumerates all possible arithmetic operators.
    /// </summary>
    public class UniverseArithmeticOperator : IUniverseOperator
    {
        /// <summary>
        /// The arithmetic operator for computing the opposite of a value.
        /// </summary>
        public static readonly UniverseArithmeticOperator Neg = new();

        /// <summary>
        /// The arithmetic operator for computing the absolute value of a value.
        /// </summary>
        public static readonly UniverseArithmeticOperator Abs = new();

        ///<summary>
        /// The arithmetic operator for computing the addition of several values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Add = new();

        ///<summary>
        /// The arithmetic operator for computing the subtraction of two values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Sub = new();

        ///<summary>
        /// The arithmetic operator for computing the multiplication of several values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Mult = new();

        ///<summary>
        /// The arithmetic operator for computing the division of two values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Div = new();

        ///<summary>
        /// The arithmetic operator for computing the remainder of two values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Mod = new();

        ///<summary>
        /// The arithmetic operator for computing the square of a value.
        ///</summary>
        public static readonly UniverseArithmeticOperator Sqr = new();

        ///<summary>
        /// The arithmetic operator for computing a value raised to the power of another.
        ///</summary>
        public static readonly UniverseArithmeticOperator Pow = new();

        ///<summary>
        /// The arithmetic operator for computing the minimum of several values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Min = new();

        ///<summary>
        /// The arithmetic operator for computing the maximum of several values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Max = new();

        ///<summary>
        /// The arithmetic operator for computing the distance between two values.
        ///</summary>
        public static readonly UniverseArithmeticOperator Dist = new();

        public IEnumerable<IUniverseOperator> Values()
        {
            yield return Neg;
            yield return Abs;
            yield return Add;
            yield return Sub;
            yield return Mult;
            yield return Div;
            yield return Mod;
            yield return Sqr;
            yield return Pow;
            yield return Min;
            yield return Max;
            yield return Dist;

        }
    }
}
