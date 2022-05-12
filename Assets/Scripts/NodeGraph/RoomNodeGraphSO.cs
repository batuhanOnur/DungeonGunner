using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Unity �st toolbar'da bulunan assets=> create i�ine atar
[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Objects/Dungeon/Room Node Graph")]
public class RoomNodeGraphSO : ScriptableObject
{
    [HideInInspector] public RoomNodeTypeListSO roomNodeTypeList;
    [HideInInspector] public List<RoomNodeSO> roomNodeList = new List<RoomNodeSO>();
    [HideInInspector] public Dictionary<string,RoomNodeSO> roomNodeDictionary = new Dictionary<string, RoomNodeSO>();
}
