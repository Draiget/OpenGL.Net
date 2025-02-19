
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
		/// [GL] glCopyTextureLevelsAPPLE: Binding for glCopyTextureLevelsAPPLE.
		/// </summary>
		/// <param name="destinationTexture">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="sourceTexture">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="sourceBaseLevel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sourceLevelCount">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_copy_texture_levels", Api = "gles1|gles2")]
		public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount)
		{
			Debug.Assert(Delegates.pglCopyTextureLevelsAPPLE != null, "pglCopyTextureLevelsAPPLE not implemented");
			Delegates.pglCopyTextureLevelsAPPLE(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
			LogCommand("glCopyTextureLevelsAPPLE", null, destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_copy_texture_levels", Api = "gles1|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount);

			[RequiredByFeature("GL_APPLE_copy_texture_levels", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glCopyTextureLevelsAPPLE pglCopyTextureLevelsAPPLE;

		}
	}

}
