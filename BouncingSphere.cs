using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class BounceingSphere : MonoBehaviour
{

    public TextMeshProUGUI bounceCountText;

    private Vector3 initialPosition;
    private int bounceCount = 0;

    void Start()
    {
        initialPosition = transform.position;
    }
    private void OnMouseDown()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
        bounceCount++;
        bounceCountText.text = "Score: " + bounceCount;
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Scene3");
    }
}
