using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTurnCommand : Command
{
    [SerializeField]
    public Controller _player;

    public RightTurnCommand(Controller control)
    {
        _player = control;
    }
    // Start is called before the first frame update
    public override void Execute()
    {
        _player.RotateRight();
    }
}
