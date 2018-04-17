#define V_Float

namespace Void.Utilities
{
    public class Time
    {
        private static float _deltaTime;
        private static float _fixedDeltaTime;

        public static float ElapsedTime { get; set; }
        public static float ElapsedFixedTime { get; set; }
        
        public static float DeltaTime
        {
            get => _deltaTime * TimeScale;
            set => _deltaTime = value;
        }

        public static float FixedDeltaTime
        {
            get => _fixedDeltaTime * FixedTimeScale;
            set => _fixedDeltaTime = value;
        }

        public static float TimeScale = 1.0f;
        public static float FixedTimeScale = 1.0f;
    }
}
