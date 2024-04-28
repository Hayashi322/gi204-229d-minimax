using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Crystal : MonoBehaviour
{
    public TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Collider2D c;
        if (!GetComponent<Collider2D>())
        {
            c = gameObject.AddComponent<Collider2D>();
        }
        else 
        {
            c = GetComponent<Collider2D>();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
            Gamemanager.nScore++;
            ScoreText.text = "Crystal : " + Gamemanager.nScore;
            Destroy(gameObject);
        
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
