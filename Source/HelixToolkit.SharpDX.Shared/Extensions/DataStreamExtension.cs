﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
using SharpDX;


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
    public static class DataStreamExtension
    {
        public static int ReadInt(this DataStream ds)
        {
            return ds.Read<int>();
        }

        public static float ReadFloat(this DataStream ds)
        {
            return ds.Read<float>();
        }

        public static Vector4 ReadVector4(this DataStream ds)
        {
            return ds.Read<Vector4>();
        }

        public static Matrix ReadMatrix(this DataStream ds)
        {
            return ds.Read<Matrix>();
        }
    }
}
