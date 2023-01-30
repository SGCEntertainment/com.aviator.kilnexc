using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float force;
    private float health = 3;
    private float score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    public GameObject[] bloods;

    private void Start()
    {
        Time.timeScale = 0f;
        scoreText.text = score.ToString();
        healthText.text = health.ToString();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * force;
    }

    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Star"))
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }
        if (other.CompareTag("death"))
        {
            
            health --;
            healthText.text = health.ToString();
            Instantiate(bloods[Random.Range(0, bloods.Length)], transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Stop")) SceneManager.LoadScene("SampleScene");
    }

    public void Pouse()
    {
        Time.timeScale = 0f;
    }

    public void StartG()
    {
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
