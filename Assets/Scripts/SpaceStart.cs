using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceStart : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
