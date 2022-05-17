using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnitManager : MonoBehaviour
{
    [SerializeField] private GameObject _SettiingsPnl, _LevelFinish,  _CategoryMenu;
    public GameObject _LevelFailedPnl, Child_LevelFailedPnl, Child_LevelFinishPnl;
    public Button _SettingsBtn;
    public static UnitManager Instance;


    void Awake()
    {
        Instance = this;
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
 
        _SettiingsPnl.SetActive(state == GameState.SettingsMenu);
        _LevelFailedPnl.SetActive(state == GameState.LevelFailed);
        _LevelFinish.SetActive(state == GameState.LevelFinish);
  
        _CategoryMenu.SetActive(state == GameState.InGameMenu);
  





    }


    //Buttons accessing the Game State selection

    public void settingBtn()
    {
        GameManager.Instance.UpdateGameState(GameState.SettingsMenu);
    }

    public void QuitBtn()
    {
        GameManager.Instance.UpdateGameState(GameState.Quit);
    }

    public void RestartBtn()
    {
        SceneManager.LoadSceneAsync("Floor 1 Level 1");
    }
    public void Restartlvl2Btn()
    {
        SceneManager.LoadSceneAsync("Floor 1 Level 2");
    }
    public void Restartlvl3Btn()
    {
        SceneManager.LoadSceneAsync("Floor 1 Level 2");
    }

    public void MenuIG()
    {


        GameManager.Instance.UpdateGameState(GameState.InGameMenu);
    }

    public void Floor1SelectLevelbtn()
    {
        GameManager.Instance.UpdateGameState(GameState.SelectLevel);
    }


   





































    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }






}

