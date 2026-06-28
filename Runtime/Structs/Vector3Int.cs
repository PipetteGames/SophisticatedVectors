using System;

namespace PipetteGames.Numerics
{
    /// <summary>
    /// UnityEngine に依存しない Vector3Int の実装
    /// System.Numerics.Vector3 相当の機能を提供します
    /// </summary>
    public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
    {
        public int X;
        public int Y;
        public int Z;

        /// <summary>
        /// ベクトルの大きさ
        /// </summary>
        public float Length => MathF.Sqrt(X * X + Y * Y + Z * Z);

        /// <summary>
        /// ゼロベクトル (0, 0, 0)
        /// </summary>
        public static readonly Vector3Int Zero = new(0, 0, 0);

        /// <summary>
        /// 単位ベクトル (1, 1, 1)
        /// </summary>
        public static readonly Vector3Int One = new(1, 1, 1);

        /// <summary>
        /// X 軸単位ベクトル (1, 0, 0)
        /// </summary>
        public static readonly Vector3Int UnitX = new(1, 0, 0);

        /// <summary>
        /// Y 軸単位ベクトル (0, 1, 0)
        /// </summary>
        public static readonly Vector3Int UnitY = new(0, 1, 0);

        /// <summary>
        /// Z 軸単位ベクトル (0, 0, 1)
        /// </summary>
        public static readonly Vector3Int UnitZ = new(0, 0, 1);

        /// <summary>
        /// x, y, z の各要素を同じ値で初期化
        /// </summary>
        public Vector3Int(int value) : this(value, value, value)
        {
        }

        /// <summary>
        /// x, y の各要素を指定し、z は 0 で初期化
        /// </summary>
        public Vector3Int(int x, int y) : this(x, y, 0)
        {
        }

        /// <summary>
        /// x, y, z の各要素を指定して初期化
        /// </summary>
        public Vector3Int(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// 2 つのベクトル間の距離
        /// </summary>
        public static float Distance(Vector3Int value1, Vector3Int value2)
        {
            int dx = value1.X - value2.X;
            int dy = value1.Y - value2.Y;
            int dz = value1.Z - value2.Z;
            return MathF.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        /// <summary>
        /// 2 つのベクトルの内積
        /// </summary>
        public static int Dot(Vector3Int left, Vector3Int right)
        {
            return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        /// <summary>
        /// 2 つのベクトルの外積
        /// </summary>
        public static Vector3Int Cross(Vector3Int left, Vector3Int right)
        {
            return new Vector3Int(
                left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X
            );
        }

        /// <summary>
        /// 各要素の絶対値
        /// </summary>
        public static Vector3Int Abs(Vector3Int value)
        {
            return new Vector3Int(Math.Abs(value.X), Math.Abs(value.Y), Math.Abs(value.Z));
        }

        /// <summary>
        /// 値を最小値と最大値の間にクランプ
        /// </summary>
        public static Vector3Int Clamp(Vector3Int value1, Vector3Int min, Vector3Int max)
        {
            return new Vector3Int(
                Math.Clamp(value1.X, min.X, max.X),
                Math.Clamp(value1.Y, min.Y, max.Y),
                Math.Clamp(value1.Z, min.Z, max.Z)
            );
        }

        /// <summary>
        /// 各要素をスケール
        /// </summary>
        public static Vector3Int Multiply(Vector3Int left, Vector3Int right)
        {
            return new Vector3Int(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        /// <summary>
        /// 各要素を除算
        /// </summary>
        public static Vector3Int Divide(Vector3Int left, Vector3Int right)
        {
            return new Vector3Int(left.X / right.X, left.Y / right.Y, left.Z / right.Z);
        }

        /// <summary>
        /// 2 つのベクトルの加算
        /// </summary>
        public static Vector3Int Add(Vector3Int left, Vector3Int right)
        {
            return new Vector3Int(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        /// <summary>
        /// 2 つのベクトルの減算
        /// </summary>
        public static Vector3Int Subtract(Vector3Int left, Vector3Int right)
        {
            return new Vector3Int(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        /// <summary>
        /// 各要素の最大値を持つベクトル
        /// </summary>
        public static Vector3Int Max(Vector3Int value1, Vector3Int value2)
        {
            return new Vector3Int(
                Math.Max(value1.X, value2.X),
                Math.Max(value1.Y, value2.Y),
                Math.Max(value1.Z, value2.Z)
            );
        }

        /// <summary>
        /// 各要素の最小値を持つベクトル
        /// </summary>
        public static Vector3Int Min(Vector3Int value1, Vector3Int value2)
        {
            return new Vector3Int(
                Math.Min(value1.X, value2.X),
                Math.Min(value1.Y, value2.Y),
                Math.Min(value1.Z, value2.Z)
            );
        }

        /// <summary>
        /// ベクトルの否定
        /// </summary>
        public static Vector3Int Negate(Vector3Int value)
        {
            return new Vector3Int(-value.X, -value.Y, -value.Z);
        }

        public override bool Equals(object obj)
        {
            return obj is Vector3Int vector && Equals(vector);
        }

        public bool Equals(Vector3Int other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}, {Z.ToString(format, formatProvider)}>";
        }

        // 演算子オーバーロード
        public static Vector3Int operator +(Vector3Int a, Vector3Int b) => Add(a, b);
        public static Vector3Int operator -(Vector3Int a, Vector3Int b) => Subtract(a, b);
        public static Vector3Int operator *(Vector3Int a, int scalar) => new(a.X * scalar, a.Y * scalar, a.Z * scalar);
        public static Vector3Int operator *(int scalar, Vector3Int a) => new(a.X * scalar, a.Y * scalar, a.Z * scalar);
        public static Vector3Int operator /(Vector3Int a, int scalar) => new(a.X / scalar, a.Y / scalar, a.Z / scalar);
        public static Vector3Int operator -(Vector3Int a) => Negate(a);

        public static bool operator ==(Vector3Int a, Vector3Int b) => a.Equals(b);
        public static bool operator !=(Vector3Int a, Vector3Int b) => !a.Equals(b);
    }
}