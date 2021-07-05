using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChangeScene(sceneName);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollision");
        ChangeScene("GameOver");
    }

    public void ChangeScene(string scene)
    {
        Debug.Log("ChangeScene");
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
