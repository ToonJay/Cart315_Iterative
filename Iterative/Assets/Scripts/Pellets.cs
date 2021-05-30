using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellets : MonoBehaviour
{

    public float slideSpeedIncrease;

    public FirstPersonController player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            player.slideSpeed += slideSpeedIncrease;

        }
    }
}
