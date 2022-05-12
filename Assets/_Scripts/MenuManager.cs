using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    //initialize GameObjects
    [SerializeField] private GameObject _Intro, _GameMenu, _SelectCategory, _SelectLevel;
    [SerializeField] private Button _PlayButton, _BackCategory, _Floor1Button, _BackSelectLvl, _QuitBtn;
  


     void Awake()
    {
        //Subscribing to Changing GameState
        GameManager.OnGameStateChange += GameManagerOnOnGameStateChange;        
    }

     void OnDestroy()
    {
        //Removing Subscribed GameState and release Process Data
        GameManager.OnGameStateChange -= GameManagerOnOnGameStateChange;

    }
    private void GameManagerOnOnGameStateChange(GameState state)
    {
        _Intro.SetActive(state == GameState.Intro);
        _GameMenu.SetActive(state == GameState.GameMenu );
        _SelectCategory.SetActive(state == GameState.SelectCategory);
        _SelectLevel.SetActive(state == GameState.SelectLevel);
       
        
      
      
        

    }


    //Buttons accessing the Category selection
    public void PlayMenuBtn()
    {
        GameManager.Instance.UpdateGameState(GameState.SelectCategory);
    }
    public void CategoryBack()
    {
        GameManager.Instance.UpdateGameState(GameState.GameMenu);
    }

    public void QuitBtn()
    {
        GameManager.Instance.UpdateGameState(GameState.Quit);
    }


    //Buttons accessing Level selection
    public void Floor1Button()
    {
        GameManager.Instance.UpdateGameState(GameState.SelectLevel);
    }
    public void BackToCategory()
    {
        PlayMenuBtn();
    }

    //Buttons accessing Selected Level
    public void Floor1Level1Button()
    {
       // _OnPlayMode.SetActive(true);
        GameManager.Instance.UpdateGameState(GameState.StartGame);
    }







    /*
    public void StartButton()
    {
        GameManager.Instance.UpdateGameState(GameState.StartLevel);
    }

    */















     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
