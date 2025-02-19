
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] eglQueryDevicesEXT: Binding for eglQueryDevicesEXT.
		/// </summary>
		/// <param name="max_devices">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="devices">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="num_devices">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_device_base")]
		[RequiredByFeature("EGL_EXT_device_enumeration")]
		public static bool QueryDevicesEXT(int max_devices, IntPtr[] devices, int[] num_devices)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_devices = devices)
				fixed (int* p_num_devices = num_devices)
				{
					Debug.Assert(Delegates.peglQueryDevicesEXT != null, "peglQueryDevicesEXT not implemented");
					retValue = Delegates.peglQueryDevicesEXT(max_devices, p_devices, p_num_devices);
					LogCommand("eglQueryDevicesEXT", retValue, max_devices, devices, num_devices					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_enumeration")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

			[RequiredByFeature("EGL_EXT_device_base")]
			[RequiredByFeature("EGL_EXT_device_enumeration")]
			internal static eglQueryDevicesEXT peglQueryDevicesEXT;

		}
	}

}
