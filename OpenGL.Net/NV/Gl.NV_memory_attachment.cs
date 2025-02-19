
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
		/// [GL] Value of GL_ATTACHED_MEMORY_OBJECT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int ATTACHED_MEMORY_OBJECT_NV = 0x95A4;

		/// <summary>
		/// [GL] Value of GL_ATTACHED_MEMORY_OFFSET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int ATTACHED_MEMORY_OFFSET_NV = 0x95A5;

		/// <summary>
		/// [GL] Value of GL_MEMORY_ATTACHABLE_ALIGNMENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int MEMORY_ATTACHABLE_ALIGNMENT_NV = 0x95A6;

		/// <summary>
		/// [GL] Value of GL_MEMORY_ATTACHABLE_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int MEMORY_ATTACHABLE_SIZE_NV = 0x95A7;

		/// <summary>
		/// [GL] Value of GL_MEMORY_ATTACHABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int MEMORY_ATTACHABLE_NV = 0x95A8;

		/// <summary>
		/// [GL] Value of GL_DETACHED_MEMORY_INCARNATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int DETACHED_MEMORY_INCARNATION_NV = 0x95A9;

		/// <summary>
		/// [GL] Value of GL_DETACHED_TEXTURES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int DETACHED_TEXTURES_NV = 0x95AA;

		/// <summary>
		/// [GL] Value of GL_DETACHED_BUFFERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int DETACHED_BUFFERS_NV = 0x95AB;

		/// <summary>
		/// [GL] Value of GL_MAX_DETACHED_TEXTURES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int MAX_DETACHED_TEXTURES_NV = 0x95AC;

		/// <summary>
		/// [GL] Value of GL_MAX_DETACHED_BUFFERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public const int MAX_DETACHED_BUFFERS_NV = 0x95AD;

		/// <summary>
		/// [GL] glGetMemoryObjectDetachedResourcesuivNV: Binding for glGetMemoryObjectDetachedResourcesuivNV.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public static void GetMemoryObjectDetachedResourcesuivNV(uint memory, int pname, int first, int count, [Out] uint[] @params)
		{
			unsafe {
				fixed (uint* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMemoryObjectDetachedResourcesuivNV != null, "pglGetMemoryObjectDetachedResourcesuivNV not implemented");
					Delegates.pglGetMemoryObjectDetachedResourcesuivNV(memory, pname, first, count, p_params);
					LogCommand("glGetMemoryObjectDetachedResourcesuivNV", null, memory, pname, first, count, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glResetMemoryObjectParameterNV: Binding for glResetMemoryObjectParameterNV.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public static void ResetMemoryObjectParameterNV(uint memory, int pname)
		{
			Debug.Assert(Delegates.pglResetMemoryObjectParameterNV != null, "pglResetMemoryObjectParameterNV not implemented");
			Delegates.pglResetMemoryObjectParameterNV(memory, pname);
			LogCommand("glResetMemoryObjectParameterNV", null, memory, pname			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexAttachMemoryNV: Binding for glTexAttachMemoryNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:ulong"/>.
		/// </param>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public static void TexAttachMemoryNV(TextureTarget target, uint memory, ulong offset)
		{
			Debug.Assert(Delegates.pglTexAttachMemoryNV != null, "pglTexAttachMemoryNV not implemented");
			Delegates.pglTexAttachMemoryNV((int)target, memory, offset);
			LogCommand("glTexAttachMemoryNV", null, target, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glBufferAttachMemoryNV: Binding for glBufferAttachMemoryNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:ulong"/>.
		/// </param>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public static void BufferAttachMemoryNV(BufferTargetARB target, uint memory, ulong offset)
		{
			Debug.Assert(Delegates.pglBufferAttachMemoryNV != null, "pglBufferAttachMemoryNV not implemented");
			Delegates.pglBufferAttachMemoryNV((int)target, memory, offset);
			LogCommand("glBufferAttachMemoryNV", null, target, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTextureAttachMemoryNV: Binding for glTextureAttachMemoryNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:ulong"/>.
		/// </param>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public static void TextureAttachMemoryNV(uint texture, uint memory, ulong offset)
		{
			Debug.Assert(Delegates.pglTextureAttachMemoryNV != null, "pglTextureAttachMemoryNV not implemented");
			Delegates.pglTextureAttachMemoryNV(texture, memory, offset);
			LogCommand("glTextureAttachMemoryNV", null, texture, memory, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glNamedBufferAttachMemoryNV: Binding for glNamedBufferAttachMemoryNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="memory">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:ulong"/>.
		/// </param>
		[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
		public static void NamedBufferAttachMemoryNV(uint buffer, uint memory, ulong offset)
		{
			Debug.Assert(Delegates.pglNamedBufferAttachMemoryNV != null, "pglNamedBufferAttachMemoryNV not implemented");
			Delegates.pglNamedBufferAttachMemoryNV(buffer, memory, offset);
			LogCommand("glNamedBufferAttachMemoryNV", null, buffer, memory, offset			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetMemoryObjectDetachedResourcesuivNV(uint memory, int pname, int first, int count, uint* @params);

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetMemoryObjectDetachedResourcesuivNV pglGetMemoryObjectDetachedResourcesuivNV;

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glResetMemoryObjectParameterNV(uint memory, int pname);

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glResetMemoryObjectParameterNV pglResetMemoryObjectParameterNV;

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexAttachMemoryNV(int target, uint memory, ulong offset);

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glTexAttachMemoryNV pglTexAttachMemoryNV;

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glBufferAttachMemoryNV(int target, uint memory, ulong offset);

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glBufferAttachMemoryNV pglBufferAttachMemoryNV;

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTextureAttachMemoryNV(uint texture, uint memory, ulong offset);

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glTextureAttachMemoryNV pglTextureAttachMemoryNV;

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glNamedBufferAttachMemoryNV(uint buffer, uint memory, ulong offset);

			[RequiredByFeature("GL_NV_memory_attachment", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glNamedBufferAttachMemoryNV pglNamedBufferAttachMemoryNV;

		}
	}

}
