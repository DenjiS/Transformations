using UnityEngine;

public class Rotator : TransformChanger
{
    protected override void PerformUpdate(Transform transform, float speed)
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.up);
    }
}
