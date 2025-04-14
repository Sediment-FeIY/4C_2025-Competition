using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneLoader : MonoBehaviour
{
    private GameObject eventObj;
    private Button startButton;
    private Button quitButton;
    private Button level1;
    private Button level2;
    private Button level3;
    private GameObject start;
    private GameObject quit;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        eventObj = GameObject.Find("EventSystem");
        GameObject.DontDestroyOnLoad(this.gameObject);
        GameObject.DontDestroyOnLoad(this.eventObj);
        startButton = GameObject.Find("startButton").GetComponent<Button>();
        quitButton = GameObject.Find("quitButton").GetComponent<Button>();


        start = GameObject.Find("startButton");
        quit = GameObject.Find("quitButton");
        startButton.onClick.AddListener(ChooseLevel);
        quitButton.onClick.AddListener(QuitGame);
    }

    private void ChooseLevel()
    {
        StartCoroutine(LoadScene("LevelSelect"));
        StartCoroutine(ButtonShow(false, start));
        StartCoroutine(ButtonShow(false, quit));
    }

    private void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    IEnumerator ButtonShow(bool isShowed,GameObject name)
    {
        yield return new WaitForSeconds(1f);

        if (isShowed)
        {
            name.SetActive(true);
        }
        else
        {
            name.SetActive(false);
        }

    }

    IEnumerator LoadScene(string sceneName)
    {
        animator.SetBool("FadeOut", true);
        animator.SetBool("FadeIn", false);

        yield return new WaitForSeconds(1f);
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
        async.completed += OnLoadedScene;
    }

    private void OnLoadedScene(AsyncOperation obj)
    {
        animator.SetBool("FadeOut", false);
        animator.SetBool("FadeIn", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
    {
        if(scene.name== "LevelSelect")
        {
            if (GameObject.Find("Level1").GetComponent<Button>() != null)
            {
                level1 = GameObject.Find("Level1").GetComponent<Button>();
            }
            else
            {
                return;
            }

            if(GameObject.Find("Level2").GetComponent<Button>() != null)
            {
                level2 = GameObject.Find("Level2").GetComponent<Button>();
            }
            else
            {
                return;
            }

            if(GameObject.Find("Level3").GetComponent<Button>() != null)
            {
                level3 = GameObject.Find("Level3").GetComponent<Button>();
            }
            else
            {
                return;
            }
            level1.onClick.AddListener(() => StartCoroutine(LoadScene("Scene1")));
            level2.onClick.AddListener(() => StartCoroutine(LoadScene("Scene2")));
            level3.onClick.AddListener(() => StartCoroutine(LoadScene("Scene3")));

        }
       
    }
}
