using UnityEngine;

public class CheckerGround : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out Ground _))
        {
            Time.timeScale = 0f;
        }
    }
}
