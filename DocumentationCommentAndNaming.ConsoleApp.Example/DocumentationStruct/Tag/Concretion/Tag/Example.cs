using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.colorTitle = Color.DarkGreen;
            this.colorDescription = Color.DarkGray;
        }
        public override void WriteParagraph(ref DocX docX)
        {
            Paragraph paragraph = docX.InsertParagraph($"Example: ", false, new Formatting() { Size = this.sizeTitle, Bold = true, FontColor = this.colorTitle });
            paragraph.IndentationBefore = this.Indentation;
            foreach (var subTag in this.Tags)
            {
                foreach (var codeTag in subTag.Tags)
                {
                    paragraph = docX.InsertParagraph($"{regexWhiteSpace.Replace(codeTag.Value, "").Replace(";", ";" + '\n'.ToString())}", false, new Formatting() { Size = this.sizeDescription, FontColor = this.colorDescription });
                    paragraph.IndentationBefore = this.Indentation;
                }
            }
        }
    }
}
