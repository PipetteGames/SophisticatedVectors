using System;

namespace PipetteGames.Numerics
{
    /// <summary>
    /// UnityEngine に依存しない Vector2Int の実装
    /// System.Numerics.Vector2 相当の機能を提供します
    /// </summary>
    public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
    {
        public int X;
        public int Y;

        /// <summary>
        /// ベクトルの大きさ
        /// </summary>
        public float Length => MathF.Sqrt(X * X + Y * Y);

        /// <summary>
        /// ゼロベクトル (0, 0)
        /// </summary>
        public static readonly Vector2Int Zero = new(0, 0);

        /// <summary>
        /// 単位ベクトル (1, 1)
        /// </summary>
        public static readonly Vector2Int One = new(1, 1);

        /// <summary>
        /// X 軸単位ベクトル (1, 0)
        /// </summary>
        public static readonly Vector2Int UnitX = new(1, 0);

        /// <summary>
        /// Y 軸単位ベクトル (0, 1)
        /// </summary>
        public static readonly Vector2Int UnitY = new(0, 1);

        /// <summary>
        /// x, y の各要素を同じ値で初期化
        /// </summary>
        public Vector2Int(int value) : this(value, value)
        {
        }

        /// <summary>
        /// x, y の各要素を指定して初期化
        /// </summary>
        public Vector2Int(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// 2 つのベクトル間の距離
        /// </summary>
        public static float Distance(Vector2Int value1, Vector2Int value2)
        {
            int dx = value1.X - value2.X;
            int dy = value1.Y - value2.Y;
            return MathF.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// 2 つのベクトルの内積
        /// </summary>
        public static int Dot(Vector2Int left, Vector2Int right)
        {
            return left.X * right.X + left.Y * right.Y;
        }

        /// <summary>
        /// 各要素の絶対値
        /// </summary>
        public static Vector2Int Abs(Vector2Int value)
        {
            return new Vector2Int(Math.Abs(value.X), Math.Abs(value.Y));
        }

        /// <summary>
        /// 値を最小値と最大値の間にクランプ
        /// </summary>
        public static Vector2Int Clamp(Vector2Int value1, Vector2Int min, Vector2Int max)
        {
            return new Vector2Int(
                Math.Clamp(value1.X, min.X, max.X),
                Math.Clamp(value1.Y, min.Y, max.Y)
            );
        }

        /// <summary>
        /// 各要素をスケール
        /// </summary>
        public static Vector2Int Multiply(Vector2Int left, Vector2Int right)
        {
            return new Vector2Int(left.X * right.X, left.Y * right.Y);
        }

        /// <summary>
        /// 各要素を除算
        /// </summary>
        public static Vector2Int Divide(Vector2Int left, Vector2Int right)
        {
            return new Vector2Int(left.X / right.X, left.Y / right.Y);
        }

        /// <summary>
        /// 2 つのベクトルの加算
        /// </summary>
        public static Vector2Int Add(Vector2Int left, Vector2Int right)
        {
            return new Vector2Int(left.X + right.X, left.Y + right.Y);
        }

        /// <summary>
        /// 2 つのベクトルの減算
        /// </summary>
        public static Vector2Int Subtract(Vector2Int left, Vector2Int right)
        {
            return new Vector2Int(left.X - right.X, left.Y - right.Y);
        }

        /// <summary>
        /// 各要素の最大値を持つベクトル
        /// </summary>
        public static Vector2Int Max(Vector2Int value1, Vector2Int value2)
        {
            return new Vector2Int(Math.Max(value1.X, value2.X), Math.Max(value1.Y, value2.Y));
        }

        /// <summary>
        /// 各要素の最小値を持つベクトル
        /// </summary>
        public static Vector2Int Min(Vector2Int value1, Vector2Int value2)
        {
            return new Vector2Int(Math.Min(value1.X, value2.X), Math.Min(value1.Y, value2.Y));
        }

        /// <summary>
        /// ベクトルの否定
        /// </summary>
        public static Vector2Int Negate(Vector2Int value)
        {
            return new Vector2Int(-value.X, -value.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is Vector2Int vector && Equals(vector);
        }

        public bool Equals(Vector2Int other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"<{X}, {Y}>";
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return $"<{X.ToString(format, formatProvider)}, {Y.ToString(format, formatProvider)}>";
        }

        // 演算子オーバーロード
        public static Vector2Int operator +(Vector2Int a, Vector2Int b) => Add(a, b);
        public static Vector2Int operator -(Vector2Int a, Vector2Int b) => Subtract(a, b);
        public static Vector2Int operator *(Vector2Int a, int scalar) => new(a.X * scalar, a.Y * scalar);
        public static Vector2Int operator *(int scalar, Vector2Int a) => new(a.X * scalar, a.Y * scalar);
        public static Vector2Int operator /(Vector2Int a, int scalar) => new(a.X / scalar, a.Y / scalar);
        public static Vector2Int operator -(Vector2Int a) => Negate(a);

        public static bool operator ==(Vector2Int a, Vector2Int b) => a.Equals(b);
        public static bool operator !=(Vector2Int a, Vector2Int b) => !a.Equals(b);
    }
}