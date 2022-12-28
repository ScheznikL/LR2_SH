using System.Collections.Generic;

namespace LR2_SH
{
    class UniversityEqualityComparer : IEqualityComparer<University>
    {
        public bool Equals(University obj1, University obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;
            else if (obj1 == null || obj2 == null)
                return false;
            else if (obj1.Lab == obj2.Lab && obj1.Lec == obj2.Lec && obj1.Staff == obj2.Staff
                     && obj1.Students == obj2.Students)
                return true;
            else
                return false;
        }

        public int GetHashCode(University obj)
        {
            int hCode = obj.Lab ^ obj.Lec ^ obj.Staff ^ obj.Students;
            return hCode.GetHashCode();
        }
    }
}
