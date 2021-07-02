using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
   private int health = 100;
   public Text healthText;
   
   
   
   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
   healthText.text = health.ToString();

   
   
    healthText.text ="HP: " + health;
    if(Input.GetKeyDown(KeyCode.Space)){
    health--;
}


    }
}
