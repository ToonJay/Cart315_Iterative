using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speed : MonoBehaviour
{
    public TextMeshProUGUI speed;
    public FirstPersonController player;
    // Update is called once per frame
    void Update()
    {
        speed.text = "Speed: " + player.slideSpeed;
    }
}
