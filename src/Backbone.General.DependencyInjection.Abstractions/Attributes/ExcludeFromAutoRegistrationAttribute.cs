namespace Backbone.General.DependencyInjection.Abstractions.Attributes;

/// <summary>
/// Represents an attribute used to exclude components from registration with reflection.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class ExcludeFromAutoRegistrationAttribute : Attribute;