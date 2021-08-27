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
    namespace Model.Scene
    {
        using Core;
        /// <summary>
        /// 
        /// </summary>
        public sealed class DirectionalLightNode : LightNode
        {
            public Vector3 Direction
            {
                set { (RenderCore as DirectionalLightCore).Direction = value; }
                get { return (RenderCore as DirectionalLightCore).Direction; }
            }

            protected override RenderCore OnCreateRenderCore()
            {
                return new DirectionalLightCore();
            }
        }
    }

}
