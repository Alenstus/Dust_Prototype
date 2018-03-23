﻿using Dust.Language.Nodes.Expressions;
using Dust.Language.Types;

namespace Dust.Language.Nodes.Statements
{
  public class FunctionDeclaration : Statement
  {
    public Function Function { get; }
 
    public FunctionDeclaration(string name, FunctionModifier[] modifiers, FunctionParameter[] parameters, Statement[] statements, DustType returnType, DustContext context)
    {
      Function = new Function(name, modifiers, parameters, statements, returnType, context);
    }
  }
}