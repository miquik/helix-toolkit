﻿using System;

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
    /// 
    /// </summary>
    public interface IGeometryBufferManager : IDisposable
    {
        int Count { get; }
        /// <summary>
        /// Registers the specified model unique identifier.
        /// </summary>
        /// <typeparam name="T">Geometry Buffer Type</typeparam>
        /// <param name="modelGuid">The model unique identifier.</param>
        /// <param name="geometry">The geometry.</param>
        /// <returns></returns>
        IGeometryBufferModel Register<T>(Guid modelGuid, Geometry3D geometry) where T : class, IGeometryBufferModel, new();
    }
}
