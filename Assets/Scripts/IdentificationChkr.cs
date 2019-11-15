using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdentificationChkr : MonoBehaviour
{
    public Text Identification;
    public string correct;
    public GameObject rightUI;
    public GameObject wrongUI;
    public GameObject nextQ;

    public void Identify()
    {
        string answer = Identification.text.ToString().ToLower().Trim();
        string c_ans = correct;

        Debug.Log(answer + c_ans);
        if (answer == c_ans)
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
