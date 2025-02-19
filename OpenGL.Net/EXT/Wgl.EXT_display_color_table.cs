
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] wglCreateDisplayColorTableEXT: Binding for wglCreateDisplayColorTableEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:ushort"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static bool CreateDisplayColorTableEXT(ushort id)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglCreateDisplayColorTableEXT != null, "pwglCreateDisplayColorTableEXT not implemented");
			retValue = Delegates.pwglCreateDisplayColorTableEXT(id);
			LogCommand("wglCreateDisplayColorTableEXT", retValue, id			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglLoadDisplayColorTableEXT: Binding for wglLoadDisplayColorTableEXT.
		/// </summary>
		/// <param name="table">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static bool LoadDisplayColorTableEXT(ushort[] table, uint length)
		{
			bool retValue;

			unsafe {
				fixed (ushort* p_table = table)
				{
					Debug.Assert(Delegates.pwglLoadDisplayColorTableEXT != null, "pwglLoadDisplayColorTableEXT not implemented");
					retValue = Delegates.pwglLoadDisplayColorTableEXT(p_table, length);
					LogCommand("wglLoadDisplayColorTableEXT", retValue, table, length					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglBindDisplayColorTableEXT: Binding for wglBindDisplayColorTableEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:ushort"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static bool BindDisplayColorTableEXT(ushort id)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindDisplayColorTableEXT != null, "pwglBindDisplayColorTableEXT not implemented");
			retValue = Delegates.pwglBindDisplayColorTableEXT(id);
			LogCommand("wglBindDisplayColorTableEXT", retValue, id			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglDestroyDisplayColorTableEXT: Binding for wglDestroyDisplayColorTableEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:ushort"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static void DestroyDisplayColorTableEXT(ushort id)
		{
			Debug.Assert(Delegates.pwglDestroyDisplayColorTableEXT != null, "pwglDestroyDisplayColorTableEXT not implemented");
			Delegates.pwglDestroyDisplayColorTableEXT(id);
			LogCommand("wglDestroyDisplayColorTableEXT", null, id			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("WGL_EXT_display_color_table")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool wglCreateDisplayColorTableEXT(ushort id);

			[RequiredByFeature("WGL_EXT_display_color_table")]
			internal static wglCreateDisplayColorTableEXT pwglCreateDisplayColorTableEXT;

			[RequiredByFeature("WGL_EXT_display_color_table")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool wglLoadDisplayColorTableEXT(ushort* table, uint length);

			[RequiredByFeature("WGL_EXT_display_color_table")]
			internal static wglLoadDisplayColorTableEXT pwglLoadDisplayColorTableEXT;

			[RequiredByFeature("WGL_EXT_display_color_table")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool wglBindDisplayColorTableEXT(ushort id);

			[RequiredByFeature("WGL_EXT_display_color_table")]
			internal static wglBindDisplayColorTableEXT pwglBindDisplayColorTableEXT;

			[RequiredByFeature("WGL_EXT_display_color_table")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void wglDestroyDisplayColorTableEXT(ushort id);

			[RequiredByFeature("WGL_EXT_display_color_table")]
			internal static wglDestroyDisplayColorTableEXT pwglDestroyDisplayColorTableEXT;

		}
	}

}
