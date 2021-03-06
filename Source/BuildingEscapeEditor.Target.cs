// Copyright 2017 Telmo Valverde

using UnrealBuildTool;
using System.Collections.Generic;

public class BuildingEscapeEditorTarget : TargetRules
{
	public BuildingEscapeEditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "BuildingEscape" } );
	}
}
