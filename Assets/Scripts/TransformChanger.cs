using UnityEngine;

public abstract class TransformChanger : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        PerformUpdate(_transform, _speed);
    }

    protected abstract void PerformUpdate(Transform transform, float speed);
}
