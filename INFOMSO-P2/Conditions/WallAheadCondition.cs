using INFOMSO_P2.Game;
namespace INFOMSO_P2.Commands;

public class WallAheadCondition : ICondition
{
    public bool Holds(Scene scene)
    {
        return
            scene.GetMapElement(scene.GetCharacter().GetAheadPosition()) == MapElement.Blocked;
    }
    
    public new string ToString() => "WallAhead";
}