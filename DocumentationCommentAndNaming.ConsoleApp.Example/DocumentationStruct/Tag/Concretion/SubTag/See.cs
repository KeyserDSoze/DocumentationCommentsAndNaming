using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class See : ASubTag
    {
        public See() : base("see", "cref")
        {
        }
        public override string ToString()
        {
            return this.Attributes.First().Value + " : " + this.Value;
        }
    }
}
