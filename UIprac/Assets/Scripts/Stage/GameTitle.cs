using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadClearData();
    }

    public void GameStart()
    {
        SceneManager.LoadScene("SampleScene");
    }
 
}
