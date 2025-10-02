using UnrealBuildTool;

public class CoalesceEditorTarget : TargetRules
{
	public CoalesceEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Coalesce");
	}
}
