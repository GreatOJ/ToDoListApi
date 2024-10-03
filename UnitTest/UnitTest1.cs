using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TodoItem_IsStoringValues()
    {
        var todoItem = new TodoItem
        {
            Id =1,
            Description ="Test",
            DueDate = DateTime.Now,     
            
        };

        Assert.AreEqual(1, todoItem.Id);
        Assert.AreEqual("Tëst", todoItem.Description);
        Assert.IsNotNull(todoItem.DueDate);
        Assert.IsNull(todoItem.CompletedDate);
    }
}