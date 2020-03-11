using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonneScript : MonoBehaviour{
    public PersonneScriptAbleObject myData;
    private Renderer _renderer;
    private void Awake() {
        _renderer = gameObject.GetComponent<Renderer>();
        _renderer.material.color = myData.couleurDeCheuveux;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
