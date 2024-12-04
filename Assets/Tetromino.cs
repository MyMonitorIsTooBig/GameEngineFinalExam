using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{

    public bool canMove = true;
    Rigidbody rb;

    public bool swapInputs = false;

    [SerializeField] List<GameObject> parts;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        if(rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
        //rb.velocity = transform.
        rb.velocity = -transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            rb.velocity = -transform.up;
        }

        if(!parts[0].gameObject.activeSelf && !parts[1].gameObject.activeSelf && !parts[2].gameObject.activeSelf)
        {
            foreach(GameObject part in parts)
            {
                part.SetActive(true);
            }
            Reset();
        }
    }


    public void Left()
    {
        if (canMove)
        {
            //rb.velocity = -transform.right + -transform.up;
            transform.position = transform.position + -transform.right * 0.5f;
        }
    }

    public void Right()
    {
        if (canMove)
        {
            //rb.velocity = transform.right + -transform.up;
            transform.position = transform.position + transform.right * 0.5f;

        }
    }

    public void TurnLeft()
    {
        if (canMove)
        {
            transform.Rotate(new Vector3(0,0,90));
        }
    }

    public void TurnRight()
    {
        if (canMove)
        {
            transform.Rotate(new Vector3(0, 0, -90));
        }
    }

    public void Reset()
    {

        //reset code here!
        canMove = true;
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.identity;
        gameObject.SetActive(false);


        ObjectPool.Instance.returnToPool(gameObject);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Tetroid"))
        {
            canMove = false;
        }
    }
}
