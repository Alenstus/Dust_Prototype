﻿using LanguageServer.Parameters;

namespace Dust.Language.Nodes.Expressions
{
  public class TypeOfExpression : Expression
  {
    public Expression Expression { get; }

    public TypeOfExpression(Expression expression, Range range)
      : base(range)
    {
      Expression = expression;
    }
  }
}