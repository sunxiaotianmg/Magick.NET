// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.
// <auto-generated/>
#nullable enable

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace ImageMagick
{
    public partial class MagickGeometry
    {
        [SuppressUnmanagedCodeSecurity]
        private static unsafe class NativeMethods
        {
            #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
            public static class X64
            {
                #if PLATFORM_AnyCPU
                static X64() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickGeometry_Create();
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickGeometry_Dispose(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_X_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_Y_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_Width_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_Height_Get(IntPtr instance);
                [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr MagickGeometry_Initialize(IntPtr Instance, IntPtr value);
            }
            #endif
            #if PLATFORM_x86 || PLATFORM_AnyCPU
            public static class X86
            {
                #if PLATFORM_AnyCPU
                static X86() { NativeLibraryLoader.Load(); }
                #endif
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern IntPtr MagickGeometry_Create();
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern void MagickGeometry_Dispose(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_X_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_Y_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_Width_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern double MagickGeometry_Height_Get(IntPtr instance);
                [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
                public static extern UIntPtr MagickGeometry_Initialize(IntPtr Instance, IntPtr value);
            }
            #endif
        }
        private unsafe sealed class NativeMagickGeometry : NativeInstance
        {
            static NativeMagickGeometry() { Environment.Initialize(); }
            protected override void Dispose(IntPtr instance)
            {
                #if PLATFORM_AnyCPU
                if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                NativeMethods.X64.MagickGeometry_Dispose(instance);
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                NativeMethods.X86.MagickGeometry_Dispose(instance);
                #endif
            }
            public NativeMagickGeometry()
            {
                #if PLATFORM_AnyCPU
                if (OperatingSystem.Is64Bit)
                #endif
                #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                Instance = NativeMethods.X64.MagickGeometry_Create();
                #endif
                #if PLATFORM_AnyCPU
                else
                #endif
                #if PLATFORM_x86 || PLATFORM_AnyCPU
                Instance = NativeMethods.X86.MagickGeometry_Create();
                #endif
                if (Instance == IntPtr.Zero)
                    throw new InvalidOperationException();
            }
            public NativeMagickGeometry(IntPtr instance)
            {
                Instance = instance;
            }
            protected override string TypeName
            {
                get
                {
                    return nameof(MagickGeometry);
                }
            }
            public double X
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickGeometry_X_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickGeometry_X_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Y
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickGeometry_Y_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickGeometry_Y_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Width
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickGeometry_Width_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickGeometry_Width_Get(Instance);
                    #endif
                    return result;
                }
            }
            public double Height
            {
                get
                {
                    double result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickGeometry_Height_Get(Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickGeometry_Height_Get(Instance);
                    #endif
                    return result;
                }
            }
            public GeometryFlags Initialize(string? value)
            {
                using (var valueNative = UTF8Marshaler.CreateInstance(value))
                {
                    UIntPtr result;
                    #if PLATFORM_AnyCPU
                    if (OperatingSystem.Is64Bit)
                    #endif
                    #if PLATFORM_x64 || PLATFORM_arm64 || PLATFORM_AnyCPU
                    result = NativeMethods.X64.MagickGeometry_Initialize(Instance, valueNative.Instance);
                    #endif
                    #if PLATFORM_AnyCPU
                    else
                    #endif
                    #if PLATFORM_x86 || PLATFORM_AnyCPU
                    result = NativeMethods.X86.MagickGeometry_Initialize(Instance, valueNative.Instance);
                    #endif
                    return (GeometryFlags)result;
                }
            }
        }
        internal static MagickGeometry? CreateInstance(IntPtr instance)
        {
            if (instance == IntPtr.Zero)
                return null;
            using (NativeMagickGeometry nativeInstance = new NativeMagickGeometry(instance))
            {
                return new MagickGeometry(nativeInstance);
            }
        }
    }
}
