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
        public void Assign(Assignment asn, bool assignConst = false)
        {

            if (SymHelper[asn.Var] == "")
                Errors.Add(asn.Var + " does not exist in the current context!");
            else if (SymHelper.isConstant(asn.Var) && !assignConst)
                Errors.Add("Can not assign value to constant " + asn.Var);
            else
            {
                if (SymHelper.getType(asn.Var) == VType.Int32 || SymHelper.isPointer(asn.Var))
                {
                    CompileIntExpression(asn.Value);
                    Assembler.Emit(new push_ptr(SymHelper[asn.Var]));
                    Assembler.Emit(new dstore());
                }
                else if (SymHelper.getType(asn.Var) == VType.Int8)
                {
                    CompileCharExpression(asn.Value);

                    Assembler.Emit(new push_ptr(SymHelper[asn.Var]));
                    Assembler.Emit(new bstore());

                }
                else if (GuessType(asn.Value) == VType.String)
                {
                    if (SymHelper.getType(asn.Var) != VType.String)
                        Errors.Add(asn.Var + " can not be converted to string!");
                    else
                    {
                        CompileStringExpression(asn.Value);
                        Assembler.Emit(new push_ptr(SymHelper[asn.Var]));
                        Assembler.Emit(new dstore());
                    }
                }
                else
                {
                    Errors.Add("Could not find type!");
                }
            }
        }

    }
}