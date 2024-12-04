using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    public GameObject currentPiece { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MoveLeft()
    {

        currentPiece.GetComponent<Tetromino>().Left();
    }

    public void MoveRight()
    {

        currentPiece.GetComponent<Tetromino>().Right();

    }


    public void RotateLeft()
    {
        currentPiece.GetComponent<Tetromino>().TurnLeft();

    }

    public void RotateRight()
    {
        currentPiece.GetComponent<Tetromino>().TurnRight();

    }
}
