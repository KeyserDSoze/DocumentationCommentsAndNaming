using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Example : ATag
    {
        public Example() : base("example")
        {
        }
        public override void WriteParagraph(ref DocX docX)
        {
            docX.InsertParagraph($"Example: ", false, new Formatting() { Size = 13, Bold = true });
            foreach (var subTag in this.Tags)
            {
                foreach (var codeTag in subTag.Tags)
                {
                    docX.InsertParagraph($"{regexWhiteSpace.Replace(codeTag.Value, "").Replace(";", ";" + '\n'.ToString())}", true, new Formatting() { Size = 12 });
                }
            }
        }
    }
}
