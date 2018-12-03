using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    Vector3 D_Vale;
    Vector3 Vale;
	void Start () {
        D_Vale = Player.transform.position - transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        transform.position = Player.transform.position - D_Vale;

	}
}
