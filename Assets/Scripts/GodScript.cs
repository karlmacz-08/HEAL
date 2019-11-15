using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GodScript
{
    public int rangerBadges;
    public int rangerLastMainDialog;

    public void GetPlayer(PlayerScript player)
    {
        rangerBadges = player.badges;
        rangerLastMainDialog = player.lastMainDialog;
    }
}
