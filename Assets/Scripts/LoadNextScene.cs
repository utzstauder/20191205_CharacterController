using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        int targetIndex = currentIndex + 1;

        if (targetIndex >= SceneManager.sceneCountInBuildSettings)
        {
            targetIndex = 0;
        }

        SceneManager.LoadScene(targetIndex);
    }
}
