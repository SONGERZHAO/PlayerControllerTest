using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollier : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OKOKOKOKOKO");
        //Transform trans = Moster.transform;
        //float x = (this.transform.position.x - trans.position.x) * 2;
        //float y = trans.position.y;
        //float z = (this.transform.position.z - trans.position.z) * 2;
        //Debug.Log(x);
        //Debug.Log(y);
        //Debug.Log(z);

        //trans.Translate(new Vector3(-2, y, -2));

    }
}
