using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 420f;

    public TextMeshProUGUI CountDownText;
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            CountDownText.text = currentTime.ToString("0");
        }

        if (currentTime >= 3.5f)
        { 
            CountDownText.color = Color.white;
        }
        if (currentTime < 3.5f)
        {
            CountDownText.color = Color.red; 
        }
        if(currentTime <= 0)
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);
        }
    }
}
