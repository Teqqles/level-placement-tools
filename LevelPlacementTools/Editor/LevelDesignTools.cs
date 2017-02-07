using UnityEditor;
using UnityEngine;
public class SpawnTools : MonoBehaviour
{
    [MenuItem("GameObject/Level Design Tools/Player Respawn Point", false, 0)]
    static void Spawn()
    {
        var empty = new GameObject();
        empty.AddComponent<PlayerRespawn>();
        empty.name = "Player Respawn Point #" + PlayerRespawn.nextValue;
        empty.tag = "Respawn";
    }
}