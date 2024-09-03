using UnityEngine;

public class Mover : TransformChanger
{
    protected override void PerformUpdate(Transform transform, float speed)
    {
        transform.position += speed * Time.deltaTime * transform.forward;
    }
}
