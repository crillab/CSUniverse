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

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension;
///<summary>
/// The VariableIntensionConstraint is an {@link IIntensionConstraint} that represents a
/// variable.
///
///
///</summary>
public class VariableIntensionConstraint : IIntensionConstraint
{

    ///<summary>
    /// The identifier of the variable.
    ///</summary>
    private string identifier;

    ///<summary>
    /// Creates a new VariableIntensionConstraint.
    ///
    ///</summary>
    ///<param name="identifier">The identifier of the variable.</param>
    public VariableIntensionConstraint(string identifier)
    {
        this.identifier = identifier;
    }

    ///<summary>
    /// Gives the identifier of the variable of this constraint.
    ///
    ///<return>identifier of the variable.</return>
    ///</summary>
    public String GetIdentifier()
    {
        return this.identifier;
    }

    public void Accept(IIntensionConstraintVisitor visitor)
    {
        visitor.Visit(this);
    }

}
