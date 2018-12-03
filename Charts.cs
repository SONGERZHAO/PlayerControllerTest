using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charts : MonoBehaviour {
    private GameObject gameobject;
    private GameData gamedata;
    private Score tmp;

    public GameObject pause1;
    public GameObject pause2;
    public GameObject pause3;

    public Text num;
    public Text name;
    public Text count;

    void Start () {

        pause1.SetActive(false);
        pause2.SetActive(false);
        pause3.SetActive(false);
        gameobject = GameObject.Find("GameData");
        gamedata = gameobject.GetComponent<GameData>();
        if ((gamedata.scorelist.Count < 10)||(gamedata.scorelist[9].num < gamedata.scorelist.Count))
        {
            GetName();
        }
        else
        {
            //展示
            DisplayCharts();
        }
        
		
	}

    public void GetName()
    {
        pause1.SetActive(true);
        pause2.SetActive(true);
        pause3.SetActive(true);

    }

    public void OnButtoAdd()
    {
        tmp.player += pause2.GetComponent<InputField>().text;
        tmp.num = gamedata.count;
        if (gamedata.scorelist.Count == 10)
        {
            gamedata.scorelist[9] = tmp;
        }
        else
        {
            gamedata.scorelist.Add(tmp);
        }
        gamedata.Sort_sez();
        DisplayCharts();
        pause1.SetActive(false);
        pause2.SetActive(false);
        pause3.SetActive(false);
        Debug.Log("OK");

    }
    public void OnbuttonQuit()
    {
        gamedata.WriteCharts();
        Application.LoadLevel("Start");
    }

    public void DisplayCharts()
    {
        int i = 1;
        string input1 = "";
        string input2 = "";
        string input3 = "";
        while (i <= gamedata.scorelist.Count)
        {
            input1 += i.ToString();
            input1 += "\n";
            input2 += gamedata.scorelist[i - 1].player;
            input2 += "\n";
            input3 += gamedata.scorelist[i - 1].num.ToString();
            input3 += "\n";
            i++;
        }
        num.text = input1;
        name.text = input2;
        count.text = input3;
    }

	
}
