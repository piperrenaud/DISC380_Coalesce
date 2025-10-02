using UnrealBuildTool;

public class CoalesceServerTarget : TargetRules
{
	public CoalesceServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Coalesce");
	}
}
