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
using Fr.UnivArtois.CRIL.CSUniverse.CSP.Operator;

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension
{
    ///<summary>
    /// The NaryIntensionConstraint is an {@link IIntensionConstraint} that applies an
    /// operator on several intension constraints.
    ///
    ///
    ///</summary>
    public class NaryIntensionConstraint : UniverseOperatorIntensionConstraint
    {

        ///<summary>
        /// The intension constraints on which an operator is applied.
        ///</summary>
        private IList<IIntensionConstraint> children;

        ///<summary>
        /// Creates a new NaryIntensionConstraint.
        ///
        ///</summary>
        ///<param name="op">The operator applied by the constraint.</param>
        ///<param name="children">The intension constraints on which the operator is applied.</param>
        public NaryIntensionConstraint(IUniverseOperator op, IList<IIntensionConstraint> children) : base(op)
        {
            this.children = children;
        }


        ///<summary>
        /// Gives the arity of this constraints.
        ///
        ///<return>number of intension constraints on which the operator is applied.</return>
        ///</summary>
        public int GetArity()
        {
            return this.children.Count;
        }


        public override void Accept(IIntensionConstraintVisitor visitor)
        {
            foreach (var c in this.children)
            {
                c.Accept(visitor);
            }

            visitor.Visit(this);

        }

    }
}
