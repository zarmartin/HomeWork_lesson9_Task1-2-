using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_lesson9_Task1_2_
{
    public class LabelObjectCollection<T> : Collection<T> where T : LabelObject
    {
        private List<LabelObject> _innerList = new List<LabelObject>();
        private LabelObjectLabelComparer _comparer = new LabelObjectLabelComparer();
        public T this[int index]
        {
            get => (T)_innerList[index];
            set => _innerList[index] = value;
        }

        public void OutputLabel()
        {
            var builder = new StringBuilder($"Label:{Environment.NewLine}");

            foreach (var currentObject in _innerList)
            {
                builder.Append(currentObject.Label);
                builder.Append(Environment.NewLine);

                Console.WriteLine(builder);
            }


        }

        public void Add(T item)
        {
            _innerList.Add(item);

            _innerList.Sort(new LabelObjectLabelComparer());
        }

    }
}
