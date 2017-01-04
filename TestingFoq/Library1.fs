

module Foq.Usage
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


let [<Test>] ``check test runner functionality`` () =
    let add x y = x + y
    let actual = add 2 3
    Assert.AreEqual(5, actual)

