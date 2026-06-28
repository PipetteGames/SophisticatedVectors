namespace PipetteGames.Numerics
{
    public static class UnityVector3IntExtensions
    {
        public static System.Numerics.Vector2 ToVector2(this UnityEngine.Vector3Int vector3Int)
        {
            return new(vector3Int.x, vector3Int.y);
        }

        public static System.Numerics.Vector3 ToVector3(this UnityEngine.Vector3Int vector3Int)
        {
            return new(vector3Int.x, vector3Int.y, vector3Int.z);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this UnityEngine.Vector3Int vector3Int)
        {
            return new PipetteGames.Numerics.Vector2Int(vector3Int.x, vector3Int.y);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this UnityEngine.Vector3Int vector3Int)
        {
            return new PipetteGames.Numerics.Vector3Int(vector3Int.x, vector3Int.y, vector3Int.z);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this UnityEngine.Vector3Int vector3Int)
        {
            return new(vector3Int.x, vector3Int.y);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this UnityEngine.Vector3Int vector3Int)
        {
            return new(vector3Int.x, vector3Int.y, vector3Int.z);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this UnityEngine.Vector3Int vector3Int)
        {
            return new(vector3Int.x, vector3Int.y);
        }
    }
}