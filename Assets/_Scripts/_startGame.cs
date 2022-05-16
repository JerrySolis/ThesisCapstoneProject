using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;


public class _startGame : MonoBehaviour
{
    [SerializeField] private GameObject Counter, Note, tri, too, won, go;

    public static _startGame Instance;
    bool toggle = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Click start button and begin the game!");

       Time.timeScale = 0f;

       
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle == true)
        {
            Time.timeScale = 1f;
           
        }
    }

    //Starting the game
    public async void StartButton()
    {
        Counter.SetActive(true);
        await Task.Delay(3000);
        Note.SetActive(false);
        tri.SetActive(true);
        await Task.Delay(1000);
        tri.SetActive(false);
        too.SetActive(true);
        await Task.Delay(1000);
        too.SetActive(false);
        won.SetActive(true);
        await Task.Delay(1000);
        won.SetActive(false);
        go.SetActive(true);
        await Task.Delay(1000);
        Counter.SetActive(false);
        toggle = true;

        
    }



    public void PauseGame()
    {
    
        Time.timeScale = 0f;
        toggle = false;

    }

    public void ResumeGame()
    {
        toggle = true;
        Time.timeScale = 1f;
    }
    void Awake()
    {
         Instance = this;
    }





    public void ExitToMainMenu()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void RestartLevel()
    {
        SceneManager.LoadSceneAsync("RestartLevel1");
    }
    public void RestartLevel1()
    {
        SceneManager.LoadSceneAsync("SampleLevel1");
    }
}
