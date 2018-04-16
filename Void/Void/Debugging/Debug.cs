using System.Diagnostics;

namespace Void.Debug
{
    public class Debug
    {
        [Conditional("DEBUG")]
        public void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

    }
}
