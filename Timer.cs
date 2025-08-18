using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;

    // ���� ���������� ���������� �������� 0.01 �������
    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;

                object value = minutes--;

            }
            else
            {
                // ���� ������ �����������, �������������  ������� �����
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }

        //��������� �������� ������ �� ����� ��� �� ������ �� �����
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}