
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
		/// [GL] Value of GL_MATRIX_PALETTE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_PALETTE_ARB = 0x8840;

		/// <summary>
		/// [GL] Value of GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;

		/// <summary>
		/// [GL] Value of GL_MAX_PALETTE_MATRICES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MAX_PALETTE_MATRICES_ARB = 0x8842;

		/// <summary>
		/// [GL] Value of GL_CURRENT_PALETTE_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int CURRENT_PALETTE_MATRIX_ARB = 0x8843;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_ARB = 0x8844;

		/// <summary>
		/// [GL] Value of GL_CURRENT_MATRIX_INDEX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int CURRENT_MATRIX_INDEX_ARB = 0x8845;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_STRIDE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;

		/// <summary>
		/// [GL] Value of GL_MATRIX_INDEX_ARRAY_POINTER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;

		/// <summary>
		/// [GL] glCurrentPaletteMatrixARB: Binding for glCurrentPaletteMatrixARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void CurrentPaletteMatrixARB(int index)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixARB != null, "pglCurrentPaletteMatrixARB not implemented");
			Delegates.pglCurrentPaletteMatrixARB(index);
			LogCommand("glCurrentPaletteMatrixARB", null, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMatrixIndexubvARB: Binding for glMatrixIndexubvARB.
		/// </summary>
		/// <param name="indices">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(byte[] indices)
		{
			unsafe {
				fixed (byte* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexubvARB != null, "pglMatrixIndexubvARB not implemented");
					Delegates.pglMatrixIndexubvARB(indices.Length, p_indices);
					LogCommand("glMatrixIndexubvARB", null, indices.Length, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMatrixIndexusvARB: Binding for glMatrixIndexusvARB.
		/// </summary>
		/// <param name="indices">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(ushort[] indices)
		{
			unsafe {
				fixed (ushort* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexusvARB != null, "pglMatrixIndexusvARB not implemented");
					Delegates.pglMatrixIndexusvARB(indices.Length, p_indices);
					LogCommand("glMatrixIndexusvARB", null, indices.Length, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMatrixIndexuivARB: Binding for glMatrixIndexuivARB.
		/// </summary>
		/// <param name="indices">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(uint[] indices)
		{
			unsafe {
				fixed (uint* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexuivARB != null, "pglMatrixIndexuivARB not implemented");
					Delegates.pglMatrixIndexuivARB(indices.Length, p_indices);
					LogCommand("glMatrixIndexuivARB", null, indices.Length, indices					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMatrixIndexPointerARB: Binding for glMatrixIndexPointerARB.
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
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexPointerARB(int size, int type, int stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerARB != null, "pglMatrixIndexPointerARB not implemented");
			Delegates.pglMatrixIndexPointerARB(size, type, stride, pointer);
			LogCommand("glMatrixIndexPointerARB", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMatrixIndexPointerARB: Binding for glMatrixIndexPointerARB.
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
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexPointerARB(int size, int type, int stride, object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MatrixIndexPointerARB(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_ARB_matrix_palette")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glCurrentPaletteMatrixARB(int index);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glCurrentPaletteMatrixARB pglCurrentPaletteMatrixARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMatrixIndexubvARB(int size, byte* indices);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexubvARB pglMatrixIndexubvARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMatrixIndexusvARB(int size, ushort* indices);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexusvARB pglMatrixIndexusvARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMatrixIndexuivARB(int size, uint* indices);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexuivARB pglMatrixIndexuivARB;

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMatrixIndexPointerARB(int size, int type, int stride, IntPtr pointer);

			[RequiredByFeature("GL_ARB_matrix_palette")]
			[ThreadStatic]
			internal static glMatrixIndexPointerARB pglMatrixIndexPointerARB;

		}
	}

}
