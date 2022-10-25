using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        StartCoroutine(LoadAsyncScene(1));
    }

    public void LoadLevel2()
    {
        StartCoroutine(LoadAsyncScene(2));
    } 

    public IEnumerator LoadAsyncScene(int scene)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(scene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
