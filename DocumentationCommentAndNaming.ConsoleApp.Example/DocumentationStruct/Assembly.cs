using DocumentationCommentAndNaming.DocumentationStruct.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.DocumentationStruct
{
    public class Assembly
    {
        public string Name { get; set; }
        public List<AMember> Members { get; set; } = new List<AMember>();
    }
}
