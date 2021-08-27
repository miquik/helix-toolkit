﻿using HelixToolkit.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#if !NETFX_CORE && !NET5_0
namespace HelixToolkit.Wpf.SharpDX
#else
#if CORE
namespace HelixToolkit.SharpDX.Core
#elif WINUI
namespace HelixToolkit.WinUI
#else
namespace TT.HelixToolkit.UWP
#endif
#endif
{
    /// <summary>
    /// Custom Texture loading IO interface.
    /// </summary>
    public interface ITexturePathResolver
    {
        /// <summary>
        /// Resolves the texture path.
        /// </summary>
        /// <param name="modelPath">The model path.</param>
        /// <param name="texturePath">The texture path.</param>
        /// <param name="logger">The logger.</param>
        /// <returns>Absolute file path for the texture</returns>
        string Resolve(string modelPath, string texturePath, ILogger logger);
    }
}
