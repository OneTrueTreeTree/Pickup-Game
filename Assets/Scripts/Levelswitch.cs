using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelswitch : MonoBehaviour
{
    GameManager gameManager;
    public string nextlevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider otherObject)

    {
        if(otherObject.transform.tag == "Player")
            
            if(gameManager.levelcomplete)
                SceneManager.LoadScene(nextlevel);
                
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
