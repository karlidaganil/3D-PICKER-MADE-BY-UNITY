using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Red_Road : MonoBehaviour
{
    public GameObject Text;
    int needed_Ball_Count;
    int touched_ball_count;

    static int level;
    static int stage;
    

    private void Start()
    {
        needed_Ball_Count = 0;
        touched_ball_count = 0;
        /////////////////////////////////////
        if(gameObject.tag=="1-1")
        {
            needed_Ball_Count = 3;
            Text.GetComponent<TextMesh>().text = "0 / 3";
        }
        if (gameObject.tag == "1-2")
        {
            needed_Ball_Count = 4;
            Text.GetComponent<TextMesh>().text = "0 / 4";
        }
        if (gameObject.tag == "1-3")
        {
            needed_Ball_Count = 5;
            Text.GetComponent<TextMesh>().text = "0 / 5";
        }
        ///////////////////////////////////////////////////
        if (gameObject.tag == "2-1")
        {
            needed_Ball_Count = 6;
            Text.GetComponent<TextMesh>().text = "0 / 6";
        }
        if (gameObject.tag == "2-2")
        {
            needed_Ball_Count = 7;
            Text.GetComponent<TextMesh>().text = "0 / 7";
        }
        if (gameObject.tag == "2-3")
        {
            needed_Ball_Count = 8;
            Text.GetComponent<TextMesh>().text = "0 / 8";
        }
        ///////////////////////////////////////////
        if (gameObject.tag == "3-1")
        {
            needed_Ball_Count = 24;
            Text.GetComponent<TextMesh>().text = "0 / 24";
        }
        if (gameObject.tag == "3-2")
        {
            needed_Ball_Count = 25;
            Text.GetComponent<TextMesh>().text = "0 / 55";
        }
        if (gameObject.tag == "3-3")
        {
            needed_Ball_Count = 26;
            Text.GetComponent<TextMesh>().text = "0 / 66";
        }
        /////////////////////////////////////////
        if (gameObject.tag == "4-1")
        {
            needed_Ball_Count = 27;
            Text.GetComponent<TextMesh>().text = "0 / 27";
        }
        if (gameObject.tag == "4-2")
        {
            needed_Ball_Count = 28;
            Text.GetComponent<TextMesh>().text = "0 / 28";
        }
        if (gameObject.tag == "4-3")
        {
            needed_Ball_Count = 29;
            Text.GetComponent<TextMesh>().text = "0 / 29";
        }
        /////////////////////////////////////////
        if (gameObject.tag == "5-1")
        {
            needed_Ball_Count = 30;
            Text.GetComponent<TextMesh>().text = "0 / 30";
        }
        if (gameObject.tag == "5-2")
        {
            needed_Ball_Count = 31;
            Text.GetComponent<TextMesh>().text = "0 / 31";
        }
        if (gameObject.tag == "5-3")
        {
            needed_Ball_Count = 32;
            Text.GetComponent<TextMesh>().text = "0 / 32";
        }
        ///////////////////////////////////////////////
        if (gameObject.tag == "6-1")
        {
            needed_Ball_Count = 33;
            Text.GetComponent<TextMesh>().text = "0 / 33";
        }
        if (gameObject.tag == "6-2")
        {
            needed_Ball_Count = 34;
            Text.GetComponent<TextMesh>().text = "0 / 34";
        }
        if (gameObject.tag == "6-3")
        {
            needed_Ball_Count = 3;
            Text.GetComponent<TextMesh>().text = "0 / 35";
        }
        //////////////////////////////////////////////
        if (gameObject.tag == "7-1")
        {
            needed_Ball_Count = 5;
            Text.GetComponent<TextMesh>().text = "0 / 36";
        }
        if (gameObject.tag == "7-2")
        {
            needed_Ball_Count = 25;
            Text.GetComponent<TextMesh>().text = "0 / 25";
        }
        if (gameObject.tag == "7-3")
        {
            needed_Ball_Count = 28;
            Text.GetComponent<TextMesh>().text = "0 / 28";
        }
        /////////////////////////////////////////////
        if (gameObject.tag == "8-1")
        {
            needed_Ball_Count = 1;
            Text.GetComponent<TextMesh>().text = "0 / 4";
        }
        if (gameObject.tag == "8-2")
        {
            needed_Ball_Count = 2;
            Text.GetComponent<TextMesh>().text = "0 / 5";
        }
        if (gameObject.tag == "8-3")
        {
            needed_Ball_Count = 3;
            Text.GetComponent<TextMesh>().text = "0 / 6";
        }
        ///////////////////////////////////////////////
        if (gameObject.tag == "9-1")
        {
            needed_Ball_Count = 1;
            Text.GetComponent<TextMesh>().text = "0 / 4";
        }
        if (gameObject.tag == "9-2")
        {
            needed_Ball_Count = 2;
            Text.GetComponent<TextMesh>().text = "0 / 5";
        }
        if (gameObject.tag == "9-3")
        {
            needed_Ball_Count = 3;
            Text.GetComponent<TextMesh>().text = "0 / 6";
        }
        //////////////////////////////////////////
        if (gameObject.tag == "10-1")
        {
            needed_Ball_Count = 1;
            Text.GetComponent<TextMesh>().text = "0 / 4";
        }
        if (gameObject.tag == "10-2")
        {
            needed_Ball_Count = 2;
            Text.GetComponent<TextMesh>().text = "0 / 5";
        }
        if (gameObject.tag == "10-3")
        {
            needed_Ball_Count = 3;
            Text.GetComponent<TextMesh>().text = "0 / 6";
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
       
       
        if (coll.tag != "Player")
        {
            Destroy(coll.gameObject);
            Debug.Log(coll.tag);
            touched_ball_count++;
            if (touched_ball_count == needed_Ball_Count)
            {
                
                int number = PlayerPrefs.GetInt("starCount");
                number = number + touched_ball_count;
                PlayerPrefs.SetInt("starCount", number);
                GameObject.FindGameObjectWithTag("starCountText").GetComponent<Text>().text = number + "";

                touched_ball_count = 0;
                Debug.Log("guzel");
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                gameObject.transform.Translate(new Vector3(0, 2, 0));
                gameObject.GetComponent<BoxCollider>().isTrigger = false;
                PlayerControl.go = true;
                Debug.Log("ANAN");

                level = PlayerPrefs.GetInt("level");
                stage = PlayerPrefs.GetInt("stage");

                if (stage == 3)
                {
                    level++;
                    PlayerPrefs.SetInt("level", level);
                    stage = 1;
                    PlayerPrefs.SetInt("stage", stage);

                    Debug.Log(level + " stage  " + stage);
                }
                else
                {
                    stage++;
                    PlayerPrefs.SetInt("stage", stage);

                }
                
            }
            else if(touched_ball_count < needed_Ball_Count)
            {
                // Invoke("ReloadScene", 3f);

            }

        }

        level = PlayerPrefs.GetInt("level");
        stage = PlayerPrefs.GetInt("stage");

        Debug.Log(level + " -- " + stage);

    }
    void ReloadScene()
    {
        GameObject.Find("Player").transform.position = new Vector3(0, 0, -15);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        SceneManager.LoadScene(scene.name);
    }


}
