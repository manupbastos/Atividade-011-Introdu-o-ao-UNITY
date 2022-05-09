using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : MonoBehaviour
{
    private SpriteRenderer sr;
    private CircleCollider2D circle;
    
    public GameObject collected;
    public int Score;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag =="Player")
        {
            sr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            Gamecontroller.instance.totalScore += Score;

            Gamecontroller.instance.UpdateScoreText();

            Destroy(gameObject, 0.25f);
        }
    }
}
