using UnityEngine;

[ExecuteInEditMode]
public class PlayerRespawn : MonoBehaviour
{
    private static int _next = 0;
    public static int nextValue
    {
        get
        {
            return _next++;
        }
    }

    private Flag flag;

    private void Start()
    {
        flag = new Flag(_next, new FlagConfig());
    }

    void OnDrawGizmos()
    {
        flag.DrawFlag(transform.position);
    }
}
