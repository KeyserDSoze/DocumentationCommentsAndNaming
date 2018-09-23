using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentationCommentAndNaming.DocumentationStruct.Tag
{
    public class Params : ATag
    {
        public Params() : base("params")
        {
            this.colorDescription = Color.DarkGray;
            this.colorTitle = Color.DarkBlue;
        }
        public override void WriteParagraph(ref DocX docX)
        {
            Paragraph paragraph = docX.InsertParagraph($"Parameters: ", false, new Formatting() { Size = this.sizeTitle, FontColor = this.colorTitle, Bold = true });
            paragraph.IndentationBefore = this.Indentation;
            Table table = docX.AddTable(this.Tags.Sum(x => x.Tags.Count) + 1, 2);
            table.Alignment = Alignment.center;
            table.Design = TableDesign.LightGridAccent1;
            table.SetWidthsPercentage(new float[2] { 20.0f, 80.0f }, 400.0f);
            table.Rows[0].Cells[0].Paragraphs.First().Append("Name", new Formatting() { Italic = true, Bold = true, Size = this.sizeTitle });
            table.Rows[0].Cells[1].Paragraphs.First().Append("Description", new Formatting() { Bold = true, Size = this.sizeTitle });
            int totTable = 0;
            foreach (var subTag in this.Tags)
            {
                int tot = 0;
                foreach (var paramTag in subTag.Tags)
                {
                    //docX.InsertParagraph("Param {" + subTag.Attributes.ElementAt(tot).Value + "} is: " + $"{regexWhiteSpace.Replace(paramTag.Value, "")}", false, new Formatting() { Size = this.sizeTitle, FontColor = this.colorDescription });
                    table.Rows[totTable + 1].Cells[0].Paragraphs.First().Append(subTag.Attributes.ElementAt(tot).Value, new Formatting() { Italic = true, Size = this.sizeDescription });
                    table.Rows[totTable + 1].Cells[1].Paragraphs.First().Append(regexWhiteSpace.Replace(paramTag.Value, ""), new Formatting() { Size = this.sizeDescription });
                    tot++;
                    totTable++;
                }
            }
            docX.InsertTable(table);
        }
    }
}
