using DocumentationCommentAndNaming.DocumentationStruct.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.DocumentationStruct
{
    public class MemberFactory
    {
        public static AMember CreateAMember(string type)
        {
            switch (type)
            {
                case "T":
                    return new Member.Type();
                case "M":
                    return new Method();
                case "P":
                    return new Property();
                case "F":
                    return new Field();
                case "E":
                    return new Event();
                default:
                    return new NullMember();
            }
        }
    }
}
