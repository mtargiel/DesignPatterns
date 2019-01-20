using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern_AbstractClass
{
    public abstract class AutoBase
    {
        public abstract  int Id { get; }
        public abstract string Name { get; }
        public abstract void Start();
        public abstract void Stop();

        #region nullAuto
        static readonly  NullAuto nullAuto = new NullAuto();
        public static NullAuto NULL => nullAuto;

        public class NullAuto : AutoBase
        {
            public override int Id => -1;
            public override string Name => "empty";
            public override void Start()
            {
            }

            public override void Stop()
            {
            }
        }

        #endregion

    }
}
