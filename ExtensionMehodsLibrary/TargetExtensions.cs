using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMehods.Library
{
    public static class TargetExtensions
    {
        internal static void ExtendInternal(this InternalTarget target)
        {
            //TODO
        }
        /*
        internal static void ExtendInternalProtected(this InternalTarget.ProtectedSubclass target)
        {
            //TODO
        }
        */
        public static string GetStandardizedId(this Target target)
        {
            return target.GetId().ToUpper();
        }
    }
}
