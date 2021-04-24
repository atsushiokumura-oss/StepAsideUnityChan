using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyController : MonoBehaviour
{

    private GameObject unitychan;


    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z + 3 < unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
