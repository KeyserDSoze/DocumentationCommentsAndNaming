using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class NullTag : ATag
    {
        public NullTag() : base(string.Empty)
        {
        }
        public override void Parse(XNode element)
        {
            this.Value = ((XText)element).Value;
        }
        public override void WriteParagraph(ref DocX docX)
        {
            
        }
    }
}
