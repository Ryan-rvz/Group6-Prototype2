using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int currentColor;
    public GameObject redCharacter;
    public GameObject blueCharacter;
    public GameObject yellowCharacter;
    public GameObject greenCharacter;

    private Vector2 targetPosition;

    public float yMoveAmount;
    public float moveSpeed;
    private bool canMove;
   

    public float maxHeight;
    public float minHeight;



    private UniversalVarHolder universeScript;

    private void Start()
    {
        canMove = true;
       
        universeScript = GameObject.Find("UniversalManager").GetComponent<UniversalVarHolder>();
        targetPosition = transform.position;
            
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ColorSwitch();
            
        }


        transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight && canMove)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y + yMoveAmount );
            canMove = false;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight && canMove)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y - yMoveAmount);
            canMove = false;
        }

        if (this.gameObject.transform.position.y == targetPosition.y)
        {
            canMove = true;
        }



        switch (gameObject.tag)
        {
            case "Red":
                currentColor = 0;
                redCharacter.SetActive(true);
                blueCharacter.SetActive(false);
                greenCharacter.SetActive(false);
                yellowCharacter.SetActive(false);
                break;

            case "Blue":
                currentColor = 1;
                redCharacter.SetActive(false);
                blueCharacter.SetActive(true);
                greenCharacter.SetActive(false);
                yellowCharacter.SetActive(false);
                break;

            case "Yellow":
                currentColor = 2;
                redCharacter.SetActive(false);
                blueCharacter.SetActive(false);
                greenCharacter.SetActive(false);
                yellowCharacter.SetActive(true);
                break;

            case "Green":
                currentColor = 3;
                redCharacter.SetActive(false);
                blueCharacter.SetActive(false);
                greenCharacter.SetActive(true);
                yellowCharacter.SetActive(false);
                break;
        }

      
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == this.tag)
        {
            ;
            Destroy(collision.gameObject);
            universeScript.AddToScore();
        }
        else  if (collision.tag == "Changer")
        {
            
            universeScript.AddToScore();
        }

       

        else if (collision.tag != this.tag)
        {

            universeScript.PlayerDeath();
        }
    }

    


    public void ColorSwitch()
    {
        int randomColor = Random.Range(0, 4);

        if (randomColor == 0 && gameObject.tag != "Red")
        {
            gameObject.tag = "Red";
        }
        else if (randomColor == 1 && gameObject.tag != "Blue")
        {
            gameObject.tag = "Blue";
        }
        else if (randomColor == 2 && gameObject.tag != "Yellow")
        {
            gameObject.tag = "Yellow";
        }
        else if (randomColor == 3 && gameObject.tag != "Green")
        {
            gameObject.tag = "Green";
        }
        else
        {
            ColorSwitch();
        }
    }


}
