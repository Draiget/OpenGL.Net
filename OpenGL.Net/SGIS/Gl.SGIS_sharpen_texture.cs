
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
		/// [GL] Value of GL_LINEAR_SHARPEN_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_SGIS = 0x80AD;

		/// <summary>
		/// [GL] Value of GL_LINEAR_SHARPEN_ALPHA_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE;

		/// <summary>
		/// [GL] Value of GL_LINEAR_SHARPEN_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_COLOR_SGIS = 0x80AF;

		/// <summary>
		/// [GL] Value of GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;

		/// <summary>
		/// [GL] glSharpenTexFuncSGIS: Binding for glSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void SharpenTexFuncSGIS(TextureTarget target, int n, float[] points)
		{
			Debug.Assert(points.Length > 0 && (points.Length % 2) == 0, "empty or not multiple of 2");
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglSharpenTexFuncSGIS != null, "pglSharpenTexFuncSGIS not implemented");
					Delegates.pglSharpenTexFuncSGIS((int)target, n, p_points);
					LogCommand("glSharpenTexFuncSGIS", null, target, n, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glSharpenTexFuncSGIS: Binding for glSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void SharpenTexFuncSGIS(TextureTarget target, float[] points)
		{
			Debug.Assert(points.Length > 0 && (points.Length % 2) == 0, "empty or not multiple of 2");
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglSharpenTexFuncSGIS != null, "pglSharpenTexFuncSGIS not implemented");
					Delegates.pglSharpenTexFuncSGIS((int)target, points.Length / 2, p_points);
					LogCommand("glSharpenTexFuncSGIS", null, target, points.Length / 2, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetSharpenTexFuncSGIS: Binding for glGetSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void GetSharpenTexFuncSGIS(TextureTarget target, [Out] float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglGetSharpenTexFuncSGIS != null, "pglGetSharpenTexFuncSGIS not implemented");
					Delegates.pglGetSharpenTexFuncSGIS((int)target, p_points);
					LogCommand("glGetSharpenTexFuncSGIS", null, target, points					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_sharpen_texture")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glSharpenTexFuncSGIS(int target, int n, float* points);

			[RequiredByFeature("GL_SGIS_sharpen_texture")]
			[ThreadStatic]
			internal static glSharpenTexFuncSGIS pglSharpenTexFuncSGIS;

			[RequiredByFeature("GL_SGIS_sharpen_texture")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetSharpenTexFuncSGIS(int target, float* points);

			[RequiredByFeature("GL_SGIS_sharpen_texture")]
			[ThreadStatic]
			internal static glGetSharpenTexFuncSGIS pglGetSharpenTexFuncSGIS;

		}
	}

}
