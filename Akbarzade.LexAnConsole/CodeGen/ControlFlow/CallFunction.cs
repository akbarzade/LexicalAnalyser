﻿using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using GruntXProductions;
using Viper;
using Viper.Opcodes;

namespace Akbarzade.LexAnConsole
{
    public partial class CodeGen
    {
        public void Call(FunctionCall func)
        {
            if (methodExists(func.Target))
            {
                func.Arguments.Reverse();
                foreach (Expression exp in func.Arguments)
                {
                    if (GuessType(exp) == VType.Int32)
                        CompileIntExpression(exp);
                    else if (GuessType(exp) == VType.Int8)
                        CompileCharExpression(exp);
                    else if (GuessType(exp) == VType.String)
                    {
                        CompileStringExpression(exp);
                    }
                }
                func.Arguments.Reverse();
                Assembler.Emit(new bsr(func.Target));
            }
            else
                Errors.Add(func.Target + " does not exist in the current context!");
        }
    }
}