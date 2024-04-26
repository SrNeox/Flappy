using UnityEngine;

public class PlayerWeapon : Weapon
{
    [SerializeField] private InputReader _inputReader;

    private void Update()
    {
        if (_inputReader.Fire1)
            PlayerShoot();
    }
}
