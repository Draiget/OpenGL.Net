
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
		/// [EGL] Value of EGL_MAX_STREAM_METADATA_BLOCKS_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int MAX_STREAM_METADATA_BLOCKS_NV = 0x3250;

		/// <summary>
		/// [EGL] Value of EGL_MAX_STREAM_METADATA_BLOCK_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int MAX_STREAM_METADATA_BLOCK_SIZE_NV = 0x3251;

		/// <summary>
		/// [EGL] Value of EGL_MAX_STREAM_METADATA_TOTAL_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int MAX_STREAM_METADATA_TOTAL_SIZE_NV = 0x3252;

		/// <summary>
		/// [EGL] Value of EGL_PRODUCER_METADATA_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int PRODUCER_METADATA_NV = 0x3253;

		/// <summary>
		/// [EGL] Value of EGL_CONSUMER_METADATA_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int CONSUMER_METADATA_NV = 0x3254;

		/// <summary>
		/// [EGL] Value of EGL_PENDING_METADATA_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int PENDING_METADATA_NV = 0x3328;

		/// <summary>
		/// [EGL] Value of EGL_METADATA0_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA0_SIZE_NV = 0x3255;

		/// <summary>
		/// [EGL] Value of EGL_METADATA1_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA1_SIZE_NV = 0x3256;

		/// <summary>
		/// [EGL] Value of EGL_METADATA2_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA2_SIZE_NV = 0x3257;

		/// <summary>
		/// [EGL] Value of EGL_METADATA3_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA3_SIZE_NV = 0x3258;

		/// <summary>
		/// [EGL] Value of EGL_METADATA0_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA0_TYPE_NV = 0x3259;

		/// <summary>
		/// [EGL] Value of EGL_METADATA1_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA1_TYPE_NV = 0x325A;

		/// <summary>
		/// [EGL] Value of EGL_METADATA2_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA2_TYPE_NV = 0x325B;

		/// <summary>
		/// [EGL] Value of EGL_METADATA3_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA3_TYPE_NV = 0x325C;

		/// <summary>
		/// [EGL] eglSetStreamMetadataNV: Binding for eglSetStreamMetadataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public static bool SetStreamNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSetStreamMetadataNV != null, "peglSetStreamMetadataNV not implemented");
			retValue = Delegates.peglSetStreamMetadataNV(dpy, stream, n, offset, size, data);
			LogCommand("eglSetStreamMetadataNV", retValue, dpy, stream, n, offset, size, data			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] eglQueryStreamMetadataNV: Binding for eglQueryStreamMetadataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public static bool QueryStreamNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data)
		{
			bool retValue;

			Debug.Assert(Delegates.peglQueryStreamMetadataNV != null, "peglQueryStreamMetadataNV not implemented");
			retValue = Delegates.peglQueryStreamMetadataNV(dpy, stream, name, n, offset, size, data);
			LogCommand("eglQueryStreamMetadataNV", retValue, dpy, stream, name, n, offset, size, data			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("EGL_NV_stream_metadata")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool eglSetStreamMetadataNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data);

			[RequiredByFeature("EGL_NV_stream_metadata")]
			internal static eglSetStreamMetadataNV peglSetStreamMetadataNV;

			[RequiredByFeature("EGL_NV_stream_metadata")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool eglQueryStreamMetadataNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data);

			[RequiredByFeature("EGL_NV_stream_metadata")]
			internal static eglQueryStreamMetadataNV peglQueryStreamMetadataNV;

		}
	}

}
