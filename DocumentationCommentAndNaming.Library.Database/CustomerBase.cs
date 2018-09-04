using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.Library.Database
{
    /// <summary>
    /// The main <c>CustomerBase</c> class contains all methods
    /// to get and manage User
    /// <list type="bullet">
    /// <item>
    /// <term>Get</term>
    /// <description>Subscribe a User</description>
    /// </item>
    /// <item>
    /// <term>Update</term>
    /// <description>Unsubscribe a User</description>
    /// </item>
    /// </list>
    /// <remarks>
    /// <para>This class manages user in DB.</para>
    /// <para>These operations can be performed everytime you want.</para>
    /// </remarks>
    /// </summary>
    /// <example>
    /// <code>
    /// CustomerBase customerBase = new CustomerBase();
    /// customerBase.Get();
    /// customerBase.Update();
    /// </code>
    /// </example>
    public class CustomerBase
    {
        public int UserId { get; set; }
        public void Get()
        {
            this.UserId = 1;
        }
        public void Update()
        {
            Console.WriteLine("Save in DB");
        }
    }
}
