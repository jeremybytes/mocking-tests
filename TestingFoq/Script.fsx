
#r @"..\packages\Foq.1.7.1\Lib\net45\Foq.dll"
#r @"..\packages\NUnit.3.5.0\lib\net45\nunit.framework.dll"

open NUnit.Framework
open Foq

let [<Test>] ``setup a method to always return true`` () =
    // Arrange
    let instance =
        Mock<System.Collections.IList>()
            .Setup(fun x -> <@ x.Contains(any()) @>).Returns(true)
            .Create()
    // Assert
    Assert.IsTrue(instance.Contains("Anything"))

``setup a method to always return true``()


