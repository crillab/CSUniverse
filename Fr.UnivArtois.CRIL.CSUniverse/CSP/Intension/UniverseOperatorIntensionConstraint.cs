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
/// The OperatorIntensionConstraint is the parent class of all the implementations of
/// {@link IIntensionConstraint} that apply an operator on some other intension
/// constraint(s).
///
///
///</summary>
public abstract class UniverseOperatorIntensionConstraint : IIntensionConstraint
{

    ///<summary>
    /// The operator applied by this constraint.
    ///</summary>
    protected IUniverseOperator Op;

    ///<summary>
    /// Creates a new OperatorIntensionConstraint.
    ///
    ///</summary>
    ///<param name="op">The op applied by the constraint.</param>
    protected UniverseOperatorIntensionConstraint(IUniverseOperator op)
    {
        this.Op = op;
    }

    ///<summary>
    /// Gives the op applied by this constraint.
    ///
    ///<return>op applied by this constraint.</return>
    ///</summary>
    public IUniverseOperator GetOperator()
    {
        return this.Op;
    }

    public abstract void Accept(IIntensionConstraintVisitor visitor);
}
