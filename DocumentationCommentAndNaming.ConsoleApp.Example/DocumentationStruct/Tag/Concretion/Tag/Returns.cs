using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Returns : ATag
    {
        public Returns() : base("returns")
        {
        }
        public override void WriteParagraph(ref DocX docX)
        {
             //docX.InsertParagraph($"Returns: {this.Value}", false, new Formatting() { Size = 13, UnderlineStyle = UnderlineStyle.singleLine, UnderlineColor = Color.OrangeRed, Bold = true, FontColor = Color.DarkGreen });
        }
    }
}
