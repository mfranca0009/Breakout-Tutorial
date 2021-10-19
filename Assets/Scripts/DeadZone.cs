using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GM.instance.LoseLife();
    }
}
