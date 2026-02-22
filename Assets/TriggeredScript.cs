using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //the function runs only when another object enters this trigger collider
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " has entered " + gameObject.name);
    }
    //the function runs only when another object leaves this trigger collider
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " has exited " + gameObject.name);
    }
    //the function runs only when another object stays inside this trigger collider
    private void OnTriggerStay(Collider other)
    {
        //print the message showing which object is currently inside to the collider
        Debug.Log(other.name + " is inside " + gameObject.name);
    }
}
