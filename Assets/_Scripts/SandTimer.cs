using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class SandTimer : MonoBehaviour
{
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


    }

    // Update is called once per frame
    async void Update()
    {
        TimeRemaining = countdown ? TimeRemaining -= Time.deltaTime : TimeRemaining += Time.deltaTime;
        if (haslimit && ((countdown && TimeRemaining <= timerLimit) ||( !countdown && TimeRemaining >= timerLimit)))
        {
            TimeRemaining = timerLimit;
            Debug.Log("Time runs out ");
            GameManager.Instance.UpdateGameState(GameState.LevelFailed);
            
        }
        setTimeText();
        timerSlider.value = TimeRemaining;
        if (timerSlider.value == 50)
        {

            Wave.SetActive(true);
         
            spawngerms.Instance.SpawnTime-=1f;
            Debug.Log("Approaching waves of germs!");
            await Task.Delay(1000);
         
        
            Wave.SetActive(false);
        }
      

    }
    private void setTimeText()
    {
   
        float time = TimeRemaining;

            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60f);

            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            Timer.text = textTime;
       
     

    }


    
    

}
