using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;
namespace Akbarzade.LexAnConsole
{
    public class Return : SyntaxNode
    {
        public Expression Value = new Expression();
    }
}