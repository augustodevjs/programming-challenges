namespace programming_challenges.Stack;

// https://leetcode.com/problems/implement-stack-using-queues
public class MyStack {
    private Queue<int> queue1;
    private Queue<int> queue2;

    public MyStack() {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }

    public void Push(int x) {
        queue2.Enqueue(x);

        while (queue1.Count > 0) {
            queue2.Enqueue(queue1.Dequeue());
        }

        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }

    public int Pop() {
        return queue1.Dequeue();
    }

    public int Top() {
        return queue1.Peek();
    }

    public bool Empty() {
        return queue1.Count == 0;
    }
}
