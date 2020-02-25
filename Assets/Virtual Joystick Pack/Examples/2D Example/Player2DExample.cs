using UnityEngine;

public class Player2DExample : MonoBehaviour 
{
    public float moveSpeed = 8f;
    public Joystick joystick;
    gulle_uret ates;
    void Start()
    {
        ates = GameObject.FindGameObjectWithTag("gulle_uretim").GetComponent<gulle_uret>();
    }
    private void Update()
    {
        Vector3 moveVector = (Vector3.up * joystick.Horizontal + Vector3.left * joystick.Vertical);

        if (moveVector != Vector3.zero)
        { 
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
            ates.ates();
            //transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
        }
        else
            ates.dur();

    }
}
