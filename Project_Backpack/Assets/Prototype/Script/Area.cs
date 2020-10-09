using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candlelight;

public class Area : MonoBehaviour
{
    public enum AreaStatus
    {
        Unreleased,
        Released
    }



    // 状態毎の色（プロトタイプ用）
    private Color[] m_StatusColor = new Color[(int)AreaStatus.Released + 1] {
        new Color(0.2f, 0.2f, 0.2f),
        new Color(1.0f, 1.0f, 1.0f)
    };

    /// <summary> エリアの状態 </summary>
    public AreaStatus Status
    {
        get { return m_Status; }
        set
        {
            // 値変更時
            if (m_Status != value)
            {
                m_Status = value;
                SetColorChildlen(m_StatusColor[(int)m_Status]);
            }
        }
    }
    [SerializeField, PropertyBackingField("Status")]
    private AreaStatus m_Status;

    private List<GameObject> m_floors = new List<GameObject>();
    private MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        m_Status = AreaStatus.Unreleased;

        for (int i = 0; i< transform.childCount; i++)
        {
            m_floors.Add(transform.GetChild(i).gameObject);
        }

        SetColorChildlen(m_StatusColor[(int)m_Status]);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SetColorChildlen(Color color)
    {
        foreach(GameObject go in m_floors)
        {
            MeshRenderer mr = go.GetComponent<MeshRenderer>();
            mr.material.color = color;
        }
    }
}
