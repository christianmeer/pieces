using System.Collections.Generic;
using UnityEngine;

// my test setup is 5 cubes numberd 1,2,4,8,16 myColour[0] = green, myColour[1] = red

public class pieces : MonoBehaviour
{
    [SerializeField]
    private Material[] myColour;
    [SerializeField]
    public int number;     
    public int nextNumber;
    [SerializeField]
    private bool mousedown = false;
    [SerializeField]
    private float countDown = 2.0f;

    private void Start()
    {
        
      GetComponent<Renderer>().material = myColour[0]; // ? how can I populate myColours[] in this script
                                                       // i have to add them in the inspector, no big deal
    }                                                  
                        
    private void Update()

    {
        if (mousedown == true ) //  add || nextNumber in a loop for all nextNumbers > 1.
        
        {
            countDown -= Time.deltaTime;
            GetComponent<Renderer>().material = myColour[1];

            if (number % 2 == 1 && number > 1) // if 1 *3 +1 = 4 you get a loop off 1,4,2,1 repeating so not nextNumber 1.
            {
                nextNumber = (number * 3) + 1;
            }
            else nextNumber = number / 2;

            if (countDown <= 0)
            {
                GetComponent<Renderer>().material = myColour[0];
                countDown = 1.9f;
                mousedown = !mousedown;


                Debug.Log(nextNumber);//take this nextNumber to the prefab with number == this nextNumber and so on...to 1. 
             
            }
        }
  
    }

    
    private void OnMouseDown()
    {
        mousedown = !mousedown;
    }


    
}   // What I am trying to do is have a x number of prefabs that when any one is selected it changes colour
    // for a time and back again and then the nextnumber changes colour for a time then starting a sequence
    // a sequence i.e if 9 was selected  9,28,14,7,22,11,34,17,52,26,13,40,20,10,5,16,8,4,2,1 note all sequences will go to 1
   

       


   




    
