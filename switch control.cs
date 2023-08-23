using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchcontrol : MonoBehaviour
{
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    private bool isOn;
    private Renderer renderer;
    public scoremanage scoreManager;
    public float score;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Set(!isOn);
            scoreManager.AddScore(score);
        }
    }

    private void Set(bool active)
    {
        isOn = active;
        if (isOn == true)
        {
            renderer.material = onMaterial;
        }
        else
        {
            renderer.material = offMaterial;
        }
    }
}