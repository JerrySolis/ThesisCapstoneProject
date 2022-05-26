using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class OnPlayMode : MonoBehaviour
{
    public GameObject LevelComplete, germinfo;
    public static OnPlayMode Instance;
    public Text remainingGerm;
    public int GermLeft;
    void Start()
    {
        string RemainingGerm = string.Format("{00}", GermLeft);
        remainingGerm.text = RemainingGerm;
    }
    // Update is called once per frame
    void  Update()
    {
        string RemainingGerm = string.Format("{00}", GermLeft);
        remainingGerm.text = RemainingGerm;

       
    }
    public void GermsLeft()
    {
        GermLeft--;
         if (GermLeft == 0)
         {
            GameManager.Instance.UpdateGameState(GameState.LevelFinish);

         }
      
    }
    void Awake()
    {
        Instance = this;
    }
}
