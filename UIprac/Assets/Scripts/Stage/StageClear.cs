using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageClear : MonoBehaviour
{
    
    public void GameClear()
    {
        GameManager.Instance.Clear();
        SceneManager.LoadScene("SampleScene");
        
    }
}
