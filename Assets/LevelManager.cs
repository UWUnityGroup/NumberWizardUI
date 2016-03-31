using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level)
    {
        Debug.Log(level);
        SceneManager.LoadScene(level);
    }

    public void QuitRequest()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
