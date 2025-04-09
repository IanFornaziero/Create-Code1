using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //para manipular objetos na unity e necessario criar um gameobject
    //manter esse tipo de variavel acima public, pois é referenciado no Unity, caso contrario, private
    private Vector3 offset = new Vector3(0, 5, -7); //cria uma instancia do vector3

    void Start()
    {
        
    }
    void LateUpdate() //ao renomear de update para lateupdate, a camera se move apenas depois do player se mover
    {
        transform.position = player.transform.position //setta a posicao da camera no player (informado na unity)
            + offset; //Vector3(0,5,-7) define a posicao da camera ao seguir o player
    }
}
