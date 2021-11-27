using Godot;

namespace SpaceGame
{
    public static class FunkyMath
    {
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return a * (1-t) + b * t;
        }

        public static float Angle(Vector3 a, Vector3 b)
        {
            float dot = a.Dot(b);
            dot /= a.Length();
            dot /= b.Length();
            float angle = Mathf.Acos(dot);
            angle = Mathf.Rad2Deg(angle);
            return angle;
        }
    }
}