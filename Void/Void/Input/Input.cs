using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Void.Input
{
    public static class Input
    {
        private struct KeyInfo
        {
            public Keys[] Keys;
            public bool IsDown;
            public bool WasDown;
        }
        private static Dictionary<string, KeyInfo> _keys = new Dictionary<string, KeyInfo>();

        public static void RegisterInput(string name, Keys[] keys)
        {
            _keys.Add(name, new KeyInfo()
            {
                Keys = keys,
                IsDown = false,
                WasDown = false
            });
        }

        public static void Update()
        {

        }

        public static bool IsButtonPressed(string name)
        {
            return _keys[name].IsDown && !_keys[name].WasDown;
        }

    }
}
