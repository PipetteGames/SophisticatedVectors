namespace PipetteGames.Numerics
{
    public static class SystemNumericsVector2Extensions
    {
        public static System.Numerics.Vector3 ToVector3(this System.Numerics.Vector2 vector2)
        {
            return new(vector2.X, vector2.Y, 0);
        }

        public static PipetteGames.Numerics.Vector2Int ToVector2Int(this System.Numerics.Vector2 vector2)
        {
            return new((int)vector2.X, (int)vector2.Y);
        }

        public static PipetteGames.Numerics.Vector3Int ToVector3Int(this System.Numerics.Vector2 vector2)
        {
            return new((int)vector2.X, (int)vector2.Y, 0);
        }

        public static UnityEngine.Vector2 ToUnityVector2(this System.Numerics.Vector2 vector2)
        {
            return new(vector2.X, vector2.Y);
        }

        public static UnityEngine.Vector3 ToUnityVector3(this System.Numerics.Vector2 vector2)
        {
            return new(vector2.X, vector2.Y, 0);
        }

        public static UnityEngine.Vector2Int ToUnityVector2Int(this System.Numerics.Vector2 vector2)
        {
            return new((int)vector2.X, (int)vector2.Y);
        }

        public static UnityEngine.Vector3Int ToUnityVector3Int(this System.Numerics.Vector2 vector2)
        {
            return new((int)vector2.X, (int)vector2.Y, 0);
        }
    }
}