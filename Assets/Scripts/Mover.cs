using UnityEngine;

public class Mover : TransformChanger
{
    protected override void PerformUpdate(Transform transform, float speed)
    {
        transform.position = new(
            transform.position.x,
            transform.position.y,
            transform.position.z + (speed * Time.deltaTime)
            );
    }
}
