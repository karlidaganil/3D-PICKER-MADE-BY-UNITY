using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Doors : MonoBehaviour
{
    public GameObject left_Door;
    public GameObject right_Door;
    static bool rotated = false;
    private void Start()
    {
        rotated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            if(rotated==false)
            {
                left_Door.transform.Rotate(new Vector3(-90, 90, 90));
                right_Door.transform.Rotate(new Vector3(-90, 0, 90));
                rotated = true;
            }
           
        }
       
    }
}
