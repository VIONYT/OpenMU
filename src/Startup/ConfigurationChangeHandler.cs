﻿// <copyright file="ConfigurationChangeHandler.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Startup;

using MUnique.OpenMU.DataModel.Configuration;
using MUnique.OpenMU.Interfaces;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// An implementation of <see cref="IConfigurationChangePublisher"/> which directly handles the changes.
/// </summary>
public class ConfigurationChangeHandler : IConfigurationChangePublisher
{
    private readonly PlugInManager _plugInManager;
    private readonly IConnectServer _connectServer;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigurationChangeHandler"/> class.
    /// </summary>
    /// <param name="plugInManager">The plug in manager.</param>
    /// <param name="connectServer">The connect server.</param>
    public ConfigurationChangeHandler(PlugInManager plugInManager, IConnectServer connectServer)
    {
        this._plugInManager = plugInManager;
        this._connectServer = connectServer;
    }

    /// <inheritdoc />
    public void ConfigurationChanged(Type type, Guid id, object configuration)
    {
        if (configuration is PlugInConfiguration plugInConfiguration)
        {
            this.OnPlugInConfigurationChanged(id, plugInConfiguration);
        }

        if (configuration is ConnectServerDefinition connectServerDefinition)
        {
            this.OnConnectServerDefinitionChanged(id, connectServerDefinition);
        }
    }

    /// <inheritdoc />
    public void ConfigurationAdded(Type type, Guid id, object configuration)
    {
        if (configuration is not PlugInConfiguration plugInConfiguration)
        {
            return;
        }

        // todo: find out what to do, because usually, plugin configs are not added during runtime.
    }

    /// <inheritdoc />
    public void ConfigurationRemoved(Type type, Guid id)
    {
        if (type.IsAssignableTo(typeof(PlugInConfiguration)))
        {
            this._plugInManager.DeactivatePlugIn(id);
        }
    }

    private void OnConnectServerDefinitionChanged(Guid id, ConnectServerDefinition connectServerDefinition)
    {
        if (this._connectServer.ServerState == ServerState.Started)
        {
            this._connectServer.Shutdown();

            //// todo: is applying new settings required?

            this._connectServer.Start();
        }
    }

    private void OnPlugInConfigurationChanged(Guid id, PlugInConfiguration plugInConfiguration)
    {
        var currentlyActive = this._plugInManager.IsPlugInActive(id);
        if (currentlyActive && !plugInConfiguration.IsActive)
        {
            this._plugInManager.DeactivatePlugIn(id);
        }
        else if (!currentlyActive && plugInConfiguration.IsActive)
        {
            this._plugInManager.ActivatePlugIn(id);
        }
        else
        {
            this._plugInManager.ConfigurePlugIn(id, plugInConfiguration);
        }
    }
}