using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject masterObj;

    private void OnCollisionEnter(Collision collision)
    {
        masterObj.GetComponent<GameMaster>().boxNum--;
        Destroy(gameObject);
    }
}
