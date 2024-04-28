using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitStart : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Start_Button")
        {
            SceneManager.LoadScene("Level");
        }
        else if (collision.gameObject.name == "Credit_Button")
        {
            SceneManager.LoadScene("Credit");
        }
        else if (collision.gameObject.name == "Menu_Button")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (collision.gameObject.name == "Back_Button")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (collision.gameObject.name == "Exit_Button")
        {
            Application.Quit();
        }
    }
}
