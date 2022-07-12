﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSafetyApp.Helpers
{
    public static class EventExtensions
    {
        public static void Invoke<T>(this EventHandler<EventArgs<T>> handler, object sender, T value)
        {
            var handle = handler;
            if (handle != null)
            {
                handle(sender, new EventArgs<T>(value));
            }
        }

        public static bool TryInvoke<T>(this EventHandler<T> handler, object sender, T args) where T : EventArgs
        {
            var handle = handler;
            if (handle != null)
            {
                handle(sender, args);
                return true;
            }

            return false;
        }
    }
}
