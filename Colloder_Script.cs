using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colloder_Script : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("OnTiggerEnter");
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("OnCollisionEnter");
    }

}
