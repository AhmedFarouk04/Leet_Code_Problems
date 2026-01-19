public class MinStack
{
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    public void Push(int val)
    {
        stack.Push(val);

        if (minStack.Count == 0 || val <= minStack.Peek())
            minStack.Push(val);
    }

    public void Pop()
    {
        if (stack.Pop() == minStack.Peek())
            minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
