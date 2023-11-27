using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeDistance : MonoBehaviour
{
    [SerializeField] private Transform cube1;
    [SerializeField] private Transform cube2;

    [SerializeField] private TextMeshProUGUI distanceText;

    [SerializeField] private GameObject sphereHolder;

    [SerializeField] private SceneLoader loader;

    private float distance;

    void Update()
    {
        CalculateDistance();
        ShowDistance();
    }
    private void CalculateDistance()
    {
        Vector3 position1 = cube1.position;
        Vector3 position2 = cube2.position;

        distance = Vector3.Distance(position1, position2);
        CheckForDistance();
    }
    private void ShowDistance()
    {
        distanceText.text = distance.ToString("F2");
    }

    private void CheckForDistance()
    {
        if (distance < 2 && !sphereHolder.activeInHierarchy)
        {
            sphereHolder.SetActive(true);
        }
        else if (distance > 2 && sphereHolder.activeInHierarchy)
        {
            sphereHolder.SetActive(false);
        }
        else if (distance < 1)
        {
            loader.LoadScene(1);
        }
    }
}
