using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
   
    [SerializeField] Image PauseGameIcon;
    [SerializeField] Image PlayGameIcon;
    public GameObject PauseMenuUI;

    private bool paused = true;

    // Start is called before the first frame update
    void Start()
    {
        
        if (!PlayerPrefs.HasKey("paused"))
        {
            PlayerPrefs.SetInt("paused", 0);
            Debug.Log("Paused!");
            Load();
        }
        else
        {

            Load();
        }
        UpdateButtonIcon();
        Save();
      //statements
    }

    // Update is called once per frame
    void Update()
    {
        Load();
    }




    public void OnButtonPress()
    {
        if (paused == false)
        {

            Pause();


        }
        else
        {
            Resume();
            
        }
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (paused == true)
        {
            PauseGameIcon.enabled = false;
            PlayGameIcon.enabled = true;
        }
        else
        {


            PauseGameIcon.enabled = true;
            PlayGameIcon.enabled = false;
        }
    }





    public void Load()
    {
   
        //Retrieve mute data and save it in integer
        paused = PlayerPrefs.GetInt("paused") == 1;
    }

    public void Save()
    {
       
        //Evaluates Bool type to convert into float
        PlayerPrefs.SetInt("paused", paused ? 1 : 0);
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        Debug.Log("Resumed the game!");
      
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        Debug.Log("Game is Paused!");
      
    }




}
