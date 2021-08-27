﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
//#define TEST

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
    namespace Core
    {
        using Render;
        using Shaders;
        /// <summary>
        /// Do a depth prepass before rendering.
        /// <para>Must customize the DefaultEffectsManager and set DepthStencilState to DefaultDepthStencilDescriptions.DSSDepthEqualNoWrite in default ShaderPass from EffectsManager to achieve best performance.</para>
        /// </summary>
        public sealed class DepthPrepassCore : RenderCore
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DepthPrepassCore"/> class.
            /// </summary>
            public DepthPrepassCore() : base(RenderType.PreProc)
            {
            }

            /// <summary>
            /// Called when [render].
            /// </summary>
            /// <param name="context">The context.</param>
            /// <param name="deviceContext">The device context.</param>
            public override void Render(RenderContext context, DeviceContextProxy deviceContext)
            {
                context.CustomPassName = DefaultPassNames.DepthPrepass;
                for (int i = 0; i < context.RenderHost.PerFrameOpaqueNodesInFrustum.Count; ++i)
                {
                    context.RenderHost.PerFrameOpaqueNodesInFrustum[i].RenderDepth(context, deviceContext, null);
                }
            }

            protected override bool OnAttach(IRenderTechnique technique)
            {
                return true;
            }
        }
    }

}
