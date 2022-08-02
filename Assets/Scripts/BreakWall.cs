using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public GameObject wall;

    public int maxHitPoint = 5;
    public int currentHitPoint = 0;

    public MeshRenderer wallMesh;


    private void OnEnable()
    {
        currentHitPoint = maxHitPoint;
    }
    // Start is called before the first frame update
    void Start()
    {

        //Hitpoint olacak, mouse left clik değil de hit point 0a düşünce kırılacak.
    }

    // Update is called once per frame
    void Update()
    {


        //if (Input.GetMouseButtonDown(0))
        //{
        //    wall.GetComponent<MeshRenderer>().enabled = false;
        //    wall.transform.GetChild(0).gameObject.SetActive(true);
        //}
    }

    private void OnParticleCollision(GameObject other)
    {
        ProccessHit();
    }

    void ProccessHit()
    {
        currentHitPoint = currentHitPoint-2;

        if(currentHitPoint <=0)
        {
            wallMesh.enabled = false;
            wall.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
 