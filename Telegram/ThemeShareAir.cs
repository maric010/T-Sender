using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram
{
    public static class ThemeShareAir
    {
        public delegate void AnimationDelegate(bool invalidate);

        private static int Frames;

        private static bool Invalidate;

        public static PrecisionTimerAir ThemeTimer = new PrecisionTimerAir();

        private const int FPS = 50;

        private const int Rate = 10;

        private static readonly List<AnimationDelegate> Callbacks = new List<AnimationDelegate>();

        private static void HandleCallbacksAir(IntPtr state, bool reserve)
        {
            Invalidate = (Frames >= 50);
            if (Invalidate)
            {
                Frames = 0;
            }

            lock (Callbacks)
            {
                for (int i = 0; i <= Callbacks.Count - 1; i++)
                {
                    Callbacks[i](Invalidate);
                }
            }

            Frames += 10;
        }

        private static void InvalidateThemeTimer()
        {
            if (Callbacks.Count == 0)
            {
                ThemeTimer.Delete();
            }
            else
            {
                ThemeTimer.Create(0u, 10u, HandleCallbacksAir);
            }
        }

        public static void AddAnimationCallback(AnimationDelegate callback)
        {
            lock (Callbacks)
            {
                if (!Callbacks.Contains(callback))
                {
                    Callbacks.Add(callback);
                    InvalidateThemeTimer();
                }
            }
        }

        public static void RemoveAnimationCallback(AnimationDelegate callback)
        {
            lock (Callbacks)
            {
                if (Callbacks.Contains(callback))
                {
                    Callbacks.Remove(callback);
                    InvalidateThemeTimer();
                }
            }
        }
    }
}
