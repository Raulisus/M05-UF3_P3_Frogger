﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Frogger
{
    public static class TimeManager
    {
        public static uint frameCount { get; private set; }
        public static double time { get; private set; }
        public static double deltaTime { get; private set; }
        public static Stopwatch timer { get; private set; } = new Stopwatch();

        public static void NextFrame()
        {
            timer.Stop();
            deltaTime = timer.Elapsed.TotalMilliseconds / 1000.0;
            time += deltaTime;
            frameCount++;
            timer.Restart();
            Thread.Sleep(200);
        }
    }
}