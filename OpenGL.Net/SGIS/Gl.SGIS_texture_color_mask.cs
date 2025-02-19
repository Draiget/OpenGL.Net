
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
		/// [GL] Value of GL_TEXTURE_COLOR_WRITEMASK_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_color_mask")]
		public const int TEXTURE_COLOR_WRITEMASK_SGIS = 0x81EF;

		/// <summary>
		/// [GL] glTextureColorMaskSGIS: Binding for glTextureColorMaskSGIS.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_color_mask")]
		public static void TextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglTextureColorMaskSGIS != null, "pglTextureColorMaskSGIS not implemented");
			Delegates.pglTextureColorMaskSGIS(red, green, blue, alpha);
			LogCommand("glTextureColorMaskSGIS", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_texture_color_mask")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTextureColorMaskSGIS([MarshalAs(UnmanagedType.I1)] bool red, [MarshalAs(UnmanagedType.I1)] bool green, [MarshalAs(UnmanagedType.I1)] bool blue, [MarshalAs(UnmanagedType.I1)] bool alpha);

			[RequiredByFeature("GL_SGIS_texture_color_mask")]
			[ThreadStatic]
			internal static glTextureColorMaskSGIS pglTextureColorMaskSGIS;

		}
	}

}
