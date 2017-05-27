using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject m_CardBoardprefab;
    public GameObject m_eventSystem;

    public string[] levelname;

    private string level = "Intro";
    // Use this for initialization


    private void Awake()
    {
        DontDestroy();
        StartCoroutine (LoadLevelAdditive());
        
    }
    IEnumerator LoadLevelAdditive () {

        Debug.Log("Loading ");
        

        var mode = UnityEngine.SceneManagement.LoadSceneMode.Additive;
        AsyncOperation asyncLoadLevel = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(level, mode);

        asyncLoadLevel.allowSceneActivation =true;
        while (!asyncLoadLevel.isDone)
        {
            Debug.Log("Loading the Scene");
            yield return null;
        }

        SetInStartPoint();

    }

    IEnumerator LoadLevelSingle()
    {

        Debug.Log("Loading ");


        var mode = UnityEngine.SceneManagement.LoadSceneMode.Single;
        AsyncOperation asyncLoadLevel = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(level, mode);

        asyncLoadLevel.allowSceneActivation = true;
        while (!asyncLoadLevel.isDone)
        {
            Debug.Log("Loading the Scene");
            yield return null;
        }
        SetInStartPoint();



    }

    // Update is called once per frame

        private void DontDestroy()
    {
        DontDestroyOnLoad(m_eventSystem);
        DontDestroyOnLoad(m_CardBoardprefab);
        DontDestroyOnLoad(this);

    }

    private void SetInStartPoint()
    {
        Transform startposition = GameObject.Find("StartPoint").transform;
        m_CardBoardprefab.transform.SetParent(startposition, true);
        m_CardBoardprefab.transform.localPosition = new Vector3(0, 0.5f, 0);

    }

    private void SetOut()
    {
        
        m_CardBoardprefab.transform.SetParent(null, true);
        m_CardBoardprefab.transform.localPosition = new Vector3(0, 0.5f, 0);

    }



    public void changeLevel (int levelid)
    {

        level = levelname[levelid];
        SetOut();
        DontDestroy();

        StartCoroutine(LoadLevelSingle());


    }

    




}
