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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IDustListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class DustBaseListener : IDustListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.module"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModule([NotNull] DustParser.ModuleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.module"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModule([NotNull] DustParser.ModuleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] DustParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] DustParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BangUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBangUnaryExpression([NotNull] DustParser.BangUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BangUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBangUnaryExpression([NotNull] DustParser.BangUnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DeleteUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteUnaryExpression([NotNull] DustParser.DeleteUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DeleteUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteUnaryExpression([NotNull] DustParser.DeleteUnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeOfExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeOfExpression([NotNull] DustParser.TypeOfExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeOfExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeOfExpression([NotNull] DustParser.TypeOfExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NotEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotEqualBinaryExpression([NotNull] DustParser.NotEqualBinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NotEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotEqualBinaryExpression([NotNull] DustParser.NotEqualBinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BiggerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBiggerEqualBinaryExpression([NotNull] DustParser.BiggerEqualBinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BiggerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBiggerEqualBinaryExpression([NotNull] DustParser.BiggerEqualBinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DotMemberExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDotMemberExpression([NotNull] DustParser.DotMemberExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DotMemberExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDotMemberExpression([NotNull] DustParser.DotMemberExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralExpression([NotNull] DustParser.LiteralExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralExpression([NotNull] DustParser.LiteralExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicationUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicationUnaryExpression([NotNull] DustParser.MultiplicationUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicationUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicationUnaryExpression([NotNull] DustParser.MultiplicationUnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayLiteralExpression([NotNull] DustParser.ArrayLiteralExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayLiteralExpression([NotNull] DustParser.ArrayLiteralExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditionUnaryExpression([NotNull] DustParser.AdditionUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditionUnaryExpression([NotNull] DustParser.AdditionUnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SubstractionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubstractionUnaryExpression([NotNull] DustParser.SubstractionUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SubstractionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubstractionUnaryExpression([NotNull] DustParser.SubstractionUnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>EqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualBinaryExpression([NotNull] DustParser.EqualBinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>EqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualBinaryExpression([NotNull] DustParser.EqualBinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BiggerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBiggerBinaryExpression([NotNull] DustParser.BiggerBinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BiggerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBiggerBinaryExpression([NotNull] DustParser.BiggerBinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>GroupExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupExpression([NotNull] DustParser.GroupExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>GroupExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupExpression([NotNull] DustParser.GroupExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpression([NotNull] DustParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpression([NotNull] DustParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SmallerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSmallerBinaryExpression([NotNull] DustParser.SmallerBinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SmallerBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSmallerBinaryExpression([NotNull] DustParser.SmallerBinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DivisionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDivisionUnaryExpression([NotNull] DustParser.DivisionUnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DivisionUnaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDivisionUnaryExpression([NotNull] DustParser.DivisionUnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryExpression([NotNull] DustParser.BinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryExpression([NotNull] DustParser.BinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpression([NotNull] DustParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpression([NotNull] DustParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SmallerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSmallerEqualBinaryExpression([NotNull] DustParser.SmallerEqualBinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SmallerEqualBinaryExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSmallerEqualBinaryExpression([NotNull] DustParser.SmallerEqualBinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallExpression([NotNull] DustParser.CallExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="DustParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallExpression([NotNull] DustParser.CallExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] DustParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] DustParser.DeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.arithmeticOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticOperator([NotNull] DustParser.ArithmeticOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.arithmeticOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticOperator([NotNull] DustParser.ArithmeticOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] DustParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] DustParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] DustParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] DustParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.propertyDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPropertyDeclaration([NotNull] DustParser.PropertyDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.propertyDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPropertyDeclaration([NotNull] DustParser.PropertyDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionDeclarationBase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclarationBase([NotNull] DustParser.FunctionDeclarationBaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionDeclarationBase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclarationBase([NotNull] DustParser.FunctionDeclarationBaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] DustParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] DustParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionName([NotNull] DustParser.FunctionNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionName([NotNull] DustParser.FunctionNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionModifier([NotNull] DustParser.FunctionModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionModifier([NotNull] DustParser.FunctionModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionParameterList([NotNull] DustParser.FunctionParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionParameterList([NotNull] DustParser.FunctionParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionFragmentator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionFragmentator([NotNull] DustParser.FunctionFragmentatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionFragmentator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionFragmentator([NotNull] DustParser.FunctionFragmentatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.functionParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionParameter([NotNull] DustParser.FunctionParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.functionParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionParameter([NotNull] DustParser.FunctionParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.parameterName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterName([NotNull] DustParser.ParameterNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.parameterName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterName([NotNull] DustParser.ParameterNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.memberName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberName([NotNull] DustParser.MemberNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.memberName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberName([NotNull] DustParser.MemberNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.identifierName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierName([NotNull] DustParser.IdentifierNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.identifierName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierName([NotNull] DustParser.IdentifierNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.statementBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementBlock([NotNull] DustParser.StatementBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.statementBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementBlock([NotNull] DustParser.StatementBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Bool</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBool([NotNull] DustParser.BoolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Bool</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBool([NotNull] DustParser.BoolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] DustParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] DustParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInt([NotNull] DustParser.IntContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Int</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInt([NotNull] DustParser.IntContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloat([NotNull] DustParser.FloatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Float</c>
	/// labeled alternative in <see cref="DustParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloat([NotNull] DustParser.FloatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.arrayLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayLiteral([NotNull] DustParser.ArrayLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.arrayLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayLiteral([NotNull] DustParser.ArrayLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.callParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallParameterList([NotNull] DustParser.CallParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.callParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallParameterList([NotNull] DustParser.CallParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.callParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallParameter([NotNull] DustParser.CallParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.callParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallParameter([NotNull] DustParser.CallParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DustParser.eos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEos([NotNull] DustParser.EosContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DustParser.eos"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEos([NotNull] DustParser.EosContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Dust.Language
