using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
public class PlayerPawn : MonoBehaviour
{
    private static PlayerPawn s_instance;
    private static Transform s_transform;

    private BoxCollider _collider;
    private Rigidbody _rigidBody;

    private void Awake()
    {
        s_instance = this;
        s_transform = transform;
        _collider = GetComponent<BoxCollider>();
        _collider.isTrigger = true;
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.useGravity = false;
    }

    private void Start()
    {
        CameraController.ChangeTargetTo(transform);
    }

    public static void MoveTo(Node node)
    {
        s_instance.StartCoroutine(s_instance.MoveRoutine(node.transform.position));
    }

    private IEnumerator MoveRoutine(Vector3 endPoint)
    {
        s_transform.forward = endPoint - s_transform.position;
        while (s_transform.position != endPoint)
        {
            s_transform.position = Vector3.MoveTowards(s_transform.position, endPoint, Time.deltaTime * GameManager.Properties.playerPawnSpeed);
            yield return new WaitForEndOfFrame();
        }
    }
}