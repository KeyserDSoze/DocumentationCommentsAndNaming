using DocumentationCommentAndNaming.DocumentationStruct.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentationCommentAndNaming.DocumentationStruct.Member
{
    public abstract class AMember
    {
        private string Type;
        public string AssemblyName { get; private set; }
        public string Name { get; set; }
        public string ReturnValue { get; set; }
        public List<AMember> Members { get; set; } = new List<AMember>();
        public List<ATag> Tags { get; set; } = new List<ATag>();
        public int Priority
        {
            get
            {
                try
                {
                    return int.Parse(this.Tags.Find(x => x is Tag.Priority).Tags.First().Value);
                }
                catch { }
                return 1000;
            }
        }
        public AMember(string type)
        {
            this.Type = type;
        }
        public virtual void Parse(XNode element)
        {
            foreach (XNode subElement in ((XElement)element).Nodes())
            {
                ATag tag = TagFactory.CreateATag(subElement is XElement ? ((XElement)subElement).Name.LocalName : string.Empty);
                tag.Parse(subElement);
                this.Tags.Add(tag);
            }
        }
        public void SetAssemblyName(string name)
        {
            Regex regex = new Regex(@"\([^\)]*\)");
            this.ReturnValue = regex.Match(name)?.Value;
            List<string> names = regex.Replace(name, "").Trim().Split('.').ToList();
            this.AssemblyName = string.Join(".", names.Take(names.Count - 1));
            this.Name = names.LastOrDefault();
            
        }
    }
}
