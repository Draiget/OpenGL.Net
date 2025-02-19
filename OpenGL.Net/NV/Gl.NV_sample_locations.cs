
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
		/// [GL] glFramebufferSampleLocationsfvNV: Binding for glFramebufferSampleLocationsfvNV.
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
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public static void FramebufferSampleLocationNV(FramebufferTarget target, uint start, int count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvNV != null, "pglFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglFramebufferSampleLocationsfvNV((int)target, start, count, p_v);
					LogCommand("glFramebufferSampleLocationsfvNV", null, target, start, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glNamedFramebufferSampleLocationsfvNV: Binding for glNamedFramebufferSampleLocationsfvNV.
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
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public static void NamedFramebufferSampleLocationNV(uint framebuffer, uint start, int count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvNV != null, "pglNamedFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvNV(framebuffer, start, count, p_v);
					LogCommand("glNamedFramebufferSampleLocationsfvNV", null, framebuffer, start, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glResolveDepthValuesNV: Binding for glResolveDepthValuesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public static void ResolveDepthValuesNV()
		{
			Debug.Assert(Delegates.pglResolveDepthValuesNV != null, "pglResolveDepthValuesNV not implemented");
			Delegates.pglResolveDepthValuesNV();
			LogCommand("glResolveDepthValuesNV", null			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glFramebufferSampleLocationsfvNV(int target, uint start, int count, float* v);

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvNV pglFramebufferSampleLocationsfvNV;

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glNamedFramebufferSampleLocationsfvNV(uint framebuffer, uint start, int count, float* v);

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvNV pglNamedFramebufferSampleLocationsfvNV;

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glResolveDepthValuesNV();

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glResolveDepthValuesNV pglResolveDepthValuesNV;

		}
	}

}
