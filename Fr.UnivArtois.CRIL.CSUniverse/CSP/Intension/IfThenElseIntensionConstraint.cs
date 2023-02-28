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

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension
{
    ///<summary>
    /// The IfThenElseIntensionConstraint is an {@link IIntensionConstraint} that represents an
    /// {@code if-then-else} (ternary) constraint.
    ///
    ///
    ///</summary>
    public class IfThenElseIntensionConstraint : IIntensionConstraint
    {

        ///<summary>
        /// The condition of this constraint.
        ///</summary>
        private IIntensionConstraint condition;

        ///<summary>
        /// The intension constraint corresponding to the case in which {@link #condition}
        /// evaluates to {@code true}.
        ///</summary>
        private IIntensionConstraint ifTrue;

        ///<summary>
        /// The intension constraint corresponding to the case in which {@link #condition}
        /// evaluates to {@code false}.
        ///</summary>
        private IIntensionConstraint ifFalse;

        ///<summary>
        /// Creates a new IfThenElseIntensionConstraint.
        ///
        ///</summary>
        ///<param name="condition">The condition of the constraint.</param>
        ///        condition evaluates to {@code true}.
        ///<param name="ifTrue">The intension constraint corresponding to the case in which the</param>
        ///        condition evaluates to {@code false}.
        ///<param name="ifFalse">The intension constraint corresponding to the case in which the</param>
        public IfThenElseIntensionConstraint(IIntensionConstraint condition,
            IIntensionConstraint ifTrue, IIntensionConstraint ifFalse)
        {
            this.condition = condition;
            this.ifTrue = ifTrue;
            this.ifFalse = ifFalse;
        }


        public void Accept(IIntensionConstraintVisitor visitor)
        {
            this.condition.Accept(visitor);
            this.ifTrue.Accept(visitor);
            this.ifFalse.Accept(visitor);
            visitor.Visit(this);

        }

    }
}
