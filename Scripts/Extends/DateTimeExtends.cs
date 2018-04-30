using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ddd.CoreModule.Extends
{
    public static class DateTimeExtends
    {
        private static readonly System.DateTime UNIX_EPOCH = new System.DateTime( 1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc );

        public static long ToUnixtime( this System.DateTime dateTime )
        {
            double nowTicks = ( dateTime.ToUniversalTime() - UNIX_EPOCH ).TotalSeconds;
            return (long)nowTicks;
        }

        public static string ToCreateAtFormatString( this System.DateTime dateTime )
        {
            return dateTime.ToString( "yyyy-MM-dd HH:mm:ss" );
        }
    }
}
