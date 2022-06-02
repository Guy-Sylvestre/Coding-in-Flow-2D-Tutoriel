using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Declaration des attributs et class de unity native
    private AudioSource finishSound;
    private bool levelCompleted = false;
    

    void Start()
    {
        finishSound = GetComponent<AudioSource>();
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();

            // Marquer une certaine pause avant la scene suivante
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }


    private void CompleteLevel()
    {
        // Sysemet de passage a la scene suivante
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
