using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if(hit.transform.name == "Asteroid 1(Clone)" || hit.transform.name == "Asteroid 2(Clone)" || hit.transform.name == "Asteroid 3(Clone)" || hit.transform.name == "Asteroid 4(Clone)" || hit.transform.name == "Asteroid 5(Clone)" || hit.transform.name == "Asteroid 6(Clone)" || hit.transform.name == "Asteroid 7(Clone)" || hit.transform.name == "Asteroid 8(Clone)" || hit.transform.name == "Asteroid 9(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
		ScoreManager.instance.AddPoint();
            }
        }
    }
}
