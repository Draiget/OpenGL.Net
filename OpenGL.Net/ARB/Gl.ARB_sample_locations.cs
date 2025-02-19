
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
		/// [GL] Value of GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;

		/// <summary>
		/// [GL] Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;

		/// <summary>
		/// [GL] Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;

		/// <summary>
		/// [GL] glFramebufferSampleLocationsfvARB: Binding for glFramebufferSampleLocationsfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		public static void FramebufferSampleLocationARB(FramebufferTarget target, uint start, int count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvARB != null, "pglFramebufferSampleLocationsfvARB not implemented");
					Delegates.pglFramebufferSampleLocationsfvARB((int)target, start, count, p_v);
					LogCommand("glFramebufferSampleLocationsfvARB", null, target, start, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glNamedFramebufferSampleLocationsfvARB: Binding for glNamedFramebufferSampleLocationsfvARB.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		public static void NamedFramebufferSampleLocationARB(uint framebuffer, uint start, int count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvARB != null, "pglNamedFramebufferSampleLocationsfvARB not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvARB(framebuffer, start, count, p_v);
					LogCommand("glNamedFramebufferSampleLocationsfvARB", null, framebuffer, start, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glEvaluateDepthValuesARB: Binding for glEvaluateDepthValuesARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		public static void EvaluateDepthValuesARB()
		{
			Debug.Assert(Delegates.pglEvaluateDepthValuesARB != null, "pglEvaluateDepthValuesARB not implemented");
			Delegates.pglEvaluateDepthValuesARB();
			LogCommand("glEvaluateDepthValuesARB", null			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glFramebufferSampleLocationsfvARB(int target, uint start, int count, float* v);

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvARB pglFramebufferSampleLocationsfvARB;

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, float* v);

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvARB pglNamedFramebufferSampleLocationsfvARB;

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glEvaluateDepthValuesARB();

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glEvaluateDepthValuesARB pglEvaluateDepthValuesARB;

		}
	}

}
