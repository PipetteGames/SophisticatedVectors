namespace PipetteGames.Numerics
{
    public static class UnityVector2IntExtensions
    {
        public static System.Numerics.Vector2 ToVector2(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y);
        }

        public static System.Numerics.Vector3 ToVector3(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y, 0);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y, 0);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y, 0);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this UnityEngine.Vector2Int vector2Int)
        {
            return new(vector2Int.x, vector2Int.y, 0);
        }
    }
}