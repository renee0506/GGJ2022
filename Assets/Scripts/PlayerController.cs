using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 1f;
    public bool leftPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (!leftPlayer)
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            var verticalInput = Input.GetAxis("Vertical");


            GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, 0, verticalInput).normalized * Speed;
        }
        else
        {
            var horizontalInput = Input.GetAxis("HorizontalLeft");
            var verticalInput = Input.GetAxis("VerticalLeft");


            GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, 0, verticalInput).normalized * Speed;
        }
        
        //Debug.Log(Input.GetAxis("Vertical"));
    }
}
