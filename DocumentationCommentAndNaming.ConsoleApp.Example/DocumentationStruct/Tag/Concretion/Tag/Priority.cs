using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Priority : ATag
    {
        public Priority() : base("priority")
        {
        }
        public override void WriteParagraph(ref DocX docX)
        {
        }
    }
}
