﻿global using AutoRetainer.Configuration;
global using AutoRetainer.Helpers;
global using AutoRetainer.Modules;
global using AutoRetainer.Modules.GcHandin;
global using AutoRetainer.Modules.Multi;
global using AutoRetainer.Scheduler;
global using Dalamud.Interface;
global using Dalamud.Interface.Colors;
global using Dalamud.Interface.Utility;
global using Dalamud.Interface.Windowing;
global using Dalamud.Plugin;
global using ECommons;
global using ECommons.DalamudServices;
global using ECommons.DalamudServices.Legacy;
global using ECommons.ImGuiMethods;
global using ECommons.Logging;
global using ECommons.Schedulers;
global using ImGuiNET;
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Numerics;
global using System.Runtime.InteropServices;
global using System.Text;
global using System.Threading.Tasks;
global using static AutoRetainer.AutoRetainer;
global using static ECommons.GenericHelpers;
global using Callback = ECommons.Automation.Callback;
global using CSFramework = FFXIVClientStructs.FFXIV.Client.System.Framework.Framework;
global using S = AutoRetainer.Services.AutoRetainerServiceManager;
global using NightmareUI.PrimaryUI;