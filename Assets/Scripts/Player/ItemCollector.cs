using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    // Declaration des attributs et class de unity native
    private int cherries = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Systeme de collecte de fruit lorsque le joueur entre en collision avec l'objet
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries ++;
            Debug.Log(cherries);
            cherriesText.text = "Cherries: " + cherries;
        }
    }
}
