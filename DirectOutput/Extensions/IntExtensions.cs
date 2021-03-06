﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// Extends the int object with additional functionality.
/// </summary>
public static class IntExtensions
{
    /// <summary>
    /// Limits the value to the supplied Min- and MaxValues
    /// </summary>
    /// <param name="i">The value to clamp</param>
    /// <param name="MinValue">Minimum Value</param>
    /// <param name="MaxValue">Maximum Value</param>
    /// <returns>int limited the to specified Min- and MaxValues</returns>
    public static int Limit(this int i, int MinValue, int MaxValue)
    {
        if (i < MinValue) return MinValue;
        if (i > MaxValue) return MaxValue;
        return i;
    }

    /// <summary>
    /// Indicates wheter the value of the int within a specified range.
    /// </summary>
    /// <param name="i">The value to test</param>
    /// <param name="MinValue">Minimum Value</param>
    /// <param name="MaxValue">>Maximum Value</param>
    /// <returns>true if the int is between <paramref name="MinValue"/> and <paramref name="MaxValue"/>, otherwise false.</returns>
    public static bool IsBetween(this int i, int MinValue, int MaxValue)
    {
        return (i >= MinValue && i <= MaxValue);
    }

    /// <summary>
    /// Returns the absolute value of the int
    /// </summary>
    /// <returns>Absolute value of the int</returns>
    public static int Abs(this int i)
    {

        return Math.Abs(i);
    }

}

