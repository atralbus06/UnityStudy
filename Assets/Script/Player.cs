using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        float xSpeed = h * speed;
        float zSpeed = v * speed;

        Vector3 PlayerVelocity = new Vector3(xSpeed, 0f, zSpeed);
        rigid.velocity = PlayerVelocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");

            foreach (GameObject bullet in bullets)
            {
                Destroy(bullet);
            }
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
