using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiScript : MonoBehaviour{

    [ContextMenuItem("Action sur Test", "ActionTest")]
    public int test;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("coucou menu")]
    public void DoSomething() {
        Debug.Log("Coucou");
    }
    
    public void ActionTest() {
        Debug.Log("Test");
        test = 15;
    }
}
