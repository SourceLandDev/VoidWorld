using LiteLoader.Hook;
using LiteLoader.NET;
using LiteLoader.NET.Std;
using System.Reflection;

namespace VoidWorld;
[PluginMain(pluginName)]
public class Main : IPluginInitializer
{
    internal const string pluginName = "VoidWorld";
    public string Introduction => "虚空世界";
    public Dictionary<string, string> MetaData => new();
    public Version Version => Assembly.GetExecutingAssembly().GetName().Version;
    public void OnInitialize()
    {
        Thook.RegisterHook<OverworldPrepareHeightsHook, OverworldPrepareHeightsHookCallback>();
        Thook.RegisterHook<OverworldDecorateWorldGenPostProcessHook, OverworldDecorateWorldGenPostProcessHookCallback>();
        Thook.RegisterHook<OverworldBuildSurfacesHook, OverworldBuildSurfacesHookCallback>();
        Thook.RegisterHook<NetherPrepareHeightsHook, NetherPrepareHeightsHookCallback>();
        Thook.RegisterHook<NetherBuildSurfacesHook, NetherBuildSurfacesHookCallback>();
        Thook.RegisterHook<TheEndPrepareHeightsHook, TheEndPrepareHeightsHookCallback>();
    }
}
#region OverworldGeneratorMultinoise._prepareHeights
internal delegate void OverworldPrepareHeightsHookCallback(nint @this, nint a2, nint a3, nint a4, nint a5, nint a6, bool a7, pointer<vector<short>> a8, int a9);
[HookSymbol("?_prepareHeights@OverworldGeneratorMultinoise@@EEAAXAEAVBlockVolume@@AEBVChunkPos@@AEBVWorldGenCache@@PEAVAquifer@@$$QEAV?$function@$$A6AXAEBVBlockPos@@AEBVBlock@@H@Z@std@@_NPEAV?$vector@FV?$allocator@F@std@@@7@H@Z")]
internal class OverworldPrepareHeightsHook : THookBase<OverworldPrepareHeightsHookCallback>
{
    public override OverworldPrepareHeightsHookCallback Hook => (_, _, _, _, _, _, _, _, _) => { };
}
#endregion
#region OverworldGeneratorMultinoise.decorateWorldGenPostProcess
internal delegate void OverworldDecorateWorldGenPostProcessHookCallback(nint @this, nint a2, nint a3, nint a4, nint a5);
[HookSymbol("?decorateWorldGenPostProcess@OverworldGeneratorMultinoise@@EEBAXAEAVBiome@@AEAVLevelChunk@@AEAVBlockSource@@AEAVRandom@@@Z")]
internal class OverworldDecorateWorldGenPostProcessHook : THookBase<OverworldDecorateWorldGenPostProcessHookCallback>
{
    public override OverworldDecorateWorldGenPostProcessHookCallback Hook => (_, _, _, _, _) => { };
}
#endregion
#region OverworldGenerator.buildSurfaces
internal delegate void OverworldBuildSurfacesHookCallback(nint @this, nint a2, nint a3, nint a4, nint a5, nint a6);
[HookSymbol("?buildSurfaces@OverworldGenerator@@QEAAXAEAUThreadData@1@AEAVBlockVolume@@AEAVLevelChunk@@AEBVChunkPos@@AEBVSurfaceLevelCache@@@Z")]
internal class OverworldBuildSurfacesHook : THookBase<OverworldBuildSurfacesHookCallback>
{
    public override OverworldBuildSurfacesHookCallback Hook => (_, _, _, _, _, _) => { };
}
#endregion
#region NetherGenerator._prepareHeights
internal delegate void NetherPrepareHeightsHookCallback(nint @this, nint a2, nint a3, bool a4, vector<short> a5, int a6);
[HookSymbol("?_prepareHeights@NetherGenerator@@AEAAXAEAVBlockVolume@@AEBVChunkPos@@_NPEAV?$vector@FV?$allocator@F@std@@@std@@H@Z")]
internal class NetherPrepareHeightsHook : THookBase<NetherPrepareHeightsHookCallback>
{
    public override NetherPrepareHeightsHookCallback Hook => (_, _, _, _, _, _) => { };
}
#endregion
#region NetherGenerator.buildSurfaces
internal delegate void NetherBuildSurfacesHookCallback(nint @this, int a2, bool a3);
[HookSymbol("?buildSurfaces@NetherGenerator@@QEAAXAEAVBlockVolume@@AEAVLevelChunk@@AEBVChunkPos@@@Z")]
internal class NetherBuildSurfacesHook : THookBase<NetherBuildSurfacesHookCallback>
{
    public override NetherBuildSurfacesHookCallback Hook => (_, _, _) => { };
}
#endregion
#region TheEndGenerator._prepareHeights
internal delegate void TheEndPrepareHeightsHookCallback(nint @this, nint a2, nint a3, bool a4, vector<short> a5, int a6);
[HookSymbol("?_prepareHeights@TheEndGenerator@@AEAAXAEAVBlockVolume@@AEBVChunkPos@@_NPEAV?$vector@FV?$allocator@F@std@@@std@@H@Z")]
internal class TheEndPrepareHeightsHook : THookBase<TheEndPrepareHeightsHookCallback>
{
    public override TheEndPrepareHeightsHookCallback Hook => (_, _, _, _, _, _) => { };
}
#endregion
