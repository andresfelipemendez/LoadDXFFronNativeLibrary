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

    [DllImport("ASimplePlugin")]
    private static extern int Hatches();
    
    [DllImport("ASimplePlugin")]
    private static extern IntPtr Array();

    void Start ()
    {
        float[] result = new float[5];
        Marshal.Copy((IntPtr)Array(), result, 0, 5);
        Debug.Log(result.Length);
        Debug.Log(result[0]);


        OpenFile(@"C:\Users\Len\Desktop\DXF\Assets\Resources\2000.dxf");
        Debug.Log(Marshal.PtrToStringAnsi(Path()));
        Debug.Log(Marshal.PtrToStringAnsi(GetStatus()));
        Debug.Log(Hatches());

        OpenFile(@"C:\Users\Len\Desktop\DXF\Assets\Resources\2004.dxf");
        Debug.Log(Marshal.PtrToStringAnsi(Path()));
        Debug.Log(Marshal.PtrToStringAnsi(GetStatus()));
        Debug.Log(Hatches());

        OpenFile(@"C:\Users\Len\Desktop\DXF\Assets\Resources\2007.dxf");
        Debug.Log(Marshal.PtrToStringAnsi(Path()));
        Debug.Log(Marshal.PtrToStringAnsi(GetStatus()));
        Debug.Log(Hatches());

        OpenFile(@"C:\Users\Len\Desktop\DXF\Assets\Resources\2010.dxf");
        Debug.Log(Marshal.PtrToStringAnsi(Path()));
        Debug.Log(Marshal.PtrToStringAnsi(GetStatus()));
        Debug.Log(Hatches());

        OpenFile(@"C:\Users\Len\Desktop\DXF\Assets\Resources\2013.dxf");
        Debug.Log(Marshal.PtrToStringAnsi(Path()));
        Debug.Log(Marshal.PtrToStringAnsi(GetStatus()));
        Debug.Log(Hatches());
    }
}
