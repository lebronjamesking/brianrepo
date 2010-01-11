﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Interfaces;

namespace Compiler
{
    public class Compiler
    {
        private string inputPath;
        
        public Compiler(string inputPath)
        {
            this.inputPath = inputPath;
        }

        public void Compile()
        {
            try
            {
                using (Tokenizer tokenizer = new Tokenizer(this.inputPath))
                {
                    IList<Pair<string, string>> tokens = tokenizer.GetTokens();
                    Console.WriteLine(tokens.PairListToString());
                }
            }
            catch (Exception ex)
            {
                // TODO remove exception handling from here
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }

       
    }
}
