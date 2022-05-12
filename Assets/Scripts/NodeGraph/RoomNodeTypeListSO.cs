using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RoomNodeTypeListSO", menuName = "Scriptable Objects/Dungeon/Room Node Type List" )]
public class RoomNodeTypeListSO : ScriptableObject
{
    #region Header ROOM NODE TYPE LIST
    [Space(10)]
    [Header("ROOM NODE TYPE LIST")]
    #endregion
    #region Tooltip
    [Tooltip("Bu liste RoomNodeTypeSO tipi ile doldurulmalı - enum yerine kullanıldı")]
    #endregion
    public List<RoomNodeTypeSO> list;

    #region Validation
#if UNITY_EDITOR 
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEnumarableValues(this, nameof(list), list);
    }
#endif
    #endregion
}
