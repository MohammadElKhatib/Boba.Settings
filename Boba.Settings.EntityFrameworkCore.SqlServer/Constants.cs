﻿namespace Boba.Settings.EntityFrameworkCore.SqlServer;

/// <summary>
/// Contains constant values used throughout the application.
/// </summary>
public abstract class Constants
{
    /// <summary>
    /// Represents the latest schema version.
    /// </summary>
    public static readonly int LatestSchemaVersion = 1;

    /// <summary>
    /// Represents the name of the schema.
    /// </summary>
    public static readonly string SchemaName = "Boba";
}
