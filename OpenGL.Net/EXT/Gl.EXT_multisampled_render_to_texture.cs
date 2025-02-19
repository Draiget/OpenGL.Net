
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
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;

		/// <summary>
		/// [GL] glFramebufferTexture2DMultisampleEXT: Binding for glFramebufferTexture2DMultisampleEXT.
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
		/// <param name="samples">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleEXT != null, "pglFramebufferTexture2DMultisampleEXT not implemented");
			Delegates.pglFramebufferTexture2DMultisampleEXT((int)target, (int)attachment, (int)textarget, texture, level, samples);
			LogCommand("glFramebufferTexture2DMultisampleEXT", null, target, attachment, textarget, texture, level, samples			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glFramebufferTexture2DMultisampleEXT(int target, int attachment, int textarget, uint texture, int level, int samples);

			[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glFramebufferTexture2DMultisampleEXT pglFramebufferTexture2DMultisampleEXT;

		}
	}

}
