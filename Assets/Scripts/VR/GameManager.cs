using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject m_CardBoardprefab;
    public GameObject m_eventSystem;

    public string[] levelname;

    public string level = "Intro";
    public int levlid =0;
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
        switch(levlid)
        {
            case 0:
                m_CardBoardprefab.transform.localPosition = new Vector3(0, 0.5f, 0);
                break;
            case 1:
                m_CardBoardprefab.transform.localPosition = new Vector3(0, 1.0f, 0);
                break;
            case 2:
                
                PlayerMove m_move = m_CardBoardprefab.AddComponent<PlayerMove>();
                m_move.mainobject = startposition.gameObject;
                m_CardBoardprefab.transform.localPosition = new Vector3(0, 0.75f, 0);
                GameObject.Find("Impling").transform.SetParent(m_CardBoardprefab.transform,true);
                break;
            default:
                m_CardBoardprefab.transform.localPosition = new Vector3(0, 0.5f, 0);
                break;
        }
        

    }

    private void SetOut()
    {
        PlayerMove a = m_CardBoardprefab.GetComponent<PlayerMove>();
        if (a != null)
           Destroy(a);
        GameObject impling = GameObject.Find("Impling");
        if (impling != null)
            Destroy(impling);
        m_CardBoardprefab.transform.SetParent(null, true);
        m_CardBoardprefab.transform.localPosition = new Vector3(0, 0.5f, 0);

    }



    public void changeLevel (int levelid)
    {
        levlid = levelid;
        level = levelname[levlid];
        SetOut();
        DontDestroy();

        StartCoroutine(LoadLevelSingle());


    }

    




}
