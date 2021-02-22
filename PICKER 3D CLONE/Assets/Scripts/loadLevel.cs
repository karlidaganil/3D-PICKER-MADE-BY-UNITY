using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadLevel : MonoBehaviour
{
    public void main_Scene()
    {
       // GameObject.Find("touchPlayPanel").active = false;
        SceneManager.LoadScene(1);
        Debug.Log("asdsadsa");
    }
}
