using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AniWithTween : MonoBehaviour
{
    public GameObject BG;
   public void Open()
    {
        BG.transform.DOScaleX(1f, 1f);
    }

    public void Close()
    {
        BG.transform.DOScaleX(0f, 1f);
    }

}
