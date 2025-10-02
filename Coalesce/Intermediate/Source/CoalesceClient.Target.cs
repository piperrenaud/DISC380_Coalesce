using UnrealBuildTool;

public class CoalesceClientTarget : TargetRules
{
	public CoalesceClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Coalesce");
	}
}
