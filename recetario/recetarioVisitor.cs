//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\laona\source\repos\recetario\recetario\recetario.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="recetarioParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public interface IrecetarioVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] recetarioParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.entry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEntry([NotNull] recetarioParser.EntryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.receta"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReceta([NotNull] recetarioParser.RecetaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.porciones"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPorciones([NotNull] recetarioParser.PorcionesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.tiempoprep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTiempoprep([NotNull] recetarioParser.TiempoprepContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.tiempococ"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTiempococ([NotNull] recetarioParser.TiempococContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.calorias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCalorias([NotNull] recetarioParser.CaloriasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.ingredientes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIngredientes([NotNull] recetarioParser.IngredientesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="recetarioParser.elaboracion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElaboracion([NotNull] recetarioParser.ElaboracionContext context);
}
