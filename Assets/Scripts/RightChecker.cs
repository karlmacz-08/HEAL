using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightChecker : MonoBehaviour
{
    public GameObject rightUI;
    public GameObject wrongUI;
    public GameObject nextQ;

    public void RightUI()
    {
        if (gameObject.tag == "ra")
        {
            wrongUI.SetActive(false);
            rightUI.SetActive(true);
            Invoke("NextQ", 1f);
        }
        else
        {
            rightUI.SetActive(false);
            wrongUI.SetActive(true);
        }
    }

    public void NextQ()
    {
        transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
        wrongUI.SetActive(false);
        rightUI.SetActive(false);

        if (nextQ != null)
        {
            nextQ.SetActive(true);
            Debug.Log("next q");
        }
        
        
        if (transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject.tag == "finalq")
        {
            // LOAD NEXT SCENE
            Debug.Log("next level");
        }
    }
}
