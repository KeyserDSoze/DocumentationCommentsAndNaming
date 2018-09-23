using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Exceptions : ATag
    {
        public Exceptions() : base("exceptions", "cref")
        {
        }
        public override void WriteParagraph(ref DocX docX)
        {
            docX.InsertParagraph($"Possible exceptions: ", false, new Formatting() { Size = 13, UnderlineStyle = UnderlineStyle.singleLine, UnderlineColor = Color.OrangeRed, Bold = true});
            foreach (var subTag in this.Tags)
            {
                int tot = 0;
                foreach (var exceptionTag in subTag.Tags)
                {
                    docX.InsertParagraph($"{regexWhiteSpace.Replace(exceptionTag.Value, "")} - ({subTag.Attributes.ElementAt(tot).Value.Split(':').Last()})", false, new Formatting() { Size = 12, FontColor = Color.DarkRed });
                    tot++;
                }
            }
        }
    }
}
