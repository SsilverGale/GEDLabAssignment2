using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    [SerializeField] GameObject WinUI;
    [SerializeField] Text WinText;
    private bool isAlive =true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("win"))
        {
            WinText.text = "You Win!";
            Debug.Log("You Win");
            WinUI.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("vehicle"))
        {
            WinText.text = "You Lose!";
            Debug.Log("You Lost");
            WinUI.SetActive(true);
            isAlive = false;
        }

    }

    public void Inputs(InputAction.CallbackContext context)
    {
        if (isAlive)
        {
            Vector2 moveDirection = context.ReadValue<Vector2>();
            transform.position += new Vector3(moveDirection.x, 0, moveDirection.y);
        }

    }
}
