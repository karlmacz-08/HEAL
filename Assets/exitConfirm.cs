using UnityEngine;

public class exitConfirm : MonoBehaviour
{
    public GameObject ExitConfirmUI;

    public void ExitConfirm()
    {
        if (ExitConfirmUI.activeSelf == true)
        {
            ExitConfirmUI.SetActive(false);
        }
    }
}
