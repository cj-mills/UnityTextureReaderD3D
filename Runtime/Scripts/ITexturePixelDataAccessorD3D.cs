using System;


namespace UnityTextureReaderD3D
{
    /// <summary>
    /// ITexturePixelDataReaderD3D is an interface that defines methods for reading pixel data from a Unity texture.
    /// </summary>
    public interface ITexturePixelDataReaderD3D
    {
        /// <summary>
        /// GetPixelDataFromTexture retrieves pixel data from a Unity texture and returns a pointer to it.
        /// </summary>
        /// <param name="texturePtr">A pointer to the Unity texture.</param>
        /// <returns>A pointer to the pixel data.</returns>
        IntPtr GetPixelDataFromTexture(IntPtr texturePtr);

        /// <summary>
        /// FreePixelData frees memory allocated for pixel data previously retrieved with GetPixelDataFromTexture.
        /// </summary>
        /// <param name="pixelDataPtr">A pointer to the previously retrieved pixel data.</param>
        void FreePixelData(IntPtr pixelDataPtr);
    }

    /// <summary>
    /// Direct3D11TexturePixelDataReader is a class that implements the ITexturePixelDataReaderD3D interface for Direct3D11.
    /// </summary>
    public class Direct3D11TexturePixelDataReader : ITexturePixelDataReaderD3D
    {
        /// <summary>
        /// GetPixelDataFromTexture retrieves pixel data from a Unity texture and returns a pointer to it.
        /// </summary>
        /// <param name="texturePtr">A pointer to the Unity texture.</param>
        /// <returns>A pointer to the pixel data.</returns>
        public IntPtr GetPixelDataFromTexture(IntPtr texturePtr)
        {
            return UnityTextureReaderD3D11.GetPixelDataFromTexture(texturePtr);
        }

        /// <summary>
        /// FreePixelData frees memory allocated for pixel data previously retrieved with GetPixelDataFromTexture.
        /// </summary>
        /// <param name="pixelDataPtr">A pointer to the previously retrieved pixel data.</param>
        public void FreePixelData(IntPtr pixelDataPtr)
        {
            UnityTextureReaderD3D11.FreePixelData(pixelDataPtr);
        }
    }

    /// <summary>
    /// Direct3D12TexturePixelDataAccessor is a class that implements the ITexturePixelDataReaderD3D interface for Direct3D12.
    /// </summary>
    public class Direct3D12TexturePixelDataAccessor : ITexturePixelDataReaderD3D
    {
        /// <summary>
        /// GetPixelDataFromTexture retrieves pixel data from a Unity texture and returns a pointer to it.
        /// </summary>
        /// <param name="texturePtr">A pointer to the Unity texture.</param>
        /// <returns>A pointer to the pixel data.</returns>
        public IntPtr GetPixelDataFromTexture(IntPtr texturePtr)
        {
            return UnityTextureReaderD3D12.GetPixelDataFromTexture(texturePtr);
        }

        /// <summary>
        /// FreePixelData frees memory allocated for pixel data previously retrieved with GetPixelDataFromTexture.
        /// </summary>
        /// <param name="pixelDataPtr">A pointer to the previously retrieved pixel data.</param>
        public void FreePixelData(IntPtr pixelDataPtr)
        {
            UnityTextureReaderD3D12.FreePixelData(pixelDataPtr);
        }
    }

}



