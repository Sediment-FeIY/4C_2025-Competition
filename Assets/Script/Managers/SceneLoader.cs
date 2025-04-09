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
    private GameObject start;
    
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        eventObj = GameObject.Find("EventSystem");
        GameObject.DontDestroyOnLoad(this.gameObject);
        GameObject.DontDestroyOnLoad(this.eventObj);
        startButton = GameObject.Find("startButton").GetComponent<Button>();
        start = GameObject.Find("startButton");
        startButton.onClick.AddListener(ChooseLevel);
    }

    private void ChooseLevel()
    {
        StartCoroutine(LoadScene("LevelSelect"));
        StartCoroutine(ButtonShow(false, start));
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
}
