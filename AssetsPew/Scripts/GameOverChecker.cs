using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverChecker : MonoBehaviour
{

    public GameObject m_gameOver;
    private bool m_isOver = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy") {
            if(m_isOver == false) {

                    m_isOver = true;
                    m_gameOver.SetActive(true);
                    StartCoroutine("restartGame");

            }
        }

        Destroy(other.gameObject);
    }

    private IEnumerator restartGame() {
        yield return new WaitForSeconds(3.0f);
        Application.LoadLevel("SampleScene");
        yield return null;
    }
}
