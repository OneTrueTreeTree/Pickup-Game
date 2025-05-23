using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject player;

    //Pickup and level completion logic 
    public int currentPickups = 0;
    public int maxPickups = 0;
    public bool levelcomplete = false;

    public Text pickupText;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



    }
    private void UpdateGUI()
    {
        pickupText.text = " Pickups:" + currentPickups + "/" + maxPickups;


    }




    private void LevelCompleteCheck()
    { 
       if (currentPickups >= maxPickups)
            levelcomplete = true;
        else 
            levelcomplete = false;
     }
    // Update is called once per frame
    
    void Update()
    {   
    LevelCompleteCheck();
    UpdateGUI();
    }
}
