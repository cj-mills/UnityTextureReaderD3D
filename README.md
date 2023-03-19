# UnityTextureReaderD3D

UnityTextureReaderD3D is a plugin package for Unity that enables easy access to pixel data from Direct3D11 and Direct3D12 textures. The package includes native plugins for both APIs, providing efficient texture reading without the need for additional scripts or workarounds.

## Features

- Supports Direct3D11 and Direct3D12 textures.
- Efficient and easy-to-use native plugins.
- Compatible with Unity game engine.

## Getting Started

### Prerequisites

- Unity game engine (compatible with Direct3D11 and Direct3D12)

### Installation

You can install the UnityTextureReaderD3D package using the Unity Package Manager:

1. Open your Unity project.
2. Go to Window > Package Manager.
3. Click the "+" button in the top left corner, and choose "Add package from git URL..."
4. Enter the GitHub repository URL: `https://github.com/cj-mills/UnityTextureReaderD3D.git`
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
using UnityEngine.Rendering;
using UnityTextureReaderD3D;

public class TextureReaderExample : MonoBehaviour
{
    private ITexturePixelDataReaderD3D _texturePixelDataReaderD3D;

    private void Start()
    {
        if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D11)
        {
            _texturePixelDataReaderD3D = new Direct3D11TexturePixelDataReader();
        }
        else if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D12)
        {
            _texturePixelDataReaderD3D = new Direct3D12TexturePixelDataReader();
        }
    }

    private void ReadPixels(Texture2D texture)
    {
        IntPtr pixelDataPtr = _texturePixelDataReaderD3D.GetPixelDataFromTexture(texture.GetNativeTexturePtr());

        if (pixelDataPtr != IntPtr.Zero)
        {
            // Process pixel data...

            _texturePixelDataReaderD3D.FreePixelData(pixelDataPtr);
        }
    }
}
```



## Contributing

If you would like to contribute to this project, please feel free to submit a pull request or open an issue on the repository.



## License

This project is licensed under the MIT License. See the [LICENSE](Documentation~/LICENSE) file for details.
