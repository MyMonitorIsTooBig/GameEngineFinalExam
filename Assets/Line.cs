using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{

    [SerializeField] List<LineCube> cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cubes[0].enteredCube != null && cubes[1].enteredCube != null && cubes[2].enteredCube != null && cubes[3].enteredCube != null && cubes[4].enteredCube != null)
        {
            deleteLine();
        }
    }


    void deleteLine()
    {
        foreach(LineCube cube in cubes)
        {
            cube.DestroyCube();
        }
    }
}
