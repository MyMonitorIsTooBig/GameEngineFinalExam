using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField]
    private Command _Left;
    [SerializeField]
    private Command _Right;
    [SerializeField]
    private Command _LeftTurn;
    [SerializeField]
    private Command _RightTurn;
    [SerializeField]
    private Controller _player;
    // Start is called before the first frame update
    void Start()
    {
        _Left = new LeftCommand(_player);
        _LeftTurn = new LeftTurnCommand(_player);
        _Right = new RightCommand(_player);
        _RightTurn = new RightTurnCommand(_player);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            _Left.Execute();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            _Right.Execute();
        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            //NOTE ADD FUNCTION TO SWAP WHEN DIFF COLOR!!!!
            if (_player.currentPiece.GetComponent<Tetromino>().swapInputs)
            {
                _LeftTurn.Execute();
            }
            else
            {
                _RightTurn.Execute();
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_player.currentPiece.GetComponent<Tetromino>().swapInputs)
            {
                _RightTurn.Execute();
            }
            else
            {
                _LeftTurn.Execute();
            }
        }
    }
}
