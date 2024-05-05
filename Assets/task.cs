using UnityEngine;

public class task : MonoBehaviour
{
    public float moveAmount = 1f; // Amount of movement for each arrow key

    void Update()
    {
        // Calculate movement direction based on arrow key input
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveVertical = 1f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveVertical = -1f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveHorizontal = 1f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveHorizontal = -1f;
        }

        // Calculate movement vector
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);

        // Move the object
        transform.Translate(movement * moveAmount);
    }
}
