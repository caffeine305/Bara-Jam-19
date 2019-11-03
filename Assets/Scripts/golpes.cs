using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpes : MonoBehaviour
{
    public Animator Animar;
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
        Animar = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<Animator>();
        col = GetComponent<Collider>();
        col.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Animar.GetBool("IsPunching") == true ){
            col.enabled = true;
        }else col.enabled = false;        
    }
}
