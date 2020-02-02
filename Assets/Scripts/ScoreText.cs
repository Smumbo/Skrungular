using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text text;

    public int score;

    private Vector3 initialPosition;
    public float shakeMagnitude;
    public float shakeMagnitudeMax;

    public bool stopShaking;

    void OnEnable()
    {
        text.text = "0";
        initialPosition = this.transform.localPosition;
        stopShaking = false;
    }

    // Update is called once per frame
    void Update()
    {

        // update score display
        if (score == 0)
        {
            return;
        }
        text.text = score.ToString("#,###");

        if (stopShaking)
        {
            return;
        }

        // shake
        if (shakeMagnitude < shakeMagnitudeMax)
        {
            shakeMagnitude = score * 0.07f;
        }
        transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
    }

    public void PlusOne()
    {
        score += 1;
    }
}
