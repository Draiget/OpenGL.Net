
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] glXCopyBufferSubDataNV: Binding for glXCopyBufferSubDataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="writeTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_copy_buffer")]
		public static void CopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, uint size)
		{
			Debug.Assert(Delegates.pglXCopyBufferSubDataNV != null, "pglXCopyBufferSubDataNV not implemented");
			Delegates.pglXCopyBufferSubDataNV(dpy, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
			LogCommand("glXCopyBufferSubDataNV", null, dpy, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLX] glXNamedCopyBufferSubDataNV: Binding for glXNamedCopyBufferSubDataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="readBuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="writeBuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_copy_buffer")]
		public static void NamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, uint size)
		{
			Debug.Assert(Delegates.pglXNamedCopyBufferSubDataNV != null, "pglXNamedCopyBufferSubDataNV not implemented");
			Delegates.pglXNamedCopyBufferSubDataNV(dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
			LogCommand("glXNamedCopyBufferSubDataNV", null, dpy, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_NV_copy_buffer")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glXCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, uint size);

			[RequiredByFeature("GLX_NV_copy_buffer")]
			internal static glXCopyBufferSubDataNV pglXCopyBufferSubDataNV;

			[RequiredByFeature("GLX_NV_copy_buffer")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glXNamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, uint size);

			[RequiredByFeature("GLX_NV_copy_buffer")]
			internal static glXNamedCopyBufferSubDataNV pglXNamedCopyBufferSubDataNV;

		}
	}

}
