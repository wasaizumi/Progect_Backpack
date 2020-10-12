using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour, Actions.ISystemActionActions
{
    // コールバックを利用して値を取得する
    private Actions.SystemActionActions m_input;

    public void Awake()
    {
        m_input = new Actions.SystemActionActions(new Actions());
        m_input.SetCallbacks(this);
    }

    public void OnEnable()
    {
        m_input.Enable();
    }

    public void OnDestroy()
    {
        m_input.Disable();
    }

    public void OnDisable()
    {
        m_input.Disable();
    }

    /// <summary>
    /// ゲーム終了操作があった場合の処理
    /// </summary>
    /// <param name="context">コールバックで与えられる</param>
    public void OnEndGame(InputAction.CallbackContext context)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
#endif
    }
}
