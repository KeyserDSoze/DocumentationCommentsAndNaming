using DocumentationCommentAndNaming.DocumentationStruct.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DocumentationCommentAndNaming.DocumentationStruct
{
    public class Documentation
    {
        public Dictionary<string, Assembly> Pages = new Dictionary<string, Assembly>();
        public string Title{ get; set; }
        public void Parse(string uri)
        {
            this.Title = uri.Split('\\').LastOrDefault().Replace(".xml", "");
            XDocument xml = XDocument.Load(uri);
            foreach(XElement element in xml.Descendants("member"))
            {
                string[] memberName = element.Attribute("name").Value.Split(':');
                AMember member = MemberFactory.CreateAMember(memberName[0]);
                member.SetAssemblyName(memberName[1]);
                member.Parse(element);
                bool isNew = true;
                foreach (KeyValuePair<string, Assembly> keyValue in this.Pages)
                {
                    foreach(AMember aMember in keyValue.Value.Members)
                    {
                        if (member.AssemblyName.Contains(aMember.AssemblyName + "." + aMember.Name))
                        {
                            isNew = false;
                            aMember.Members.Add(member);
                        }
                    }
                }
                if (isNew)
                {
                    if (!this.Pages.ContainsKey(member.AssemblyName)) this.Pages.Add(member.AssemblyName, new Assembly() { Name = member.AssemblyName });
                    this.Pages[member.AssemblyName].Members.Add(member);
                }
            }
        }
    }
}
