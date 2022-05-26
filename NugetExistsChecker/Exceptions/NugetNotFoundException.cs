﻿// <copyright file="NugetNotFoundException.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

namespace NugetExistsChecker.Exceptions;

/// <summary>
/// Occurs when a nuget package is not found.
/// </summary>
public class NugetNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NugetNotFoundException"/> class.
    /// </summary>
    public NugetNotFoundException()
        : base("The nuget package was not found.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NugetNotFoundException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public NugetNotFoundException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NugetNotFoundException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">
    ///     The <see cref="Exception"/> instance that caused the current exception.
    /// </param>
    public NugetNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

