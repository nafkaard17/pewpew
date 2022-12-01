using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float m_speed = 0.3f;
    void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
        transform.position += transform.right * m_speed;        
    }

    void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Enemy") {
            
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
