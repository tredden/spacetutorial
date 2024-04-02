using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float bounds;

    public AudioClip clip;
    AudioSource source;

    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameController").GetComponent<GameController>();
        source = controller.GetComponents<AudioSource>()[1];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        if(transform.position.y > bounds)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("HIT!!");
        source.PlayOneShot(clip, 1.0f);
        controller.IncScore();

        Destroy(collision.gameObject);
        Destroy(gameObject);
        
    }
}
