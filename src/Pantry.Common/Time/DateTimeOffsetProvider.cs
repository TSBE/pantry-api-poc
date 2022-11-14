﻿namespace Pantry.Common.Time;

/// <summary>
/// Provides date and time information.
/// <remarks>
/// This class is a testable wrapper around the native <see cref="DateTimeOffset"/> functions.
/// When used in a <see cref="DateTimeContext"/> it returns the date and time values
/// that are configured in that context.
/// If an instance of this class is used outside of a <see cref="DateTimeContext"/> it
/// returns the real date and time values.
/// </remarks>
/// </summary>
public static class DateTimeOffsetProvider
{
    private static readonly Func<DateTimeOffset> DefaultNowFunction = () => DateTimeOffset.Now;
    private static readonly Func<DateTimeOffset> DefaultUtcNowFunction = () => DateTimeOffset.UtcNow;

    /// <summary>
    /// Returns the current date and time (local time).
    /// If this is called within a <see cref="DateTimeContext"/> it
    /// returns the value that is valid in that context.
    /// </summary>
    public static DateTimeOffset Now => DateTimeContext.Current == null
        ? DefaultNowFunction.Invoke()
        : DateTimeContext.Current.ContextDateTimeOffsetNow;

    /// <summary>
    /// Returns the current UTC datetime value.
    /// If this is called within a <see cref="DateTimeContext"/> it
    /// returns the value that is valid in that context.
    /// </summary>
    public static DateTimeOffset UtcNow => DateTimeContext.Current == null
        ? DefaultUtcNowFunction.Invoke()
        : DateTimeContext.Current.ContextDateTimeOffsetUtcNow;
}
