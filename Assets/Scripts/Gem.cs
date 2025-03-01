using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public Mesh[] allGems;
    public Color[] allColor;
    public AudioClip pickUpSFX;


    private void Start()
    {
        GetComponent<MeshFilter>().mesh = allGems[Random.Range(0, allGems.Length)];
        GetComponent<MeshRenderer>().material.color = allColor[Random.Range(0, allColor.Length)]; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MapManager.instance.GemPickedUp();
            AudioManager.instance.PlaySFX(pickUpSFX);
            Destroy(gameObject);
        }
    }



}
