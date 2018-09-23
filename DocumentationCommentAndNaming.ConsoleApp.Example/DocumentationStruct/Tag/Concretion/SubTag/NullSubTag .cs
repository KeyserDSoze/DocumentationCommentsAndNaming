using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class NullSubTag : ASubTag
    {
        public NullSubTag() : base(string.Empty)
        {
        }
        public override void Parse(XNode element)
        {
            this.Value = ((XText)element).Value;
        }
    }
}
