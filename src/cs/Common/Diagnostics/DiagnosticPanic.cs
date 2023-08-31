// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using JetBrains.Annotations;

namespace bottlenoselabs.Common.Diagnostics;

[PublicAPI]
public sealed class DiagnosticPanic : Diagnostic
{
    public DiagnosticPanic(Exception exception)
        : base(DiagnosticSeverity.Panic, CreateMessage(exception))
    {
    }

    private static string CreateMessage(Exception exception)
    {
        return $"{exception.Message}{Environment.NewLine}{exception.StackTrace}";
    }
}
