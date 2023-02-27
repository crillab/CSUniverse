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
using Fr.UnivArtois.CRIL.CSUniverse.CSP.Operator;

namespace Fr.UnivArtois.CRIL.CSUniverse.CSP.Intension;
///<summary>
/// The IntensionConstraintFactory makes easier the construction of {@code intension}
/// constraints from the solver's API, by providing a functional notation similar to that
/// used to define the constraints using XCSP3.
///</summary>
public class IntensionConstraintFactory
{

    ///<summary>
    /// Disables instantiation.
    ///</summary>
    private IntensionConstraintFactory()
    {
        throw new Exception("No IntensionConstraintFactory instances for you!");
    }

    ///<summary>
    /// Wraps a constant value in its representation as an {@code intension} constraint.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="value">The value of the constant.</param>
    public static IIntensionConstraint Constant(long value)
    {
        return new ConstantIntensionConstraint(new BigInteger(value));
    }

    ///<summary>
    /// Wraps a constant value in its representation as an {@code intension} constraint.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="value">The value of the constant.</param>
    public static IIntensionConstraint Constant(BigInteger value)
    {
        return new ConstantIntensionConstraint(value);
    }

    ///<summary>
    /// Wraps a variable in its representation as an {@code intension} constraint.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="id">The identifier of the variable.</param>
    public static IIntensionConstraint Variable(String id)
    {
        return new VariableIntensionConstraint(id);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code opposite} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constr">The constraint on which to apply the op.</param>
    public static IIntensionConstraint Neg(IIntensionConstraint constr)
    {
        return Unary(UniverseArithmeticOperator.Neg, constr);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code absolute-value}
    /// op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constr">The constraint on which to apply the op.</param>
    public static IIntensionConstraint Abs(IIntensionConstraint constr)
    {
        return Unary(UniverseArithmeticOperator.Abs, constr);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code addition} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Add(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseArithmeticOperator.Add, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code addition} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Add(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseArithmeticOperator.Add, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code subtraction} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Sub(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseArithmeticOperator.Sub, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code multiplication}
    /// op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Mult(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseArithmeticOperator.Mult, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code multiplication}
    /// op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Mult(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseArithmeticOperator.Mult, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code division} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Div(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseArithmeticOperator.Div, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code modulo} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Mod(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseArithmeticOperator.Mod, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code square} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constr">The constraint on which to apply the op.</param>
    public static IIntensionConstraint Sqr(IIntensionConstraint constr)
    {
        return Unary(UniverseArithmeticOperator.Sqr, constr);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code power} op.
    ///
    ///</summary>
    ///<param name="constr">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="exponent">The exponent in the power operation</param>
    public static IIntensionConstraint Pow(IIntensionConstraint constr, IIntensionConstraint exponent)
    {
        return Binary(UniverseArithmeticOperator.Pow, constr, exponent);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code minimum} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Min(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseArithmeticOperator.Min, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code minimum} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Min(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseArithmeticOperator.Min, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code maximum} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Max(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseArithmeticOperator.Max, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code maximum} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Max(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseArithmeticOperator.Max, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code distance} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Dist(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseArithmeticOperator.Dist, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code less-than} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Lt(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseRelationalOperator.Lt, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code less-or-equal}
    /// op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Le(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseRelationalOperator.Le, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code equal} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Eq(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseBooleanOperator.Equiv, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code equal} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Eq(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseBooleanOperator.Equiv, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code different} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Neq(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseRelationalOperator.Neq, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code greater-or-equal}
    /// op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Ge(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseRelationalOperator.Ge, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code greater-than} op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Gt(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseRelationalOperator.Gt, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code not} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constr">The constraint on which to apply the op.</param>
    public static IIntensionConstraint Not(IIntensionConstraint constr)
    {
        return Unary(UniverseBooleanOperator.Not, constr);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code conjunction} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint And(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseBooleanOperator.And, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code conjunction} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint And(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseBooleanOperator.And, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code disjunction} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Or(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseBooleanOperator.Or, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code disjunction} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Or(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseBooleanOperator.Or, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code exclusive-disjunction}
    /// op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Xor(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseBooleanOperator.Xor, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code exclusive-disjunction}
    /// op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Xor(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseBooleanOperator.Xor, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code equivalence} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Equiv(params IIntensionConstraint[] constrs)
    {
        return Nary(UniverseBooleanOperator.Equiv, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code equivalence} op.
    ///
    ///</summary>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which to apply the op.</param>
    public static IIntensionConstraint Equiv(IList<IIntensionConstraint> constrs)
    {
        return Nary(UniverseBooleanOperator.Equiv, constrs);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code implication}
    /// op.
    ///
    ///</summary>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Impl(IIntensionConstraint left, IIntensionConstraint right)
    {
        return Binary(UniverseBooleanOperator.Impl, left, right);
    }

    ///<summary>
    /// Creates an {@code intension} constraint applying the {@code if-then-else} op.
    ///
    ///</summary>
    ///<param name="condition">The condition of the constraint.</param>
    ///        condition evaluates to {@code true}.
    ///<param name="ifTrue">The intension constraint corresponding to the case in which the</param>
    ///        condition evaluates to {@code false}.
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="ifFalse">The intension constraint corresponding to the case in which the</param>
    public static IIntensionConstraint Ite(IIntensionConstraint condition,
    IIntensionConstraint ifTrue, IIntensionConstraint ifFalse)
    {
        return new IfThenElseIntensionConstraint(condition, ifTrue, ifFalse);
    }

    ///<summary>
    /// Creates a new unary {@code intension} constraint.
    ///
    ///</summary>
    ///<param name="op">The op applied by the constraint.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constr">The constraint on which the op is applied.</param>
    public static IIntensionConstraint Unary(IUniverseOperator op, IIntensionConstraint constr)
    {
        return new UnaryIntensionConstraint(op, constr);
    }

    ///<summary>
    /// Creates a new binary {@code intension} constraint.
    ///
    ///</summary>
    ///<param name="op">The op applied by the constraint.</param>
    ///<param name="left">The left constraint on which the op is applied.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="right">The right constraint on which the op is applied.</param>
    public static IIntensionConstraint Binary(IUniverseOperator op, IIntensionConstraint left,
    IIntensionConstraint right)
    {
        return new BinaryIntensionConstraint(op, left, right);
    }

    ///<summary>
    /// Creates a new n-ary {@code intension} constraint.
    ///
    ///</summary>
    ///<param name="op">The op applied by the constraint.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which the op is applied.</param>
    public static IIntensionConstraint Nary(IUniverseOperator op, params IIntensionConstraint[] constrs)
    {
        return Nary(op, new List<IIntensionConstraint>(constrs));
    }

    ///<summary>
    /// Creates a new n-ary {@code intension} constraint.
    ///
    ///</summary>
    ///<param name="op">The op applied by the constraint.</param>
    ///
    ///<return>created {@code intension} constraint.</return>
    ///<param name="constrs">The constraints on which the op is applied.</param>
    public static IIntensionConstraint Nary(IUniverseOperator op, IList<IIntensionConstraint> constrs)
    {
        return new NaryIntensionConstraint(op, constrs);
    }

}
