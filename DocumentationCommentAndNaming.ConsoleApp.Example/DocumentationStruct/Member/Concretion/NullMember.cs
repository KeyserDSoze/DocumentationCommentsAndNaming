using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentationCommentAndNaming.DocumentationStruct.Member
{
    public class NullMember : AMember
    {
        public NullMember() : base(string.Empty) { }
        public override void Parse(XNode element)
        {
        }
    }
}
