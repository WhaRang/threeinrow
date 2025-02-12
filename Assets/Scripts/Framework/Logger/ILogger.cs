﻿using System;

namespace Framework.Logger
{
    public interface ILogger
    {
        public void Log(String message);
        public void LogError(String message);
        public void LogWarning(String message);
    }
}