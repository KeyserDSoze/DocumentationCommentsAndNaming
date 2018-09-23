using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Params : ATag
    {
        public Params() : base("params")
        {
        }
        public override void WriteParagraph(ref DocX docX)
        {
            docX.InsertParagraph($"Parameters: ", false, new Formatting() { Size = 13, UnderlineStyle = UnderlineStyle.singleLine, UnderlineColor = Color.OrangeRed, Bold = true });
            foreach (var subTag in this.Tags)
            {
                int tot = 0;
                foreach (var paramTag in subTag.Tags)
                {
                    docX.InsertParagraph("Param {" + subTag.Attributes.ElementAt(tot).Value + "} is: " + $"{regexWhiteSpace.Replace(paramTag.Value, "")}", false, new Formatting() { Size = 13, FontColor = Color.DarkGray });
                    tot++;
                }
            }
        }
    }
}
