using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollier : MonoBehaviour {

    public GameObject Moster;
    private bool flag;

    private void OnTriggerEnter(Collider other)//打到怪兽
    {
        MonsterMove monster = Moster.GetComponent<MonsterMove>();
        monster.Gethit = true;
        GameObject gamedata = GameObject.Find("GameData");
        GameData gamedata2 = gamedata.GetComponent<GameData>();
        gamedata2.count++;
        Debug.Log(gamedata2.count);
    }


}
