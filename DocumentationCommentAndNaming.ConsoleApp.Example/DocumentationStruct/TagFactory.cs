using DocumentationCommentAndNaming.DocumentationStruct.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.DocumentationStruct
{
    public class TagFactory
    {
        public static ATag CreateATag(string tag)
        {
            switch (tag)
            {
                case "example": return new Example();
                case "exceptions": return new Tag.Exceptions();
                case "list": return new List();
                case "params": return new Params();
                case "permission": return new Permission();
                case "priority": return new Priority();
                case "remarks": return new Remarks();
                case "returns": return new Returns();
                case "summary": return new Summary();
                case "value": return new Value();
                default: return new NullTag();
            }
        }
        public static ASubTag CreateASubTag(string tag)
        {
            switch (tag)
            {
                case "c": return new C();
                case "code": return new Code();
                case "exception": return new Tag.Exception();
                case "para": return new Para();
                case "param": return new Param();
                case "paramref": return new Paramref();
                case "see": return new See();
                case "seealso": return new SeeAlso();
                case "typeparam": return new TypeParam();
                case "typeparamref": return new TypeParamRef();
                default: return new NullSubTag();
            }
        }
    }
}
