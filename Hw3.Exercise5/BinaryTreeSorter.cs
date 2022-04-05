namespace Hw3.Exercise5
{

    public static class BinaryTreeSorter
    {
        public static List<int>? Sort(BinaryNode? node)
        {
            if (node is null)
                return new List<int>();

            var queue = new Queue<BinaryNode>();
            var result = new List<int>();

            queue.Enqueue(node);

            while (queue.TryDequeue(out var nodes))
            {
                result.Add(nodes.Value);

                if (nodes?.Left is not null)
                    queue.Enqueue(nodes.Left);

                if (nodes?.Right is not null)
                    queue.Enqueue(nodes.Right);

            }

            return result;
        }
    }
}
