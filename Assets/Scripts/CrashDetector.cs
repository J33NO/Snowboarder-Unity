using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delay = .5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            var playerController = GetComponent<PlayerController>();
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("ReloadScene", delay);
            //Giving null reference error for some reason
            //test.PlayOneShot(crashSFX, 0.1f);
            //crashEffect.Play();
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);  
    }
}
