using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AniWithCoroutine : MonoBehaviour
{
    public GameObject panel;
    
    public void Open_Panel()
    {
        StartCoroutine("Open");
    }

    public void Close_Panel()
    {
        StartCoroutine("Close");
    }

    IEnumerator Open()
    {
        float revisedScale = 0f;

        while (revisedScale < 1f)
        {
            revisedScale += 2f*Time.deltaTime;
            panel.transform.localScale = new Vector3(revisedScale, 1f, 1f);

            yield return null;
        }
        panel.transform.localScale = new Vector3(1f, 1f, 1f);
    }


    IEnumerator Close ()
    {

        float revisedScale = 1f;

        while (revisedScale > 0f)
        {
            revisedScale -= 2f * Time.deltaTime;
            panel.transform.localScale = new Vector3(revisedScale, 1f, 1f);

            yield return null;
        }
        panel.transform.localScale = new Vector3(0f, 1f, 1f);
    }

}
