
using UnityEngine;

/// <summary>
/// Parallax scrolling script that should be assigned to a layer
/// </summary>
public class ScrollScript : MonoBehaviour
{
    /// <summary>
    /// Scrolling speed
    /// </summary>
    public float speed ;

    /// <summary>
    /// Moving direction
    /// </summary>
    private Vector2 direction = Vector2.down ;

    public Transform background1, background2;


    public void ScrollBg()
    {
        // Movement
        Vector2 movement = direction * speed;

        movement *= Time.deltaTime;

        background1.Translate(movement);
        background2.Translate(movement);
    }
}



