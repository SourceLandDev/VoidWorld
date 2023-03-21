using LiteLoader.Hook;
using LiteLoader.NET;

namespace NoPortal;
[PluginMain("NoPortal")]
public class Main : IPluginInitializer
{
    public string Introduction => "禁用下界传送门";
    public Dictionary<string, string> MetaData => new();
    public Version Version => new();
    public void OnInitialize() => Thook.RegisterHook<TrySpawnPortalHook, TrySpawnPortalHookDelegate>();
}

internal delegate bool TrySpawnPortalHookDelegate(nint a1, nint a2);
[HookSymbol("?trySpawnPortal@PortalBlock@@SA_NAEAVBlockSource@@AEBVBlockPos@@@Z")]
internal class TrySpawnPortalHook : THookBase<TrySpawnPortalHookDelegate>
{
    public override TrySpawnPortalHookDelegate Hook => (a1, a2) => false;
}
