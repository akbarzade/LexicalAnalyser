using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;
namespace Akbarzade.LexAnConsole
{
    public class SymbolReference : SyntaxNode
    {
        public string Symbol;
        public SymbolReference()
        {
        }
        public SymbolReference(string str)
        {
            this.Symbol = str;
        }
    }
}