using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RoueScript : MonoBehaviour{

    public AnimationCurve Curve;
    public int nbRayon;
    public Color[] couleursRayon;
    // Start is called before the first frame update
    private void Awake() {
        nbRayon = 5;
        couleursRayon = new Color[5];
    }
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }
}