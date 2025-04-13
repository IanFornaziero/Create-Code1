using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float horizontalInput;
    public float horizontalSpeed;
    public float xRange = 20;

    public GameObject projectilePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //setta o tipo de input

        if (transform.position.x < -xRange) //define o limite para a esquerda
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); //impede que passe

        }
        else if (transform.position.x > xRange) //define o limite para direita
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); //impede que passe
        }

        transform.Translate(Vector3.right * horizontalSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); //atira comida
        }
    }
}
