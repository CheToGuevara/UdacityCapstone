using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject m_CardBoardprefab;
    public GameObject m_eventSystem;

    public string[] levelname;

    private string level = "Setup"; 
	// Use this for initialization
	void Awake () {
        



       
        
        

        DontDestroyOnLoad(m_eventSystem);
        DontDestroyOnLoad(m_CardBoardprefab);
        DontDestroyOnLoad(this);

        var mode = UnityEngine.SceneManagement.LoadSceneMode.Additive;
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelname[0], mode);

    }

    // Update is called once per frame
   


    public void changeLevel (int levelid)
    {

        level = levelname[levelid];
        var mode = UnityEngine.SceneManagement.LoadSceneMode.Single;
        UnityEngine.SceneManagement.SceneManager.LoadScene(level, mode);

        Transform startposition = GameObject.Find("StartPoint").transform;
        m_CardBoardprefab.transform.position = startposition.position;




    }

    




}
