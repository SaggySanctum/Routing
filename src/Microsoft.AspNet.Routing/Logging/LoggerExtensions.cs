﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.Logging;

namespace Microsoft.AspNet.Routing.Logging
{
    internal static class LoggerExtensions
    {
        public static bool WriteValues([NotNull] this ILogger logger, object values)
        {
            return logger.WriteCore(
                eventType: TraceType.Information,
                eventId: 0,
                state: values,
                exception: null,
                formatter: LogFormatter.Formatter);
        }
    }
}