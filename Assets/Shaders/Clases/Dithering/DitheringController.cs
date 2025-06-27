using UnityEngine;

public class DitheringController : MonoBehaviour
{

    [SerializeField] private Transform _playerTransform;
    [SerializeField]
    private void Update()
    {
        Shader.SetGlobalVector("_PlayerPosition", _playerTransform.position);
    }
}
