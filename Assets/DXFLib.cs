using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class DXFLib : MonoBehaviour
{
    [DllImport("ASimplePlugin", CallingConvention = CallingConvention.Cdecl)]
    private static extern void OpenFile(string path);

    [DllImport("ASimplePlugin")]
    private static extern IntPtr Path();
    
    [DllImport("ASimplePlugin")]
    private static extern IntPtr GetStatus();


    void Start ()
    {
        OpenFile(Application.dataPath);
        Debug.Log(Marshal.PtrToStringAnsi(Path()));
        Debug.Log(Marshal.PtrToStringAnsi(GetStatus()));
    }
}
