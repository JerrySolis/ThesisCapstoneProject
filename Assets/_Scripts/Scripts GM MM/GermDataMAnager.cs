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
                  GermData16, GermData17, GermData18,
                  GermData19;
    [SerializeField]
    private GameObject nameGermData1, nameGermData2, nameGermData3,
                       nameGermData4, nameGermData5, nameGermData6,
                       nameGermData7, nameGermData8, nameGermData9,
                       nameGermData10, nameGermData11, nameGermData12,
                       nameGermData13, nameGermData14, nameGermData15,
                       nameGermData16, nameGermData17, nameGermData18,
                       nameGermData19;
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
        GermData19.interactable = dataStates >= 19;

        if (GermData1.interactable)
        {
            nameGermData1.SetActive(true);
        }
        if (GermData2.interactable)
        {
            nameGermData2.SetActive(true);
        }
        if (GermData3.interactable)
        {
            nameGermData3.SetActive(true);
        }
        if (GermData4.interactable)
        {
            nameGermData4.SetActive(true);
        }
        if (GermData5.interactable)
        {
            nameGermData5.SetActive(true);
        }
        if (GermData6.interactable)
        {
            nameGermData6.SetActive(true);
        }
        if (GermData7.interactable)
        {
            nameGermData7.SetActive(true);
        }
        if (GermData8.interactable)
        {
            nameGermData8.SetActive(true);
        }
        if (GermData9.interactable)
        {
            nameGermData9.SetActive(true);
        }
        if (GermData10.interactable)
        {
            nameGermData10.SetActive(true);
        }
        if (GermData11.interactable)
        {
            nameGermData11.SetActive(true);
        }
        if (GermData12.interactable)
        {
            nameGermData12.SetActive(true);
        }
        if (GermData13.interactable)
        {
            nameGermData13.SetActive(true);
        }
        if (GermData14.interactable)
        {
            nameGermData14.SetActive(true);
        }
        if (GermData15.interactable)
        {
            nameGermData15.SetActive(true);
        }
        if (GermData16.interactable)
        {
            nameGermData16.SetActive(true);
        }
        if (GermData17.interactable)
        {
            nameGermData17.SetActive(true);
        }
        if (GermData18.interactable)
        {
            nameGermData18.SetActive(true);
        }
        if (GermData19.interactable)
        {
            nameGermData19.SetActive(true);
        }


    }
}
