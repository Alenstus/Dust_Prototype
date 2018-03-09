﻿using System;
using System.Linq;
using Dust.Language.Nodes;
using Dust.Language.Nodes.Expressions;
using Dust.Language.Nodes.Statements;

//222222+3445432+6546/566*4555

namespace Dust.Language.Compiler
{
  public class DustRuntimeCompiler : BaseCompiler<object>
  {
    public override string Name => "runtime";

    public DustRuntimeCompiler(DustContext visitorContext)
      : base(visitorContext)
    {
    }

    public override object CompileModule(Module module)
    {
      return CompileStatements(module.Statements);
    }

    protected override object CompileFunctionDeclaration(FunctionDeclaration statement)
    {
      throw new NotImplementedException();
    }

    protected override object CompileReturnStatement(ReturnStatement statement)
    {
      throw new NotImplementedException();
    }

    protected override object CompilePropertyDeclaration(PropertyDeclaration statement)
    {
      object value = CompileExpression(statement.Initializer);

      visitorContext.AddProperty(statement.Identifier, value);

      return value;
    }

    protected override object CompileTypeOfExpression(TypeOfExpression expression)
    {
      object value = CompileExpression(expression.Expression);

      return DustType.GetDustType(value);
    }

    protected override object CompileArrayExpression(ArrayExpression expression)
    {
      throw new NotImplementedException();
    }

    protected override object CompileBinaryExpression(BinaryExpression expression)
    {
      object left = CompileExpression(expression.Left);
      object right = CompileExpression(expression.Right);
      BinaryOperatorType @operator = expression.Operator;

      switch (@operator)
      {
        case BinaryOperatorType.EQUAL:
          return left.Equals(right);
        case BinaryOperatorType.NOT_EQUAL:
          return !left.Equals(right);
        case BinaryOperatorType.BIGGER:
          if (DustType.GetDustType(left) == DustType.Number && DustType.GetDustType(right) == DustType.Number)
          {
            return Convert.ToSingle(left) > Convert.ToSingle(right);
          }

          if ((DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int) && (DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int))
          {
            if (DustType.GetDustType(left) == DustType.Int)
            {
              return (int) left > ((string) right).Length;
            }

            if (DustType.GetDustType(right) == DustType.Int)
            {
              return ((string) left).Length > (int) right;
            }

            return Convert.ToSingle(left) > Convert.ToSingle(right);
          }

          break;
        case BinaryOperatorType.BIGGER_EQUAL:
          if (DustType.GetDustType(left) == DustType.Number && DustType.GetDustType(right) == DustType.Number)
          {
            return Convert.ToSingle(left) >= Convert.ToSingle(right);
          }

          if ((DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int) && (DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int))
          {
            if (DustType.GetDustType(left) == DustType.Int)
            {
              return (int) left >= ((string) right).Length;
            }

            if (DustType.GetDustType(right) == DustType.Int)
            {
              return ((string) left).Length >= (int) right;
            }

            return Convert.ToSingle(left) >= Convert.ToSingle(right);
          }

          break;
        case BinaryOperatorType.SMALLER:
          if (DustType.GetDustType(left) == DustType.Number && DustType.GetDustType(right) == DustType.Number)
          {
            return Convert.ToSingle(left) < Convert.ToSingle(right);
          }

          if ((DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int) && (DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int))
          {
            if (DustType.GetDustType(left) == DustType.Int)
            {
              return (int) left < ((string) right).Length;
            }

            if (DustType.GetDustType(right) == DustType.Int)
            {
              return ((string) left).Length < (int) right;
            }

            return Convert.ToSingle(left) < Convert.ToSingle(right);
          }

          break;
        case BinaryOperatorType.SMALLER_EQUAL:
          if (DustType.GetDustType(left) == DustType.Number && DustType.GetDustType(right) == DustType.Number)
          {
            return Convert.ToSingle(left) <= Convert.ToSingle(right);
          }

          if ((DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int) && (DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Int))
          {
            if (DustType.GetDustType(left) == DustType.Int)
            {
              return (int) left <= ((string) right).Length;
            }

            if (DustType.GetDustType(right) == DustType.Int)
            {
              return ((string) left).Length <= (int) right;
            }

            return Convert.ToSingle(left) <= Convert.ToSingle(right);
          }

          break;
      }

      if (DustType.GetDustType(left) == DustType.Number && DustType.GetDustType(right) == DustType.Number)
      {
        switch (@operator)
        {
          case BinaryOperatorType.PLUS:
            if (DustType.GetDustType(left) == DustType.Int && DustType.GetDustType(right) == DustType.Int)
              return (int) left + (int) right;

            return Convert.ToSingle(left) + Convert.ToSingle(right);
          case BinaryOperatorType.MINUS:
            if (DustType.GetDustType(left) == DustType.Int && DustType.GetDustType(right) == DustType.Int)
              return (int) left - (int) right;

            return Convert.ToSingle(left) - Convert.ToSingle(right);
          case BinaryOperatorType.TIMES:
            if (DustType.GetDustType(left) == DustType.Int && DustType.GetDustType(right) == DustType.Int)
              return (int) left * (int) right;

            return Convert.ToSingle(left) * Convert.ToSingle(right);
          case BinaryOperatorType.DIVIDE:
            if (DustType.GetDustType(left) == DustType.Int && DustType.GetDustType(right) == DustType.Int)
              return (int) left / (int) right;

            return Convert.ToSingle(left) / Convert.ToSingle(right);
        }
      }

      if ((DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Number) && (DustType.GetDustType(right) == DustType.String || DustType.GetDustType(right) == DustType.Number))
      {
        switch (@operator)
        {
          case BinaryOperatorType.PLUS:
            if (DustType.GetDustType(right) == DustType.Number)
            {
              return (string) left + Convert.ToSingle(right);
            }

            if (DustType.GetDustType(left) == DustType.Number)
            {
              return Convert.ToSingle(left) + (string) right;
            }

            return (string) left + (string) right;
          case BinaryOperatorType.TIMES:
            if (DustType.GetDustType(right) == DustType.Number)
            {
              return string.Concat(Enumerable.Repeat((string) left, (int) right).ToArray());
            }

            if (DustType.GetDustType(left) == DustType.Number)
            {
              return string.Concat(Enumerable.Repeat((string) right, (int) left).ToArray());
            }

            break;
        }
      }

      return null;
    }

    protected override object CompileUnaryExpression(UnaryExpression expression)
    {
      object value = CompileExpression(expression.Expression);
      UnaryOperatorType @operator = expression.Operator;

      if (DustType.GetDustType(value) == DustType.Number)
      {
        switch (@operator)
        {
          case UnaryOperatorType.PLUS_PLUS:
            if (DustType.GetDustType(value) == DustType.Int)
              return (int) value + 1;

            return Convert.ToSingle(value) + 1;
          case UnaryOperatorType.MINUS_MINUS:
            if (DustType.GetDustType(value) == DustType.Int)
              return (int) value - 1;

            return Convert.ToSingle(value) - 1;
          case UnaryOperatorType.TIMES_TIMES:
            if (DustType.GetDustType(value) == DustType.Int)
              return Math.Pow((int) value, 2);

            return Math.Pow(Convert.ToSingle(value), 2);
          case UnaryOperatorType.DIVIDE_DIVIDE:
            if (DustType.GetDustType(value) == DustType.Int)
              return Math.Sqrt((int) value);

            return Math.Sqrt(Convert.ToSingle(value));
        }
      }

      return null;
    }

    protected override object CompileAssignmentExpression(AssignmentExpression expression)
    {
      object value = CompileExpression(expression.Right);

      expression.Left.Value = value;

      return value;
    }

    protected override object CompileCallExpression(CallExpression expression)
    {
      throw new NotImplementedException();
    }

    protected override object CompileIdentifierExpression(IdentifierExpression expression)
    {
      return expression.Value;
    }

    protected override object CompileLiteralExpression(LiteralExpression expression)
    {
      return expression.Value;
    }

    protected override object CombineStatements(object[] returns)
    {
      return returns.Last();
    }
  }
}