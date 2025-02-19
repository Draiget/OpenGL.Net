
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
		/// [GL] glIsRenderbufferOES: Binding for glIsRenderbufferOES.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static bool IsRenderbufferOES(uint renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbufferOES != null, "pglIsRenderbufferOES not implemented");
			retValue = Delegates.pglIsRenderbufferOES(renderbuffer);
			LogCommand("glIsRenderbufferOES", retValue, renderbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glBindRenderbufferOES: Binding for glBindRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void BindRenderbufferOES(RenderbufferTarget target, uint renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferOES != null, "pglBindRenderbufferOES not implemented");
			Delegates.pglBindRenderbufferOES((int)target, renderbuffer);
			LogCommand("glBindRenderbufferOES", null, target, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDeleteRenderbuffersOES: Binding for glDeleteRenderbuffersOES.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void DeleteRenderbuffersOES(uint[] renderbuffers)
		{
			unsafe {
				fixed (uint* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffersOES != null, "pglDeleteRenderbuffersOES not implemented");
					Delegates.pglDeleteRenderbuffersOES(renderbuffers.Length, p_renderbuffers);
					LogCommand("glDeleteRenderbuffersOES", null, renderbuffers.Length, renderbuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenRenderbuffersOES: Binding for glGenRenderbuffersOES.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenRenderbuffersOES(uint[] renderbuffers)
		{
			unsafe {
				fixed (uint* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffersOES != null, "pglGenRenderbuffersOES not implemented");
					Delegates.pglGenRenderbuffersOES(renderbuffers.Length, p_renderbuffers);
					LogCommand("glGenRenderbuffersOES", null, renderbuffers.Length, renderbuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenRenderbuffersOES: Binding for glGenRenderbuffersOES.
		/// </summary>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static uint GenRenderbufferOES()
		{
			uint retValue;
			unsafe {
				Delegates.pglGenRenderbuffersOES(1, &retValue);
				LogCommand("glGenRenderbuffersOES", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glRenderbufferStorageOES: Binding for glRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void RenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageOES != null, "pglRenderbufferStorageOES not implemented");
			Delegates.pglRenderbufferStorageOES((int)target, (int)internalformat, width, height);
			LogCommand("glRenderbufferStorageOES", null, target, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetRenderbufferParameterivOES: Binding for glGetRenderbufferParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:RenderbufferParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GetRenderbufferParameterOES(RenderbufferTarget target, RenderbufferParameterName pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameterivOES != null, "pglGetRenderbufferParameterivOES not implemented");
					Delegates.pglGetRenderbufferParameterivOES((int)target, (int)pname, p_params);
					LogCommand("glGetRenderbufferParameterivOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsFramebufferOES: Binding for glIsFramebufferOES.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static bool IsFramebufferOES(uint framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebufferOES != null, "pglIsFramebufferOES not implemented");
			retValue = Delegates.pglIsFramebufferOES(framebuffer);
			LogCommand("glIsFramebufferOES", retValue, framebuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glBindFramebufferOES: Binding for glBindFramebufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void BindFramebufferOES(FramebufferTarget target, uint framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferOES != null, "pglBindFramebufferOES not implemented");
			Delegates.pglBindFramebufferOES((int)target, framebuffer);
			LogCommand("glBindFramebufferOES", null, target, framebuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDeleteFramebuffersOES: Binding for glDeleteFramebuffersOES.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void DeleteFramebuffersOES(uint[] framebuffers)
		{
			unsafe {
				fixed (uint* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffersOES != null, "pglDeleteFramebuffersOES not implemented");
					Delegates.pglDeleteFramebuffersOES(framebuffers.Length, p_framebuffers);
					LogCommand("glDeleteFramebuffersOES", null, framebuffers.Length, framebuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenFramebuffersOES: Binding for glGenFramebuffersOES.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenFramebuffersOES(uint[] framebuffers)
		{
			unsafe {
				fixed (uint* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffersOES != null, "pglGenFramebuffersOES not implemented");
					Delegates.pglGenFramebuffersOES(framebuffers.Length, p_framebuffers);
					LogCommand("glGenFramebuffersOES", null, framebuffers.Length, framebuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenFramebuffersOES: Binding for glGenFramebuffersOES.
		/// </summary>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static uint GenFramebufferOES()
		{
			uint retValue;
			unsafe {
				Delegates.pglGenFramebuffersOES(1, &retValue);
				LogCommand("glGenFramebuffersOES", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glCheckFramebufferStatusOES: Binding for glCheckFramebufferStatusOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static FramebufferStatus CheckFramebufferStatusOES(FramebufferTarget target)
		{
			int retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatusOES != null, "pglCheckFramebufferStatusOES not implemented");
			retValue = Delegates.pglCheckFramebufferStatusOES((int)target);
			LogCommand("glCheckFramebufferStatusOES", (FramebufferStatus)retValue, target			);
			DebugCheckErrors(retValue);

			return ((FramebufferStatus)retValue);
		}

		/// <summary>
		/// [GL] glFramebufferRenderbufferOES: Binding for glFramebufferRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void FramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbufferOES != null, "pglFramebufferRenderbufferOES not implemented");
			Delegates.pglFramebufferRenderbufferOES((int)target, (int)attachment, (int)renderbuffertarget, renderbuffer);
			LogCommand("glFramebufferRenderbufferOES", null, target, attachment, renderbuffertarget, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glFramebufferTexture2DOES: Binding for glFramebufferTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void FramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DOES != null, "pglFramebufferTexture2DOES not implemented");
			Delegates.pglFramebufferTexture2DOES((int)target, (int)attachment, (int)textarget, texture, level);
			LogCommand("glFramebufferTexture2DOES", null, target, attachment, textarget, texture, level			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetFramebufferAttachmentParameterivOES: Binding for glGetFramebufferAttachmentParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:FramebufferAttachmentParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GetFramebufferAttachmentParameterOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameterivOES != null, "pglGetFramebufferAttachmentParameterivOES not implemented");
					Delegates.pglGetFramebufferAttachmentParameterivOES((int)target, (int)attachment, (int)pname, p_params);
					LogCommand("glGetFramebufferAttachmentParameterivOES", null, target, attachment, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenerateMipmapOES: Binding for glGenerateMipmapOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public static void GenerateMipmapOES(TextureTarget target)
		{
			Debug.Assert(Delegates.pglGenerateMipmapOES != null, "pglGenerateMipmapOES not implemented");
			Delegates.pglGenerateMipmapOES((int)target);
			LogCommand("glGenerateMipmapOES", null, target			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsRenderbufferOES(uint renderbuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glIsRenderbufferOES pglIsRenderbufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glBindRenderbufferOES(int target, uint renderbuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glBindRenderbufferOES pglBindRenderbufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteRenderbuffersOES(int n, uint* renderbuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glDeleteRenderbuffersOES pglDeleteRenderbuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGenRenderbuffersOES(int n, uint* renderbuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGenRenderbuffersOES pglGenRenderbuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glRenderbufferStorageOES(int target, int internalformat, int width, int height);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glRenderbufferStorageOES pglRenderbufferStorageOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetRenderbufferParameterivOES(int target, int pname, int* @params);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGetRenderbufferParameterivOES pglGetRenderbufferParameterivOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsFramebufferOES(uint framebuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glIsFramebufferOES pglIsFramebufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glBindFramebufferOES(int target, uint framebuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glBindFramebufferOES pglBindFramebufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteFramebuffersOES(int n, uint* framebuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glDeleteFramebuffersOES pglDeleteFramebuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGenFramebuffersOES(int n, uint* framebuffers);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGenFramebuffersOES pglGenFramebuffersOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glCheckFramebufferStatusOES(int target);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glCheckFramebufferStatusOES pglCheckFramebufferStatusOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glFramebufferRenderbufferOES(int target, int attachment, int renderbuffertarget, uint renderbuffer);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glFramebufferRenderbufferOES pglFramebufferRenderbufferOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glFramebufferTexture2DOES(int target, int attachment, int textarget, uint texture, int level);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glFramebufferTexture2DOES pglFramebufferTexture2DOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetFramebufferAttachmentParameterivOES(int target, int attachment, int pname, int* @params);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGetFramebufferAttachmentParameterivOES pglGetFramebufferAttachmentParameterivOES;

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGenerateMipmapOES(int target);

			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			[ThreadStatic]
			internal static glGenerateMipmapOES pglGenerateMipmapOES;

		}
	}

}
