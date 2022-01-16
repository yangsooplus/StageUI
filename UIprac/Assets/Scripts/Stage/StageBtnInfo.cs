using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StageBtnInfo : MonoBehaviour
{
    public int StageNum;
    public bool isAble;
    public Text Stagetext;
    private Button btn;
    public Sprite ClearedSprite;

    public void Start()
    {
        Stagetext.text = (StageNum+1).ToString();
        btn = GetComponent<Button>();
        ClearCheck();
    }

   public void ClearCheck()
    {
        if (StageNum > 0)
        {
            if (GameManager.Instance.isCleared(StageNum - 1))
                isAble = true;
            else
                isAble = false;

        }
        else
            isAble = true;


        if (!isAble)
        {
            btn.image.sprite = ClearedSprite;
            btn.interactable = false;
        }

    }

    public void Clicked()
    {
        if (!isAble) 
            return;

        GameManager.Instance.ChangeCurStage(StageNum);
        SceneManager.LoadScene("GameScene");
    }





}
