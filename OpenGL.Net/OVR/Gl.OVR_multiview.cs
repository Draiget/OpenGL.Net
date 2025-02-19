
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
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;

		/// <summary>
		/// [GL] Value of GL_MAX_VIEWS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int MAX_VIEWS_OVR = 0x9631;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;

		/// <summary>
		/// [GL] glFramebufferTextureMultiviewOVR: Binding for glFramebufferTextureMultiviewOVR.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="baseViewIndex">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numViews">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public static void FramebufferTextureMultiOVR(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int baseViewIndex, int numViews)
		{
			Debug.Assert(Delegates.pglFramebufferTextureMultiviewOVR != null, "pglFramebufferTextureMultiviewOVR not implemented");
			Delegates.pglFramebufferTextureMultiviewOVR((int)target, (int)attachment, texture, level, baseViewIndex, numViews);
			LogCommand("glFramebufferTextureMultiviewOVR", null, target, attachment, texture, level, baseViewIndex, numViews			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glFramebufferTextureMultiviewOVR(int target, int attachment, uint texture, int level, int baseViewIndex, int numViews);

			[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glFramebufferTextureMultiviewOVR pglFramebufferTextureMultiviewOVR;

		}
	}

}
