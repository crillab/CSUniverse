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

using System.Numerics;

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension;
///<summary>
/// The ConstantIntensionConstraint is an {@link IIntensionConstraint} that represents a
/// constant value.
///
///
///</summary>
public class ConstantIntensionConstraint : IIntensionConstraint
{

    ///<summary>
    /// The value of the constant.
    ///</summary>
    private BigInteger value;

    ///<summary>
    /// Creates a new ConstantIntensionConstraint.
    ///
    ///</summary>
    ///<param name="value">The value of the constant.</param>
    public ConstantIntensionConstraint(BigInteger value)
    {
        this.value = value;
    }

    ///<summary>
    /// Gives the value of the constant.
    ///
    ///<return>value of the constant.</return>
    ///</summary>
    public BigInteger GetValue()
    {
        return this.value;
    }

    public void Accept(IIntensionConstraintVisitor visitor)
    {

        visitor.Visit(this);

    }

}
