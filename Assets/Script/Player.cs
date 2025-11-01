using UnityEngine;

public class Player
{
    //変数宣言
    [SerializeField, Header("移動速度")]
    private float _moveSpeed;

    private Vector2 _inputDirection; //座標を記憶
    private Rigidbody2D _rigid; //重力

    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
}
