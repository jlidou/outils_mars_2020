using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GizmosScript : MonoBehaviour{
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }
    private void OnDrawGizmos() {
        Gizmos.color = new Color(1, 1, 0);
        Gizmos.DrawWireCube(new Vector3(transform.position.x, transform.position.y+2, transform.position.z),  new Vector3(2, 2, 2));
        
    }
}