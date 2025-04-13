using UnityEngine;

public class DetectColision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //define que qd um objeto encosta no outro, ele vai destruilo
        Destroy(other.gameObject); //define que qd um objeto encosta em outro além do ultimo, também vai destruilo
    }
}
