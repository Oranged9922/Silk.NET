// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ClipPlaneName")]
    public enum ClipPlaneName : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_CLIP_PLANE0")]
        ClipPlane0 = 0x3000,
        [NativeName("Name", "GL_CLIP_DISTANCE0")]
        ClipDistance0 = 0x3000,
        [System.Obsolete]
        [NativeName("Name", "GL_CLIP_PLANE1")]
        ClipPlane1 = 0x3001,
        [NativeName("Name", "GL_CLIP_DISTANCE1")]
        ClipDistance1 = 0x3001,
        [System.Obsolete]
        [NativeName("Name", "GL_CLIP_PLANE2")]
        ClipPlane2 = 0x3002,
        [NativeName("Name", "GL_CLIP_DISTANCE2")]
        ClipDistance2 = 0x3002,
        [System.Obsolete]
        [NativeName("Name", "GL_CLIP_PLANE3")]
        ClipPlane3 = 0x3003,
        [NativeName("Name", "GL_CLIP_DISTANCE3")]
        ClipDistance3 = 0x3003,
        [System.Obsolete]
        [NativeName("Name", "GL_CLIP_PLANE4")]
        ClipPlane4 = 0x3004,
        [NativeName("Name", "GL_CLIP_DISTANCE4")]
        ClipDistance4 = 0x3004,
        [System.Obsolete]
        [NativeName("Name", "GL_CLIP_PLANE5")]
        ClipPlane5 = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE5")]
        ClipDistance5 = 0x3005,
        [NativeName("Name", "GL_CLIP_DISTANCE6")]
        ClipDistance6 = 0x3006,
        [NativeName("Name", "GL_CLIP_DISTANCE7")]
        ClipDistance7 = 0x3007,
    }
}
