using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Shop.Automation.Framework
{
    public class AssertException
    {
        /// <summary>
        ///     Verifies that the exact exception is thrown (and not a derived exception type).
        /// </summary>
        /// <typeparam name="T">The type of the exception expected to be thrown</typeparam>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static T Throws<T>(Action testCode)
            where T : Exception
        {
            return (T)Throws(typeof(T), RecordException(testCode));
        }

        /// <summary>
        ///     Verifies that the exact exception is thrown (and not a derived exception type).
        ///     Generally used to test property accessors.
        /// </summary>
        /// <typeparam name="T">The type of the exception expected to be thrown</typeparam>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static T Throws<T>(Func<object> testCode)
            where T : Exception
        {
            return (T)Throws(typeof(T), RecordException(testCode));
        }


        /// <summary>
        ///     Verifies that the exact exception or a derived exception type is thrown.
        /// </summary>
        /// <typeparam name="T">The type of the exception expected to be thrown</typeparam>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static T ThrowsAny<T>(Action testCode)
            where T : Exception
        {
            return (T)ThrowsAny(typeof(T), RecordException(testCode));
        }

        /// <summary>
        ///     Verifies that the exact exception or a derived exception type is thrown.
        ///     Generally used to test property accessors.
        /// </summary>
        /// <typeparam name="T">The type of the exception expected to be thrown</typeparam>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static T ThrowsAny<T>(Func<object> testCode)
            where T : Exception
        {
            return (T)ThrowsAny(typeof(T), RecordException(testCode));
        }

        /// <summary>
        ///     Verifies that the exact exception is thrown (and not a derived exception type).
        /// </summary>
        /// <param name="exceptionType">The type of the exception expected to be thrown</param>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static Exception Throws(Type exceptionType, Action testCode)
        {
            return Throws(exceptionType, RecordException(testCode));
        }

        private static Exception RecordException(Action testCode)
        {
            GuardArgumentNotNull("testCode", testCode);
            try
            {
                testCode();
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }

        }

        internal static void GuardArgumentNotNull(string argName, object argValue)
        {
            if (argValue == null)
                throw new ArgumentNullException(argName);
        }

        protected static Exception RecordException(Func<object> testCode)
        {

            GuardArgumentNotNull("testCode", testCode);
            Task task;


            try
            {
                task = testCode() as Task;
            }
            catch (Exception ex)
            {
                return ex;
            }


            if (task != null)
                throw new InvalidOperationException("You must call Assert.ThrowsAsync, Assert.DoesNotThrowAsync, or Record.ExceptionAsync when testing async code.");


            return null;
        }

        /// <summary>
        ///     Verifies that the exact exception is thrown (and not a derived exception type).
        ///     Generally used to test property accessors.
        /// </summary>
        /// <param name="exceptionType">The type of the exception expected to be thrown</param>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static Exception Throws(Type exceptionType, Func<object> testCode)
        {
            return Throws(exceptionType, RecordException(testCode));
        }

        private static Exception Throws(Type exceptionType, Exception exception)
        {
            GuardArgumentNotNull("exceptionType", exceptionType);

            if (exception == null)
            {
                throw new ThrowsException(exceptionType);
            }

            if (!exceptionType.Equals(exception.GetType()))
            {
                throw new ThrowsException(exceptionType, exception);
            }

            return exception;
        }

        private static Exception ThrowsAny(Type exceptionType, Exception exception)
        {
            GuardArgumentNotNull("exceptionType", exceptionType);

            if (exception == null)
            {
                throw new ThrowsException(exceptionType);
            }

            if (!exceptionType.GetTypeInfo().IsAssignableFrom(exception.GetType().GetTypeInfo()))
            {
                throw new ThrowsException(exceptionType, exception);
            }

            return exception;
        }

        /// <summary>
        ///     Verifies that the exact exception is thrown (and not a derived exception type), where the exception
        ///     derives from <see cref="ArgumentException" /> and has the given parameter name.
        /// </summary>
        /// <param name="paramName">The parameter name that is expected to be in the exception</param>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static T Throws<T>(string paramName, Action testCode)
            where T : ArgumentException
        {
            var ex = Throws<T>(testCode);
            Assert.AreEqual(paramName, ex.ParamName);
            return ex;
        }

        /// <summary>
        ///     Verifies that the exact exception is thrown (and not a derived exception type), where the exception
        ///     derives from <see cref="ArgumentException" /> and has the given parameter name.
        /// </summary>
        /// <param name="paramName">The parameter name that is expected to be in the exception</param>
        /// <param name="testCode">A delegate to the code to be tested</param>
        /// <returns>The exception that was thrown, when successful</returns>
        /// <exception cref="ThrowsException">
        ///     Thrown when an exception was not thrown, or when an exception of the incorrect type
        ///     is thrown
        /// </exception>
        public static T Throws<T>(string paramName, Func<object> testCode)
            where T : ArgumentException
        {
            var ex = Throws<T>(testCode);
            Assert.AreEqual(paramName, ex.ParamName);
            return ex;
        }
    }
}
