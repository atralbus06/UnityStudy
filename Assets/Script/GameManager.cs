using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float time;
    bool isGameover;

    [SerializeField] GameObject gameoverText;
    [SerializeField] Text timeText;
    [SerializeField] Text bestTimeText;

    void Awake()
    {
        time = 0f;
        isGameover = false;

        gameoverText.SetActive(false);
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
                SceneManager.LoadScene("Dodge");
        }
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

        bestTimeText.text = "Best Time: " + string.Format("{0:f2}", time);
    }
}
