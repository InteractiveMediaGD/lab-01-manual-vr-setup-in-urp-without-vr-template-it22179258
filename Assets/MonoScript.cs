using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoScript : MonoBehaviour
{
    public float speed = 5f; //movement speed
    

    // Update is called once per frame
    void Update()
    {
        //get horizontal input
        //multiply by speed and time for more frame- independant movement
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //get vertical input
        float moveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //move the object using collected values
        //MoveX -> left/right movement
        //0-> no moveme t in Y direction
        //Move -> forward/back

        transform.Translate(moveX, 0, moveZ);

    }
}
