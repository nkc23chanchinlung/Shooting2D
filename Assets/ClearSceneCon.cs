using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClearSceneCon : MonoBehaviour
{
    public Text sccon;
    // Start is called before the first frame update
    void Start()
    {
        sccon.text = "�򉻎���:" + GameDirector.kyorii.ToString("D6");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void motoru()
    {
        SceneManager.LoadScene(0);
    }
}
