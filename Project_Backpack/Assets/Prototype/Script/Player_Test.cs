using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Test : MonoBehaviour
{
    [SerializeField, Tooltip("移動速度")]
    private float m_speed = 0.02f;

    // 入力値の取得用
    private Actions m_action;
    // 現在の移動量
    private Vector3 m_move;
    // 自分の剛体コンポーネント
    private Rigidbody m_rigid;
    // メインカメラの向きによる操作方向の補正用
    private Camera m_main_camera;

    // 入力値の保存
    private Vector3 m_input_move;
    private float m_input_reaction_a;
    private float m_input_reaction_b;

    public void Awake()
    {
        m_action = new Actions();
        m_rigid = GetComponent<Rigidbody>();
    }

    public void Start()
    {
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        m_main_camera = camera.GetComponent<Camera>();
    }


    public void OnEnable()
    {
        m_action.Enable();
    }

    public void OnDestroy()
    {
        m_action.Disable();
    }

    public void OnDisable()
    {
        m_action.Disable();
    }

    public void Update()
    {
        Reaction_A();
        Reaction_B();
        Walk();
    }

    private void Walk()
    {
        // 値の取得と軸の変換
        m_input_move = m_action.PlayerAction.Move.ReadValue<Vector2>();
        m_input_move.z = m_input_move.y;
        m_input_move.y = 0.0f;

        Walk_Turn();
        Walk_Move();

        // 入力が無い場合に減衰するように
        if (m_input_move.magnitude > 0)
            m_move = m_input_move;
        else
            m_move *= 0.98f;
    }

    /// <summary>
    /// 入力方向に向きを変える
    /// </summary>
    private void Walk_Turn()
    {
        if (m_input_move.magnitude > 0)
        {
            // 入力された方向にカメラの向きをかける
            Vector3 c = m_main_camera.transform.rotation * m_input_move.normalized;
            c.y = 0.0f;
            Quaternion q = Quaternion.LookRotation(c.normalized, Vector3.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, q, 0.1f);
        }
    }

    /// <summary>
    /// 入力方向へ座標移動する
    /// </summary>
    private void Walk_Move()
    {
        Vector3 t = transform.position;
        Vector3 c = m_main_camera.transform.rotation * m_move;
        c.y = 0.0f;

        // 補正済み入力方向に移動する
        t += c.normalized * m_move.magnitude * m_speed;
        transform.position = t;

        m_rigid.velocity = Vector3.zero;

    }

    /// <summary>
    /// リアクションボタンA(InputSystemの設定値参照)
    /// </summary>
    private void Reaction_A()
    {
        // 0.5 or 0 を受け取る(仕様上の仕組み)
        float input_reaction = m_action.PlayerAction.Reaction_A.ReadValue<float>();
        if (input_reaction > m_input_reaction_a)
        {
            // リアクション１
            Debug.Log("Fizz!");
        }
        m_input_reaction_a = input_reaction;
    }

    /// <summary>
    /// リアクションボタンB(InputSystemの設定値参照)
    /// </summary>
    private void Reaction_B()
    {
        // 0.5 or 0 を受け取る(仕様上の仕組み)
        float input_reaction = m_action.PlayerAction.Reaction_B.ReadValue<float>();
        if (input_reaction > m_input_reaction_b)
        {
            // リアクション２
            Debug.Log("Buzz!");
        }
        m_input_reaction_b = input_reaction;
    }
}
