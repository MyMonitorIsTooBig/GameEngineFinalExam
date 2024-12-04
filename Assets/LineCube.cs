using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCube : MonoBehaviour
{
    public GameObject enteredCube;
    bool canCollect = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("cube entered my zone");
        if (canCollect)
        {
            enteredCube = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enteredCube = null;
    }


    public void DestroyCube()
    {
        enteredCube.SetActive(false);
        enteredCube = null;
    }

}
