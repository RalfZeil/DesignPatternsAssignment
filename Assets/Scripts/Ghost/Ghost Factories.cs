//Spirit is most basic form of Ghost
public class SpiritFactory : IGhostFactory
{
    public Ghost CreateGhost()
    {
        return new Ghost();
    }
}

//Poltergheists are know for throwing objects
public class PoltergeistFactory : IGhostFactory
{
    public Ghost CreateGhost()
    {
        return new Thrower(new Ghost());
    }
}

//Banshees are hunter ghosts searching for their prey
public class BansheeFactory : IGhostFactory
{
    public Ghost CreateGhost()
    {
        return new Screamer(new Ghost());
    }
}

//Demons are aggressive ghosts
public class DemonFactory : IGhostFactory
{
    public Ghost CreateGhost()
    {
        return new Aggressive( new Thrower(new Ghost()));
    }
}

//Shades are shy ghosts
public class ShadeFactory : IGhostFactory
{
    public Ghost CreateGhost()
    {
        return new Shy(new Screamer(new Ghost()));
    }
}
