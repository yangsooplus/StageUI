using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    public int CurrentStageNum;
    public bool[] StageClearStatus;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }


    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            return instance;
        }
    }

    public void ChangeCurStage(int num)
    {
        CurrentStageNum = num;
    }

    public void Clear()
    {
        StageClearStatus[CurrentStageNum] = true;
        PlayerPrefs.SetInt("Stage" + CurrentStageNum.ToString(), 1);

    }

    public bool isCleared(int idx)
    {
        if (StageClearStatus[idx])
            return true;
        else
            return false;
    }



    public void LoadClearData()
    {
        for (int i = 0; i < 12; i++)
        {
            StageClearStatus[i] = PlayerPrefs.GetInt("Stage" + i.ToString())!=0;

        }
    }
}
