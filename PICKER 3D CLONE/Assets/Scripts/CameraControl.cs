using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
     GameObject Player;
    private void Start()
    {
        Player = GameObject.Find("Player");
       
    }
    void LateUpdate()
    {
        transform.position = new Vector3(0f, Player.transform.position.y + 9, Player.transform.position.z - 3.5f);
    }

    void bul()
    {
       
    }
 
}
