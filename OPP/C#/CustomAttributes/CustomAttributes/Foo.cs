using System;
using System.Collections.Generic;
using System.Text;


namespace CustomAttribute
{

    public class Foo
    {
        [AddChangesLater]
        void M1()
        {

        }
        void M2()
        {

        }
        [AddChangesLater]
        void M3()
        {

        }
    }
}
