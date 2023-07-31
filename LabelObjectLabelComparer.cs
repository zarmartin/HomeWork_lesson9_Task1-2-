using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson9_Task1_2_
{
    class LabelObjectLabelComparer : IComparer<LabelObject>
    {
        private StringComparer _comparer = StringComparer.CurrentCulture;
        public LabelObjectLabelComparer(StringComparer? comparer = null)
        {
            if (comparer != null)
            {
                _comparer = comparer;
            }
        }

        public int Compare(LabelObject? x, LabelObject? y)
        {
            return _comparer.Compare(x?.Label, y?.Label);
        }
    }
}
