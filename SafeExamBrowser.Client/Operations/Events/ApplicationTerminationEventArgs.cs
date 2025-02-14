﻿/*
 * Copyright (c) 2022 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using SafeExamBrowser.Core.Contracts.OperationModel.Events;
using SafeExamBrowser.Monitoring.Contracts.Applications;
using System.Collections.Generic;

namespace SafeExamBrowser.Client.Operations.Events
{
	internal class ApplicationTerminationEventArgs : ActionRequiredEventArgs
	{
		internal IEnumerable<RunningApplication> RunningApplications { get; }
		internal bool TerminateProcesses { get; set; }

		internal ApplicationTerminationEventArgs(IEnumerable<RunningApplication> runningApplications)
		{
			RunningApplications = runningApplications;
		}
	}
}
