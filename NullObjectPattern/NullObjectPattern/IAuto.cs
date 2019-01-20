using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    interface IAuto
    {
        int Id { get; }
        string Name { get; }
        void Start();
        void Stop();
    }
}
