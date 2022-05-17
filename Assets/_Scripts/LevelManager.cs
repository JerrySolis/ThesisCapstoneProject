using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public static event Action<LevelState> OnLevelStateChange;
    public LevelState State;
    public Button F1Level2Button, F1Level3Button, F1Level4Button,
                  F1Level5Button, F1Level6Button, F1Level7Button,
                  F1Level8Button, F1Level9Button, F1Level10Button;
    int Floor1Levels = 1;




    void Awake()
    {
        Instance = this;
        //Subscribing to Changing GameState
        LevelManager.OnLevelStateChange += LevelManagerOnOnGameStateChange;
    }

    void OnDestroy()
    {
        //Removing Subscribed GameState and release Process Data
        LevelManager.OnLevelStateChange -= LevelManagerOnOnGameStateChange;

    }
    private void LevelManagerOnOnGameStateChange(LevelState state)
    {

        F1Level2Button.interactable = Floor1Levels >= 2;
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



    public void NextLevels()
    {
        Floor1Levels++;
        if (Floor1Levels >= 2)
        {
   
            F1Level3Button.interactable = Floor1Levels >= 2;
            HandleOnFloor1Level2();
           

            Debug.Log(Floor1Levels);
   
        }
        else if (Floor1Levels >= 3)
        {
            F1Level3Button.interactable = Floor1Levels >= 3;
            HandleOnFloor1Level3();
            Floor1Levels = Floor1Levels;
        }
        else if (Floor1Levels >= 4)
        {
            F1Level3Button.interactable = Floor1Levels >= 4;
       
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Floor1Levels);
        if (!PlayerPrefs.HasKey("Floor1Levels"))
        {
            PlayerPrefs.SetInt("Floor1Levels", Floor1Levels);
         
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}


public enum LevelState
{
    Floor1Level1,
    Floor1Level2,
    Floor1Level3,
    Floor1Level4,
    Floor1Level5,
    Floor1Level6,
    Floor1Level7,
    Floor1Level8,
    Floor1Level9,
    Floor1Level10,

}