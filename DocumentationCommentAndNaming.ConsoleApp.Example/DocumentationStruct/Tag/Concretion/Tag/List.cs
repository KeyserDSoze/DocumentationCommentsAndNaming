using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class List : ATag
    {
        public List() : base("list", "type")
        {
        }
        public override void Parse(XNode element)
        {
            //foreach(XElement elem in ((XElement)element).Descendants("item"))
            //{
            //}
        }
        public override void WriteParagraph(ref DocX docX)
        {
            
        }
    }
}
