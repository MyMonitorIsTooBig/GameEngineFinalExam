using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommand : Command
{
    [SerializeField]
    public Controller _player;

    public RightCommand(Controller control)
    {
        _player = control;
    }
    // Start is called before the first frame update
    public override void Execute()
    {
        _player.MoveRight();
    }

}
