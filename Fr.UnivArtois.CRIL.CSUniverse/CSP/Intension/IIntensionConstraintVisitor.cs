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
    /// The IIntensionConstraintVisitor visits an intension constraint in order to compute its
    /// encoding using pseudo-Boolean constraints.
    ///
    ///
    ///</summary>
    public interface IIntensionConstraintVisitor
    {

        ///<summary>
        /// Visits a unary constraint that appears in an {@code intension} constraint.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If visiting (and encoding) the constraint results in
        ///         a trivial inconsistency.
        ///<param name="constr">The constraint to visit.</param>
        void Visit(UnaryIntensionConstraint constr);

        ///<summary>
        /// Visits a binary constraint that appears in an {@code intension} constraint.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If visiting (and encoding) the constraint results in
        ///         a trivial inconsistency.
        ///<param name="constr">The constraint to visit.</param>
        void Visit(BinaryIntensionConstraint constr);

        ///<summary>
        /// Visits an n-ary constraint that appears in an {@code intension} constraint.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If visiting (and encoding) the constraint results in
        ///         a trivial inconsistency.
        ///<param name="constr">The constraint to visit.</param>
        void Visit(NaryIntensionConstraint constr);

        ///<summary>
        /// Visits an if-then-else constraint that appears in an {@code intension} constraint.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If visiting (and encoding) the constraint results in
        ///         a trivial inconsistency.
        ///<param name="ifThenElse">The constraint to visit.</param>
        void Visit(IfThenElseIntensionConstraint ifThenElse);

        ///<summary>
        /// Visits a variable that appears in an {@code intension} constraint.
        ///
        ///</summary>
        ///
        ///<param name="variable">The variable to visit.</param>
        void Visit(VariableIntensionConstraint variable);

        ///<summary>
        /// Visits a constant that appears in an {@code intension} constraint.
        ///
        ///</summary>
        ///
        ///<param name="constant">The constant to visit.</param>
        void Visit(ConstantIntensionConstraint constant);


    }
}
