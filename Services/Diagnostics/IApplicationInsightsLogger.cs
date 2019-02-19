﻿// Copyright (c) Microsoft. All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.IoTSolutions.DeviceSimulation.Services.Models;

namespace Microsoft.Azure.IoTSolutions.DeviceSimulation.Services.Diagnostics
{
    public interface IApplicationInsightsLogger
    {
        void Init();
        void WaitingForConnectionTasks(string simulationId, int taskCount);
        void DeviceConnectionLoopCompleted(string simulationid, long durationMsecs);
    }
}