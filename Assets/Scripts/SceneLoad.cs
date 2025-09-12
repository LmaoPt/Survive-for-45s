using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class SceneLoad : MonoBehaviour
{
    public Animator transition;
    private void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextScene();
        }
    }
    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    private IEnumerator LoadScene(int indexScene)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1.0f);

        SceneManager.LoadScene(indexScene);
    }
    public void ExitGame()
    {
        Application.Quit(); 
    }
}
