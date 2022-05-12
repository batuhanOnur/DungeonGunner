﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header
    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    #endregion Header
    public bool displayInNodeGraphEditor = true;
    #region Header
    [Header("One Type Should be A Corridor")]
    #endregion Header
    public bool isCorridor;
    #region Header
    [Header("One Type Should be A CorridorNS")]
    #endregion Header
    public bool isCorridorNS;
    #region Header
    [Header("One Type Should be A CorridorEW")]
    #endregion Header
    public bool isCorridorEW;
    #region Header
    [Header("One Type Should be An Entrance")]
    #endregion Header
    public bool isEntrance;
    #region Header
    [Header("One Type Should be A Boss Room")]
    #endregion Header
    public bool isBossRoom;
    #region Header
    [Header("One Type Should be None (Unassigned)")]
    #endregion Header
    public bool isNone;

    #region Validation
#if UNITY_EDITOR // sadece unity editor'de çalışır
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif
    #endregion
}
