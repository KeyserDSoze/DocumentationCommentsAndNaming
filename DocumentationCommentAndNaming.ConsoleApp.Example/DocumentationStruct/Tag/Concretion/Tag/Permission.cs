using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Permission : ATag
    {
        public Permission() : base("permission", "cref")
        {
        }
        public override void WriteParagraph(ref DocX docX)
        {
            
        }
    }
}
