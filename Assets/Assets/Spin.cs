using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float _speed;
    private void Update()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}