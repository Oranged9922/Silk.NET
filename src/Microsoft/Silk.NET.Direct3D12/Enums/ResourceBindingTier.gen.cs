// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER")]
    public enum ResourceBindingTier : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_1")]
        ResourceBindingTier1 = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_2")]
        ResourceBindingTier2 = 0x2,
        [NativeName("Name", "D3D12_RESOURCE_BINDING_TIER_3")]
        ResourceBindingTier3 = 0x3,
    }
}
