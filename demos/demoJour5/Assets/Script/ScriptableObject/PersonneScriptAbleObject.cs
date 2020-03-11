using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personne", menuName = "Personne / Creation" )]
public class PersonneScriptAbleObject : ScriptableObject{
    public String nom;
    public int age;
    public Color couleurDeCheuveux;
}