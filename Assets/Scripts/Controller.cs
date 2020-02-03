using UnityEngine;

public class Controller : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * 0.1f;
        }
    }
}
