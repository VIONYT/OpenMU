// <copyright file="ExtendedTypeContext.Generated.cs" company="MUnique">
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
/// DbContext which sets all extended base types to ignore.
/// </summary>
public class ExtendedTypeContext : Microsoft.EntityFrameworkCore.DbContext
{
    /// <inheritdoc/>
    protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Statistics.MiniGameRankingEntry>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Account>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.AppearanceData>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Character>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.CharacterQuestState>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Guild>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.GuildMember>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.Item>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.ItemAppearance>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.ItemOptionLink>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.ItemStorage>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.LetterBody>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.QuestMonsterKillRequirementState>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Entities.SkillEntry>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.BattleZoneDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.CharacterClass>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ChatServerDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ChatServerEndpoint>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ConnectServerDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.DropItemGroup>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.EnterGate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ExitGate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameClientDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameConfiguration>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameMapDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameServerConfiguration>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameServerDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.GameServerEndpoint>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Gate>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.JewelMix>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.LevelDependentDamage>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MagicEffectDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MasterSkillDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MasterSkillRoot>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameReward>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MiniGameSpawnWave>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MonsterAttribute>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MonsterDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.MonsterSpawnArea>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Rectangle>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Skill>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.StatAttributeDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.WarpInfo>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestItemRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestMonsterKillRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Quests.QuestReward>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.AttributeRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.CombinationBonusRequirement>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.IncreasableItemOption>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOfItemSet>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOption>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionCombinationBonus>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionOfLevel>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemSetGroup>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.ItemSlotType>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.Items.LevelBonus>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCrafting>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingRequiredItem>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.ItemCraftingResultItem>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Configuration.ItemCrafting.SimpleCraftingSettings>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Attributes.PowerUpDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Attributes.PowerUpDefinitionValue>();
        modelBuilder.Ignore<MUnique.OpenMU.DataModel.Attributes.PowerUpDefinitionWithDuration>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.AttributeDefinition>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.StatAttribute>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.ConstValueAttribute>();
        modelBuilder.Ignore<MUnique.OpenMU.AttributeSystem.AttributeRelationship>();
        modelBuilder.Ignore<MUnique.OpenMU.Interfaces.LetterHeader>();
        modelBuilder.Ignore<MUnique.OpenMU.Interfaces.Friend>();
        modelBuilder.Ignore<MUnique.OpenMU.PlugIns.PlugInConfiguration>();

    }

    /// <summary>
    /// Adds the generated join definitions.
    /// </summary>
    /// <param name="modelBuilder">The model builder.</param>
    protected void AddJoinDefinitions(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>().HasMany(entity => entity.JoinedUnlockedCharacterClasses).WithOne(join => join.Account);
        modelBuilder.Entity<AccountCharacterClass>().HasKey(join => new { join.AccountId, join.CharacterClassId });
        modelBuilder.Entity<Character>().HasMany(entity => entity.JoinedDropItemGroups).WithOne(join => join.Character);
        modelBuilder.Entity<CharacterDropItemGroup>().HasKey(join => new { join.CharacterId, join.DropItemGroupId });
        modelBuilder.Entity<Item>().HasMany(entity => entity.JoinedItemSetGroups).WithOne(join => join.Item);
        modelBuilder.Entity<ItemItemSetGroup>().HasKey(join => new { join.ItemId, join.ItemSetGroupId });
        modelBuilder.Entity<ItemAppearance>().HasMany(entity => entity.JoinedVisibleOptions).WithOne(join => join.ItemAppearance);
        modelBuilder.Entity<ItemAppearanceItemOptionType>().HasKey(join => new { join.ItemAppearanceId, join.ItemOptionTypeId });
        modelBuilder.Entity<DropItemGroup>().HasMany(entity => entity.JoinedPossibleItems).WithOne(join => join.DropItemGroup);
        modelBuilder.Entity<DropItemGroupItemDefinition>().HasKey(join => new { join.DropItemGroupId, join.ItemDefinitionId });
        modelBuilder.Entity<GameMapDefinition>().HasMany(entity => entity.JoinedDropItemGroups).WithOne(join => join.GameMapDefinition);
        modelBuilder.Entity<GameMapDefinitionDropItemGroup>().HasKey(join => new { join.GameMapDefinitionId, join.DropItemGroupId });
        modelBuilder.Entity<GameServerConfiguration>().HasMany(entity => entity.JoinedMaps).WithOne(join => join.GameServerConfiguration);
        modelBuilder.Entity<GameServerConfigurationGameMapDefinition>().HasKey(join => new { join.GameServerConfigurationId, join.GameMapDefinitionId });
        modelBuilder.Entity<MasterSkillDefinition>().HasMany(entity => entity.JoinedRequiredMasterSkills).WithOne(join => join.MasterSkillDefinition);
        modelBuilder.Entity<MasterSkillDefinitionSkill>().HasKey(join => new { join.MasterSkillDefinitionId, join.SkillId });
        modelBuilder.Entity<MonsterDefinition>().HasMany(entity => entity.JoinedDropItemGroups).WithOne(join => join.MonsterDefinition);
        modelBuilder.Entity<MonsterDefinitionDropItemGroup>().HasKey(join => new { join.MonsterDefinitionId, join.DropItemGroupId });
        modelBuilder.Entity<Skill>().HasMany(entity => entity.JoinedQualifiedCharacters).WithOne(join => join.Skill);
        modelBuilder.Entity<SkillCharacterClass>().HasKey(join => new { join.SkillId, join.CharacterClassId });
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.JoinedQualifiedCharacters).WithOne(join => join.ItemDefinition);
        modelBuilder.Entity<ItemDefinitionCharacterClass>().HasKey(join => new { join.ItemDefinitionId, join.CharacterClassId });
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.JoinedPossibleItemSetGroups).WithOne(join => join.ItemDefinition);
        modelBuilder.Entity<ItemDefinitionItemSetGroup>().HasKey(join => new { join.ItemDefinitionId, join.ItemSetGroupId });
        modelBuilder.Entity<ItemDefinition>().HasMany(entity => entity.JoinedPossibleItemOptions).WithOne(join => join.ItemDefinition);
        modelBuilder.Entity<ItemDefinitionItemOptionDefinition>().HasKey(join => new { join.ItemDefinitionId, join.ItemOptionDefinitionId });
        modelBuilder.Entity<ItemCraftingRequiredItem>().HasMany(entity => entity.JoinedPossibleItems).WithOne(join => join.ItemCraftingRequiredItem);
        modelBuilder.Entity<ItemCraftingRequiredItemItemDefinition>().HasKey(join => new { join.ItemCraftingRequiredItemId, join.ItemDefinitionId });
        modelBuilder.Entity<ItemCraftingRequiredItem>().HasMany(entity => entity.JoinedRequiredItemOptions).WithOne(join => join.ItemCraftingRequiredItem);
        modelBuilder.Entity<ItemCraftingRequiredItemItemOptionType>().HasKey(join => new { join.ItemCraftingRequiredItemId, join.ItemOptionTypeId });

    }
}
