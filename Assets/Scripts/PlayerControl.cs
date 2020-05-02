using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float horizontalMovement;
    private float verticalMovement;
    private float sensitivity = 50f;
    private float horizontalTurn;
    private bool jump;
    private float acceleration = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        horizontalTurn = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        jump = Input.GetAxis("Jump") > 0;

        Vector3 destination = new Vector3(horizontalMovement, 0f, verticalMovement) * acceleration;
        
        
        
        transform.Translate(destination, Space.Self);

        //transform.Translate();
    }
}
