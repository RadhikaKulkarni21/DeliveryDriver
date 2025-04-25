using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //Camera should trace the car positione
    void LateUpdate()
    {
       transform.position = thingToFollow.transform.position + new Vector3(0,0,-20);
    }
}
