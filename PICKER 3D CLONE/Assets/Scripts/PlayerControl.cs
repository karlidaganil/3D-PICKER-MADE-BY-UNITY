using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
   public static bool go = false;
    private void Start()
    {
        go = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(go);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5f);
        }

        if (go)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10f);
        }
         
        


        for (int i = 0; i < Input.touchCount; i++)           //ilk if in için Input.GetTouch(i).phase == TouchPhase.Moved idi
        {
            if (Input.GetTouch(i).phase == TouchPhase.Moved)
            {
                Vector2 touchPosition = Input.GetTouch(i).position;
              


               

                    transform.Translate(Input.GetTouch(i).deltaPosition.x * 0.0075f,0,0, Space.World);
                }

            }



        }
    
   
   public void Close_Panel()
    {
        GameObject.Find("touchPlayPanel").active = false;
       // SceneManager.LoadScene(0);
        go = true;
        Debug.Log("asdsadsa");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="stop")
        {
            go = false;
            Destroy(other.gameObject);
        }
        
    }
}
