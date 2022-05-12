using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayOnStart : MonoBehaviour
{

    bool toggle = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
       
       // StartCoroutine("StartDelay");
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle == true)
        {
            Time.timeScale = 1f;
        }
    }

    public void toggleStartButton()
    {
        toggle = true;
    }
    void begin()
    {
        Time.timeScale = 0f;

    }



    IEnumerator StartDelay()
    {
      

        
        Time.timeScale = 0f;
        float PauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < PauseTime)
            yield return 0;
      
        Time.timeScale = 1f;
    }
}
