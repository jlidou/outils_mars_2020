using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour{
    [SerializeField]
    private int test;
    // Start is called before the first frame update
    void Start() {
    }
    // Update is called once per frame
    void Update() {

        
        Debug.DrawLine(
            Vector3.one, new Vector3(2,1,2));
    }
}