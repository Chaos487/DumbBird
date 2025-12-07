using UnityEngine;

public class BirdScript : MonoBehaviour
{   
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManager logic; 
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myRigidbody.linearVelocity = new Vector2(0, 1)*flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
