using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public struct Score
{
    public int num;
    public string player;
};

public class GameData : MonoBehaviour
{

    public List<Score> scorelist = new List<Score>();
    public bool flag = true;
    public int count;

    private void Start()
    {
        ReadCharts();
        GameObject.DontDestroyOnLoad(gameObject);

    }
    public void ReadCharts()
    {

        // FileStream file = new FileStream(Application.dataPath + "/Charts", FileMode.OpenOrCreate);
        FileInfo fileinfo = new FileInfo(Application.dataPath + "/Charts");
        StreamReader rd = null;

        if (!fileinfo.Exists)
        {
            fileinfo.Create();

        }

        rd = new StreamReader(Application.dataPath + "/Charts");
        string nextLine;
        while ((nextLine = rd.ReadLine()) != null)
        {
            scorelist.Add(JsonUtility.FromJson<Score>(nextLine));
            // Sort_sez();
        }
        rd.Close();
    }

    public void WriteCharts()
    {
        FileInfo fileinfo = new FileInfo(Application.dataPath + "/Charts");
        if (!fileinfo.Exists)
        {
            Debug.Log("Charts lost");
            return;
        }
        StreamWriter wt = new StreamWriter(Application.dataPath + "/Charts", false);
        int i = 0;
        while (i < scorelist.Count)
        {
            Debug.Log(scorelist[i].player);
            wt.WriteLine(JsonUtility.ToJson(scorelist[i]));
            i++;
            Debug.Log("Has write");
        }
        wt.Close();
    }
    public void Sort_sez()
    {
        int i = scorelist.Count - 1;
        while (i >= 1)
        {
            if (scorelist[i].num > scorelist[i - 1].num)
            {
                Score tmp = scorelist[i];
                scorelist[i] = scorelist[i - 1];
                scorelist[i - 1] = tmp;
            }
            i--;

        }
    }

}

