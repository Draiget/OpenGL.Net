
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
		/// [GL] Value of GL_BUFFER_SERIALIZED_MODIFY_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		public const int BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;

		/// <summary>
		/// [GL] Value of GL_BUFFER_FLUSHING_UNMAP_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		public const int BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;

		/// <summary>
		/// [GL] glBufferParameteriAPPLE: Binding for glBufferParameteriAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		public static void BufferParameterAPPLE(int target, int pname, int param)
		{
			Debug.Assert(Delegates.pglBufferParameteriAPPLE != null, "pglBufferParameteriAPPLE not implemented");
			Delegates.pglBufferParameteriAPPLE(target, pname, param);
			LogCommand("glBufferParameteriAPPLE", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_flush_buffer_range")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glBufferParameteriAPPLE(int target, int pname, int param);

			[RequiredByFeature("GL_APPLE_flush_buffer_range")]
			[ThreadStatic]
			internal static glBufferParameteriAPPLE pglBufferParameteriAPPLE;

		}
	}

}
