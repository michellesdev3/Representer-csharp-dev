using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Exercism.Representers.CSharp.Simplification
{
    internal static class ExpressionSyntaxExtensions
    {
        public static string IdentifierName(this ExpressionSyntax expression) =>
            expression is IdentifierNameSyntax identifierName ? identifierName.Identifier.ValueText : null;
    }
}