﻿// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using MUnique.OpenMU.LoginServer.Host;
using MUnique.OpenMU.Dapr.Common;

var builder = DaprService.CreateBuilder("LoginServer", args);

// Add services to the container.
builder.Services
    .AddSingleton<PersistentLoginServer>()
    .AddHostedService<LoginStateCleanup>()
    .AddSingleton<GameServerRegistry>();

var app = builder.BuildAndConfigure();

app.Run();