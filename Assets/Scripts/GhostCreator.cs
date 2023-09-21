public class GhostCreator
{
    private IGhostFactory factory;

    public Ghost OrderGhost(GhostType ghostType)
    {
        switch (ghostType)
        {
            case GhostType.spirit:
                factory = new SpiritFactory();
                return  factory.CreateGhost();

            case GhostType.poltergeist:
                factory = new PoltergeistFactory();
                return factory.CreateGhost();

            case GhostType.banshee:
                factory = new BansheeFactory();
                return factory.CreateGhost();

            case GhostType.demon:
                factory = new DemonFactory();
                return factory.CreateGhost();

            case GhostType.shade:
                factory = new ShadeFactory();
                return factory.CreateGhost();

            default:
                return null;
        }
    }
}
