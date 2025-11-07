using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxMagnitude;
    private Camera mainCamera;


    private void Awake()
    {
        mainCamera = Camera.main;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = mainCamera.transform.position *  parallaxMagnitude;
    }
}
