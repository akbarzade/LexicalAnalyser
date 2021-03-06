using System;
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
        private static int IfIndex = 0;
        public void CompileIf(IfStatement ifstat)
        {
            string label = "_if_" + IfIndex.ToString();
            string end_label = "_endif_" + IfIndex.ToString();
            IfIndex++;
            CompileIntExpression(ifstat.Compare);
            Assembler.Emit(new bz(label));
            CompileBlock(ifstat.IfBlock);
            Assembler.Emit(new bra(end_label));
            Assembler.CreateLabel(label);
            CompileBlock(ifstat.ElseBlock);
            Assembler.CreateLabel(end_label);
        }

    }
}