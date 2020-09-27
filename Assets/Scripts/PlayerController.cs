using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool inMotion = false;
    Vector2 direction = Vector2.right;
    public float speed = 6.0f;
    KeyCode bannedKey = KeyCode.Z;
    public AudioSource Chomp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && bannedKey != KeyCode.D) {
            bannedKey = KeyCode.D;
            inMotion = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            direction = Vector2.right;
        } else if (Input.GetKey(KeyCode.S) && bannedKey != KeyCode.S) {
            bannedKey = KeyCode.S;
            inMotion = true;
            transform.localRotation = Quaternion.Euler(0, 0, 270);
            direction = Vector2.down;
        } else if (Input.GetKey(KeyCode.A) && bannedKey != KeyCode.A) {
            bannedKey = KeyCode.A;
            inMotion = true;
            transform.localRotation = Quaternion.Euler(0, 0, 180);
            direction = Vector2.left;
        } else if (Input.GetKey(KeyCode.W) && bannedKey != KeyCode.W) {
            bannedKey = KeyCode.W;
            inMotion = true;
            transform.localRotation = Quaternion.Euler(0, 0, 90);
            direction = Vector2.up;
        }

        if (inMotion == true)
        {
            Movement(direction);
        }
    }

    void Movement(Vector2 direction)
    {
            transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pellet")
        {
            Debug.Log("Pellet");
            Destroy(collision.gameObject);
            if (!Chomp.isPlaying)
            {
                Chomp.Play();
            }


        } else if (collision.tag == "Maze")
        {
            inMotion = false;
            adjustPosition();
        }
    }

    private void adjustPosition()
    {
        transform.localPosition -= (Vector3)(direction * speed) * Time.deltaTime;
    }
}
