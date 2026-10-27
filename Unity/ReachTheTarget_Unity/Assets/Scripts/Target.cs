using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public TMP_Text victoryText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("TARGET REACHED!");
            victoryText.text = "TARGET REACHED!";
        }
    }
}