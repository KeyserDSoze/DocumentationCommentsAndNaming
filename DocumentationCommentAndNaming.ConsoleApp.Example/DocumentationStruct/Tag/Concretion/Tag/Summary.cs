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
        }
        public override void WriteParagraph(ref DocX docX)
        {
            docX.InsertParagraph($"Summary: ", false, new Formatting() { Size = 14, UnderlineStyle = UnderlineStyle.singleLine, UnderlineColor = Color.OrangeRed, Bold = true });
            string value = "";
            foreach (var subTag in this.Tags)
            {
                if (subTag.Value != null) value += " " + regexWhiteSpace.Replace(subTag.Value, "").Trim();
                foreach (var paramTag in subTag.Tags)
                {
                    value += " " + regexWhiteSpace.Replace(paramTag.Value, "").Trim();
                }
            }
            docX.InsertParagraph(value.Trim(), false, new Formatting() { Size = 14, FontColor = Color.Black });
        }
    }
}
