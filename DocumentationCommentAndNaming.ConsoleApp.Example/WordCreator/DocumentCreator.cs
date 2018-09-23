using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.DocumentationStruct
{
    public class DocumentCreator
    {
        private string ProjectPath;
        public DocumentCreator(string projectPath)
        {
            this.ProjectPath = projectPath.Trim('\\');
        }
        public string Title
        {
            get
            {
                return this.ProjectPath.Split('\\').Last();
            }
        }
        public List<Documentation> GetAllDocuments()
        {
            List<Documentation> documentations = new List<Documentation>();
            foreach(string uri in this.FindUri(this.ProjectPath))
            {
                Documentation documentation = new Documentation();
                documentation.Parse(uri);
                documentations.Add(documentation);
            }
            return documentations;
        }
        private List<string> FindUri(string path)
        {
            List<string> xmlUris = new List<string>();
            foreach(DirectoryInfo di in new DirectoryInfo(path).GetDirectories())
            {
                if (di.Name.ToLower().Equals("debug"))
                {
                    foreach(FileInfo fi in di.GetFiles())
                    {
                        if (fi.Name.Contains(".xml"))
                        {
                            xmlUris.Add(fi.FullName);
                        }
                    }
                }
                else
                {
                    xmlUris = xmlUris.Concat(this.FindUri(di.FullName)).ToList();
                }
            }
            return xmlUris;
        }
    }
}
