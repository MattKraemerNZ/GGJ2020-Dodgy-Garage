using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doozy.Engine;

[RequireComponent(typeof(MeshCollider))]
public class UserPress : MonoBehaviour
{
    void OnMouseDown()
    {
        GameEventMessage.SendEvent("Sabotage", gameObject);
    }
}
