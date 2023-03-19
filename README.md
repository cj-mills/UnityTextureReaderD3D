# UnityTextureReaderD3D

UnityTextureReaderD3D is a plugin package for Unity that enables easy access to pixel data from DirectX 11 and DirectX 12 textures. The package includes native plugins for both APIs, providing efficient texture reading without the need for additional scripts or workarounds.

## Features

- Supports DirectX 11 and DirectX 12 textures.
- Efficient and easy-to-use native plugins.
- Compatible with Unity game engine.

## Getting Started

### Prerequisites

- Unity game engine (compatible with DirectX 11 and DirectX 12)

### Installation

You can install the UnityTextureReaderD3D package using the Unity Package Manager:

1. Open your Unity project.
2. Go to Window > Package Manager.
3. Click the "+" button in the top left corner, and choose "Add package from git URL..."
4. Enter the GitHub repository URL, for example: `https://github.com/cj-mills/UnityTextureReaderD3D.git`
5. Click "Add". The package will be added to your project.

For Unity versions older than 2021.1, add the Git URL to the `manifest.json` file in your project's `Packages` folder as a dependency:

```json
{
  "dependencies": {
    "com.cj-mills.unitytexturereaderd3d": "https://github.com/cj-mills/UnityTextureReaderD3D.git",
    // other dependencies...
  }
}
```



### Usage

The UnityTextureReaderD3D package provides two native plugins: UnityTextureReaderD3D11 and UnityTextureReaderD3D12, and C# scripts to interact with the plugin functions. The appropriate script will be automatically chosen based on your Unity project's rendering pipeline.

Here's an example of how to use the package:


```c#
using UnityEngine;

public class TextureReaderExample : MonoBehaviour
{
    private ITexturePixelDataAccessor _texturePixelDataAccessor;

    private void Start()
    {
        if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D11)
        {
            _texturePixelDataAccessor = new DirectX11TexturePixelDataAccessor();
        }
        else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D12)
        {
            _texturePixelDataAccessor = new DirectX12TexturePixelDataAccessor();
        }
    }

    private void ReadPixels(Texture2D texture)
    {
        IntPtr pixelDataPtr = _texturePixelDataAccessor.GetPixelDataFromTexture(texture.GetNativeTexturePtr());

        if (pixelDataPtr != IntPtr.Zero)
        {
            // Process pixel data...

            _texturePixelDataAccessor.FreePixelData(pixelDataPtr);
        }
    }
}
```



## Contributing

If you would like to contribute to this project, please feel free to submit a pull request or open an issue on the repository.



## License

This project is licensed under the MIT License. See the [LICENSE](./LICENSE) file for details.
