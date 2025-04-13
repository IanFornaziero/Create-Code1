using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float velocidade = 2.0f;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;

        InvokeRepeating("MudarCor", 1.0f, 2.0f);

    }
    
    void Update()
    {
        transform.Rotate(200.0f * Time.deltaTime, 200.0f * Time.deltaTime, 200.0f * Time.deltaTime);
        transform.localScale += Vector3.one * velocidade * Time.deltaTime;

        if(transform.localScale.x > 5.0f)
        {
            transform.localScale = Vector3.one;
        }
    }

    void MudarCor()
    {
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }
}
