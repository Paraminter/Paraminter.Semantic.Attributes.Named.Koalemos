﻿namespace Paraminter.Semantic.Attributes.Named.Koalemos.Models;

using Microsoft.CodeAnalysis;

using Paraminter.Models;

using System.Collections.Generic;

/// <summary>Represents data used to associate semantic named attribute arguments.</summary>
public interface IAssociateSemanticAttributeNamedData
    : IAssociateArgumentsData
{
    /// <summary>The names of named attribute parameters and the associated arguments.</summary>
    public abstract IReadOnlyList<KeyValuePair<string, TypedConstant>> Associations { get; }
}