

using UnityEngine;
using System.Collections;

public class ResetPosition : MonoBehaviour {

    /// <summary>
    /// Resets road block position if its less than -18.5f
    /// </summary>
    void Update()
    {
        if (transform.position.y <= -18.5f)
            transform.position = new Vector2(0, 18.5f);
    }

}
