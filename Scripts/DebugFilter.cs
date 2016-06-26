/**********************************************************
// Author   : K.(k79k06k02k)
// FileName : DebugFilter.cs
// Reference: http://liangyenchen.blogspot.tw/2015/09/unity3d-debuglog.html
**********************************************************/
#if DebugFilter

using System.Diagnostics;
using UnityEngine;

public static class Debug
{
    [Conditional("DebugFilter")]
    public static void Break() { }
    [Conditional("DebugFilter")]
    public static void ClearDeveloperConsole() { }
    [Conditional("DebugFilter")]
    public static void DebugBreak() { }
    [Conditional("DebugFilter")]
    public static void DrawLine(Vector3 start, Vector3 end) { }
    [Conditional("DebugFilter")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color) { }
    [Conditional("DebugFilter")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) { }
    [Conditional("DebugFilter")]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) { }
    [Conditional("DebugFilter")]
    public static void DrawRay(Vector3 start, Vector3 dir) { }
    [Conditional("DebugFilter")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color) { }
    [Conditional("DebugFilter")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) { }
    [Conditional("DebugFilter")]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) { }

    [Conditional("DebugFilter")]
    public static void Log(object message) { }
    [Conditional("DebugFilter")]
    public static void Log(object message, UnityEngine.Object context) { }
    [Conditional("DebugFilter")]
    public static void LogError(object message) { }
    [Conditional("DebugFilter")]
    public static void LogError(object message, UnityEngine.Object context) { }
    [Conditional("DebugFilter")]
    public static void LogException(System.Exception exception) { }
    [Conditional("DebugFilter")]
    public static void LogException(System.Exception exception, UnityEngine.Object context) { }
    [Conditional("DebugFilter")]
    public static void LogWarning(object message) { }
    [Conditional("DebugFilter")]
    public static void LogWarning(object message, UnityEngine.Object context) { }
}
#endif