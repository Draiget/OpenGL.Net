
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
		/// [GL] Value of GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D;

		/// <summary>
		/// [GL] Value of GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E;

		/// <summary>
		/// [GL] Value of GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F;

		/// <summary>
		/// [GL] Value of GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF;

		/// <summary>
		/// [GL] glAlphaToCoverageDitherControlNV: Binding for glAlphaToCoverageDitherControlNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public static void AlphaToCoverageDitherControlNV(int mode)
		{
			Debug.Assert(Delegates.pglAlphaToCoverageDitherControlNV != null, "pglAlphaToCoverageDitherControlNV not implemented");
			Delegates.pglAlphaToCoverageDitherControlNV(mode);
			LogCommand("glAlphaToCoverageDitherControlNV", null, mode			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glAlphaToCoverageDitherControlNV(int mode);

			[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
			[ThreadStatic]
			internal static glAlphaToCoverageDitherControlNV pglAlphaToCoverageDitherControlNV;

		}
	}

}
