
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
		/// [GLX] Value of GLX_TEXTURE_1D_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		[Log(BitmaskName = "GLXBindToTextureTargetMask")]
		public const uint TEXTURE_1D_BIT_EXT = 0x00000001;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_2D_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		[Log(BitmaskName = "GLXBindToTextureTargetMask")]
		public const uint TEXTURE_2D_BIT_EXT = 0x00000002;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_RECTANGLE_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		[Log(BitmaskName = "GLXBindToTextureTargetMask")]
		public const uint TEXTURE_RECTANGLE_BIT_EXT = 0x00000004;

		/// <summary>
		/// [GLX] Value of GLX_BIND_TO_TEXTURE_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_TEXTURE_RGB_EXT = 0x20D0;

		/// <summary>
		/// [GLX] Value of GLX_BIND_TO_TEXTURE_RGBA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_TEXTURE_RGBA_EXT = 0x20D1;

		/// <summary>
		/// [GLX] Value of GLX_BIND_TO_MIPMAP_TEXTURE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_MIPMAP_TEXTURE_EXT = 0x20D2;

		/// <summary>
		/// [GLX] Value of GLX_BIND_TO_TEXTURE_TARGETS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_TEXTURE_TARGETS_EXT = 0x20D3;

		/// <summary>
		/// [GLX] Value of GLX_Y_INVERTED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int Y_INVERTED_EXT = 0x20D4;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_EXT = 0x20D5;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_TARGET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_TARGET_EXT = 0x20D6;

		/// <summary>
		/// [GLX] Value of GLX_MIPMAP_TEXTURE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int MIPMAP_TEXTURE_EXT = 0x20D7;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_FORMAT_NONE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_NONE_EXT = 0x20D8;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_FORMAT_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_RGB_EXT = 0x20D9;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_FORMAT_RGBA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_RGBA_EXT = 0x20DA;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_1D_EXT = 0x20DB;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_2D_EXT = 0x20DC;

		/// <summary>
		/// [GLX] Value of GLX_TEXTURE_RECTANGLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_RECTANGLE_EXT = 0x20DD;

		/// <summary>
		/// [GLX] Value of GLX_FRONT_LEFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int FRONT_LEFT_EXT = 0x20DE;

		/// <summary>
		/// [GLX] Value of GLX_FRONT_RIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int FRONT_RIGHT_EXT = 0x20DF;

		/// <summary>
		/// [GLX] Value of GLX_BACK_LEFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BACK_LEFT_EXT = 0x20E0;

		/// <summary>
		/// [GLX] Value of GLX_BACK_RIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BACK_RIGHT_EXT = 0x20E1;

		/// <summary>
		/// [GLX] Value of GLX_AUX0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX0_EXT = 0x20E2;

		/// <summary>
		/// [GLX] Value of GLX_AUX1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX1_EXT = 0x20E3;

		/// <summary>
		/// [GLX] Value of GLX_AUX2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX2_EXT = 0x20E4;

		/// <summary>
		/// [GLX] Value of GLX_AUX3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX3_EXT = 0x20E5;

		/// <summary>
		/// [GLX] Value of GLX_AUX4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX4_EXT = 0x20E6;

		/// <summary>
		/// [GLX] Value of GLX_AUX5_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX5_EXT = 0x20E7;

		/// <summary>
		/// [GLX] Value of GLX_AUX6_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX6_EXT = 0x20E8;

		/// <summary>
		/// [GLX] Value of GLX_AUX7_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX7_EXT = 0x20E9;

		/// <summary>
		/// [GLX] Value of GLX_AUX8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX8_EXT = 0x20EA;

		/// <summary>
		/// [GLX] Value of GLX_AUX9_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX9_EXT = 0x20EB;

		/// <summary>
		/// [GLX] glXBindTexImageEXT: Binding for glXBindTexImageEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public static void BindTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer, int[] attrib_list)
		{
			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXBindTexImageEXT != null, "pglXBindTexImageEXT not implemented");
					Delegates.pglXBindTexImageEXT(dpy, drawable, buffer, p_attrib_list);
					LogCommand("glXBindTexImageEXT", null, dpy, drawable, buffer, attrib_list					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLX] glXReleaseTexImageEXT: Binding for glXReleaseTexImageEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public static void ReleaseTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer)
		{
			Debug.Assert(Delegates.pglXReleaseTexImageEXT != null, "pglXReleaseTexImageEXT not implemented");
			Delegates.pglXReleaseTexImageEXT(dpy, drawable, buffer);
			LogCommand("glXReleaseTexImageEXT", null, dpy, drawable, buffer			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glXBindTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer, int* attrib_list);

			[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
			internal static glXBindTexImageEXT pglXBindTexImageEXT;

			[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glXReleaseTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer);

			[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
			internal static glXReleaseTexImageEXT pglXReleaseTexImageEXT;

		}
	}

}
