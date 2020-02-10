using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("Stage1");
        SceneManager.LoadSceneAsync("UI", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Stage1-left", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Stage2", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Stage2-left", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Stage2-right", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Stage2-rightdown", LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Emppty", LoadSceneMode.Additive);

    }

    public void ExitGame()
    {
        Application.Quit();

    }
}
