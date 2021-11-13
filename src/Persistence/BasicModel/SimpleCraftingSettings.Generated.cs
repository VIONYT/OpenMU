// <copyright file="SimpleCraftingSettings.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel;

using MUnique.OpenMU.Persistence.Json;

/// <summary>
/// A plain implementation of <see cref="SimpleCraftingSettings"/>.
/// </summary>
public partial class SimpleCraftingSettings : MUnique.OpenMU.DataModel.Configuration.ItemCrafting.SimpleCraftingSettings, IIdentifiable, IConvertibleTo<SimpleCraftingSettings>
{
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets the raw collection of <see cref="RequiredItems" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("requiredItems")]
    [System.Text.Json.Serialization.JsonPropertyName("requiredItems")]
    public ICollection<ItemCraftingRequiredItem> RawRequiredItems { get; } = new List<ItemCraftingRequiredItem>();
    
    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingRequiredItem> RequiredItems
    {
        get => base.RequiredItems ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingRequiredItem, ItemCraftingRequiredItem>(this.RawRequiredItems);
        protected set
        {
            this.RequiredItems.Clear();
            foreach (var item in value)
            {
                this.RequiredItems.Add(item);
            }
        }
    }

    /// <summary>
    /// Gets the raw collection of <see cref="ResultItems" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("resultItems")]
    [System.Text.Json.Serialization.JsonPropertyName("resultItems")]
    public ICollection<ItemCraftingResultItem> RawResultItems { get; } = new List<ItemCraftingResultItem>();
    
    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingResultItem> ResultItems
    {
        get => base.ResultItems ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingResultItem, ItemCraftingResultItem>(this.RawResultItems);
        protected set
        {
            this.ResultItems.Clear();
            foreach (var item in value)
            {
                this.ResultItems.Add(item);
            }
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

    /// <inheritdoc/>
    public SimpleCraftingSettings Convert() => this;
}
