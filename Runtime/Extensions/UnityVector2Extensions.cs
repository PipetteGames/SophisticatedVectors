namespace PipetteGames.Numerics
{
    public static class UnityVector2Extensions
    {
        public static System.Numerics.Vector2 ToVector2(this UnityEngine.Vector2 vector2)
        {
            return new(vector2.x, vector2.y);
        }

        public static System.Numerics.Vector3 ToVector3(this UnityEngine.Vector2 vector2)
        {
            return new(vector2.x, vector2.y, 0);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this UnityEngine.Vector2 vector2)
        {
            return new PipetteGames.Numerics.Vector2Int((int)vector2.x, (int)vector2.y);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this UnityEngine.Vector2 vector2)
        {
            return new PipetteGames.Numerics.Vector3Int((int)vector2.x, (int)vector2.y, 0);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this UnityEngine.Vector2 vector2)
        {
            return new(vector2.x, vector2.y, 0);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this UnityEngine.Vector2 vector2)
        {
            return new((int)vector2.x, (int)vector2.y);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this UnityEngine.Vector2 vector2)
        {
            return new((int)vector2.x, (int)vector2.y, 0);
        }
    }
}