using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public abstract class ASubTag : ATag
    {
        public ASubTag(string tag, params string[] attributes) : base(tag, attributes)
        {
        }
        public override string ToString()
        {
            Regex regex = new Regex(@"\s\s+");
            string creation = this.Value?.Replace('\n', ' ').Replace('\t', ' ');
            if (creation == null) creation = "";
            creation = regex.Replace(creation, " ");
            foreach (var attribute in this.Attributes)
            {
                if (string.IsNullOrWhiteSpace(attribute.Value)) continue;
                creation += "{" + attribute.Value + "}";
            }
            return creation;
        }
    }
}
