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

    void OnEnable()
    {
        initialPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
        text.text = score.ToString("#,###");
    }

    public void PlusOne()
    {
        score += 1;
    }
}
