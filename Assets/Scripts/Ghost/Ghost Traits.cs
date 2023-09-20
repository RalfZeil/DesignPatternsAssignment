using UnityEngine;

//Ghost is aggressive and attacks without warning to the players
public class Aggressive : GhostTraitDecorator
{
    public Aggressive(Ghost _ghost) : base(_ghost) { }

    public override void Haunt()
    {
        base.Haunt();
        Debug.Log("Attacked without warning...");
    }
}

//Ghost throws random objects around the ghost room
public class Thrower : GhostTraitDecorator
{
    public Thrower(Ghost _ghost) : base(_ghost) { }

    public override void Haunt()
    {
        base.Haunt();
        Debug.Log("Threw Object...");
    }
}

//Ghost can be heard screaming through the parabolic microphone
public class Screamer : GhostTraitDecorator
{
    public Screamer(Ghost _ghost) : base(_ghost) { }

    public override void Haunt()
    {
        base.Haunt();
        Debug.Log("Screaming...");
    }
}

//Ghost is less active when multiple people around
public class Shy : GhostTraitDecorator
{
    public Shy(Ghost _ghost) : base(_ghost) { }

    public override void Haunt()
    {
        base.Haunt();
        Debug.Log("*silence*...");
    }
}
