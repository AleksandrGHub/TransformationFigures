using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()
    {
        transform.localScale += new Vector3(1, 1, 1) * _speed * Time.deltaTime;
    }
}