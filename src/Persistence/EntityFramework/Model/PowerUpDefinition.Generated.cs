// <copyright file="PowerUpDefinition.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model;

using System.ComponentModel.DataAnnotations.Schema;
using MUnique.OpenMU.Persistence;

/// <summary>
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Attributes.PowerUpDefinition"/>.
/// </summary>
[Table(nameof(PowerUpDefinition), Schema = SchemaNames.Configuration)]
internal partial class PowerUpDefinition : MUnique.OpenMU.DataModel.Attributes.PowerUpDefinition, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="TargetAttribute"/>.
    /// </summary>
    public Guid? TargetAttributeId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="TargetAttribute" />.
    /// </summary>
    [ForeignKey(nameof(TargetAttributeId))]
    public AttributeDefinition RawTargetAttribute
    {
        get => base.TargetAttribute as AttributeDefinition;
        set => base.TargetAttribute = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.AttributeSystem.AttributeDefinition TargetAttribute
    {
        get => base.TargetAttribute;set
        {
            base.TargetAttribute = value;
            this.TargetAttributeId = this.RawTargetAttribute?.Id;
        }
    }

    /// <summary>
    /// Gets or sets the identifier of <see cref="Boost"/>.
    /// </summary>
    public Guid? BoostId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="Boost" />.
    /// </summary>
    [ForeignKey(nameof(BoostId))]
    public PowerUpDefinitionValue RawBoost
    {
        get => base.Boost as PowerUpDefinitionValue;
        set => base.Boost = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Attributes.PowerUpDefinitionValue Boost
    {
        get => base.Boost;set
        {
            base.Boost = value;
            this.BoostId = this.RawBoost?.Id;
        }
    }


    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var baseObject = obj as IIdentifiable;
        if (baseObject != null)
        {
            return baseObject.Id == this.Id;
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    
}
