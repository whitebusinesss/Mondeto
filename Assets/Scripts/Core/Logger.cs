using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Mondeto.Core
{

public class Logger
{
    public enum LogType
    {
        Debug, Log, Error
    }

    public struct LogEntry
    {
        public readonly LogType Type;
        public readonly string Component;
        public readonly string Message;

        public LogEntry(LogType type, string component, string message)
        {
            Type = type;
            Component = component;
            Message = message;
        }
    }

    public delegate void LogHandler(LogType type, string component, string msg);
    public static event LogHandler OnLog;

    static ConcurrentQueue<LogEntry> queue = new();

    static Dictionary<LogType, string> TypeString = new Dictionary<LogType, String> {
        { LogType.Debug, "DBG" },
        { LogType.Log, "LOG" },
        { LogType.Error, "ERR" }
    };

    public static string LogTypeToString(LogType type) => TypeString[type];

    public static void Write(LogType type, string component, string msg)
    {
        if (OnLog == null)
        {
            // Store log entries when output is not available
            queue.Enqueue(new LogEntry(type, component, msg));
        }
        else
        {
            // Write stored log entries
            LogEntry entry;
            while (queue.TryDequeue(out entry))
            {
                OnLog?.Invoke(entry.Type, entry.Component, entry.Message);
            }

            // New log entry is directly written
            OnLog?.Invoke(type, component, msg);
        }
    }
    
    public static void Debug(string component, string msg) => Write(LogType.Debug, component, msg);
    public static void Log(string component, string msg) => Write(LogType.Log, component, msg);
    public static void Error(string component, string msg) => Write(LogType.Error, component, msg);
}

} // end namespace