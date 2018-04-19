#define V_Float

namespace Void.Utilities
{
    public class Time
    {
        private static float _deltaTime;
        private static float _fixedDeltaTime;

        public static float ElapsedTime { get; set; }
        public static float ElapsedFixedTime { get; set; }

        /// <summary>
        /// The elapsed time between the previous frame and this frame.
        /// </summary>
        /// <value>
        /// The delta time.
        /// </value>
        public static float DeltaTime
        {
            get => _deltaTime * TimeScale;
            set => _deltaTime = value;
        }

        /// <summary>
        /// The elapsed time between the previous render frame and this frame.
        /// </summary>
        /// <value>
        /// The fixed delta time.
        /// </value>
        public static float FixedDeltaTime
        {
            get => _fixedDeltaTime * FixedTimeScale;
            set => _fixedDeltaTime = value;
        }

        public static float TimeScale { get; set; }= 1.0f;
        public static float FixedTimeScale { get; set; }= 1.0f;
    }
}
