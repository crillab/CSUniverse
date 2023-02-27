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

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension;
///<summary>
/// The UnaryIntensionConstraint is an {@link IIntensionConstraint} that applies an
/// operator on a single intension constraint.
///
///
///</summary>
public class UnaryIntensionConstraint : UniverseOperatorIntensionConstraint
{

    ///<summary>
    /// The intension constraint on which an operator is applied.
    ///</summary>
    private IIntensionConstraint child;

    ///<summary>
    /// Creates a new UnaryIntensionConstraint.
    ///
    ///</summary>
    ///<param name="operator">The operator applied by the constraint.</param>
    ///<param name="child">The intension constraint on which the operator is applied.</param>
    public UnaryIntensionConstraint(IUniverseOperator op, IIntensionConstraint child) : base(op)
    {
        this.child = child;
    }

    public override void Accept(IIntensionConstraintVisitor visitor)
    {
        this.child.Accept(visitor);
        visitor.Visit(this);

    }


}
