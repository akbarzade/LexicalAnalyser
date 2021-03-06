﻿using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;
namespace Akbarzade.LexAnConsole
{
    public class Method : SyntaxNode
    {
        public string Name;
        public string ReturnType;
        public Block block;
        public List<Declaration> Arguments = new List<Declaration>();
        public bool External = false;
        public bool ReturnsPtr = false;
        public Method()
        {
        }
        public Method(string name, string type)
        {
            this.Name = name;
            this.ReturnType = type;
        }
    }
}