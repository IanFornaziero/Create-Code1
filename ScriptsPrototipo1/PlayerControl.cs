using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float VelocidadeFrente = 10.0f; //define as variaveis de velocidade
    private float VelocidadeVirar = 35.0f;
    private float horizontalInput; //define a variavel para virar
    private float tatakaeInput; //define a variavel para ir para frente

    
    void Start()
    {
       
    }

    void Update() //faz o objeto se mover
    {
        horizontalInput = Input.GetAxis("Horizontal"); //setta o tipo do input que é definido na unity
        tatakaeInput = Input.GetAxis("Vertical"); //setta o tipo do input

        transform.Translate(Vector3.forward * Time.deltaTime 
            * VelocidadeFrente //define a velocidade para ir para frente
            * tatakaeInput); //faz ele ativar a velocidade quando apertar na tecla

        if (tatakaeInput != 0f) //adicionei um if para impedir que vire com o carro parado (tava testando, nao e do video)
        {
            transform.Rotate(Vector3.up, 
                VelocidadeVirar * //define a velocidade de virada
                horizontalInput * //define que so vai ativar a velocidade de virada se der input
                Time.deltaTime); //define a rotacao do objeto
        }
    }
}
