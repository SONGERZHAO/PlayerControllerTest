using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollier2 : MonoBehaviour {
    public GameObject player;
    
    private void OnTriggerEnter(Collider other)//被怪兽打到
    {
        
        MonsterMove monstermove = other.gameObject.GetComponent<MonsterMove>();
        if (!monstermove.Attack)
        {
            Debug.Log("test");
            monstermove.Attack = true;
            player.GetComponent<PlayerAnimitor>().flag = true;
        }
    }
}
