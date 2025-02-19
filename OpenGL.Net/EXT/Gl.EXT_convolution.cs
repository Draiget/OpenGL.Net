
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] glGetConvolutionFilterEXT: Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTarget target, PixelFormat format, PixelType type, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetConvolutionFilterEXT != null, "pglGetConvolutionFilterEXT not implemented");
			Delegates.pglGetConvolutionFilterEXT((int)target, (int)format, (int)type, image);
			LogCommand("glGetConvolutionFilterEXT", null, target, format, type, image			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetConvolutionFilterEXT: Binding for glGetConvolutionFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionFilterEXT(ConvolutionTarget target, PixelFormat format, PixelType type, object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetConvolutionFilterEXT(target, format, type, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// [GL] glGetConvolutionParameterfvEXT: Binding for glGetConvolutionParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTarget target, ConvolutionParameterEXT pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterfvEXT != null, "pglGetConvolutionParameterfvEXT not implemented");
					Delegates.pglGetConvolutionParameterfvEXT((int)target, (int)pname, p_params);
					LogCommand("glGetConvolutionParameterfvEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetConvolutionParameterivEXT: Binding for glGetConvolutionParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetConvolutionParameterEXT(ConvolutionTarget target, ConvolutionParameterEXT pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterivEXT != null, "pglGetConvolutionParameterivEXT not implemented");
					Delegates.pglGetConvolutionParameterivEXT((int)target, (int)pname, p_params);
					LogCommand("glGetConvolutionParameterivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetSeparableFilterEXT: Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTarget target, PixelFormat format, PixelType type, IntPtr row, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetSeparableFilterEXT != null, "pglGetSeparableFilterEXT not implemented");
			Delegates.pglGetSeparableFilterEXT((int)target, (int)format, (int)type, row, column, span);
			LogCommand("glGetSeparableFilterEXT", null, target, format, type, row, column, span			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetSeparableFilterEXT: Binding for glGetSeparableFilterEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_convolution")]
		public static void GetSeparableFilterEXT(SeparableTarget target, PixelFormat format, PixelType type, object row, object column, object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetSeparableFilterEXT(target, format, type, pin_row.AddrOfPinnedObject(), pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_EXT_convolution")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetConvolutionFilterEXT(int target, int format, int type, IntPtr image);

			[RequiredByFeature("GL_EXT_convolution")]
			[ThreadStatic]
			internal static glGetConvolutionFilterEXT pglGetConvolutionFilterEXT;

			[RequiredByFeature("GL_EXT_convolution")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetConvolutionParameterfvEXT(int target, int pname, float* @params);

			[RequiredByFeature("GL_EXT_convolution")]
			[ThreadStatic]
			internal static glGetConvolutionParameterfvEXT pglGetConvolutionParameterfvEXT;

			[RequiredByFeature("GL_EXT_convolution")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetConvolutionParameterivEXT(int target, int pname, int* @params);

			[RequiredByFeature("GL_EXT_convolution")]
			[ThreadStatic]
			internal static glGetConvolutionParameterivEXT pglGetConvolutionParameterivEXT;

			[RequiredByFeature("GL_EXT_convolution")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetSeparableFilterEXT(int target, int format, int type, IntPtr row, IntPtr column, IntPtr span);

			[RequiredByFeature("GL_EXT_convolution")]
			[ThreadStatic]
			internal static glGetSeparableFilterEXT pglGetSeparableFilterEXT;

		}
	}

}
