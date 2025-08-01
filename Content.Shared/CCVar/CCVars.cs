using Content.Shared.Administration;
using Content.Shared.CCVar.CVarAccess;
using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

/// <summary>
/// Contains all the CVars used by content.
/// </summary>
/// <remarks>
/// NOTICE FOR FORKS: Put your own CVars in a separate file with a different [CVarDefs] attribute. RT will automatically pick up on it.
/// </remarks>
[CVarDefs]
public sealed partial class CCVars : CVars
{
    // Only debug stuff lives here.

#if DEBUG
    [CVarControl(AdminFlags.Debug)]
    public static readonly CVarDef<string> DebugTestCVar =
        CVarDef.Create("debug.test_cvar", "default", CVar.SERVER);

    [CVarControl(AdminFlags.Debug)]
    public static readonly CVarDef<float> DebugTestCVar2 =
        CVarDef.Create("debug.test_cvar2", 123.42069f, CVar.SERVER);
#endif

    /// <summary>
    /// A simple toggle to test <c>OptionsVisualizerComponent</c>.
    /// </summary>
    public static readonly CVarDef<bool> DebugOptionVisualizerTest =
        CVarDef.Create("debug.option_visualizer_test", false, CVar.CLIENTONLY);

    /// <summary>
    /// Set to true to disable parallel processing in the pow3r solver.
    /// </summary>
    public static readonly CVarDef<bool> DebugPow3rDisableParallel =
        CVarDef.Create("debug.pow3r_disable_parallel", true, CVar.SERVERONLY);

    /// <summary>
    ///     Goobstation: The amount of time between NPC Silicons draining their battery in seconds.
    /// </summary>
    public static readonly CVarDef<float> SiliconNpcUpdateTime =
        CVarDef.Create("silicon.npcupdatetime", 1.5f, CVar.SERVERONLY);

    public static readonly CVarDef<bool> AutoGetUp =
        CVarDef.Create("rest.auto_get_up", false, CVar.CLIENT | CVar.ARCHIVE | CVar.REPLICATED);

    #region Surgery

    public static readonly CVarDef<bool> CanOperateOnSelf =
        CVarDef.Create("surgery.can_operate_on_self", true, CVar.SERVERONLY);

    public static readonly CVarDef<bool> CrawlUnderTables =
        CVarDef.Create("rest.crawlundertables", true, CVar.SERVER | CVar.ARCHIVE);
        
    public static readonly CVarDef<bool> AutoVoteEnabled =
            CVarDef.Create("vote.autovote_enabled", true, CVar.SERVERONLY); // Floof

        /// Automatically starts a map vote when returning to the lobby.
        /// Requires auto voting to be enabled.
    public static readonly CVarDef<bool> MapAutoVoteEnabled =
            CVarDef.Create("vote.map_autovote_enabled", true, CVar.SERVERONLY);

        /// Automatically starts a gamemode vote when returning to the lobby.
        /// Requires auto voting to be enabled.
    public static readonly CVarDef<bool> PresetAutoVoteEnabled =
            CVarDef.Create("vote.preset_autovote_enabled", true, CVar.SERVERONLY);

    #endregion
}
