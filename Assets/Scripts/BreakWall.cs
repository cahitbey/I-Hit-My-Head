using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        //Hitpoint olacak, mouse left clik değil de hit point 0a düşünce kırılacak.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            wall.GetComponent<MeshRenderer>().enabled = false;
            wall.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
 