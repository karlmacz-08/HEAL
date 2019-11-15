using UnityEngine;

public class confirmUI : MonoBehaviour
{
    public GameObject ConfirmUI;

    public void Confirm()
    {
        if (ConfirmUI.activeSelf == false)
        {
            ConfirmUI.SetActive(true);
        }

    }

}
