using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        coinscorecounter.coinAmount += 1;
        Destroy(gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
