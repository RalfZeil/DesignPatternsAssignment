public abstract class GhostTraitDecorator : Ghost
{
    protected Ghost ghost;

    public GhostTraitDecorator(Ghost _ghost)
    {
        ghost = _ghost;
    }

    public override void Haunt()
    {
        ghost?.Haunt();
    }
}
