using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        { 
            //Creates an instanc eof the Staff Class
            clsStaff NewStaff = new clsStaff();

        //Tests to see if it exists
        Assert.IsNotNull(NewStaff);


        }
    }
}


