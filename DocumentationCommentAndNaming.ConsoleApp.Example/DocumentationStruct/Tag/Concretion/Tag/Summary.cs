using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Summary : ATag
    {
        public Summary() : base("summary")
        {
            this.sizeTitle = 15;
            this.sizeDescription = 14;
            this.colorTitle = Color.DarkViolet;
            this.colorDescription = Color.DarkGray;

        }
        public override void WriteParagraph(ref DocX docX)
        {
            Paragraph paragraph = docX.InsertParagraph($"Summary: ", false, new Formatting() { Size = this.sizeTitle, FontColor = this.colorTitle, Bold = true });
            paragraph.IndentationBefore = this.Indentation;
            string value = "";
            foreach (var subTag in this.Tags)
            {
                if (subTag.Value != null) value += " " + regexWhiteSpace.Replace(subTag.Value, "").Trim();
                foreach (var paramTag in subTag.Tags)
                {
                    value += " " + regexWhiteSpace.Replace(paramTag.Value, "").Trim();
                }
            }
            paragraph = docX.InsertParagraph(value.Trim(), false, new Formatting() { Size = this.sizeDescription, FontColor = this.colorDescription });
            paragraph.IndentationBefore = this.Indentation;
        }
    }
}
