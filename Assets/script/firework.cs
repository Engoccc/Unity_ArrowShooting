using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firework : MonoBehaviour
{
    public GameObject fireworks;
    // Start is called before the first frame update
    void Start()
    {
        fireworks.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            fireworks.SetActive(true);
        }
    }
}
