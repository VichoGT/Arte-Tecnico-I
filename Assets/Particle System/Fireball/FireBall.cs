using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FireBall : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed = 10;
    [SerializeField] private GameObject _explosion;
    [SerializeField] private Transform _explosionPivot;
 

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    private void OnEnable()
    {
        Vector3 impulse = transform.up * _speed;
        _rb.AddForce(impulse,ForceMode.Impulse);
    }


    private void OnDisable()
    {
        _rb.linearVelocity = Vector3.zero;
    }
    private void OnCollisionEnter(Collision collision)
    {
        _explosion.transform.position = _explosionPivot.position;
        _explosion.SetActive(true);
        gameObject.SetActive(false);
    }

}



