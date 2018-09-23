using DocumentationCommentAndNaming.DocumentationStruct;
using DocumentationCommentAndNaming.DocumentationStruct.Member;
using DocumentationCommentAndNaming.DocumentationStruct.Tag;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.WordCreator
{
    public class WordDocument
    {
        private Color baseColor = Color.DarkSlateGray;
        DocX doc;
        public void CreateDocument(string projectPath)
        {
            DocumentCreator documentCreator = new DocumentCreator(projectPath);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            List<Documentation> documentations = documentCreator.GetAllDocuments();
            this.doc = DocX.Create(path + @"\" + documentCreator.Title + ".docx");
            doc.InsertParagraph($"{documentCreator.Title}", false, new Formatting() { Size = 26, FontColor = baseColor });
            doc.InsertSectionPageBreak(true);
            int capitol = 1;
            foreach (Documentation documentation in documentations)
            {
                doc.InsertParagraph($"{capitol} - {documentation.Title.Replace(documentCreator.Title,"").Trim('.')}", false, new Formatting() { Size = 22 });
                doc.InsertParagraph(" ", false, new Formatting() { Size = 40 });
                int subCapitol = 1;
                foreach (KeyValuePair<string, Assembly> assembly in documentation.Pages.OrderBy(x => x.Value.Members.OrderBy(y => y.Priority).First().Priority))
                {
                    doc.InsertParagraph($"{capitol}.{subCapitol} - {assembly.Value.Members.First().Name}", false, new Formatting() { Size = 20 });
                    doc.InsertParagraph($"Namespace: {assembly.Value.Name}", false, new Formatting() { Size = 14, FontColor = Color.DarkGray });
                    foreach (AMember member in assembly.Value.Members.OrderBy(x => x.Priority)) WriteMember(member, false);
                    doc.InsertParagraph(" ", false, new Formatting() { Size = 24 });
                    subCapitol++;
                }
                if (capitol < documentations.Count) doc.InsertSectionPageBreak(true);
                capitol++;
            }
            doc.Save();
        }
        public void WriteMember(AMember member, bool inner)
        {
            if (inner) doc.InsertParagraph($"{member.GetType().Name}: {member.Name}", false, new Formatting() { Size = 18 });
            if (!string.IsNullOrWhiteSpace(member.ReturnValue)) doc.InsertParagraph($"Return values: {member.ReturnValue}", false, new Formatting() { Size = 12, FontColor = Color.DarkViolet });
            foreach (ATag tag in member.Tags)
            {
                tag.WriteParagraph(ref doc);
            }
            foreach (AMember aMember in member.Members) WriteMember(aMember, true);
            doc.InsertParagraph(" ", false, new Formatting() { Size = !inner ? 10 : 20 });
        }
    }
}
