// Created by HowlC

using UnrealBuildTool;
using System.Collections.Generic;

public class TheFallenDungeonTarget : TargetRules
{
	public TheFallenDungeonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "TheFallenDungeon" } );
	}
}
