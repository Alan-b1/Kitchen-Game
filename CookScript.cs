using UnityEngine;

public class CookScript : MonoBehaviour
{
    private bool hasBroccoli;
    private bool hasEgg;
    private bool hasMilk;
    private bool hasSpinach;

    public GameObject plate; // Reference to the plate game object

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Broccoli"))
        {
            hasBroccoli = true;
        }
        else if (collision.CompareTag("Egg"))
        {
            hasEgg = true;
        }
        else if (collision.CompareTag("Milk"))
        {
            hasMilk = true;
        }
        else if (collision.CompareTag("Spinach"))
        {
            hasSpinach = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Plate"))
        {
            if (hasBroccoli && hasEgg && hasMilk)
            {
                Debug.Log("Broccoli, eggs and milk served!");
                // Display broccoli served or perform necessary actions
                hasBroccoli = false;
                hasEgg = false;
                hasMilk = false;
                // Reset collected items
            }
            else if (hasSpinach)
            {
                Debug.Log("Spinach served!");
                // Display spinach served or perform necessary actions
                hasSpinach = false;
                hasEgg = false;
                hasMilk = false;
                // Reset collected items
            }
            else if (hasEgg)
            {
                Debug.Log("Eggs served!");
                hasEgg = false;
            }
            // You can add more combinations here with their respective outputs
        }
    }
}
