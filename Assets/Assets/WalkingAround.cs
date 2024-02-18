using UnityEngine;

public class WalkingAround : MonoBehaviour
{
    void Update()
    {
        transform.localScale += new Vector3(1, 1, 1) * 0.2f * Time.deltaTime;
        transform.Translate(Vector3.right * Time.deltaTime);
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }
}