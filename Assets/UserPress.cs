using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine;

[RequireComponent(typeof(MeshCollider))]
public class UserPress : MonoBehaviour
{
    public int ClicksToRemove = 5;
    public bool PopOff = true;

    void OnMouseDown()
    {
        DealDamage();
    }

    void DealDamage()
    {
        if (!IsAlive())
        {
            return;
        }

        ClicksToRemove--;
        GameEventMessage.SendEvent("Sabotage", gameObject);

        print("Sabotage " + name + ", clicks left: " + ClicksToRemove);

        if (!IsAlive() && PopOff)
        {
            Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward * 5, ForceMode.Impulse);
            GetComponent<MeshCollider>().enabled = false;
        }
    }

    bool IsAlive()
    {
        return ClicksToRemove > 0;
    }
}
