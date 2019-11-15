using UnityEngine;

public class burgerMenu : MonoBehaviour
{
    public GameObject BurgerMenuUI;

    public void BurgerUI()
    {
        Animator animator = BurgerMenuUI.GetComponent<Animator>();

        bool BurgerMenuState = animator.GetBool("open");

        animator.SetBool("open", !BurgerMenuState); 
    }
}
