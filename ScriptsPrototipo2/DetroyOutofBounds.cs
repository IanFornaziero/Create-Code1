using UnityEngine;

public class DetroyOutofBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) //caso passe para fora da tela para cima
        {
            Destroy(gameObject); //apaga o objeto
        }
        else if (transform.position.z < lowerBound) //caso passe para fora da tela para baixo
        {
            Destroy(gameObject); //apaga o objeto
            Debug.Log("Game Over!"); //mostra gameover se o objeto passar pelo player
        }
    }
}
