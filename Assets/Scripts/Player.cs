using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    public int badges;
    public int lastMainDialog;
    public float x;
    public float y;
    public float z;

    public Player(PlayerScript player)
    {
        badges = player.badges;
        lastMainDialog = player.lastMainDialog;
    }
}
