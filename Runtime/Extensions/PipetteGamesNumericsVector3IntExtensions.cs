namespace PipetteGames.Numerics
{
    public static class PipetteGamesNumericsVector3IntExtensions
    {
        public static System.Numerics.Vector2 ToVector2(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y);
        }

        public static System.Numerics.Vector3 ToVector3(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y, vector3Int.Z);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y, vector3Int.Z);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this Vector3Int vector3Int)
        {
            return new(vector3Int.X, vector3Int.Y, vector3Int.Z);
        }
    }
}