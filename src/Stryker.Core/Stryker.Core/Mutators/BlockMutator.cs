using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Stryker.Core.Mutants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stryker.Core.Mutators
{
    class BlockMutator : MutatorBase<BlockSyntax>, IMutator
    {
        public override IEnumerable<Mutation> ApplyMutations(BlockSyntax node)
        {
            yield return new Mutation()
            {
                OriginalNode = node,
                ReplacementNode = SyntaxFactory.Block(SyntaxFactory.ReturnStatement(SyntaxFactory.LiteralExpression(SyntaxKind.DefaultLiteralExpression))),
                DisplayName = "Block mutation",
                Type = Mutator.Block
            };
        }
    }
}
