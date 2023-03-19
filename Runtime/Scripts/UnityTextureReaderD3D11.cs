using System;
using System.Runtime.InteropServices;


namespace UnityTextureReaderD3D
{
    public static class UnityTextureReaderD3D11
    {
        // Name of the native DLL file that this C# code is interfacing with
        const string nativeDLL = "UnityTextureReaderD3D11";

        // Loads the native Unity plugin with the provided Unity interfaces pointer
        [DllImport(nativeDLL)]
        public static extern void UnityPluginLoad(IntPtr unityInterfaces);

        // Retrieves pixel data from a Unity texture and returns a pointer to it
        [DllImport(nativeDLL)]
        public static extern IntPtr GetPixelDataFromTexture(IntPtr texturePtr);

        // Frees memory allocated for pixel data previously retrieved with GetPixelDataFromTexture
        [DllImport(nativeDLL)]
        public static extern void FreePixelData(IntPtr pixelDataPtr);

        // Inverts the colors of a block of pixel data in place
        [DllImport(nativeDLL)]
        public static extern void InvertColors(IntPtr pixelData, int width, int height);
    }

}

