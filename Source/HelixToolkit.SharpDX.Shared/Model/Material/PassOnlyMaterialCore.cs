﻿/*
The MIT License (MIT)
Copyright (c) 2018 Helix Toolkit contributors
*/
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
    namespace Model
    {
        /// <summary>
        /// Vertex Normal Material
        /// </summary>
        public sealed class NormalMaterialCore : MaterialCore
        {
            public static readonly NormalMaterialCore Core = new NormalMaterialCore();

            public override MaterialVariable CreateMaterialVariables(IEffectsManager manager, IRenderTechnique technique)
            {
                return new PassOnlyMaterialVariable(DefaultPassNames.Normals, technique);
            }
        }
        /// <summary>
        /// Vertex Color Material
        /// </summary>
        public sealed class ColorMaterialCore : MaterialCore
        {
            public static readonly ColorMaterialCore Core = new ColorMaterialCore();
            public override MaterialVariable CreateMaterialVariables(IEffectsManager manager, IRenderTechnique technique)
            {
                return new PassOnlyMaterialVariable(DefaultPassNames.Colors, technique);
            }
        }
        /// <summary>
        /// Vertex Position Material
        /// </summary>
        public sealed class PositionMaterialCore : MaterialCore
        {
            public static readonly PositionMaterialCore Core = new PositionMaterialCore();
            public override MaterialVariable CreateMaterialVariables(IEffectsManager manager, IRenderTechnique technique)
            {
                return new PassOnlyMaterialVariable(DefaultPassNames.Positions, technique);
            }
        }
        /// <summary>
        /// Vertex Normal Vector Material
        /// </summary>
        public sealed class NormalVectorMaterialCore : MaterialCore
        {
            public static readonly NormalVectorMaterialCore Core = new NormalVectorMaterialCore();
            public override MaterialVariable CreateMaterialVariables(IEffectsManager manager, IRenderTechnique technique)
            {
                return new PassOnlyMaterialVariable(DefaultPassNames.NormalVector, technique);
            }
        }
    }

}
