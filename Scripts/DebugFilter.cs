/**********************************************************
// Author   : K.(k79k06k02k)
// FileName : DebugFilter.cs
// Reference: http://liangyenchen.blogspot.tw/2015/09/unity3d-debuglog.html
**********************************************************/
#if DEBUG_FILTER

using System.Diagnostics;
using UnityEngine;

public static class Debug
{
    [Conditional("DEBUG_FILTER")]
    public static void Break() { }
    [Conditional("DEBUG_FILTER")]
    public static void ClearDeveloperConsole() { }
    [Conditional("DEBUG_FILTER")]
    public static void DebugBreak() { }

    [Conditional("DEBUG_FILTER")]
    public static void DrawLine(Vector3 start, Vector3 end) { }
    [Conditional("DEBUG_FILTER")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color) { }
    [Conditional("DEBUG_FILTER")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }
    [Conditional("DEBUG_FILTER")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }

    [Conditional("DEBUG_FILTER")]
    public static void DrawRay(Vector3 start, Vector3 dir) { }
    [Conditional("DEBUG_FILTER")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }
    [Conditional("DEBUG_FILTER")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }
    [Conditional("DEBUG_FILTER")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

    [Conditional("DEBUG_FILTER")]
    public static void Log(object message) { }
    [Conditional("DEBUG_FILTER")]
    public static void Log(object message, Object context) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogFormat(string format, params object[] args) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogFormat(Object context, string format, params object[] args) { }

    [Conditional("DEBUG_FILTER")]
    public static void LogWarning(object message) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogWarning(object message, Object context) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogWarningFormat(string format, params object[] args) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogWarningFormat(Object context, string format, params object[] args) { }

    [Conditional("DEBUG_FILTER")]
    public static void LogError(object message) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogError(object message, Object context) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogErrorFormat(string format, params object[] args) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogErrorFormat(Object context, string format, params object[] args) { }

    [Conditional("DEBUG_FILTER")]
    public static void LogException(System.Exception exception) { }
    [Conditional("DEBUG_FILTER")]
    public static void LogException(System.Exception exception, Object context) { }
}
#endif