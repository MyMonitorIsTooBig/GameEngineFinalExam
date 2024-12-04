using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommand : Command
{
    [SerializeField]
    public Controller _player;

    public LeftCommand(Controller control)
    {
        _player = control;
    }
    // Start is called before the first frame update
    public override void Execute()
    {
        _player.MoveLeft();
    }
}
