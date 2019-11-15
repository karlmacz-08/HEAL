using UnityEngine;

public class newUserTest : MonoBehaviour
{
    public GameObject Panel;
    
    
    public void OpenPanel()
    {
        if (Panel.activeSelf == false)
        {
            Panel.SetActive(true);
        }
        else
        {
            Panel.SetActive(false);
        }
    }
}
