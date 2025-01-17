// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Newtonsoft.Json;

namespace Docfx;

/// <summary>
/// MergeJsonConfig.
/// </summary>
[JsonConverter(typeof(MergeJsonConfigConverter))]
internal class MergeJsonConfig : List<MergeJsonItemConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MergeJsonConfig"/> class.
    /// </summary>
    /// <param name="configs">The collection whose elements are copied to the new list.</param>
    public MergeJsonConfig(IEnumerable<MergeJsonItemConfig> configs) : base(configs) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="MergeJsonConfig"/> class.
    /// </summary>
    /// <param name="configs">The collection whose elements are copied to the new list.</param>
    public MergeJsonConfig(params MergeJsonItemConfig[] configs) : base(configs)
    {
    }
}
