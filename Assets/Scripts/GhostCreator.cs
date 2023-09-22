using System.Collections.Generic;

public class GhostCreator
{
    private readonly Dictionary<GhostType, IGhostFactory> factories =
        new Dictionary<GhostType, IGhostFactory>
        {
            { GhostType.spirit, new SpiritFactory() },
            { GhostType.poltergeist, new PoltergeistFactory() },
            { GhostType.banshee, new BansheeFactory() },
            { GhostType.demon, new DemonFactory() },
            { GhostType.shade, new ShadeFactory() }
        };

    public Ghost OrderGhost(GhostType ghostType)
    {
        return factories[ghostType].CreateGhost();
    }
}
