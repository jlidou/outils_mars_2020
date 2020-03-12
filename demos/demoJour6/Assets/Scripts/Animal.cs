using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Animal{
    public String nom;
    public int nbPatte;
    public Color color;
    public Vector3 position;
    public Animal(string nom, int nbPatte, Color color, Vector3 position) {
        this.nom = nom;
        this.nbPatte = nbPatte;
        this.color = color;
        this.position = position;
    }
}