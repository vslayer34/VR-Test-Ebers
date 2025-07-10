using UnityEngine;

public class WallTarget : MonoBehaviour
{
    // Game Loop Methods---------------------------------------------------------------------------

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IThrowable throwable))
        {
            throwable.ShowEndGame();
        }
    }
}
