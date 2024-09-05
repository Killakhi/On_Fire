using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Burnbar : MonoBehaviour
{
    public Player player;
    public Slider burnbar;

    public void setNotOnFire(float health)
    {
       burnbar.value = health;
    }
    
}
