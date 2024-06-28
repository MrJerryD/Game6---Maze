using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Application.Quit();
            SceneManager.LoadScene("Menu");
            //Debug.Log("123");
        }
    }
}
