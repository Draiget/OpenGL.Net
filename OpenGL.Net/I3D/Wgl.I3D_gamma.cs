
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
		/// [WGL] Value of WGL_GAMMA_TABLE_SIZE_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_gamma")]
		public const int GAMMA_TABLE_SIZE_I3D = 0x204E;

		/// <summary>
		/// [WGL] Value of WGL_GAMMA_EXCLUDE_DESKTOP_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_gamma")]
		public const int GAMMA_EXCLUDE_DESKTOP_I3D = 0x204F;

		/// <summary>
		/// [WGL] wglGetGammaTableParametersI3D: Binding for wglGetGammaTableParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglGetGammaTableParametersI3D != null, "pwglGetGammaTableParametersI3D not implemented");
					retValue = Delegates.pwglGetGammaTableParametersI3D(hDC, iAttribute, p_piValue);
					LogCommand("wglGetGammaTableParametersI3D", retValue, hDC, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSetGammaTableParametersI3D: Binding for wglSetGammaTableParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglSetGammaTableParametersI3D != null, "pwglSetGammaTableParametersI3D not implemented");
					retValue = Delegates.pwglSetGammaTableParametersI3D(hDC, iAttribute, p_piValue);
					LogCommand("wglSetGammaTableParametersI3D", retValue, hDC, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetGammaTableI3D: Binding for wglGetGammaTableI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iEntries">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="puRed">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		/// <param name="puGreen">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		/// <param name="puBlue">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] ushort[] puRed, [Out] ushort[] puGreen, [Out] ushort[] puBlue)
		{
			bool retValue;

			unsafe {
				fixed (ushort* p_puRed = puRed)
				fixed (ushort* p_puGreen = puGreen)
				fixed (ushort* p_puBlue = puBlue)
				{
					Debug.Assert(Delegates.pwglGetGammaTableI3D != null, "pwglGetGammaTableI3D not implemented");
					retValue = Delegates.pwglGetGammaTableI3D(hDC, iEntries, p_puRed, p_puGreen, p_puBlue);
					LogCommand("wglGetGammaTableI3D", retValue, hDC, iEntries, puRed, puGreen, puBlue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSetGammaTableI3D: Binding for wglSetGammaTableI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iEntries">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="puRed">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		/// <param name="puGreen">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		/// <param name="puBlue">
		/// A <see cref="T:ushort[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_gamma")]
		public static bool SetGammaTableI3D(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
		{
			bool retValue;

			unsafe {
				fixed (ushort* p_puRed = puRed)
				fixed (ushort* p_puGreen = puGreen)
				fixed (ushort* p_puBlue = puBlue)
				{
					Debug.Assert(Delegates.pwglSetGammaTableI3D != null, "pwglSetGammaTableI3D not implemented");
					retValue = Delegates.pwglSetGammaTableI3D(hDC, iEntries, p_puRed, p_puGreen, p_puBlue);
					LogCommand("wglSetGammaTableI3D", retValue, hDC, iEntries, puRed, puGreen, puBlue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_gamma")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_I3D_gamma")]
			internal static wglGetGammaTableParametersI3D pwglGetGammaTableParametersI3D;

			[RequiredByFeature("WGL_I3D_gamma")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_I3D_gamma")]
			internal static wglSetGammaTableParametersI3D pwglSetGammaTableParametersI3D;

			[RequiredByFeature("WGL_I3D_gamma")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue);

			[RequiredByFeature("WGL_I3D_gamma")]
			internal static wglGetGammaTableI3D pwglGetGammaTableI3D;

			[RequiredByFeature("WGL_I3D_gamma")]
			[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue);

			[RequiredByFeature("WGL_I3D_gamma")]
			internal static wglSetGammaTableI3D pwglSetGammaTableI3D;

		}
	}

}
