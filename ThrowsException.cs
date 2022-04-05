using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Shop.Automation.Framework
{
    public class ThrowsException : AssertFailedException
    {
        private readonly string _stackTrace;

        /// <summary>
        ///     Creates a new instance of the <see cref="ThrowsException" /> class. Call this constructor
        ///     when no exception was thrown.
        /// </summary>
        /// <param name="expectedType">The type of the exception that was expected</param>
        public ThrowsException(Type expectedType)
            : this(expectedType, "(No exception was thrown)", null, null) { }

        /// <summary>
        ///     Creates a new instance of the <see cref="ThrowsException" /> class. Call this constructor
        ///     when an exception of the wrong type was thrown.
        /// </summary>
        /// <param name="expectedType">The type of the exception that was expected</param>
        /// <param name="actual">The actual exception that was thrown</param>
        public ThrowsException(Type expectedType, Exception actual)
            : this(expectedType, actual.GetType().Name, actual.Message, actual.StackTrace) { }

        /// <summary>
        ///     THIS CONSTRUCTOR IS FOR UNIT TESTING PURPOSES ONLY.
        /// </summary>
        protected ThrowsException(Type expected, string actual, string actualMessage, string stackTrace) : base(CreateMessage(expected, actual, actualMessage))
        {
            _stackTrace = stackTrace;
        }

        /// <summary>
        ///     Gets a string representation of the frames on the call stack at the time the current exception was thrown.
        /// </summary>
        /// <returns>A string that describes the contents of the call stack, with the most recent method call appearing first.</returns>
        public override string StackTrace => _stackTrace ?? base.StackTrace;

        /// <summary>Gets a message that describes the current exception.</summary>
        /// <returns>A message describing the exception.</returns>
        public static string CreateMessage(Type expected, string actual, string actualMessage)
        {
            return $"Assert.Throws() Failure\n{actual} was not of type  {expected.Name}. {actualMessage}";
        }
    }
}