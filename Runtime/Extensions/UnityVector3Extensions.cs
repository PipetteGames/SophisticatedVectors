namespace PipetteGames.Numerics
{
    public static class UnityVector3Extensions
    {
        public static System.Numerics.Vector2 ToVector2(this UnityEngine.Vector3 vector3)
        {
            return new(vector3.x, vector3.y);
        }

        public static System.Numerics.Vector3 ToVector3(this UnityEngine.Vector3 vector3)
        {
            return new(vector3.x, vector3.y, vector3.z);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this UnityEngine.Vector3 vector3)
        {
            return new PipetteGames.Numerics.Vector2Int((int)vector3.x, (int)vector3.y);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this UnityEngine.Vector3 vector3)
        {
            return new PipetteGames.Numerics.Vector3Int((int)vector3.x, (int)vector3.y, (int)vector3.z);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this UnityEngine.Vector3 vector3)
        {
            return new(vector3.x, vector3.y);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this UnityEngine.Vector3 vector3)
        {
            return new((int)vector3.x, (int)vector3.y);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this UnityEngine.Vector3 vector3)
        {
            return new((int)vector3.x, (int)vector3.y, (int)vector3.z);
        }
    }
}