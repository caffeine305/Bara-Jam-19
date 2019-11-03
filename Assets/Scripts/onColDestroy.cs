using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onColDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision otherCol)
    {
        if (otherCol.gameObject.tag == "Punch")
            Destroy(this.gameObject);
    }
}
