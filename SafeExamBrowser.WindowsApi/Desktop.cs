﻿/*
 * Copyright (c) 2022 ETH Zürich, Educational Development and Technology (LET)
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.WindowsApi.Contracts;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SafeExamBrowser.WindowsApi
{
	public class Desktop : IDesktop
	{
		public IntPtr Handle { get; private set; }
		public string Name { get; private set; }

		public Desktop(IntPtr handle, string name)
		{
			Handle = handle;
			Name = name;
		}

		public void Activate()
		{
			var success = User32.SwitchDesktop(Handle);

			if (!success)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}

		public void Close()
		{
			var success = User32.CloseDesktop(Handle);

			if (!success)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}

		public override string ToString()
		{
			return $"'{Name}' [{Handle}]";
		}
	}
}
