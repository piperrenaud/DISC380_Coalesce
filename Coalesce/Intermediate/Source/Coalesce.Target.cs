using UnrealBuildTool;

public class CoalesceTarget : TargetRules
{
	public CoalesceTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Coalesce");
	}
}
