using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Test : MonoBehaviour
{
    [SerializeField, Tooltip("注視するオブジェクト")]
    private Transform m_target = null;

    [SerializeField, Tooltip("カメラとターゲットとの距離を任意で設定する場合はONにする/nOFFの場合、初期のTransformの値から自動で距離を決める")]
    private bool m_enable_setting_distance = false;
    [SerializeField, Tooltip("カメラとターゲットとの距離")]
    private float m_distance = 5.0f;
    [SerializeField, Range(0.5f, 2.0f), Tooltip("カメラのズームイン、ズームアウト率\t基準の距離はDistanceを参照する")]
    private float m_zoom = 1.0f;

    // 現在の回転量
    private float m_rotation = 0.0f;

    // 入力値の取得用
    private Actions m_action;

    // 入力値の保存
    private float m_input_zoom = 0.0f;
    private float m_input_rotation = 0.0f;

    public void Awake()
    {
        m_action = new Actions();
    }

    public void Start()
    {
        if (m_enable_setting_distance)
            m_distance = Mathf.Clamp(m_distance, 2.0f, 20.0f);
        else
            m_distance = transform.position.magnitude;
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
        // 入力値の読み取り
        m_input_rotation = m_action.CameraAction.Rotation.ReadValue<float>() * -0.2f;
        m_input_zoom = m_action.CameraAction.Updown.ReadValue<float>() * 0.005f;

        Rotate();
        Zoom();
    }

    /// <summary>
    /// カメラの回転
    /// </summary>
    private void Rotate()
    {
        // キー入力で注視点に対し回り込みを行う
        transform.forward = Quaternion.AngleAxis(m_rotation, Vector3.up) * transform.forward;
        transform.position = m_target.position - transform.forward * m_distance * m_zoom;

        // 回転量の減衰と入力値からの更新
        if (m_input_rotation.Equals(0.0f))
            m_rotation *= 0.98f;
        else
            m_rotation = m_input_rotation;

    }

    /// <summary>
    /// カメラをターゲットに接近、後退させる
    /// </summary>
    private void Zoom()
    {
        m_zoom = Mathf.Clamp(m_zoom - m_input_zoom, 0.5f, 2.0f);
    }
}
