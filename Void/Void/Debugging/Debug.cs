using System.Diagnostics;

namespace Void.Debug
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

    }
}
