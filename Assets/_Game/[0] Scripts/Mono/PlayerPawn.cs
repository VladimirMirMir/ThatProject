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
        s_instance.StartCoroutine(s_instance.AnimateRoutine(node.transform.position));
    }

    private IEnumerator AnimateRoutine(Vector3 endPoint)
    {
        yield return MoveUpRoutine();
        yield return RotateRoutine(endPoint);
        yield return MoveRoutine(endPoint);
        yield return MoveDownRoutine();
    }

    private IEnumerator MoveUpRoutine()
    {
        while(s_transform.position.y < GameManager.Properties.pawnLiftHeight)
        {
            s_transform.position += Vector3.up * Time.deltaTime * GameManager.Properties.playerPawnSpeed;
            yield return new WaitForEndOfFrame();
        }
        s_transform.position = s_transform.position.WithY(GameManager.Properties.pawnLiftHeight);
    }

    private IEnumerator RotateRoutine(Vector3 endPoint)
    {
        Quaternion endRot = Quaternion.LookRotation(endPoint.WithY(s_transform.position.y) - s_transform.position);
        while(s_transform.rotation != endRot)
        {
            s_transform.rotation = Quaternion.RotateTowards(s_transform.rotation, endRot, Time.deltaTime * GameManager.Properties.pawnRotationSpeed);
            yield return new WaitForEndOfFrame();
        }
    }

    private IEnumerator MoveRoutine(Vector3 endPoint)
    {
        while (s_transform.position != endPoint.WithY(s_transform.position.y))
        {
            s_transform.position += s_transform.forward * GameManager.Properties.playerPawnSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
            if (Vector3.Distance(s_transform.position, endPoint.WithY(s_transform.position.y)) < 0.1f)
                break;
        }
        s_transform.position = endPoint.WithY(s_transform.position.y);
    }

    private IEnumerator MoveDownRoutine()
    {
        while (s_transform.position.y > 0)
        {
            s_transform.position -= Vector3.up * Time.deltaTime * GameManager.Properties.playerPawnSpeed;
            yield return new WaitForEndOfFrame();
        }
        s_transform.position = s_transform.position.WithY(0);
    }
}