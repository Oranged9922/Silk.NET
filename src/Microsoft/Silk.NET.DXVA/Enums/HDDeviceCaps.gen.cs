// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [Flags]
    [NativeName("Name", "_DXVAHD_DEVICE_CAPS")]
    public enum HDDeviceCaps : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "DXVAHD_DEVICE_CAPS_LINEAR_SPACE")]
        HDDeviceCapsLinearSpace = 0x1,
        [NativeName("Name", "DXVAHD_DEVICE_CAPS_xvYCC")]
        HDDeviceCapsXvYcc = 0x2,
        [NativeName("Name", "DXVAHD_DEVICE_CAPS_RGB_RANGE_CONVERSION")]
        HDDeviceCapsRgbRangeConversion = 0x4,
        [NativeName("Name", "DXVAHD_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION")]
        HDDeviceCapsYCbCrMatrixConversion = 0x8,
    }
}
