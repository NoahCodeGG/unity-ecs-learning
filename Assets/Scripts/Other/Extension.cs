using UnityEngine;
namespace Other
{
    /// <summary>
    ///     拓展方法
    /// </summary>
    public static class Extension
    {
        /// <summary>
        ///     角度->vector2
        /// </summary>
        /// <param name="angle">角度</param>
        /// <returns>角度对应 vector2</returns>
        public static Vector2 Angle2Vector2D(this float angle)
        {
            var a = (angle + 90)*Mathf.Deg2Rad;
            return new Vector2(Mathf.Cos(a), Mathf.Sin(a));
        }
    }
}