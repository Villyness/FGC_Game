using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SelectDialogue : MonoBehaviour
{
    public int BattleSceneNumber = 0;
    public event Action<int> Confirm;
    public event Action Decline;

    public void Yes()
    {
        if (Confirm != null)
        {
            Confirm(BattleSceneNumber);
        }
    }

    public void No()
    {
        if (Decline != null)
        {
            Decline();
        }
    }
}
