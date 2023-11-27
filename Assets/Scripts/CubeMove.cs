using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private bool WASD_Move;

    void Update()
    {
        if (WASD_Move)
        {
            WasdMove();
        }
        else
        {
            ArrowMove();
        }
    }
    private void WasdMove()
    {
        float horizontal1 = Input.GetAxis("Horizontal1");
        float vertical1 = Input.GetAxis("Vertical1");
        Vector3 movement1 = new Vector3(horizontal1, 0f, vertical1) * moveSpeed * Time.deltaTime;
        transform.Translate(movement1);
    }
    private void ArrowMove()
    {
        float horizontal2 = Input.GetAxis("Horizontal2");
        float vertical2 = Input.GetAxis("Vertical2");
        Vector3 movement2 = new Vector3(horizontal2, 0f, vertical2) * moveSpeed * Time.deltaTime;
        transform.Translate(movement2);
    }
}
