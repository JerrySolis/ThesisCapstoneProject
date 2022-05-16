using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    public static GameManager Instance;

    public GameState State;
    public bool intro = true;
    public static event Action<GameState> OnGameStateChange;

    void Awake()
    {
        Instance = this; 
    }

    void Start()
    {
    
        
       
            UpdateGameState(GameState.Intro);
        
      
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Intro:
                HandleIntro();
                break;
            case GameState.GameMenu:
                HandleGameMenu();
                break;
            case GameState.SelectCategory:
                HandleSelectCategory();
                break;
            case GameState.SelectLevel:
                HandleSelectLevel();
                break;
         /*   case GameState.StartLevel:
                HandleStartLevel();
                break;                    */
            case GameState.StartGame:
                HandleOnStart();
                break;
            case GameState.SettingsMenu:
                HandleOnSettingsMenu();
                break;
            case GameState.LevelFailed:
                HandleOnLevelFailed();
                break;
            case GameState.GameOverMenu:
                HandleOnGameOverMenu();
                break;
            case GameState.LevelFinish:
                HandleOnLevelFinish();
                break;
            case GameState.StoryBegin:
                HandleOnStoryBegin();
                break;
            case GameState.InGameMenu:
                HandleOnInGameMenu();
                break;
            //put new case here!


            case GameState.Quit:
                HandleQuit();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
                
        }

        OnGameStateChange?.Invoke(newState);
    }

    private void HandleOnInGameMenu()
    {
        Debug.Log("Hold Switch case for choosing category");

    }

    private  void HandleOnStoryBegin()
    {
        
        SceneManager.LoadSceneAsync("Story");
   
    
        Debug.Log("Flashing Story Comiks!");
    }

    private async void HandleOnLevelFinish()
    {
        Debug.Log("Yay! Level Finish!");
        await Task.Delay(2000);
        _startGame.Instance.PauseGame();
        UnitManager.Instance.Child_LevelFinishPnl.SetActive(true);
       
       
    }

    private void HandleOnGameOverMenu()
    {
        Debug.Log("Directed to GameOver Menu");
        UnitManager.Instance._LevelFailedPnl.SetActive(false);
    }

    private async void HandleOnLevelFailed()
    {
        Debug.Log("Oops Level failed! Sorry");
        await Task.Delay(2000);
       _startGame.Instance.PauseGame();
        UnitManager.Instance.Child_LevelFailedPnl.SetActive(true);
        
    }

    private void HandleOnSettingsMenu()
    {
        Debug.Log("Opened Settings Menu");
    }

    private async void HandleOnStart()
    {
        await Task.Delay(1000);
        GameManager.Instance.UpdateGameState(GameState.StoryBegin);
        await Task.Delay(5000);
        SceneManager.LoadSceneAsync("Story 1");
        Debug.Log("Starting the game");
        Debug.Log("Now playing..");
        await Task.Delay(5000);
        SceneManager.LoadSceneAsync("Floor 1 Level 1");
     


    }









































    private void HandleStartLevel()
    {
        //StartLevel
    }


    private void HandleSelectLevel()
    {
        //Select level
    }

    private void HandleSelectCategory()
    {
        //Select category
    }

    private void HandleGameMenu()
    {
       //Select Menu
    }

    private async void HandleIntro()
    {
       Time.timeScale = 1f;
        await Task.Delay(3000);
        GameManager.Instance.UpdateGameState(GameState.GameMenu);
    }
    

    public void HandleQuit()
    {
            Application.Quit();
            Debug.Log("Game Quit Confirmed!");   
    }




    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
    
    }

   
}


public enum GameState
{
    Intro,
    GameMenu,
    SelectCategory,
    SelectLevel,
  //  StartLevel,
    OnPlayMode,
    StartGame,
    SettingsMenu,
    LevelFailed,
    GameOverMenu,
    LevelFinish,
    StoryBegin,
    InGameMenu,

    Quit

}