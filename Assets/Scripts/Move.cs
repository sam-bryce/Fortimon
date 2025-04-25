using UnityEngine;

public class Move
{
    public MoveInfo info { get; set; }
    public int PP { get; set; }
    public Move(MoveInfo info)
    {
        this.info = info;
        PP = info.PP;
    }
}
