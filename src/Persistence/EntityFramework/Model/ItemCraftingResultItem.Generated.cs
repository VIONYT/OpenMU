// <copyright file="ItemCraftingResultItem.Generated.cs" company="MUnique">
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
/// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingResultItem"/>.
/// </summary>
[Table(nameof(ItemCraftingResultItem), Schema = SchemaNames.Configuration)]
internal partial class ItemCraftingResultItem : MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingResultItem, IIdentifiable
{
    
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the identifier of <see cref="ItemDefinition"/>.
    /// </summary>
    public Guid? ItemDefinitionId { get; set; }

    /// <summary>
    /// Gets the raw object of <see cref="ItemDefinition" />.
    /// </summary>
    [ForeignKey(nameof(ItemDefinitionId))]
    public ItemDefinition RawItemDefinition
    {
        get => base.ItemDefinition as ItemDefinition;
        set => base.ItemDefinition = value;
    }

    /// <inheritdoc/>
    [NotMapped]
    public override MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition ItemDefinition
    {
        get => base.ItemDefinition;set
        {
            base.ItemDefinition = value;
            this.ItemDefinitionId = this.RawItemDefinition?.Id;
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
