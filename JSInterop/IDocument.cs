using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSInterop
{
    public interface IDocument
    {
        #region Events

        void OnEvent(Object o);

        #endregion

        #region Methods

        void JSFunction(String s);

        #endregion
    }
}
