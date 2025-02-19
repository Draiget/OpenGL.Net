
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] wglJoinSwapGroupNV: Binding for wglJoinSwapGroupNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool JoinSwapGroupNV(IntPtr hDC, uint group)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglJoinSwapGroupNV != null, "pwglJoinSwapGroupNV not implemented");
			retValue = Delegates.pwglJoinSwapGroupNV(hDC, group);
			LogCommand("wglJoinSwapGroupNV", retValue, hDC, group			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglBindSwapBarrierNV: Binding for wglBindSwapBarrierNV.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool BindSwapBarrierNV(uint group, uint barrier)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindSwapBarrierNV != null, "pwglBindSwapBarrierNV not implemented");
			retValue = Delegates.pwglBindSwapBarrierNV(group, barrier);
			LogCommand("wglBindSwapBarrierNV", retValue, group, barrier			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQuerySwapGroupNV: Binding for wglQuerySwapGroupNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="barrier">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QuerySwapGroupNV(IntPtr hDC, uint[] group, uint[] barrier)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_group = group)
				fixed (uint* p_barrier = barrier)
				{
					Debug.Assert(Delegates.pwglQuerySwapGroupNV != null, "pwglQuerySwapGroupNV not implemented");
					retValue = Delegates.pwglQuerySwapGroupNV(hDC, p_group, p_barrier);
					LogCommand("wglQuerySwapGroupNV", retValue, hDC, group, barrier					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryMaxSwapGroupsNV: Binding for wglQueryMaxSwapGroupsNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxGroups">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="maxBarriers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QueryMaxSwapGroupsNV(IntPtr hDC, uint[] maxGroups, uint[] maxBarriers)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_maxGroups = maxGroups)
				fixed (uint* p_maxBarriers = maxBarriers)
				{
					Debug.Assert(Delegates.pwglQueryMaxSwapGroupsNV != null, "pwglQueryMaxSwapGroupsNV not implemented");
					retValue = Delegates.pwglQueryMaxSwapGroupsNV(hDC, p_maxGroups, p_maxBarriers);
					LogCommand("wglQueryMaxSwapGroupsNV", retValue, hDC, maxGroups, maxBarriers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryFrameCountNV: Binding for wglQueryFrameCountNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool QueryFrameCountNV(IntPtr hDC, uint[] count)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_count = count)
				{
					Debug.Assert(Delegates.pwglQueryFrameCountNV != null, "pwglQueryFrameCountNV not implemented");
					retValue = Delegates.pwglQueryFrameCountNV(hDC, p_count);
					LogCommand("wglQueryFrameCountNV", retValue, hDC, count					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglResetFrameCountNV: Binding for wglResetFrameCountNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_swap_group")]
		public static bool ResetFrameCountNV(IntPtr hDC)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglResetFrameCountNV != null, "pwglResetFrameCountNV not implemented");
			retValue = Delegates.pwglResetFrameCountNV(hDC);
			LogCommand("wglResetFrameCountNV", retValue, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("WGL_NV_swap_group")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglJoinSwapGroupNV(IntPtr hDC, uint group);

			[RequiredByFeature("WGL_NV_swap_group")]
			internal static wglJoinSwapGroupNV pwglJoinSwapGroupNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglBindSwapBarrierNV(uint group, uint barrier);

			[RequiredByFeature("WGL_NV_swap_group")]
			internal static wglBindSwapBarrierNV pwglBindSwapBarrierNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglQuerySwapGroupNV(IntPtr hDC, uint* group, uint* barrier);

			[RequiredByFeature("WGL_NV_swap_group")]
			internal static wglQuerySwapGroupNV pwglQuerySwapGroupNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglQueryMaxSwapGroupsNV(IntPtr hDC, uint* maxGroups, uint* maxBarriers);

			[RequiredByFeature("WGL_NV_swap_group")]
			internal static wglQueryMaxSwapGroupsNV pwglQueryMaxSwapGroupsNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglQueryFrameCountNV(IntPtr hDC, uint* count);

			[RequiredByFeature("WGL_NV_swap_group")]
			internal static wglQueryFrameCountNV pwglQueryFrameCountNV;

			[RequiredByFeature("WGL_NV_swap_group")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglResetFrameCountNV(IntPtr hDC);

			[RequiredByFeature("WGL_NV_swap_group")]
			internal static wglResetFrameCountNV pwglResetFrameCountNV;

		}
	}

}
