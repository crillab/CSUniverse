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

using Fr.UnivArtois.CRIL.CSUniverse.CSP.Operator;

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension
{
    ///<summary>
    /// The BinaryIntensionConstraint is an {@link IIntensionConstraint} that applies an
    /// operator on two intension constraints.
    ///
    ///
    ///</summary>
    public class BinaryIntensionConstraint : UniverseOperatorIntensionConstraint
    {

        ///<summary>
        /// The left intension constraint on which an operator is applied.
        ///</summary>
        private IIntensionConstraint left;

        ///<summary>
        /// The right intension constraint on which an operator is applied.
        ///</summary>
        private IIntensionConstraint right;

        ///<summary>
        /// Creates a new BinaryIntensionConstraint.
        ///
        ///</summary>
        ///<param name="op">The operator applied by the constraint.</param>
        ///<param name="left">The left intension constraint on which the operator is applied.</param>
        ///<param name="right">The right intension constraint on which the operator is applied.</param>
        public BinaryIntensionConstraint(IUniverseOperator op, IIntensionConstraint left, IIntensionConstraint right) :
            base(op)
        {
            this.left = left;
            this.right = right;
        }

        public override void Accept(IIntensionConstraintVisitor visitor)
        {
            this.left.Accept(visitor);
            this.right.Accept(visitor);
            visitor.Visit(this);
        }


    }
}
