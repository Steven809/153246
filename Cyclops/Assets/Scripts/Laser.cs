using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject sphere;
    public GameObject prefab;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition); //beam is taking point on curser

        Debug.DrawRay(beam.origin, beam.direction * 100f);

        RaycastHit beamHit = new RaycastHit();

        if (Physics.Raycast(beam, out beamHit, 100f))
        {
            Debug.Log("You hit something");

        }
       
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            { //if ray cast is looking at something destroy it.
                if (hit.collider.gameObject.tag == "Hit") { 

                  Destroy(hit.collider.gameObject);
                }
            }

        }
    }
}