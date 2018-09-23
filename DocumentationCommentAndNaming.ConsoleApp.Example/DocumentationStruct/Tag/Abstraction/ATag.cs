using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public abstract class ATag : ICloneable
    {
        protected Regex regexWhiteSpace = new Regex(@"\s\s+");
        public Dictionary<string, string> Attributes = new Dictionary<string, string>();
        public List<ASubTag> Tags = new List<ASubTag>();
        public string Value { get; set; }
        private string Tag;
        public ATag(string tag, params string[] attributes)
        {
            this.Tag = tag;
            foreach (string attribute in attributes) if (attribute != string.Empty && !this.Attributes.ContainsKey(attribute)) this.Attributes.Add(attribute, "");
        }
        public virtual void Parse(XNode element)
        {
            List<string> attributesKey = this.Attributes.Select(x => x.Key).ToList();
            foreach (string attribute in attributesKey) this.Attributes[attribute] = ((XElement)element).Attribute(attribute)?.Value;
            foreach(XNode subElement in ((XElement)element).Nodes())
            {
                ASubTag tag = TagFactory.CreateASubTag(subElement is XElement ? ((XElement)subElement).Name.LocalName : string.Empty);
                tag.Parse(subElement);
                this.Tags.Add(tag);
            }
        }
        public virtual void WriteParagraph(ref DocX docX)
        {
            Regex regex = new Regex(@"\s\s+");
            string value = this.Value?.Replace('\n', ' ').Replace('\t', ' ');
            if (value == null) value = "";
            value = regex.Replace(value, " ");
            foreach (var attribute in this.Attributes)
            {
                if (string.IsNullOrWhiteSpace(attribute.Value)) continue;
                value += "{" + attribute.Value + "}";
            }
            foreach (ASubTag subTag in this.Tags)
            {
                value += subTag.ToString();
            }
            value = value.Trim();
            if (!string.IsNullOrWhiteSpace(value)) docX.InsertParagraph($"{value}", false, new Formatting() { Size = 12 });
        }
        public object Clone()
        {
            return this.MemberwiseClone();   
        }
    }
}
