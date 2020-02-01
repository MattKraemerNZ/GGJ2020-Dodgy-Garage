using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine;

[RequireComponent(typeof(MeshCollider))]
public class UserPress : MonoBehaviour
{
    public int ClicksToRemove;

    void OnMouseDown()
    {
        GameEventMessage.SendEvent("Sabotage", gameObject);
    }

    void DealDamage()
    {
        ClicksToRemove--;
        if ()
    }

    bool IsAlive()
    {
        return ClicksToRemove > 0;
    }
}
