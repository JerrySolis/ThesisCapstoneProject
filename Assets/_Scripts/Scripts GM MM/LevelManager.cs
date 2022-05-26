using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
  //  public static event Action<LevelState> OnLevelStateChange;
    
    public Button F1Level2Button, F1Level3Button, F1Level4Button,
                  F1Level5Button, F1Level6Button, F1Level7Button,
                  F1Level8Button, F1Level9Button, F1Level10Button;
    public int Floor1Levels = 1;
 


    

            void Awake()
            {
                Instance = this;
            }

            public void HandleOnFloor1Level1()
            {
       
                SceneManager.LoadSceneAsync("Floor 1 Level 1");
            }
            public void HandleOnFloor1Level2()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 2");
            }
            public void HandleOnFloor1Level3()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 3");
            }
            public void HandleOnFloor1Level4()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 4");
            }
            public void HandleOnFloor1Level5()
            {

                SceneManager.LoadSceneAsync("Floor 1 Level 5");
            }
            public void HandleOnFloor1Level6()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 6");
            }
            public void HandleOnFloor1Level7()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 7");
            }
            public void HandleOnFloor1Level8()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 8");
            }
            public void HandleOnFloor1Level9()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 9");
            }
            public void HandleOnFloor1Level10()
            {
                SceneManager.LoadSceneAsync("Floor 1 Level 10");
            }

    
    public void resetLevels()
    {
        
        //Resetting all saved level states   
        PlayerPrefs.DeleteKey("LevelState");
        Debug.Log("All levels state is reset! Outcome:" + Floor1Levels);
        PlayerPrefs.SetInt("LevelState", 1);
    }
    public void SetLevelState()
    {
        Floor1Levels++;
        PlayerPrefs.SetInt("LevelState", Floor1Levels);
    }
    public void UpdateLevelState(int LevelState)
    {
        Floor1Levels = LevelState;
    }
    // Start is called before the first frame update
    void Start()
    {
        Floor1Levels = PlayerPrefs.GetInt("LevelState");
        Debug.Log("Current Level outcome is "+Floor1Levels);
    }

    // Update is called once per frame
    void Update()
    {
        F1Level2Button.interactable = Floor1Levels >= 2;
        F1Level3Button.interactable = Floor1Levels >= 3;
        F1Level4Button.interactable = Floor1Levels >= 4;
        F1Level5Button.interactable = Floor1Levels >= 5;
        F1Level6Button.interactable = Floor1Levels >= 6;
        F1Level7Button.interactable = Floor1Levels >= 7;
        F1Level8Button.interactable = Floor1Levels >= 8;
        F1Level9Button.interactable = Floor1Levels >= 9;
        F1Level10Button.interactable = Floor1Levels >= 10;
      
    }
}

