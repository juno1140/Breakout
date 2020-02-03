using UnityEngine;

public class BoxInit : MonoBehaviour
{

    public GameObject boxObjPrefab;
    public GameObject boxesObj;
    private int boxCount = 0;

    private void Awake()
    {
        GameObject masterObj = GameObject.Find("Master");
        for(int x=0; x<5; x++)
        {
            for (int y=0; y<2; y++)
            {
                boxCount++;
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                g.transform.position = new Vector3(2f + (1f * y), 0.4f, (-4.2f + (1.2f * x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
        masterObj.GetComponent<GameMaster>().boxNum = boxCount;
    }
}
