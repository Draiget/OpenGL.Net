
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
		/// [GL] Value of GL_MODELVIEW0_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW1_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW1_STACK_DEPTH_EXT = 0x8502;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW0_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW0_MATRIX_EXT = 0x0BA6;

		/// <summary>
		/// [GL] Value of GL_MODELVIEW1_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW1_MATRIX_EXT = 0x8506;

		/// <summary>
		/// [GL] Value of GL_VERTEX_WEIGHTING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHTING_EXT = 0x8509;

		/// <summary>
		/// [GL] Value of GL_CURRENT_VERTEX_WEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int CURRENT_VERTEX_WEIGHT_EXT = 0x850B;

		/// <summary>
		/// [GL] Value of GL_VERTEX_WEIGHT_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_EXT = 0x850C;

		/// <summary>
		/// [GL] Value of GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;

		/// <summary>
		/// [GL] Value of GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;

		/// <summary>
		/// [GL] Value of GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;

		/// <summary>
		/// [GL] Value of GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;

		/// <summary>
		/// [GL] glVertexWeightfEXT: Binding for glVertexWeightfEXT.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightEXT(float weight)
		{
			Debug.Assert(Delegates.pglVertexWeightfEXT != null, "pglVertexWeightfEXT not implemented");
			Delegates.pglVertexWeightfEXT(weight);
			LogCommand("glVertexWeightfEXT", null, weight			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexWeightfvEXT: Binding for glVertexWeightfvEXT.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightEXT(float[] weight)
		{
			Debug.Assert(weight.Length >= 1);
			unsafe {
				fixed (float* p_weight = weight)
				{
					Debug.Assert(Delegates.pglVertexWeightfvEXT != null, "pglVertexWeightfvEXT not implemented");
					Delegates.pglVertexWeightfvEXT(p_weight);
					LogCommand("glVertexWeightfvEXT", null, weight					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexWeightPointerEXT: Binding for glVertexWeightPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightPointerEXT(int size, int type, int stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexWeightPointerEXT != null, "pglVertexWeightPointerEXT not implemented");
			Delegates.pglVertexWeightPointerEXT(size, type, stride, pointer);
			LogCommand("glVertexWeightPointerEXT", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexWeightPointerEXT: Binding for glVertexWeightPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightPointerEXT(int size, int type, int stride, object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexWeightPointerEXT(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertexWeightfEXT(float weight);

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[ThreadStatic]
			internal static glVertexWeightfEXT pglVertexWeightfEXT;

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertexWeightfvEXT(float* weight);

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[ThreadStatic]
			internal static glVertexWeightfvEXT pglVertexWeightfvEXT;

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertexWeightPointerEXT(int size, int type, int stride, IntPtr pointer);

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[ThreadStatic]
			internal static glVertexWeightPointerEXT pglVertexWeightPointerEXT;

		}
	}

}
