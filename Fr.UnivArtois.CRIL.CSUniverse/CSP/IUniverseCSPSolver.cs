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
using System.Numerics;
using Fr.UnivArtois.CRIL.CSUniverse.Csp;
using Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension;
using Fr.UnivArtois.CRIL.CSUniverse.CSP.Operator;
using Fr.UnivArtois.CRIL.CSUniverse.PB;

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP
{
    /// <summary>
    /// The IUniverseCSPSolver
    /// </summary>
    public interface IUniverseCspSolver : IUniversePseudoBooleanSolver
    {

        ///<summary>
        /// Notifies this listener that a new variable is to be created.
        ///
        ///</summary>
        ///<param name="id">The identifier of the variable to create.</param>
        ///<param name="min">The minimum value of the domain of the variable.</param>
        ///<param name="max">The maximum value of the domain of the variable.</param>
        void NewVariable(string id, int min, int max);

        ///<summary>
        /// Notifies this listener that a new variable is to be created.
        ///
        ///</summary>
        ///<param name="id">The identifier of the variable to create.</param>
        ///<param name="min">The minimum value of the domain of the variable.</param>
        ///<param name="max">The maximum value of the domain of the variable.</param>
        void NewVariable(string id, BigInteger min, BigInteger max);

        ///<summary>
        /// Notifies this listener that a new variable is to be created.
        ///
        ///</summary>
        ///<param name="id">The identifier of the variable to create.</param>
        ///<param name="values">The values of the domain of the variable.</param>
        void NewVariable(string id, List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that an {@code instantiation} constraint is to be
        /// added.
        ///
        ///</summary>
        ///<param name="variable">The variable to assign.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to assign to the variable.</param>
        void AddInstantiation(string variable, int value);

        ///<summary>
        /// Notifies this listener that an {@code instantiation} constraint is to be
        /// added.
        ///
        ///</summary>
        ///<param name="variable">The variable to assign.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to assign to the variable.</param>
        void AddInstantiation(string variable, BigInteger value);

        ///<summary>
        /// Notifies this listener that an {@code instantiation} constraint is to be
        /// added.
        ///
        ///</summary>
        ///<param name="variables">The variables to assign.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The values to assign to the variables.</param>
        void AddInstantiation(List<string> variables, List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code clause} constraint is to be added.
        ///
        ///</summary>
        ///<param name="positive">The (bool) variables appearing positively in the clause.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="negative">The (bool) variables appearing negatively in the clause.</param>
        void AddClause(List<string> positive, List<string> negative);

        ///<summary>
        /// Notifies this listener that a {@code logical} constraint is to be added.
        ///
        ///</summary>
        ///<param name="op">The bool operator to apply on the variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variables">The (bool) variables on which the operator is applied.</param>
        void AddLogical(UniverseBooleanOperator op, List<string> variables);

        ///<summary>
        /// Notifies this listener that a {@code logical} constraint is to be added.
        ///
        ///</summary>
        ///        value of the logical operations.
        ///<param name="variable">The (bool) variable whose assignment depends on the truth</param>
        ///        value of the logical operations.
        ///<param name="equiv">Whether {@code variable} must be equivalent to the truth</param>
        ///<param name="op">The bool operator to apply on the variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variables">The (bool) variables on which the operator is applied.</param>
        void AddLogical(string variable, bool equiv, UniverseBooleanOperator op,
        List<string> variables);

        ///<summary>
        /// Notifies this listener that a {@code logical} constraint is to be added.
        ///
        ///</summary>
        ///        value of the comparison between {@code left} and
        ///        {@code right}.
        ///<param name="variable">The (bool) variable whose assignment depends on the truth</param>
        ///<param name="left">The variable on the left-hand side of the comparison.</param>
        ///        {@code right}.
        ///<param name="op">The relational operator used to compare {@code left} and</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="right">The value on the right-hand side of the comparison.</param>
        void AddLogical(string variable, string left, UniverseRelationalOperator op,
        BigInteger right);

        ///<summary>
        /// Notifies this listener that a {@code logical} constraint is to be added.
        ///
        ///</summary>
        ///        value of the comparison between {@code left} and
        ///        {@code right}.
        ///<param name="variable">The (bool) variable whose assignment depends on the truth</param>
        ///<param name="left">The variable on the left-hand side of the comparison.</param>
        ///        {@code right}.
        ///<param name="op">The relational operator used to compare {@code left} and</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="right">The variable on the right-hand side of the comparison.</param>
        void AddLogical(string variable, string left, UniverseRelationalOperator op,
        string right);

        ///<summary>
        /// Notifies this listener that an {@code all-different} constraint is to be
        /// added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variables">The variables that should all be different.</param>
        void AddAllDifferent(List<string> variables);

        ///<summary>
        /// Notifies this listener that an {@code all-different} constraint is to be
        /// added.
        ///
        ///</summary>
        ///<param name="variables">The variables that should all be different.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="except">The values not to consider in the constraint.</param>
        void AddAllDifferent(List<string> variables, List<BigInteger> except);

        ///<summary>
        /// Notifies this listener that an {@code all-different} constraint is to be
        /// added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variableMatrix">The matrix of variables that should all be different.</param>
        void AddAllDifferentMatrix(List<List<string>> variableMatrix);

        ///<summary>
        /// Notifies this listener that an {@code all-different} constraint is to be
        /// added.
        ///
        ///</summary>
        ///<param name="variableMatrix">The matrix of variables that should all be different.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="except">The values not to consider in the constraint.</param>
        void AddAllDifferentMatrix(List<List<string>> variableMatrix, List<BigInteger> except);

        ///<summary>
        /// Notifies this listener that an {@code all-different} constraint is to be
        /// added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variableLists">The lists of variables that should all be different.</param>
        void AddAllDifferentList(List<List<string>> variableLists);

        ///<summary>
        /// Notifies this listener that an {@code all-different} constraint is to be
        /// added.
        ///
        ///</summary>
        ///        different.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="intensionConstraints">The intension constraints that should all be</param>
        void AddAllDifferentIntension(List<IIntensionConstraint> intensionConstraints);

        ///<summary>
        /// Notifies this listener that a {@code cardinality} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The assignable values to count.</param>
        ///<param name="occurs">The number of times each value can be assigned.</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="closed">Whether only the values in {@code value} can be assigned to</param>
        void AddCardinalityWithConstantValuesAndConstantCounts(List<string> variables,
        List<BigInteger> values,
        List<BigInteger> occurs, bool closed);

        ///<summary>
        /// Notifies this listener that a {@code cardinality} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The assignable values to count.</param>
        ///<param name="occursMin">The minimum number of times each value can be assigned.</param>
        ///<param name="occursMax">The maximum number of times each value can be assigned.</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="closed">Whether only the values in {@code value} can be assigned to</param>
        void AddCardinalityWithConstantValuesAndConstantIntervalCounts(List<string> variables,
        List<BigInteger> values,
        List<BigInteger> occursMin, List<BigInteger> occursMax, bool closed);

        ///<summary>
        /// Notifies this listener that a {@code cardinality} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The assignable values to count.</param>
        ///        assigned.
        ///<param name="occurs">The variables encoding the number of times each value can be</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="closed">Whether only the values in {@code value} can be assigned to</param>
        void AddCardinalityWithConstantValuesAndVariableCounts(List<string> variables,
        List<BigInteger> values,
        List<string> occurs, bool closed);

        ///<summary>
        /// Notifies this listener that a {@code cardinality} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The variables encoding the assignable values to count.</param>
        ///<param name="occurs">The number of times each value can be assigned.</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="closed">Whether only the values in {@code value} can be assigned to</param>
        void AddCardinalityWithVariableValuesAndConstantCounts(List<string> variables,
        List<string> values,
        List<BigInteger> occurs, bool closed);

        ///<summary>
        /// Notifies this listener that a {@code cardinality} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The variables encoding the assignable values to count.</param>
        ///<param name="occursMin">The minimum number of times each value can be assigned.</param>
        ///<param name="occursMax">The maximum number of times each value can be assigned.</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="closed">Whether only the values in {@code value} can be assigned to</param>
        void AddCardinalityWithVariableValuesAndConstantIntervalCounts(List<string> variables,
        List<string> values,
        List<BigInteger> occursMin, List<BigInteger> occursMax, bool closed);

        ///<summary>
        /// Notifies this listener that a {@code cardinality} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The variables encoding the assignable values to count.</param>
        ///        assigned.
        ///<param name="occurs">The variables encoding the number of times each value can be</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="closed">Whether only the values in {@code value} can be assigned to</param>
        void AddCardinalityWithVariableValuesAndVariableCounts(List<string> variables,
        List<string> values,
        List<string> occurs, bool closed);

        ///<summary>
        /// Notifies this listener that a {@code channel} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="startIndex">The index at which the constraint starts.</param>
        void AddChannel(List<string> variables, int startIndex);

        ///<summary>
        /// Notifies this listener that a {@code channel} constraint is to be added.
        ///
        ///</summary>
        ///        starting from the given index.
        ///<param name="variables">The variables among which exactly one should be satisfied</param>
        ///<param name="startIndex">The index at which the constraint starts.</param>
        ///        variable.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable containing the index of the satisfied</param>
        void AddChannel(List<string> variables, int startIndex, string value);

        ///<summary>
        /// Notifies this listener that a {@code channel} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        vector of variables.
        ///<param name="startIndex">The index at which the constraint starts on the first</param>
        ///        the first vector.
        ///<param name="otherVariables">The variables with which to channel the variables of</param>
        ///        vector of variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="otherStartIndex">The index at which the constraint starts on the second</param>
        void AddChannel(List<string> variables, int startIndex, List<string> otherVariables,
        int otherStartIndex);

        ///<summary>
        /// Notifies this listener that an {@code at-least} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="value">The value to count the assignments of.</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The minimum number of times the value can be assigned among</param>
        void AddAtLeast(List<string> variables, BigInteger value, BigInteger count);

        ///<summary>
        /// Notifies this listener that an {@code exactly} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="value">The value to count the assignments of.</param>
        ///        variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The number of times the value can be assigned among the</param>
        void AddExactly(List<string> variables, BigInteger value, BigInteger count);

        ///<summary>
        /// Notifies this listener that an {@code exactly} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="value">The value to count the assignments of.</param>
        ///        assigned among the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The variable encoding the number of times the value can be</param>
        void AddExactly(List<string> variables, BigInteger value, string count);

        ///<summary>
        /// Notifies this listener that an {@code among} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The values to count the assignments of.</param>
        ///        variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The number of times the value can be assigned among the</param>
        void AddAmong(List<string> variables, List<BigInteger> values, BigInteger count);

        ///<summary>
        /// Notifies this listener that an {@code among} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The values to count the assignments of.</param>
        ///        assigned among the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The variable encoding the number of times the values can be</param>
        void AddAmong(List<string> variables, List<BigInteger> values, string count);

        ///<summary>
        /// Notifies this listener that an {@code at-most} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="value">The value to count the assignments of.</param>
        ///        the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The maximum number of times the value can be assigned among</param>
        void AddAtMost(List<string> variables, BigInteger value, BigInteger count);

        ///<summary>
        /// Notifies this listener that a {@code count} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The values to count the assignments of.</param>
        ///        their expected count.
        ///<param name="op">The operator to use to compare the number of assignments to</param>
        ///        variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The number of times the values can be assigned among the</param>
        void AddCountWithConstantValues(List<string> variables, List<BigInteger> values,
        UniverseRelationalOperator op, BigInteger count);

        ///<summary>
        /// Notifies this listener that a {@code count} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///<param name="values">The values to count the assignments of.</param>
        ///        their expected count.
        ///<param name="op">The operator to use to compare the number of assignments to</param>
        ///        assigned among the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The variable encoding the number of times the values can be</param>
        void AddCountWithConstantValues(List<string> variables, List<BigInteger> values,
        UniverseRelationalOperator op, string count);

        ///<summary>
        /// Notifies this listener that a {@code count} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///        of.
        ///<param name="values">The variables encoding the values to count the assignments</param>
        ///        their expected count.
        ///<param name="op">The operator to use to compare the number of assignments to</param>
        ///        variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The number of times the values can be assigned among the</param>
        void AddCountWithVariableValues(List<string> variables, List<string> values,
        UniverseRelationalOperator op,
        BigInteger count);

        ///<summary>
        /// Notifies this listener that a {@code count} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to count the assignments of.</param>
        ///        of.
        ///<param name="values">The variables encoding the values to count the assignments</param>
        ///        their expected count.
        ///<param name="op">The operator to use to compare the number of assignments to</param>
        ///        assigned among the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The variable encoding the number of times the values can be</param>
        void AddCountWithVariableValues(List<string> variables, List<string> values,
        UniverseRelationalOperator op,
        string count);

        ///<summary>
        /// Notifies this listener that a {@code count} constraint is to be added.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to count the assignments of.</param>
        ///<param name="values">The values to count the assignments of.</param>
        ///        to their expected count.
        ///<param name="op">The operator to use to compare the number of assignments</param>
        ///        be assigned among the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The variable encoding the number of times the values can</param>
        void AddCountIntensionWithConstantValues(List<IIntensionConstraint> expressions,
        List<BigInteger> values,
        UniverseRelationalOperator op, BigInteger count);

        ///<summary>
        /// Notifies this listener that a {@code count} constraint is to be added.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to count the assignments of.</param>
        ///<param name="values">The values to count the assignments of.</param>
        ///        to their expected count.
        ///<param name="op">The operator to use to compare the number of assignments</param>
        ///        be assigned among the variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="count">The variable encoding the number of times the values can</param>
        void AddCountIntensionWithConstantValues(List<IIntensionConstraint> expressions,
        List<BigInteger> values,
        UniverseRelationalOperator op, string count);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeConstantLengthsConstantHeights(List<string> origins, List<BigInteger> lengths,
        List<BigInteger> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeConstantLengthsConstantHeights(List<string> origins, List<BigInteger> lengths,
        List<string> ends,
        List<BigInteger> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeConstantLengthsConstantHeights(List<string> origins, List<BigInteger> lengths,
        List<BigInteger> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeConstantLengthsConstantHeights(List<string> origins, List<BigInteger> lengths,
        List<string> ends,
        List<BigInteger> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="heights">The variable encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeConstantLengthsVariableHeights(List<string> origins, List<BigInteger> lengths,
        List<string> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The variable encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeConstantLengthsVariableHeights(List<string> origins, List<BigInteger> lengths,
        List<string> ends,
        List<string> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="heights">The variable encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeConstantLengthsVariableHeights(List<string> origins, List<BigInteger> lengths,
        List<string> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The variable encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeConstantLengthsVariableHeights(List<string> origins, List<BigInteger> lengths,
        List<string> ends,
        List<string> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeVariableLengthsConstantHeights(List<string> origins, List<string> lengths,
        List<BigInteger> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeVariableLengthsConstantHeights(List<string> origins, List<string> lengths,
        List<string> ends,
        List<BigInteger> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeVariableLengthsConstantHeights(List<string> origins, List<string> lengths,
        List<BigInteger> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeVariableLengthsConstantHeights(List<string> origins, List<string> lengths,
        List<string> ends,
        List<BigInteger> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="heights">The variables encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeVariableLengthsVariableHeights(List<string> origins, List<string> lengths,
        List<string> heights,
        UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The variables encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value for the cumulative use.</param>
        void AddCumulativeVariableLengthsVariableHeights(List<string> origins, List<string> lengths,
        List<string> ends,
        List<string> heights, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="heights">The variables encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeVariableLengthsVariableHeights(List<string> origins, List<string> lengths,
        List<string> heights,
        UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code cumulative} constraint is to be added.
        ///
        ///</summary>
        ///<param name="origins">The variables encoding the origins of the resources.</param>
        ///<param name="lengths">The variables encoding the lengths of the tasks to assign.</param>
        ///<param name="ends">The variables encoding the ends of the resources.</param>
        ///<param name="heights">The variables encoding the heights of the tasks to assign.</param>
        ///<param name="op">The operator to compare the cumulative use with.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value for the cumulative use.</param>
        void AddCumulativeVariableLengthsVariableHeights(List<string> origins, List<string> lengths,
        List<string> ends,
        List<string> heights, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value that must appear among the variables.</param>
        void AddElement(List<string> variables, BigInteger value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        variables.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value that must appear among the</param>
        void AddElement(List<string> variables, string value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="values">The values among which to look for the variable.</param>
        ///<param name="startIndex">The index at which to start looking for the variable.</param>
        ///<param name="index">The index at which the variable appears in the values.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to look for.</param>
        void AddElementConstantValues(List<BigInteger> values, int startIndex, string index,
        BigInteger value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="values">The values among which to look for the variable.</param>
        ///<param name="startIndex">The index at which to start looking for the variable.</param>
        ///<param name="index">The index at which the variable appears in the values.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variable">The variable whose value is to be looked for.</param>
        void AddElementConstantValues(List<BigInteger> values, int startIndex, string index,
        string variable);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables among which to look for the value.</param>
        ///<param name="startIndex">The index at which to start looking for the value.</param>
        ///<param name="index">The index at which the value appears in the variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to look for.</param>
        void AddElement(List<string> variables, int startIndex, string index, BigInteger value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///        for the variable.
        ///<param name="values">The variables representing the values among which to look</param>
        ///<param name="startIndex">The index at which to start looking for the variable.</param>
        ///<param name="index">The index at which the variable appears in the values.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variable">The variable whose value is to be looked for.</param>
        void AddElement(List<string> values, int startIndex, string index, string variable);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="matrix">The matrix of values among which the value must appear.</param>
        ///        appear.
        ///<param name="startRowIndex">The index of the row starting from which the value must</param>
        ///        value appears.
        ///<param name="rowIndex">The variable encoding the index of the row at which the</param>
        ///        must appear.
        ///<param name="startColIndex">The index of the column starting from which the value</param>
        ///        the value appears.
        ///<param name="colIndex">The variable encoding the index of the column at which</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to look for inside the matrix.</param>
        void AddElementConstantMatrix(List<List<BigInteger>> matrix, int startRowIndex, string rowIndex,
        int startColIndex,
        string colIndex, BigInteger value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///<param name="matrix">The matrix of values among which the value must appear.</param>
        ///        appear.
        ///<param name="startRowIndex">The index of the row starting from which the value must</param>
        ///        value appears.
        ///<param name="rowIndex">The variable encoding the index of the row at which the</param>
        ///        must appear.
        ///<param name="startColIndex">The index of the column starting from which the value</param>
        ///        the value appears.
        ///<param name="colIndex">The variable encoding the index of the column at which</param>
        ///        matrix.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to look for inside the</param>
        void AddElementConstantMatrix(List<List<BigInteger>> matrix, int startRowIndex, string rowIndex,
        int startColIndex,
        string colIndex, string value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///        assigned.
        ///<param name="matrix">The matrix of variables among which the value must be</param>
        ///        appear.
        ///<param name="startRowIndex">The index of the row starting from which the value must</param>
        ///        value appears.
        ///<param name="rowIndex">The variable encoding the index of the row at which the</param>
        ///        must appear.
        ///<param name="startColIndex">The index of the column starting from which the value</param>
        ///        the value appears.
        ///<param name="colIndex">The variable encoding the index of the column at which</param>
        ///        matrix.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to look for inside the</param>
        void AddElementMatrix(List<List<string>> matrix, int startRowIndex, string rowIndex,
        int startColIndex,
        string colIndex, BigInteger value);

        ///<summary>
        /// Notifies this listener that an {@code element} constraint is to be added.
        ///
        ///</summary>
        ///        assigned.
        ///<param name="matrix">The matrix of variables among which the value must be</param>
        ///        appear.
        ///<param name="startRowIndex">The index of the row starting from which the value must</param>
        ///        value appears.
        ///<param name="rowIndex">The variable encoding the index of the row at which the</param>
        ///        must appear.
        ///<param name="startColIndex">The index of the column starting from which the value</param>
        ///        the value appears.
        ///<param name="colIndex">The variable encoding the index of the column at which</param>
        ///        matrix.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to look for inside the</param>
        void AddElementMatrix(List<List<string>> matrix, int startRowIndex, string rowIndex,
        int startColIndex,
        string colIndex, string value);

        ///<summary>
        /// Notifies this listener that an {@code extension} constraint describing the
        /// support of a tuple of variables is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable for which the support is given.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="allowedValues">The values allowed for the variable.</param>
        void AddSupport(string variable, List<BigInteger> allowedValues);

        ///<summary>
        /// Notifies this listener that an {@code extension} constraint describing the
        /// support of a tuple of variables is to be added.
        ///
        ///</summary>
        ///<param name="variableTuple">The tuple of variables for which the support is given.</param>
        ///        to {@code null} are interpreted as "any value" (as in
        ///        so-called "starred tuples").
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="allowedValues">The values allowed for the tuple variables. Values equal</param>
        void AddSupport(List<string> variableTuple, List<List<BigInteger>> allowedValues);

        ///<summary>
        /// Notifies this listener that an {@code extension} constraint describing the
        /// conflicts of a tuple of variables is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable for which the conflicts are given.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="forbiddenValues">The values forbidden for the variable.</param>
        void AddConflicts(string variable, List<BigInteger> forbiddenValues);

        ///<summary>
        /// Notifies this listener that an {@code extension} constraint describing the
        /// conflicts of a tuple of variables is to be added.
        ///
        ///</summary>
        ///        given.
        ///<param name="variableTuple">The tuple of variables for which the conflicts are</param>
        ///        equal to {@code null} are interpreted as "any value"
        ///        (as in so-called "starred tuples").
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="forbiddenValues">The values forbidden for the tuple variables. Values</param>
        void AddConflicts(List<string> variableTuple, List<List<BigInteger>> forbiddenValues);

        ///<summary>
        /// Notifies this listener that an {@code intension} constraint is to be added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="constr">The user-friendly representation of the constraint to add.</param>
        void AddIntension(IIntensionConstraint constr);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///<param name="op">The operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to compare the variable with.</param>
        void AddPrimitive(string variable, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///<param name="arithOp">The arithmetic operator applied on the variable.</param>
        ///<param name="leftHandSide">The value on the left-hand side of the constraint.</param>
        ///        side with the left-hand side.
        ///<param name="relOp">The relational operator used to compare the right-hand</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightHandSide">The value on the right-hand side of the constraint.</param>
        void AddPrimitive(string variable, UniverseArithmeticOperator arithOp, BigInteger leftHandSide,
        UniverseRelationalOperator relOp, BigInteger rightHandSide);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///<param name="arithOp">The arithmetic operator applied on the variable.</param>
        ///<param name="leftHandSide">The variable on the left-hand side of the constraint.</param>
        ///        side with the left-hand side.
        ///<param name="relOp">The relational operator used to compare the right-hand</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightHandSide">The value on the right-hand side of the constraint.</param>
        void AddPrimitive(string variable, UniverseArithmeticOperator arithOp, string leftHandSide,
        UniverseRelationalOperator relOp, BigInteger rightHandSide);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///<param name="arithOp">The arithmetic operator applied on the variable.</param>
        ///<param name="leftHandSide">The value on the left-hand side of the constraint.</param>
        ///        side with the left-hand side.
        ///<param name="relOp">The relational operator used to compare the right-hand</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightHandSide">The variable on the right-hand side of the constraint.</param>
        void AddPrimitive(string variable, UniverseArithmeticOperator arithOp, BigInteger leftHandSide,
        UniverseRelationalOperator relOp, string rightHandSide);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///<param name="arithOp">The arithmetic operator applied on the variable.</param>
        ///<param name="leftHandSide">The variable on the left-hand side of the constraint.</param>
        ///        side with the left-hand side.
        ///<param name="relOp">The relational operator used to compare the right-hand</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightHandSide">The variable on the right-hand side of the constraint.</param>
        void AddPrimitive(string variable, UniverseArithmeticOperator arithOp, string leftHandSide,
        UniverseRelationalOperator relOp, string rightHandSide);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="arithOp">The arithmetic operator applied on the variable.</param>
        ///<param name="variable">The variable on which the operator is applied.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightHandSide">The variable on the right-hand side of the constraint.</param>
        void AddPrimitive(UniverseArithmeticOperator arithOp, string variable, string rightHandSide);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///        forbidden.
        ///<param name="op">The operator defining whether the values are allowed or</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values on which the operator is applied.</param>
        void AddPrimitive(string variable, UniverseSetBelongingOperator op,
        List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code primitive} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variable">The variable appearing in the constraint.</param>
        ///        forbidden.
        ///<param name="op">The operator defining whether the values are allowed or</param>
        ///        applied.
        ///<param name="min">The minimum value of the range on which the operator is</param>
        ///        applied.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range on which the operator is</param>
        void AddPrimitive(string variable, UniverseSetBelongingOperator op, BigInteger min,
        BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code minimum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to compute the minimum of.</param>
        ///<param name="op">The relational operator to use to compare the minimum.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to compare the minimum with.</param>
        void AddMinimum(List<string> variables, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code minimum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to compute the minimum of.</param>
        ///<param name="op">The relational operator to use to compare the minimum.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to compare the minimum with.</param>
        void AddMinimum(List<string> variables, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code minimum} constraint is to be added.
        ///
        ///</summary>
        ///        of.
        ///<param name="intensionConstraints">The intension constraints to compute the minimum</param>
        ///        minimum.
        ///<param name="op">The relational operator to use to compare the</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to compare the minimum with.</param>
        void AddMinimumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseRelationalOperator op,
        BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code minimum} constraint is to be added.
        ///
        ///</summary>
        ///        of.
        ///<param name="intensionConstraints">The intension constraints to compute the minimum</param>
        ///        minimum.
        ///<param name="op">The relational operator to use to compare the</param>
        ///        minimum with.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to compare the</param>
        void AddMinimumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseRelationalOperator op,
        string value);

        ///<summary>
        /// Notifies this listener that a {@code maximum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to compute the maximum of.</param>
        ///<param name="op">The relational operator to use to compare the maximum.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to compare the maximum with.</param>
        void AddMaximum(List<string> variables, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code maximum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables to compute the maximum of.</param>
        ///<param name="op">The relational operator to use to compare the maximum.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to compare the maximum with.</param>
        void AddMaximum(List<string> variables, UniverseRelationalOperator op, string value);

        ///<summary>
        /// Notifies this listener that a {@code maximum} constraint is to be added.
        ///
        ///</summary>
        ///        of.
        ///<param name="intensionConstraints">The intension constraints to compute the maximum</param>
        ///        maximum.
        ///<param name="op">The relational operator to use to compare the</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value to compare the maximum with.</param>
        void AddMaximumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseRelationalOperator op,
        BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code maximum} constraint is to be added.
        ///
        ///</summary>
        ///        of.
        ///<param name="intensionConstraints">The intension constraints to compute the maximum</param>
        ///        maximum.
        ///<param name="op">The relational operator to use to compare the</param>
        ///        maximum with.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The variable encoding the value to compare the</param>
        void AddMaximumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseRelationalOperator op,
        string value);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="length">The length associated to the variables.</param>
        void AddNoOverlap(List<string> variables, List<BigInteger> length);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="length">The length associated to the variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="zeroIgnored">Whether {@code 0}-lengths should be ignored.</param>
        void AddNoOverlap(List<string> variables, List<BigInteger> length, bool zeroIgnored);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="length">The variable for the length of the other variables.</param>
        void AddNoOverlapVariableLength(List<string> variables, List<string> length);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="length">The variable for the length of the other variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="zeroIgnored">Whether {@code 0}-lengths should be ignored.</param>
        void AddNoOverlapVariableLength(List<string> variables, List<string> length,
        bool zeroIgnored);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="length">The length associated to the variables.</param>
        void AddMultiDimensionalNoOverlap(List<List<string>> variables, List<List<BigInteger>> length);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="length">The length associated to the variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="zeroIgnored">Whether {@code 0}-lengths should be ignored.</param>
        void AddMultiDimensionalNoOverlap(List<List<string>> variables, List<List<BigInteger>> length,
        bool zeroIgnored);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="length">The variable for the length of the other variables.</param>
        void AddMultiDimensionalNoOverlapVariableLength(List<List<string>> variables,
        List<List<string>> length);

        ///<summary>
        /// Notifies this listener that a {@code no-overlap} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="length">The variable for the length of the other variables.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="zeroIgnored">Whether {@code 0}-lengths should be ignored.</param>
        void AddMultiDimensionalNoOverlapVariableLength(List<List<string>> variables,
        List<List<string>> length,
        bool zeroIgnored);

        ///<summary>
        /// Notifies this listener that an {@code n-values} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="nb">The number of distinct values to count.</param>
        void AddNValues(List<string> variables, UniverseRelationalOperator op, BigInteger nb);

        ///<summary>
        /// Notifies this listener that an {@code n-values} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="nb">The number of distinct values to count.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="except">The values that should not be counted.</param>
        void AddNValuesExcept(List<string> variables, UniverseRelationalOperator op,
        BigInteger nb,
        List<BigInteger> except);

        ///<summary>
        /// Notifies this listener that an {@code n-values} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="nb">The variable counting the number of distinct values.</param>
        void AddNValues(List<string> variables, UniverseRelationalOperator op, string nb);

        ///<summary>
        /// Notifies this listener that an {@code n-values} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="nb">The variable counting the number of distinct values.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="except">The values that should not be counted.</param>
        void AddNValuesExcept(List<string> variables, UniverseRelationalOperator op, string nb,
        List<BigInteger> except);

        ///<summary>
        /// Notifies this listener that an {@code n-values} constraint is to be added.
        ///
        ///</summary>
        ///<param name="expressions">The expressions appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="nb">The number of distinct values to count.</param>
        void AddNValuesIntension(List<IIntensionConstraint> expressions,
        UniverseRelationalOperator op,
        BigInteger nb);

        ///<summary>
        /// Notifies this listener that an {@code n-values} constraint is to be added.
        ///
        ///</summary>
        ///<param name="expressions">The expressions appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="nb">The variable counting the number of distinct values.</param>
        void AddNValuesIntension(List<IIntensionConstraint> expressions,
        UniverseRelationalOperator op, string nb);

        ///<summary>
        /// Notifies this listener that an {@code ordered} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables that should be ordered.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="op">The relational operator defining the order of the variables.</param>
        void AddOrdered(List<string> variables, UniverseRelationalOperator op);

        ///<summary>
        /// Notifies this listener that an {@code ordered} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables that should be ordered.</param>
        ///        variables.
        ///<param name="lengths">The lengths that must exist between two consecutive</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="op">The relational operator defining the order of the variables.</param>
        void AddOrderedWithConstantLength(List<string> variables, List<BigInteger> lengths,
        UniverseRelationalOperator op);

        ///<summary>
        /// Notifies this listener that an {@code ordered} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables that should be ordered.</param>
        ///        two consecutive variables.
        ///<param name="lengths">The variables encoding the lengths that must exist between</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="op">The relational operator defining the order of the variables.</param>
        void AddOrderedWithVariableLength(List<string> variables, List<string> lengths,
        UniverseRelationalOperator op);

        ///<summary>
        /// Notifies this listener that an {@code all-equal} constraint is to be added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variables">The variables that should all be equal.</param>
        void AddAllEqual(List<string> variables);

        ///<summary>
        /// Notifies this listener that an {@code all-equal} constraint is to be added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="expressions">The expressions that should all be equal.</param>
        void AddAllEqualIntension(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that a {@code not-all-equal} constraint is to be
        /// added.
        ///
        ///</summary>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="variables">The variables that should not be all equal.</param>
        void AddNotAllEqual(List<string> variables);

        ///<summary>
        /// Notifies this listener that an {@code lex} constraint is to be added.
        ///
        ///</summary>
        ///        ordered.
        ///<param name="tuples">The tuple of variables that should be lexicographically</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="op">The relational operator defining the order of the tuples.</param>
        void AddLex(List<List<string>> tuples, UniverseRelationalOperator op);

        ///<summary>
        /// Notifies this listener that an {@code lex-matrix} constraint is to be added.
        ///
        ///</summary>
        ///        ordered.
        ///<param name="matrix">The matrix of variables that should be lexicographically</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="op">The relational operator defining the order in the matrix.</param>
        void AddLexMatrix(List<List<string>> matrix, UniverseRelationalOperator op);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="min">The minimum value of the range.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range.</param>
        void AddSum(List<string> variables, UniverseSetBelongingOperator op, BigInteger min,
        BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="min">The minimum value of the range.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range..</param>
        void AddSum(List<string> variables, List<BigInteger> coefficients,
        UniverseSetBelongingOperator op,
        BigInteger min, BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values.</param>
        void AddSum(List<string> variables, UniverseSetBelongingOperator op,
        List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values.</param>
        void AddSum(List<string> variables, List<BigInteger> coefficients,
        UniverseSetBelongingOperator op,
        List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="min">The minimum value of the range.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range.</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseSetBelongingOperator op,
        BigInteger min, BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="min">The minimum value of the range.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range.</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        List<BigInteger> coefficients,
        UniverseSetBelongingOperator op, BigInteger min, BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseSetBelongingOperator op,
        List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values.</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        List<BigInteger> coefficients,
        UniverseSetBelongingOperator op, List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="min">The minimum value of the range.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range.</param>
        void AddSumWithVariableCoefficients(List<string> variables, List<string> coefficients,
        UniverseSetBelongingOperator op, BigInteger min, BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values.</param>
        void AddSumWithVariableCoefficients(List<string> variables, List<string> coefficients,
        UniverseSetBelongingOperator op, List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///<param name="min">The minimum value of the range.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="max">The maximum value of the range.</param>
        void AddSumIntensionWithVariableCoefficients(List<IIntensionConstraint> intensionConstraints,
        List<string> coefficients, UniverseSetBelongingOperator op, BigInteger min,
        BigInteger max);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="values">The set of values</param>
        void AddSumIntensionWithVariableCoefficients(List<IIntensionConstraint> intensionConstraints,
        List<string> coefficients, UniverseSetBelongingOperator op,
        List<BigInteger> values);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value of the right-hand side of the constraint.</param>
        void AddSum(List<string> variables, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value of the right-hand side of the constraint.</param>
        void AddSum(List<string> variables, List<BigInteger> coefficients,
        UniverseRelationalOperator op,
        BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightVariable">The variable on the right-hand side of the constraint.</param>
        void AddSum(List<string> variables, UniverseRelationalOperator op, string rightVariable);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightVariable">The variable on the right-hand side of the constraint.</param>
        void AddSum(List<string> variables, List<BigInteger> coefficients,
        UniverseRelationalOperator op,
        string rightVariable);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///        constraint.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value of the right-hand side of the</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseRelationalOperator op,
        BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///        constraint.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value of the right-hand side of the</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        List<BigInteger> coefficients,
        UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///        constraint.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightVariable">The variable on the right-hand side of the</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        UniverseRelationalOperator op,
        string rightVariable);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the constraint.
        ///<param name="coefficients">The coefficients of the variables appearing in</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///        constraint.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightVariable">The variable on the right-hand side of the</param>
        void AddSumIntension(List<IIntensionConstraint> intensionConstraints,
        List<BigInteger> coefficients,
        UniverseRelationalOperator op, string rightVariable);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value of the right-hand side of the constraint.</param>
        void AddSumWithVariableCoefficients(List<string> variables, List<string> coefficients,
        UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="variables">The variables appearing in the constraint.</param>
        ///        variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of the</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightVariable">The variable on the right-hand side of the constraint.</param>
        void AddSumWithVariableCoefficients(List<string> variables, List<string> coefficients,
        UniverseRelationalOperator op, string rightVariable);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///        constraint.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="value">The value of the right-hand side of the</param>
        void AddSumIntensionWithVariableCoefficients(List<IIntensionConstraint> intensionConstraints,
        List<string> coefficients, UniverseRelationalOperator op, BigInteger value);

        ///<summary>
        /// Notifies this listener that a {@code sum} constraint is to be added.
        ///
        ///</summary>
        ///<param name="intensionConstraints">The intension constraints to compute the sum of.</param>
        ///        the variables appearing in the constraint.
        ///<param name="coefficients">The variables representing the coefficients of</param>
        ///<param name="op">The relational operator used in the constraint.</param>
        ///        constraint.
        ///
        /// @throws UniverseContradictionException If adding the constraint results in a
        ///         trivial inconsistency.
        ///<param name="rightVariable">The variable on the right-hand side of the</param>
        void AddSumIntensionWithVariableCoefficients(List<IIntensionConstraint> intensionConstraints,
        List<string> coefficients, UniverseRelationalOperator op, string rightVariable);

        void AddRegular(List<string> list, List<UniverseTransition> transitions,
        string startState, List<string> finalStates);

        void AddMdd(List<string> list, List<UniverseTransition> transitions);


        void AddCircuit(List<string> list, int startIndex);

        void AddCircuit(List<string> list, int startIndex, int size);

        void AddCircuit(List<string> list, int startIndex, string size);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the value assigned to a variable.
        ///
        ///</summary>
        ///<param name="variable">The variable to minimize the value of.</param>
        void MinimizeVariable(string variable);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the value assigned to a variable.
        ///
        ///</summary>
        ///<param name="variable">The variable to maximize the value of.</param>
        void MaximizeVariable(string variable);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the value of an expression.
        ///
        ///</summary>
        ///<param name="expression">The expression to minimize the value of.</param>
        void MinimizeExpression(IIntensionConstraint expression);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the value of an expression.
        ///
        ///</summary>
        ///<param name="expression">The expression to maximize the value of.</param>
        void MaximizeExpression(IIntensionConstraint expression);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a sum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the sum of.</param>
        void MinimizeSum(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a sum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the sum of.</param>
        ///<param name="coefficients">The coefficients of the variables in the sum.</param>
        void MinimizeSum(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a sum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the sum of.</param>
        void MinimizeExpressionSum(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a sum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the sum of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the sum.</param>
        void MinimizeExpressionSum(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a sum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the sum of.</param>
        void MaximizeSum(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a sum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the sum of.</param>
        ///<param name="coefficients">The coefficients of the variables in the sum.</param>
        void MaximizeSum(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a sum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the sum of.</param>
        void MaximizeExpressionSum(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a sum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the sum of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the sum.</param>
        void MaximizeExpressionSum(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a product of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the product of.</param>
        void MinimizeProduct(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a product of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the product of.</param>
        ///<param name="coefficients">The coefficients of the variables in the product.</param>
        void MinimizeProduct(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a product of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the product of.</param>
        void MinimizeExpressionProduct(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// a product of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the product of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the product.</param>
        void MinimizeExpressionProduct(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a product of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the product of.</param>
        void MaximizeProduct(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a product of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the product of.</param>
        ///<param name="coefficients">The coefficients of the variables in the product.</param>
        void MaximizeProduct(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a product of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the product of.</param>
        void MaximizeExpressionProduct(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// a product of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the product of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the product.</param>
        void MaximizeExpressionProduct(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the minimum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the minimum of.</param>
        void MinimizeMinimum(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the minimum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the minimum of.</param>
        ///<param name="coefficients">The coefficients of the variables in the minimum.</param>
        void MinimizeMinimum(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the minimum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the minimum of.</param>
        void MinimizeExpressionMinimum(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the minimum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the minimum of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the minimum.</param>
        void MinimizeExpressionMinimum(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the minimum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the minimum of.</param>
        void MaximizeMinimum(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the minimum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the minimum of.</param>
        ///<param name="coefficients">The coefficients of the variables in the minimum.</param>
        void MaximizeMinimum(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the minimum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the minimum of.</param>
        void MaximizeExpressionMinimum(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the minimum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the minimum of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the minimum.</param>
        void MaximizeExpressionMinimum(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the maximum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the maximum of.</param>
        void MinimizeMaximum(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the maximum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the maximum of.</param>
        ///<param name="coefficients">The coefficients of the variables in the maximum.</param>
        void MinimizeMaximum(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the maximum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the maximum of.</param>
        void MinimizeExpressionMaximum(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the maximum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the maximum of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the maximum.</param>
        void MinimizeExpressionMaximum(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the maximum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the maximum of.</param>
        void MaximizeMaximum(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the maximum of variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the maximum of.</param>
        ///<param name="coefficients">The coefficients of the variables in the maximum.</param>
        void MaximizeMaximum(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the maximum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the maximum of.</param>
        void MaximizeExpressionMaximum(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the maximum of expressions.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the maximum of.</param>
        ///<param name="coefficients">The coefficients of the expressions in the maximum.</param>
        void MaximizeExpressionMaximum(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the number of values of.</param>
        void MinimizeNValues(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to minimize the number of values of.</param>
        ///<param name="coefficients">The coefficients of the variables.</param>
        void MinimizeNValues(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the number of values of.</param>
        void MinimizeExpressionNValues(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to minimize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to minimize the number of values of.</param>
        ///<param name="coefficients">The coefficients of the expressions.</param>
        void MinimizeExpressionNValues(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the number of values of.</param>
        void MaximizeNValues(List<string> variables);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="variables">The variables to maximize the number of values of.</param>
        ///<param name="coefficients">The coefficients of the variables.</param>
        void MaximizeNValues(List<string> variables, List<BigInteger> coefficients);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the number of values of.</param>
        void MaximizeExpressionNValues(List<IIntensionConstraint> expressions);

        ///<summary>
        /// Notifies this listener that an objective function is to be added to maximize
        /// the number of values assigned to variables.
        ///
        ///</summary>
        ///<param name="expressions">The expressions to maximize the number of values of.</param>
        ///<param name="coefficients">The coefficients of the expressions.</param>
        void MaximizeExpressionNValues(List<IIntensionConstraint> expressions,
        List<BigInteger> coefficients);

        void DecisionVariables(List<string> variables);
    }

}

