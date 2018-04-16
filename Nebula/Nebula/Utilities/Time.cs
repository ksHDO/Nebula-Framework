namespace Nebula.Utilities
{
    public class Time
    {
        private static double _deltaTime;
        private static double _fixedDeltaTime;

        public static double DeltaTime
        {
            get => _deltaTime * TimeScale;
            set => _deltaTime = value;
        }

        public static double FixedDeltaTime
        {
            get => _fixedDeltaTime * FixedTimeScale;
            set => _fixedDeltaTime = value;
        }

        public static double TimeScale;
        public static double FixedTimeScale;
    }
}
