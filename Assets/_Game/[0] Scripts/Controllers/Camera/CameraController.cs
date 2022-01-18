using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    private static CameraController s_instance;
    private static Transform s_transform;

    [SerializeField] private Vector3 _offset;
    
    private CameraRails _rail;
    private Transform _target;
    private bool _onRails = false;
    private float _timer = 0;

    private void Awake()
    {
        s_instance = this;
        s_transform = transform;
    }

    private void LateUpdate()
    {
        if (!_onRails)
            FollowTarget();
    }

    private static void FollowTarget()
    {
        if (s_instance._target != null)
            s_transform.position = Vector3.MoveTowards(s_transform.position, s_instance._target.position + s_instance._offset, Time.deltaTime * GameManager.Properties.camSpeed);
    }

    private static void FollowRail(float step)
    {
        s_instance.transform.position = s_instance._rail.EvaluatePosition(step);
        s_instance.transform.rotation = s_instance._rail.EvaluateRotation(step);
    }

    public static IEnumerator StartRailingRoutine(CameraRails rails, float duration)
    {
        if (duration <= 0) duration = 1;
        s_instance._timer = 0;
        s_instance._rail = rails;
        s_instance._onRails = true;
        FollowRail(0);
        while(s_instance._timer <= duration)
        {
            yield return new WaitForEndOfFrame();
            s_instance._timer += Time.deltaTime;
            FollowRail(s_instance._timer / duration);
        }
        FollowRail(1);
        s_instance._onRails = false;
    }

    public static void ChangeTargetTo(Transform newTarget)
    {
        s_instance._target = newTarget;
    }

    public static void ChangeTargetTo(Transform newTarget, float duration)
    {
        s_instance.StartCoroutine(ChangeTargetRoutine(newTarget, duration));
    }

    private static IEnumerator ChangeTargetRoutine(Transform newTarget, float duration)
    {
        var oldTarget = s_instance._target;
        s_instance._target = newTarget;
        yield return new WaitForSeconds(duration);
        s_instance._target = oldTarget;
    }


}