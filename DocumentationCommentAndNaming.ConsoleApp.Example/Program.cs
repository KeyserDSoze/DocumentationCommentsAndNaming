﻿using DocumentationCommentAndNaming.DocumentationStruct;
using DocumentationCommentAndNaming.WordCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.ConsoleApp.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDocument wordDocument = new WordDocument();
            wordDocument.CreateDocument(@"C:\Users\aless\source\repos\DocumentationCommentsAndNaming");
        }
    }
}
