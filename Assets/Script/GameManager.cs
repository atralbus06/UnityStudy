using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float time;
    bool isGameover;

    int deleteCount = 3;

    GameObject[] spawners;

    [SerializeField] GameObject gameoverText;
    [SerializeField] Text timeText;
    [SerializeField] Text bestTimeText;
    [SerializeField] Text deleteCountText;

    void Awake()
    {
        time = 0f;
        isGameover = false;

        gameoverText.SetActive(false);
    }

    void Start()
    {
        Invoke("IntervalSet", 5f);
    }

    void Update()
    {
        if (!isGameover)
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + string.Format("{0:f2}", time);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Dodge");
                Time.timeScale = 1;
            }
        }

        deleteCountText.text = "" + deleteCount;

        if (Input.GetKeyDown(KeyCode.Space) && deleteCount != 0)
        {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");

            foreach (GameObject bullet in bullets)
            {
                Destroy(bullet);
            }

            deleteCount--;
        }
    }

    void IntervalSet()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");

        foreach (GameObject spawner in spawners)
        {
            spawner.GetComponent<Spawner>().intervalMax = Mathf.Max(0.5f, spawner.GetComponent<Spawner>().intervalMax - 0.2f);
            spawner.GetComponent<Spawner>().intervalMin = Mathf.Max(0.1f, spawner.GetComponent<Spawner>().intervalMin - 0.1f);
        }

        Invoke("IntervalSet", 5f);
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime", 0f);

        if (time > bestTime)
        {
            bestTime = time;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        Time.timeScale = 0;

        bestTimeText.text = "Best Time: " + string.Format("{0:f2}", time);
    }
}
