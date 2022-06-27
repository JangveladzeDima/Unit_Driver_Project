using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Delievery : MonoBehaviour {
    private bool isPicket = false;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Package" && !this.isPicket){
            this.isPicket = true;
            Debug.Log("Avige Paketi");
            spriteRenderer.color = hasPackageColor;
            other.transform.position = new Vector3(Random.Range(10, 20), Random.Range(10, 20), 0);
        }

        if (other.tag == "Costumer" && this.isPicket){
            Debug.Log("Mivitane");
            spriteRenderer.color = noPackageColor;
            this.isPicket = false;
        }
    }
}