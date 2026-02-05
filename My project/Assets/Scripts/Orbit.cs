using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 50f * Time.deltaTime, 0);
    }
}
