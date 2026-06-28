namespace PipetteGames.Numerics
{
    public static class PipetteGamesNumericsVector2IntExtensions
    {
        public static System.Numerics.Vector2 ToVector2(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y);
        }

        public static System.Numerics.Vector3 ToVector3(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y, 0);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y, 0);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y, 0);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this Vector2Int vector2Int)
        {
            return new(vector2Int.X, vector2Int.Y, 0);
        }
    }
}