using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;
public class AnimalScript : MonoBehaviour{
    // Start is called before the first frame update
    void Start() {
        
        List<Animal> animals = new List<Animal>();
        animals.Add(new Animal("titi", 3, Color.cyan, new Vector3(4, 5, 7)));
        animals.Add(new Animal("titi", 3, Color.cyan, new Vector3(4, 5, 7)));
        animals.Add(new Animal("titi", 3, Color.cyan, new Vector3(4, 5, 7)));



        string json = JsonManager.StringListToJSon(animals);
        
        JsonManager.SaveToStreamingAsset(json);
        
        Debug.Log(json);
    }

    // Update is called once per frame
    void Update() {
    }
}