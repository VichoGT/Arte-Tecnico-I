using UnityEngine;

public class Explosion : MonoBehaviour
{
    private ParticleSystem _particleSystem;



    private void OnParticleSystemStopped()
    {

       transform.parent.gameObject.SetActive(false);
    }
}
