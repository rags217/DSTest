using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(DSTest.Droid.DependencyBase))]
namespace DSTest.Droid
{
    public class DependencyBase : iDependencyBase
    {
        public void initialiseTest1(){
            DependencyService.Register<DependencyTest1>();
        }

        public void initialiseTest2(){
            DependencyService.Register<DependencyTest2>();
        }

    }
}
