﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

   bool getDestroy = false;

    void OnCollisionEnter(Collision  other){
        if (other.gameObject.tag == "Enemy") {
            Destroy (other.gameObject);
            getDestroy = true;
        }
    }
}