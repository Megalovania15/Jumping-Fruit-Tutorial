using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] sounds;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || 
            collision.gameObject.tag == "Fruit")
        {
            int index = Random.Range(0, sounds.Length);
            AudioClip chosenClip = sounds[index];
            source.clip = chosenClip;
            source.pitch = Random.Range(-3f, 3f);
            source.volume = Random.Range(0.6f, 1f);
            source.Play();
        }
    }
}
