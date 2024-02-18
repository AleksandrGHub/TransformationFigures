using UnityEngine;

public class Mowement : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
    }
}