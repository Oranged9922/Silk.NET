// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE")]
    public enum RenderPassEndingAccessType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_DISCARD")]
        RenderPassEndingAccessTypeDiscard = 0x0,
        [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_PRESERVE")]
        RenderPassEndingAccessTypePreserve = 0x1,
        [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_RESOLVE")]
        RenderPassEndingAccessTypeResolve = 0x2,
        [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_TYPE_NO_ACCESS")]
        RenderPassEndingAccessTypeNoAccess = 0x3,
    }
}
