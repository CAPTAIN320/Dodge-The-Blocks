using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {

        StartCoroutine(RestartLevel());

        Debug.Log("ENDING GAME!!!");
    }

    IEnumerator RestartLevel()
    {
        //b4 1 sec
        yield return new WaitForSeconds(1f);

        //after 1 sec
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
