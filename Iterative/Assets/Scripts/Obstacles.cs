using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float slideSpeedDecrease;

    public FirstPersonController player;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if((player.slideSpeed - slideSpeedDecrease) < 10)
            {
                player.slideSpeed = 10;
            } else
            {
                player.slideSpeed -= slideSpeedDecrease;
            }
        }
    }
}
