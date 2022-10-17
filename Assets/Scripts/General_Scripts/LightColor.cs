using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColor : MonoBehaviour
{
    private Light pointLight;
    private float time;
    private Color lightColor = new Color(1.0f, 1.0f, 1.0f, 0.4f);

    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        // Debug.Log(time%2);
        pointLight.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0.4f);
    }
}
