﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine;

[RequireComponent(typeof(MeshCollider))]
public class UserPress : MonoBehaviour
{
    public int ClicksToRemove = 5;
    public bool PopOff = true;
    public float DamageScore = 200f;
    public string PressEvent = "Damage";
    public string DestroyEvent = "Sabotage";

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
        GameEventMessage.SendEvent("Damage", gameObject);

        print("Sabotage " + name + ", clicks left: " + ClicksToRemove);

        if (!IsAlive() && PopOff)
        {
            GameEventMessage.SendEvent("Sabotage", gameObject);
            Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward * 5, ForceMode.Impulse);
            GetComponent<MeshCollider>().enabled = false;
            ScoreManager.instance.Score += DamageScore;
        }
    }

    bool IsAlive()
    {
        return ClicksToRemove > 0;
    }
}
