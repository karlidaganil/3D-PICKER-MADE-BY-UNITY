using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  
    public GameObject player;
    public GameObject[] levels;
    public static Dictionary<string, int> level_Info = new Dictionary<string, int>();

    public  Text CurrentLevel;
    public  Text NexttLevel;

    public GameObject[] panels;
    private void Awake()
    {

     
        if (PlayerPrefs.GetInt("starCount") == 0)
        {
            PlayerPrefs.SetInt("starCount", 0);
        }


        if (PlayerPrefs.GetInt("level")==0)
        {
            PlayerPrefs.SetInt("level", 1);
        }
        if (PlayerPrefs.GetInt("stage") == 0)
        {
            PlayerPrefs.SetInt("stage", 1);
        }

       



        //level_Info.Add("11", 10);
        //level_Info.Add("12", 20);
        //level_Info.Add("13", 30);

    }
    private void Start()
    {
         int level = PlayerPrefs.GetInt("level");
       
        for (int i = level; i < 10; i++)
        {
            Instantiate(levels[i-1], new Vector3(0, 0, 120*(-level+i)), Quaternion.identity);
        }
    
    }
        
    private void Update()
    {
        if (PlayerPrefs.GetInt("stage") == 4)
        {
            int lwl = PlayerPrefs.GetInt("level");
            lwl++;
            PlayerPrefs.SetInt("level", lwl);
            PlayerPrefs.SetInt("stage", 0);

        }
        CurrentLevel.text = PlayerPrefs.GetInt("level") + "";

        NexttLevel.text = (PlayerPrefs.GetInt("level") + 1) + "";
        if (PlayerPrefs.GetInt("stage") == 1)
        {
            panels[0].GetComponent<Image>().color = Color.white;
            panels[1].GetComponent<Image>().color = Color.white;
            panels[2].GetComponent<Image>().color = Color.white;
        }

        if (PlayerPrefs.GetInt("stage") == 2)
        {
            panels[0].GetComponent<Image>().color = Color.green;
        }
        if (PlayerPrefs.GetInt("stage") == 3)
        {
            panels[0].GetComponent<Image>().color = Color.green;
            panels[1].GetComponent<Image>().color = Color.green;
        }
        if (PlayerPrefs.GetInt("stage") == 4)
        {
            panels[0].GetComponent<Image>().color = Color.green;
            panels[1].GetComponent<Image>().color = Color.green;
            panels[2].GetComponent<Image>().color = Color.green;
          
        }
    }


    //public  void level_indicators()
    //{
    //    CurrentLevel.text = PlayerPrefs.GetInt("level") + "";

    //    NexttLevel.text = (PlayerPrefs.GetInt("level") + 1) + "";

    //    if(PlayerPrefs.GetInt("stage")==2)
    //    {
    //        panels[0].GetComponent<Image>().color = Color.green;
    //    }
    //    if (PlayerPrefs.GetInt("stage") == 3)
    //    {
    //        panels[0].GetComponent<Image>().color = Color.green;
    //        panels[1].GetComponent<Image>().color = Color.green;
    //    }
    //    if (PlayerPrefs.GetInt("stage") == 4)
    //    {
    //        panels[0].GetComponent<Image>().color = Color.green;
    //        panels[1].GetComponent<Image>().color = Color.green;
    //        panels[2].GetComponent<Image>().color = Color.green;
    //        PlayerPrefs.SetInt("stage", 0);
    //    }
    //}
}
