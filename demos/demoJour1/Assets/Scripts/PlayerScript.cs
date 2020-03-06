using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class PlayerScript : MonoBehaviour{
    [Range(0,10)]
    public int speed;
    public float hp;
    public List<GameObject> gameObjects;
    // Start is called before the first frame update
    void Start() {
        gameObjects = new List<GameObject>();
        gameObjects.Add(new GameObject());
    }

    // Update is called once per frame
    void Update() {
    }
}