using DocumentationCommentsAndNaming.Library.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentationCommentsAndNaming.Library.Base2
{
    ///<priority>2</priority>
    /// <summary>
    /// The main <c>Event</c> class contains all methods 
    /// for performing basic subscription events.
    /// </summary>
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
    /// <example>
    /// <code>
    /// Event event = new Event();
    /// event.Subscribe(1);
    /// event.Bill(1, 3.0);
    /// event.Notify(1);
    /// event.Unsubscribe(1);
    /// </code>
    /// </example>
    public class SecondEvent
    {
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and returns the result of subscription.
        /// </summary>
        /// <returns>
        /// The subscription code.
        /// </returns>
        /// <params>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        /// </params>
        /// <exceptions>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// </exceptions>
        /// <remarks>
        /// See <see cref="Event.Subscribe(int)"/> to perform a subscription.
        /// <seealso cref="Event.Unsubscribe(int)"/>
        /// <seealso cref="Event.Bill(int, float)"/>
        /// <seealso cref="Event.Notify(int, string)"/>
        /// </remarks>
        public int Subscribe(int userId) { return 3; }
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and returns the result of unsubscription.
        /// </summary>
        /// <returns>
        /// The unsubscription result.
        /// </returns>
        /// <params>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        /// </params>
        /// <exceptions>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// </exceptions>
        /// <remarks>
        /// See <see cref="Event.Unsubscribe(int)"/> to perform an unsubscription.
        /// <seealso cref="Event.Subscribe(int)"/>
        /// <seealso cref="Event.Bill(int, float)"/>
        /// <seealso cref="Event.Notify(int, string)"/>
        /// </remarks>
        public void Unsubscribe(int userId) { }
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and the amount to bill <paramref name="price"/> and returns the result of billing.
        /// </summary>
        /// <returns>
        /// The billing result.
        /// </returns>
        /// <params>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        /// <param name="price">Amount to bill the user.</param>
        /// </params>
        /// <exceptions>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// </exceptions>
        /// <remarks>
        /// See <see cref="Event.Bill(int, float)"/> to perform an unsubscription.
        /// <seealso cref="Event.Subscribe(int)"/>
        /// <seealso cref="Event.Unsubscribe(int)"/>
        /// <seealso cref="Event.Notify(int, string)"/>
        /// </remarks>
        public bool Bill(int userId, float price) { return true; }
        /// <summary>
        /// Pass an integer as <paramref name="userId"/> and a string to send to user <paramref name="message"/> and returns the result of unsubscription.
        /// </summary>
        /// <returns>
        /// The notification result.
        /// </returns>
        /// <params>
        /// <param name="userId">Id of CustomerBase to recognize the user.</param>
        /// <param name="message">String to send to user as notification.</param>
        /// </params>
        /// <exceptions>
        /// <exception cref="System.Exception">Thrown when one parameter is null or zero.</exception>
        /// </exceptions>
        /// <remarks>
        /// See <see cref="Event.Notify(int, string)"/> to perform a notification.
        /// <seealso cref="Event.Subscribe(int)"/>
        /// <seealso cref="Event.Bill(int, float)"/>
        /// <seealso cref="Event.Unsubscribe(int)"/>
        /// </remarks>
        public bool Notify(int userId, string message) { return true; }
    }
}
