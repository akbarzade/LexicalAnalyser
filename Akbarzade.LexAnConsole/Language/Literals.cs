using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;

namespace Akbarzade.LexAnConsole
{
    public class IntLiteral : SyntaxNode
    {
        public int Value;

        public IntLiteral()
        {
        }

        public IntLiteral(int val)
        {
            this.Value = val;
        }
    }

    public class StringLiteral : SyntaxNode
    {
        public string Value;

        public StringLiteral()
        {
        }

        public StringLiteral(string val)
        {
            this.Value = val;
        }
    }
}