
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
		/// [GLX] Value of GLX_SAMPLE_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_4")]
		[RequiredByFeature("GLX_ARB_multisample")]
		[RequiredByFeature("GLX_SGIS_multisample")]
		public const int SAMPLE_BUFFERS = 100000;

		/// <summary>
		/// [GLX] Value of GLX_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_4")]
		[RequiredByFeature("GLX_ARB_multisample")]
		[RequiredByFeature("GLX_SGIS_multisample")]
		public const int SAMPLES = 100001;

		/// <summary>
		/// [GL2.1] glXGetProcAddress: obtain a pointer to an OpenGL or GLX function
		/// </summary>
		/// <param name="procName">
		/// Specifies the name of the OpenGL or GLX function whose address is to be returned.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_4")]
		public static IntPtr GetProcAddress(byte[] procName)
		{
			IntPtr retValue;

			unsafe {
				fixed (byte* p_procName = procName)
				{
					Debug.Assert(Delegates.pglXGetProcAddress != null, "pglXGetProcAddress not implemented");
					retValue = Delegates.pglXGetProcAddress(p_procName);
					LogCommand("glXGetProcAddress", retValue, procName					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_VERSION_1_4")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glXGetProcAddress(byte* procName);

			[RequiredByFeature("GLX_VERSION_1_4")]
			internal static glXGetProcAddress pglXGetProcAddress;

		}
	}

}
