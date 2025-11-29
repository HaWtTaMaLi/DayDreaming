using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Orbit arouned player
    public GameObject orbitObject;
    //Full Zoom-in = First Person/Character is not visable even when looking down
    //90% Zoom-in = Character Focus, Camera comes to look at the player
    //Middle Zoom = Third Person
    //Full Zoom-out = Third person but far away, maybe like a 90 FOV
    //clamp to stop rotation look Up and Down i think its like 30 down and 90 up is the perfect clamp
    public int minCameraAngle = 30;
    public int maxCameraAngle = 90;
    //if player is idle for X amount of time Camera goes into to 90% zoom and stares at player
    //if player is idle, the camera sometimes rotates around the player slowly "cinimatic" in any FOV, zoom ins and zoom outs and rotate in and rotate out
    //Z forward/ -Z Back
    //Y Up/ -Y Down
    //-X Left/ X Right

}
