﻿using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;
namespace Akbarzade.LexAnConsole
{
    public class Block : SyntaxNode
    {
        public List<SyntaxNode> Body = new List<SyntaxNode>();
    }
}