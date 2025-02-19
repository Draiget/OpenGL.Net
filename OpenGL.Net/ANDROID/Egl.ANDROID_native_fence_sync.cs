
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_SYNC_NATIVE_FENCE_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_ANDROID = 0x3144;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_NATIVE_FENCE_FD_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_FD_ANDROID = 0x3145;

		/// <summary>
		/// [EGL] Value of EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_SIGNALED_ANDROID = 0x3146;

		/// <summary>
		/// [EGL] Value of EGL_NO_NATIVE_FENCE_FD_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int NO_NATIVE_FENCE_FD_ANDROID = -1;

		/// <summary>
		/// [EGL] eglDupNativeFenceFDANDROID: Binding for eglDupNativeFenceFDANDROID.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public static int DupNativeFenceANDROID(IntPtr dpy, IntPtr sync)
		{
			int retValue;

			Debug.Assert(Delegates.peglDupNativeFenceFDANDROID != null, "peglDupNativeFenceFDANDROID not implemented");
			retValue = Delegates.peglDupNativeFenceFDANDROID(dpy, sync);
			LogCommand("eglDupNativeFenceFDANDROID", retValue, dpy, sync			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

			[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
			internal static eglDupNativeFenceFDANDROID peglDupNativeFenceFDANDROID;

		}
	}

}
