// Created by HowlC

using UnrealBuildTool;
using System.Collections.Generic;

public class TheFallenDungeonEditorTarget : TargetRules
{
	public TheFallenDungeonEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "TheFallenDungeon" } );
	}
}
