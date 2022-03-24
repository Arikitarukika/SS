using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControloLuz : MonoBehaviour
{
    private Light It;

    [Range(0, 1)] public float lerpTime;

    public Color[] color;

    int colorIndex = 0;

    float time;

    void Start()
    {

        It = GetComponent<Light>();

    }

    void Update()
    {
        int RotationX = 90;


        RotationX++;

        if (transform.eulerAngles.x < 175)
        {
            transform.Rotate(0.01f, 0, 0);
        }

        It.color = Color.Lerp(It.color, color[colorIndex], lerpTime * Time.deltaTime);

        time = Mathf.Lerp(time, 1f, lerpTime * Time.deltaTime);

        if (time > 0.9f)
        {
            time = 0;
            colorIndex++;
            colorIndex = (colorIndex >= color.Length) ? 0 : colorIndex;
        }

    }
}
