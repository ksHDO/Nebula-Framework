using System;

namespace Void.Utilities
{
    public static class Mathf
    {
        private static Random _random = new Random();

        public static void SetSeed(int seed)
        {
            _random = new Random(seed);
        }


    }
}