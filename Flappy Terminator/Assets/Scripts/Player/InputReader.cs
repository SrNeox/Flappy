using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const string _jump = "Jump";
    private const string _fire1 = "Fire1";

    public bool Fire1 { get; private set; }
    public bool Jump {  get; private set; }

    public void Update()
    {
        Fire1 = Input.GetButtonDown(_fire1);
        Jump = Input.GetButton(_jump);
    }
}
