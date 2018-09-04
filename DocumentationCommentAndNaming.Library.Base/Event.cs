using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentAndNaming.Library.Base
{
    /// <summary>
    /// The main <c>Event</c> class contains all methods
    /// for performing basic subscription events.
    /// <list type="bullet">
    /// <item>
    /// <term>Subscribe</term>
    /// <description>Subscribe a User</description>
    /// </item>
    /// <item>
    /// <term>Unsubscribe</term>
    /// <description>Unsubscribe a User</description>
    /// </item>
    /// <item>
    /// <term>Bill</term>
    /// <description>Bill a User</description>
    /// </item>
    /// <item>
    /// <term>Notify</term>
    /// <description>Notify a User</description>
    /// </item>
    /// </list>
    /// <remarks>
    /// <para>This class can subscribe, unsubscribe, bill and notify a user.</para>
    /// <para>These operations can be performed everytime you want.</para>
    /// </remarks>
    /// </summary>
    /// <example>
    /// <code>
    /// Event event = new Event();
    /// event.Subscribe(1);
    /// event.Bill(1, 3.0);
    /// event.Notify(1);
    /// event.Unsubscribe(1);
    /// </code>
    /// </example>
    public class Event
    {
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and returns the result of subscription.
        /// </summary>
        /// <returns>
        /// The subscription code.
        /// </returns>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// See <see cref="Subscribe(int)"/> to perform a subscription.
        /// <seealso cref="Unsubscribe(int)"/>
        /// <seealso cref="Bill(int, float)"/>
        /// <seealso cref="Notify(int, string)"/>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        public int Subscribe(int userId) { return 3; }
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and returns the result of unsubscription.
        /// </summary>
        /// <returns>
        /// The unsubscription result.
        /// </returns>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// See <see cref="Unsubscribe(int)"/> to perform an unsubscription.
        /// <seealso cref="Subscribe(int)"/>
        /// <seealso cref="Bill(int, float)"/>
        /// <seealso cref="Notify(int, string)"/>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        public void Unsubscribe(int userId) { }
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and the amount to bill <paramref name="price"/> and returns the result of billing.
        /// </summary>
        /// <returns>
        /// The billing result.
        /// </returns>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// See <see cref="Bill(int, float)"/> to perform an unsubscription.
        /// <seealso cref="Subscribe(int)"/>
        /// <seealso cref="Unsubscribe(int)"/>
        /// <seealso cref="Notify(int, string)"/>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        /// <param name="price">Amount to bill the user.</param>
        public bool Bill(int userId, float price) { return true; }
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and a string to send to user <paramref name="message"/> and returns the result of unsubscription.
        /// </summary>
        /// <returns>
        /// The notification result.
        /// </returns>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// See <see cref="Notify(int, string)"/> to perform a notification.
        /// <seealso cref="Subscribe(int)"/>
        /// <seealso cref="Bill(int, float)"/>
        /// <seealso cref="Unsubscribe(int)"/>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        /// <param name="message">String to send to user as notification.</param>
        public bool Notify(int userId, string message) { return true; }
    }
}
