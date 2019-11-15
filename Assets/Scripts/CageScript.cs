using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CageScript : MonoBehaviour
{
    public GameObject player;
    public Button releaseButton;

    SphereCollider collider;

    void Start()
    {
        collider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        if(collider.bounds.Contains(player.transform.position))
        {
            releaseButton.onClick.AddListener(delegate { releaseOnClick(); });
        }
    }

    public void releaseOnClick()
    {
        player.GetComponent<PlayerScript>().badges += 1;
        Destroy(this);
    }
}
