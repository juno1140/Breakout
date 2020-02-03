using UnityEngine;

public class KabeOut : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver("ゲーム失敗！！");
    }
}
