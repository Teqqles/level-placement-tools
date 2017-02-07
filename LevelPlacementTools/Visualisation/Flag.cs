using UnityEngine;

public class Flag
{
    Vector3 flagTop, flagLeft, flagBottom;
    Mesh flag;
    Color[] availableColours = new Color[] { Color.red, Color.blue, Color.green, Color.yellow };
    Color color;
    FlagConfig config;

    public Flag(int colourReference, FlagConfig flagConfig)
    {
        flagTop = Vector3.up * flagConfig.flagScale;
        flagLeft = (Vector3.down / 2 + Vector3.left) * flagConfig.flagScale;
        flagBottom = Vector3.down * flagConfig.flagScale;

        flag = new Mesh();
        flag.vertices = new Vector3[] { flagTop, flagLeft, flagBottom };
        flag.triangles = new int[] { 0, 1, 2, 2, 1, 0 };
        flag.RecalculateNormals();
        flag.RecalculateBounds();
        color = this.pickColour(colourReference);
        config = flagConfig;
    }

    private Color pickColour(int colourReference)
    {
        return availableColours[colourReference % availableColours.Length];
    }

    public void DrawFlag(Vector3 startPosition)
    {
        Vector3 flagPole = startPosition + Vector3.up * config.sizeOfFlag;
        Gizmos.color = this.color;
        Gizmos.DrawLine(startPosition, flagPole);
        Gizmos.DrawMesh(flag, 0, flagPole + flagBottom);
        Gizmos.DrawCube(startPosition, Vector3.one * config.boxScale);
    }
}
