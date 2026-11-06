using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority
    // Expected Result: maria pedro juan
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Juan", 2);
        priorityQueue.Enqueue("Pedro", 5);
        priorityQueue.Enqueue("Maria", 8);
        Assert.AreEqual("Maria", priorityQueue.Dequeue());
        Assert.AreEqual("Pedro", priorityQueue.Dequeue());
        Assert.AreEqual("Juan", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed
    // Expected Result: juan pedro maria
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Juan", 5);
        priorityQueue.Enqueue("Pedro", 5);
        priorityQueue.Enqueue("Maria", 2);;
        Assert.AreEqual("Juan", priorityQueue.Dequeue());
        Assert.AreEqual("Pedro", priorityQueue.Dequeue());
        Assert.AreEqual("Maria", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
// Scenario: The queue is empty
// Expected Result: Show an error message.
// Defect(s) Found:
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        var exception = Assert.ThrowsException<InvalidOperationException>(
        () => priorityQueue.Dequeue()
        );
        Assert.AreEqual("The queue is empty.", exception.Message);

    }
    [TestMethod]
// Scenario: Verify that Enqueue adds items to the back of the queue.
// Expected Result: Items appear in the order they were added.
// Defect(s) Found:
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Juan", 3);
        priorityQueue.Enqueue("Pedro", 8);
        priorityQueue.Enqueue("Maria", 5);
        Assert.AreEqual("Juan", priorityQueue.Dequeue());
        Assert.AreEqual("Pedro", priorityQueue.Dequeue());
        Assert.AreEqual("Maria", priorityQueue.Dequeue());
    }
}