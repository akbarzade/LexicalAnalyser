using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;
namespace Akbarzade.LexAnConsole
{
    public class WhileStatement : SyntaxNode
    {
        public Expression Compare = new Expression();
        public Block Body = new Block();
    }
}