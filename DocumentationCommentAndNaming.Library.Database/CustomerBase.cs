using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentsAndNaming.Library.Database
{
    /// <summary>
    /// The main <c>CustomerBase</c> class contains all methods
    /// to get and manage User
    /// </summary>
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
        /// <summary>
        /// Retrieve user from DB.
        /// </summary>
        /// <returns>
        /// Nothing but populate this class.
        /// </returns>
        /// <exceptions>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// </exceptions>
        /// <remarks>
        /// See <see cref="Get()"/> to perform a retrieve.
        /// <seealso cref="Update()"/>
        /// </remarks>
        public void Get()
        {
            this.UserId = 1;
        }
        /// <summary>
        /// Save user on DB.
        /// </summary>
        /// <returns>
        /// Nothing.
        /// </returns>
        /// <exceptions>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// </exceptions>
        /// <remarks>
        /// See <see cref="Update()"/> to perform an update on DB.
        /// <seealso cref="Get()"/>
        /// </remarks>
        public void Update()
        {
            Console.WriteLine("Save in DB");
        }
    }
}
