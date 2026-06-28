namespace PipetteGames.Numerics
{
    public static class SystemNumericsVector3Extensions
    {
        public static System.Numerics.Vector2 ToVector2(this System.Numerics.Vector3 vector3)
        {
            return new(vector3.X, vector3.Y);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this System.Numerics.Vector3 vector3)
        {
            return new((int)vector3.X, (int)vector3.Y);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this System.Numerics.Vector3 vector3)
        {
            return new((int)vector3.X, (int)vector3.Y, (int)vector3.Z);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this System.Numerics.Vector3 vector3)
        {
            return new(vector3.X, vector3.Y);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this System.Numerics.Vector3 vector3)
        {
            return new(vector3.X, vector3.Y, vector3.Z);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this System.Numerics.Vector3 vector3)
        {
            return new((int)vector3.X, (int)vector3.Y);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this System.Numerics.Vector3 vector3)
        {
            return new((int)vector3.X, (int)vector3.Y, (int)vector3.Z);
        }
    }
}