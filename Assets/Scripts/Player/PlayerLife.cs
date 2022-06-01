using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // Declaration des attributs et class de unity native
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource deathSoundEffect;


    void Start()
    {
        // Initiailisation des composants 
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnCollisionEnter2D (Collision2D collision)
    {
        // Systeme de colision lorsque le joyeur entre en contact avec l'objet
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        // Systeme d'animation de mort du personnage
        
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        deathSoundEffect.Play();
    }

    private void RestartLevel()
    {
        // Faire reprendre le joueur a l'etape initiale de la scene lorsqu'il meurt
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
// 