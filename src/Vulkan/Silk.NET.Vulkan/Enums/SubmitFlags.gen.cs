// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSubmitFlags")]
    public enum SubmitFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_SUBMIT_PROTECTED_BIT")]
        SubmitProtectedBit = 1,
        [NativeName("Name", "VK_SUBMIT_PROTECTED_BIT_KHR")]
        SubmitProtectedBitKhr = 1,
    }
}
