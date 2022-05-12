using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;
    [SerializeField]
    private string SceneNameToLoad;

    private float elapseTime;
    // Update is called once per frame
    void Update()
    {
       
    }

    public void retry()
    {
        elapseTime += Time.deltaTime;

        if (elapseTime > delayBeforeLoading)
        {
            SceneManager.LoadScene(SceneNameToLoad);
        }
    }
}
