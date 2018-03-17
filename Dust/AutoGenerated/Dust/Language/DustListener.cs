//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from F:/PROJECTS/Active/Dust/Dust/Dust\Dust.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Dust.Language {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DustParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public interface IDustListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule([NotNull] DustParser.ModuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.module"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule([NotNull] DustParser.ModuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] DustParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] DustParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BangUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBangUnaryExpression([NotNull] DustParser.BangUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BangUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBangUnaryExpression([NotNull] DustParser.BangUnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DeleteUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteUnaryExpression([NotNull] DustParser.DeleteUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DeleteUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteUnaryExpression([NotNull] DustParser.DeleteUnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeOfExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeOfExpression([NotNull] DustParser.TypeOfExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeOfExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeOfExpression([NotNull] DustParser.TypeOfExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NotEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotEqualBinaryExpression([NotNull] DustParser.NotEqualBinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NotEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotEqualBinaryExpression([NotNull] DustParser.NotEqualBinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BiggerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBiggerEqualBinaryExpression([NotNull] DustParser.BiggerEqualBinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BiggerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBiggerEqualBinaryExpression([NotNull] DustParser.BiggerEqualBinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DotMemberExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDotMemberExpression([NotNull] DustParser.DotMemberExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DotMemberExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDotMemberExpression([NotNull] DustParser.DotMemberExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralExpression([NotNull] DustParser.LiteralExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralExpression([NotNull] DustParser.LiteralExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicationUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicationUnaryExpression([NotNull] DustParser.MultiplicationUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicationUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicationUnaryExpression([NotNull] DustParser.MultiplicationUnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayLiteralExpression([NotNull] DustParser.ArrayLiteralExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayLiteralExpression([NotNull] DustParser.ArrayLiteralExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionUnaryExpression([NotNull] DustParser.AdditionUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionUnaryExpression([NotNull] DustParser.AdditionUnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SubstractionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubstractionUnaryExpression([NotNull] DustParser.SubstractionUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SubstractionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubstractionUnaryExpression([NotNull] DustParser.SubstractionUnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>EqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualBinaryExpression([NotNull] DustParser.EqualBinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualBinaryExpression([NotNull] DustParser.EqualBinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BiggerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBiggerBinaryExpression([NotNull] DustParser.BiggerBinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BiggerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBiggerBinaryExpression([NotNull] DustParser.BiggerBinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupExpression([NotNull] DustParser.GroupExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupExpression([NotNull] DustParser.GroupExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] DustParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] DustParser.IdentifierExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SmallerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSmallerBinaryExpression([NotNull] DustParser.SmallerBinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SmallerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSmallerBinaryExpression([NotNull] DustParser.SmallerBinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DivisionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDivisionUnaryExpression([NotNull] DustParser.DivisionUnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DivisionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDivisionUnaryExpression([NotNull] DustParser.DivisionUnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinaryExpression([NotNull] DustParser.BinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinaryExpression([NotNull] DustParser.BinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] DustParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] DustParser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SmallerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSmallerEqualBinaryExpression([NotNull] DustParser.SmallerEqualBinaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SmallerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSmallerEqualBinaryExpression([NotNull] DustParser.SmallerEqualBinaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallExpression([NotNull] DustParser.CallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallExpression([NotNull] DustParser.CallExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] DustParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] DustParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.arthimeticOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArthimeticOperator([NotNull] DustParser.ArthimeticOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.arthimeticOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArthimeticOperator([NotNull] DustParser.ArthimeticOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] DustParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] DustParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] DustParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] DustParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.propertyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyDeclaration([NotNull] DustParser.PropertyDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.propertyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyDeclaration([NotNull] DustParser.PropertyDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionDeclarationBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclarationBase([NotNull] DustParser.FunctionDeclarationBaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionDeclarationBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclarationBase([NotNull] DustParser.FunctionDeclarationBaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclaration([NotNull] DustParser.FunctionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclaration([NotNull] DustParser.FunctionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionName([NotNull] DustParser.FunctionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionName([NotNull] DustParser.FunctionNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionModifier([NotNull] DustParser.FunctionModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionModifier([NotNull] DustParser.FunctionModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionParameterList([NotNull] DustParser.FunctionParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionParameterList([NotNull] DustParser.FunctionParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionFragmentator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionFragmentator([NotNull] DustParser.FunctionFragmentatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionFragmentator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionFragmentator([NotNull] DustParser.FunctionFragmentatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionParameter([NotNull] DustParser.FunctionParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionParameter([NotNull] DustParser.FunctionParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterName([NotNull] DustParser.ParameterNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterName([NotNull] DustParser.ParameterNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.memberName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberName([NotNull] DustParser.MemberNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.memberName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberName([NotNull] DustParser.MemberNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.identifierName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierName([NotNull] DustParser.IdentifierNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.identifierName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierName([NotNull] DustParser.IdentifierNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementBlock([NotNull] DustParser.StatementBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementBlock([NotNull] DustParser.StatementBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Bool</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] DustParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Bool</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] DustParser.BoolContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] DustParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] DustParser.StringContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] DustParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] DustParser.IntContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] DustParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] DustParser.FloatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.arrayLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayLiteral([NotNull] DustParser.ArrayLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.arrayLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayLiteral([NotNull] DustParser.ArrayLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.callParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallParameterList([NotNull] DustParser.CallParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.callParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallParameterList([NotNull] DustParser.CallParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.callParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallParameter([NotNull] DustParser.CallParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.callParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallParameter([NotNull] DustParser.CallParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEos([NotNull] DustParser.EosContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEos([NotNull] DustParser.EosContext context);
}
} // namespace Dust.Language
