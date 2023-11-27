using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeParticle : MonoBehaviour
{
    [SerializeField] private Transform targetCube;
    [SerializeField] private ParticleSystem particles;

    void Update()
    {
        ChangeDirection();
    }
    private void ChangeDirection()
    {
        Vector3 direction = targetCube.position - transform.position;
        Quaternion rotationToTarget = Quaternion.LookRotation(direction);
        particles.transform.rotation = rotationToTarget;
    }
}
