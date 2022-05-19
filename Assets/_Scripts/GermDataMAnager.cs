using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GermDataMAnager : MonoBehaviour
{
    public static GermDataMAnager Instance;
    public Button GermData1, GermData2, GermData3,
                  GermData4, GermData5, GermData6,
                  GermData7, GermData8, GermData9,
                  GermData10, GermData11, GermData12,
                  GermData13, GermData14, GermData15,
                  GermData16, GermData17, GermData18;
    int dataStates = 0;
    void Awake()
    {
        Instance = this;
    }
    public void resetGermData()
    {

        //Resetting all saved level states   
        PlayerPrefs.DeleteKey("GermData");
        Debug.Log("All levels state is reset! Outcome:" + dataStates);
        PlayerPrefs.SetInt("GermData", 0);
    }
    public void SetGermData()
    {
        dataStates++;
        PlayerPrefs.SetInt("GermData", dataStates);
    }
    public void UpdateGermData(int LevelState)
    {
        dataStates = LevelState;
    }
    // Start is called before the first frame update
    void Start()
    {
        dataStates = PlayerPrefs.GetInt("GermData");
        Debug.Log("Current Germ data outcome is " + dataStates);
    }

    // Update is called once per frame
    void Update()
    {
        GermData1.interactable = dataStates >= 1;
        GermData2.interactable = dataStates >= 2;
        GermData3.interactable = dataStates >= 3;
        GermData4.interactable = dataStates >= 4;
        GermData5.interactable = dataStates >= 5;
        GermData6.interactable = dataStates >= 6;
        GermData7.interactable = dataStates >= 7;
        GermData8.interactable = dataStates >= 8;
        GermData9.interactable = dataStates >= 9;
        GermData10.interactable = dataStates >= 10;
        GermData11.interactable = dataStates >= 11;
        GermData12.interactable = dataStates >= 12;
        GermData13.interactable = dataStates >= 13;
        GermData14.interactable = dataStates >= 14;
        GermData15.interactable = dataStates >= 15;
        GermData16.interactable = dataStates >= 16;
        GermData17.interactable = dataStates >= 17;
        GermData18.interactable = dataStates >= 18;
    }
}
