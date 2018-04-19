using System;
using System.Diagnostics;

namespace Void.Debugging
{
    public class Debug
    {
        [Conditional("DEBUG")]
        public static void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        [Conditional("DEBUG")]
        public static void Log(object value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }

        #region DoInDebug

        /// <summary>
        /// Does an action only in debug mode.
        /// </summary>
        /// <param name="action">The action to perform.</param>
        [Conditional("DEBUG")]
        public static void DoInDebug(Action action) => action();

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        [Conditional("DEBUG")]
        public static void DoInDebug<T>(Action<T> action, T arg1) => action(arg1);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2) => action(arg1, arg2);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) =>
            action(arg1, arg2, arg3);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        [Conditional("DEBUG")]
        public static void
            DoInDebug<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) =>
            action(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Does an action only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action">The action.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3,
            T4 arg4, T5 arg5) => action(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1,
            T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <param name="action">The action.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
            T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <param name="action">The action to perform.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <remarks>
        /// You might want to reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <param name="action">The action.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <remarks>
        /// You should probably reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <param name="action">The action.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="arg15">The arg15.</param>
        /// <remarks>
        /// You should probably reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13,
            T14 arg14, T15 arg15) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Does an action with the passed parameters only in debug mode.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <param name="action">The action.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        /// <param name="arg3">The arg3.</param>
        /// <param name="arg4">The arg4.</param>
        /// <param name="arg5">The arg5.</param>
        /// <param name="arg6">The arg6.</param>
        /// <param name="arg7">The arg7.</param>
        /// <param name="arg8">The arg8.</param>
        /// <param name="arg9">The arg9.</param>
        /// <param name="arg10">The arg10.</param>
        /// <param name="arg11">The arg11.</param>
        /// <param name="arg12">The arg12.</param>
        /// <param name="arg13">The arg13.</param>
        /// <param name="arg14">The arg14.</param>
        /// <param name="arg15">The arg15.</param>
        /// <param name="arg16">The arg16.</param>
        /// <remarks>
        /// You should probably reconsider your architecture if you're passing in more than 5 parameters...
        /// </remarks>
        [Conditional("DEBUG")]
        public static void DoInDebug<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 arg1, T2 arg2,
            T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13,
            T14 arg14, T15 arg15, T16 arg16) =>
            action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15,
                arg16);

        #endregion

    }
}
