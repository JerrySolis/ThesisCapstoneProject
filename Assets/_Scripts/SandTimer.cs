using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SandTimer : MonoBehaviour
{
    public static SandTimer Instance;
    [Header("Component")]
    public Text Timer;
    [Header("Timer settings")]
    public float TimeRemaining;
    public bool countdown;
    [Header("Limit settings")]
    public bool haslimit;
    public float timerLimit;
    [Header("Sand Timer Bar")]
    public Slider timerSlider;
    [SerializeField]
    private GameObject Wave;
    



    // Start is called before the first frame update
    void Start()
    {
        timerSlider.maxValue = TimeRemaining;
        timerSlider.value = TimeRemaining;
        countDownTimer();

    }

    // Update is called once per frame
    void Update()
    {
       
      TimeRemaining = countdown ? TimeRemaining -= Time.deltaTime : TimeRemaining += Time.deltaTime;
        if (haslimit && ((countdown && TimeRemaining <= timerLimit) ||( !countdown && TimeRemaining >= timerLimit)))
        {
            TimeRemaining = timerLimit;

           // GameManager.Instance.UpdateGameState(GameState.LevelFailed);

        }
        setTimeText();
        timerSlider.value = TimeRemaining;
    
      
      

    }
    private void setTimeText()
    {
   
        float time = TimeRemaining;

            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60f);

            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            Timer.text = textTime;
    }




    //Gameover This Error takes me 3 days to debug and its just fvcking Invoke countdown!!!!
    async void countDownTimer()
    {
        int Countdowns = (int)TimeRemaining;
        if (Countdowns>0)
        {

            if (Countdowns == 70)
            {

                Wave.SetActive(true);

                spawngerms.Instance.SpawnTime = 1.0f;
                Debug.Log("Approaching waves of germs!");
                await Task.Delay(2000);
                Wave.SetActive(false);
            }


            Countdowns--;
            Invoke("countDownTimer", 1.0f);

        }
        else
        {
            GameManager.Instance.UpdateGameState(GameState.LevelFailed);
        }
      
    }


    void Awake()
    {
        Instance = this;
    }

}
