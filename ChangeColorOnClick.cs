using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    // Reference to the game object whose color will change
    public GameObject objectToChange;

    // Function called when the button is clicked
    public void OnButtonClick()
    {
        // Generate a random color
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        // Assign the random color to the object's renderer
        objectToChange.GetComponent<Renderer>().material.color = randomColor;
    }
}
